using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XmlDasta
{
    class SWHO1
    {
        private const string vetaSWHO1AtrName = "naz";
        private const string vetaSWHO1AtrKod = "kod";
        private const string vetaSWHO1AtrDg = "dg";
        private const string vetaSWHO1AtrPlatnost = "plati_od";
        private const string elementVetaSWHO1 = "VETA";

        public string AtrName = "naz";
        public string AtrKod = "kod";
        public string AtrDg = "dg";
        public string AtrPlatnost = "plati_od";
        public List<Diag> diagList = new List<Diag>();
        public List<MKN10> mkList = new List<MKN10>();
        //public Diag diagIt = new Diag();

        public List<SWHO1> GetListOfSWHO1(XDocument xmlDok)
        {
            List<SWHO1> listsWHO1 = new List<SWHO1>();

            var root = xmlDok.Root.Elements();
            foreach (var element in root)
            {
                SWHO1 sWHO = new SWHO1();
        sWHO.AtrName = GetAtr("naz",element);
        sWHO.AtrKod = GetAtr("kod",element);
        sWHO.AtrDg = GetAtr("dg",element);
        sWHO.AtrPlatnost = GetAtr("plati_od", element);

                listsWHO1.Add(sWHO);
            }

            return listsWHO1;

        }

        private string GetAtr(string nameAttribute, XElement element)
        {
            return String.IsNullOrWhiteSpace((string)element.Attribute(nameAttribute)) ? "" : element.Attribute(nameAttribute).Value;

        }

       
    }
}
