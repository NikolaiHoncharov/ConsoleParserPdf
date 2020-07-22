using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace ConsoleParserPdf
{
    class HtmlDowloadHelper
    {
        public  static  string DowloadHtml(string uri)
        {
            string html = null;
            try
            {
                //формировка запроса на сервер
                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                //получение ответа от сервера 
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //получаем из response html
                StreamReader sr = new StreamReader(response.GetResponseStream());
                html = sr.ReadToEnd();
                return html;
            }
            catch (Exception)
            {
                return "Code HTML do not download";
            }
        }

        public static IEnumerable<string> SearchPdfLinks(string html)
        {
            List<string> Pdflink = new List<string>();
            ///логика поиска всех <a> c .pdf </a>
            string firstWordbp = $".pdf\"";
            foreach (Match m in Regex.Matches(html, firstWordbp))
            {

                int IndexStart = -1;
                int IndexEnd = -1;
                for (int i = m.Index; i < html.Length; i++)
                {
                    int count = 0;
                    if (html[i] == '<')
                    {
                        count++;
                        if (html[i + count] == '/')
                        {
                            count++;
                            if (html[i + count] == 'a')
                            {
                                count++;
                                if (html[i + count] == '>')
                                {
                                    i += count;
                                    IndexEnd = i;
                                    break;
                                }
                            }
                        }
                    }
                }

                //IndexStart
                for (int i = IndexEnd; i >= 0; i--)
                {
                    if (html[i] == 'a')
                    {
                        if (html[--i] == '<')
                        {
                            IndexStart = i;
                            break;
                        }
                    }
                }
                if (IndexStart != -1 && IndexEnd != -1)
                {
                    string linkPdf = "";
                    for (int i = IndexStart; i <= IndexEnd; i++)
                    {
                        linkPdf += html[i];
                    }
                    Pdflink.Add(linkPdf);
                }
            }
            return Pdflink;
        }

        /// <summary>
        /// <param name="url">полная ссылка на скачиваемый файл;</param>
        /// <param name="filename">полный путь для сохранения файла и его наввание с расширением файла (пр. D:\\Report.png</param>
        /// <returns>fasle - если один из параметров будет равен null</returns>
        public static bool DownloadPdf(string url, string filename)
        {
            if (!String.IsNullOrWhiteSpace(url) && !String.IsNullOrWhiteSpace(filename))
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFileAsync(new Uri(url), filename);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// </summary>
        /// <param name="ListLinks">Лист ссылок</param>
        /// <param name="KeyWord">ключевые слова</param>
        /// <returns>null - если поиск не дал результатов и string - если поиск нашел нужный pdf </returns>
        public static string DeleteUnwantedLinks(List<string> ListLinks, List<string> KeyWord)
        {
            if (ListLinks != null && KeyWord != null &&
                ListLinks.Count != 0 && KeyWord.Count != 0)
            {
                List<int> CountCurrent = new List<int>();

                foreach (var itemll in ListLinks)
                {
                    int c = 0;
                    string tmpstr = itemll.ToLower();
                    foreach (var itemKw in KeyWord)
                    {
                        if (tmpstr.IndexOf(itemKw) != -1)
                        {
                            c++;
                        }
                    }
                    CountCurrent.Add(c);
                }
                if (CountCurrent.Count != 0)
                {
                    int Max = CountCurrent[0];
                    int Index = 0;
                    for (int i = 0; i < CountCurrent.Count; i++)
                    {
                        if (CountCurrent[i] > Max)
                        {
                            Max = CountCurrent[i];
                            Index = i;
                        }
                    }

                    string firstWordbp = "href=\"";
                    foreach (Match m in Regex.Matches(ListLinks[Index], firstWordbp))
                    {
                        int IndexEnd = -1;
                        for (int i = m.Index+6; i < ListLinks[Index].Length; i++)
                        {
                            if (ListLinks[Index][i] == '"')
                            {
                                IndexEnd = i;
                                break;
                            }
                        }

                        string linkPdf = "";
                        for (int i = m.Index+6; i < IndexEnd; i++)
                        {
                            linkPdf += ListLinks[Index][i];
                        }
                        //Console.WriteLine(linkPdf);
                        return linkPdf;
                    }
                }
            }
            return null;
        }
    }
}

