using System;
using System.Collections.Generic;

namespace ConsoleParserPdf
{
    class LinkParsSite
    {
        public readonly List<SitePars> SiteParseList;

        public LinkParsSite()
        {
            SiteParseList = new List<SitePars>();

            //1
            //ethosfund
            SitePars ethosfund = new SitePars();
            ethosfund.LinkPdfFile = @"https://www.ethosfund.ch/en/news-and-publications/reports-publications";
            ethosfund.Link = @"https://www.ethosfund.ch";
            ethosfund.KeyWord = new List<string>() { "voting", "guidelines", $"{DateTime.Now.Year}" };
            ethosfund.TestPdfLink = @"https://www.ethosfund.ch/sites/default/files/2020-02/LDPCG_Ethos_2020_EN.pdf";

            //2
            //zcapital
            SitePars zcapital = new SitePars();
            zcapital.LinkPdfFile = @"https://www.zcapital.ch/en/approach/";
            zcapital.Link = @"https://www.zcapital.ch";
            zcapital.KeyWord = new List<string>() { "voting", "guidelines" };
            zcapital.TestPdfLink = @"https://www.zcapital.ch/fileadmin/zcapital/documents/Abstimmungsrichtlinien_01.pdf";

            //3
            //inrate1
            SitePars inrateAbstim = new SitePars();
            inrateAbstim.LinkPdfFile = @"https://www.inrate.com/en/f0185000144.html";
            inrateAbstim.Link = @"https://www.inrate.com";
            inrateAbstim.KeyWord = new List<string>() { "voting", "guideline", $"{DateTime.Now.Year}" };
            inrateAbstim.TestPdfLink = @"https://www.inrate.com/cm_document/zRating-Abstimmungsrichtlinie_2020.pdf";

            //4
            //inrate1
            SitePars Kriteri = new SitePars();
            Kriteri.LinkPdfFile = @"https://www.inrate.com/en/f0185000144.html";
            Kriteri.Link = @"https://www.inrate.com";
            Kriteri.KeyWord = new List<string>() { "criteria", "catalogue", $"{DateTime.Now.Year}" };
            Kriteri.TestPdfLink = @"https://www.inrate.com/cm_document/zRating-Kriterienkatalog_2020.pdf";

            //5
            //glasslewis Switzerland
            SitePars glasslewis = new SitePars();
            glasslewis.LinkPdfFile = @"https://www.glasslewis.com/guidelines/";
            glasslewis.Link = @"https://www.glasslewis.com";
            glasslewis.KeyWord = new List<string>() { "switzerland guideline", "_switzerland" };//id="Switzerland Guideline"
            glasslewis.TestPdfLink = @"https://www.glasslewis.com/wp-content/uploads/2016/01/Guidelines_Switzerland.pdf";


            //6
            //glasslewis Europe
            SitePars glasslewisEurope = new SitePars();
            glasslewisEurope.LinkPdfFile = @"https://www.glasslewis.com/guidelines/";
            glasslewisEurope.Link = @"https://www.glasslewis.com";
            glasslewisEurope.KeyWord = new List<string>() { "europe guideline" };//id="Europe Guideline"
            glasslewisEurope.TestPdfLink = @"https://www.glasslewis.com/wp-content/uploads/2016/11/Guidelines_Continental_Europe.pdf";



            //7
            //issgovernance  --Europe Proxy Voting Summary Guidelines
            SitePars issgovernanceE = new SitePars();
            issgovernanceE.LinkPdfFile = @"https://www.issgovernance.com/policy-gateway/voting-policies/";
            issgovernanceE.Link = @"https://www.issgovernance.com";
            issgovernanceE.KeyWord = new List<string>() { "europe", "voting", "guidelines" };
            issgovernanceE.TestPdfLink = @"https://www.issgovernance.com/file/policy/active/emea/Europe-Voting-Guidelines.pdf";

            //8
            //issgovernance  --European Pay-for-Performance Methodology Overview
            SitePars issgovernanceEPay = new SitePars();
            issgovernanceEPay.LinkPdfFile = @"https://www.issgovernance.com/policy-gateway/voting-policies/";
            issgovernanceEPay.Link = @"https://www.issgovernance.com";
            issgovernanceEPay.KeyWord = new List<string>() { "european pay-for-performance methodology overview" };
            issgovernanceEPay.TestPdfLink = @"https://www.issgovernance.com/file/policy/active/emea/European-Pay-for-Performance-Methodology-Overview.pdf";

            //9
            //issgovernance  --European Pay-for-Performance Methodology FAQ
            SitePars issgovernanceEFAQ = new SitePars();
            issgovernanceEFAQ.LinkPdfFile = @"https://www.issgovernance.com/policy-gateway/voting-policies/";
            issgovernanceEFAQ.Link = @"https://www.issgovernance.com";
            issgovernanceEFAQ.KeyWord = new List<string>() { "european pay-for-performance methodology faq" };
            issgovernanceEFAQ.TestPdfLink = @"https://www.issgovernance.com/file/policy/active/emea/European-Pay-for-Performance-Methodology-FAQ.pdf";


            //10
            //swisscanto 
            SitePars swisscanto = new SitePars();
            swisscanto.LinkPdfFile = @"https://www.swisscanto.com/ch/en/po/companies/swisscanto-asset-management-international-sa.html";
            swisscanto.Link = @"https://www.swisscanto.com";
            swisscanto.KeyWord = new List<string>() { "generalversammlungen", "abstimmungspolitik" };//????
            swisscanto.TestPdfLink = @"https://www.swisscanto.com/media/dok/corporate/7_legal/706-sami-abstimmungspolitik-an-generalversammlungen-eng.pdf";


            //11
            //swisscanto 
            SitePars compenswiss = new SitePars();
            compenswiss.LinkPdfFile = @"https://www.compenswiss.ch/governance/en/?page_name=vote";
            compenswiss.Link = @"https://www.compenswiss.ch/governance/EN/";
            compenswiss.KeyWord = new List<string>() { ".pdf" };//Reglement B-200 - Ausuebung der Stimmrechte.pdf
            compenswiss.TestPdfLink = @"https://www.compenswiss.ch/governance/EN/doc.cfm?grp_name=avsLibFileListing&doc_name=Reglement%20B-200%20-%20Ausuebung%20der%20Stimmrechte.pdf";


            //12
            //blackrock 
            SitePars blackrock = new SitePars();
            blackrock.LinkPdfFile = @"https://www.blackrock.com/corporate/about-us/investment-stewardship#guidelines";
            blackrock.Link = @"https://www.blackrock.com/corporate";
            blackrock.KeyWord = new List<string>() { "european, middle eastern & african securities", "guidelines"  };
            blackrock.TestPdfLink = @"https://www.blackrock.com/corporate/literature/fact-sheet/blk-responsible-investment-guidelines-emea.pdf";


            //13
            //nbim 
            SitePars nbim = new SitePars();
            nbim.LinkPdfFile = @"https://www.nbim.no/en/publications/";
            nbim.Link = @"https://www.nbim.no";
            nbim.KeyWord = new List<string>() { "global", "voting", "guidelines", $"{DateTime.Now.Year}" };
            nbim.TestPdfLink = @"https://www.nbim.no/contentassets/1059e60479784796bac26e0cee596613/global-voting-guidelines-2020.pdf";


            //14
            //nbim 
            SitePars nbimCEO = new SitePars();
            nbimCEO.LinkPdfFile = @"ceo-remuneration"; //Bad search
            nbimCEO.Link = @"https://www.nbim.no";
            nbimCEO.KeyWord = new List<string>() {  };
            nbimCEO.TestPdfLink = @"https://www.nbim.no/contentassets/bc85c448e6b24ff5a31088883695a344/ceo-remuneration---amp-1-17---norges-bank-investment-management.pdf";


            //15
            //nbim 
            SitePars fidelity = new SitePars();
            fidelity.LinkPdfFile = @"https://www.fidelity.com/about-fidelity/fidelity-by-numbers/fmr/proxy-voting-overview";
            fidelity.Link = @"https://www.fidelity.com";
            fidelity.KeyWord = new List<string>() { "fidelity funds advised by fmr (pdf)", "voting", "guidelines" };
            fidelity.TestPdfLink = @"https://www.fidelity.com/bin-public/060_www_fidelity_com/documents/Full-Proxy-Voting-Guidelines-for-Fidelity-Funds-Advised-by-FMRCo-and-SelectCo.pdf";


            SiteParseList.Add(ethosfund);//1
            SiteParseList.Add(zcapital);//2
            SiteParseList.Add(inrateAbstim);//3
            SiteParseList.Add(Kriteri);//4
            SiteParseList.Add(glasslewis);//5
            SiteParseList.Add(glasslewisEurope);//6
            SiteParseList.Add(issgovernanceE);//7
            SiteParseList.Add(issgovernanceEPay);//8
            SiteParseList.Add(issgovernanceEFAQ);//9
            SiteParseList.Add(swisscanto);//10
            SiteParseList.Add(compenswiss);//11
            SiteParseList.Add(blackrock);//12
            SiteParseList.Add(nbim);//13
            SiteParseList.Add(fidelity);//15
        }

    }
}
