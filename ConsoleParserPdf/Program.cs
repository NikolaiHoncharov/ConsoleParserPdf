using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleParserPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            //string HtmlTest = "<body><header><ahref=\"/\">Home</a><ahref=\"/Account/Login\">Login</a><ahref=\"/Account/Exit\">Exit</a></header><div><h1>Index</h1><a href=\"/fileadmin/zcapital/documents/Abstimmungsrichtlinien_01.pdf\"target=\"_blank\">voting guidelines</a><hr/><footer><p>&copy;2020-Finopis</p></footer></div></body><a title=\"In neuem Fenster\" href=\"/cm_document/zRating-Kriterienkatalog_2020.pdf\" target=\"_blank\">Kriterienkatalog 2020</a></html>";
            //LinkParsSite linkPars = new LinkParsSite();
            //List<string> tempLink = HtmlDowloadHelper.SearchPdfLinks(HtmlTest) as List<string>;
            //string link = HtmlDowloadHelper.DeleteUnwantedLinks(tempLink, linkPars.SiteParseList.FirstOrDefault(x=>x.Link == @"https://www.zcapital.ch/").KeyWord);
            //if(!String.IsNullOrWhiteSpace(link))
            //{
            //}
            //Console.WriteLine(countpage);
            //HtmlDowloadHelper.DownloadPdf(@"https://www.ethosfund.ch/sites/default/files/2020-02/LDPCG_Ethos_2020_EN.pdf", @"D:\\Report.pdf");


            int countpage = 0;//счетчик страниц 
            LinkParsSite linkPars = new LinkParsSite();

            foreach (var spl in linkPars.SiteParseList)
            {
                countpage++;
                spl.HtmlPage = HtmlDowloadHelper.DowloadHtml(spl.LinkPdfFile);
                List<string> tempLink = HtmlDowloadHelper.SearchPdfLinks(spl.HtmlPage) as List<string>;
                string link = HtmlDowloadHelper.DeleteUnwantedLinks(tempLink, spl.KeyWord);
                if (!String.IsNullOrWhiteSpace(link))
                {
                    if(link.IndexOf(spl.Link)==-1)
                    {
                        Console.WriteLine(spl.Link + link);
                    }
                    else
                    {
                        Console.WriteLine(link);
                    }
 
                    //HtmlDowloadHelper.DownloadPdf(spl.Link + link, $"D:\\Report{countpage}.pdf");
                }
            }
             Console.ReadKey();
        }
    }
}
