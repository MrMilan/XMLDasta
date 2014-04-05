using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XmlDasta
{
    class TDG
    {
        private const string vetaTDGAtrNaz = "naz";
        private const string vetaTDGAtrRim = "rim";
        private const string vetaTDGAtrKod = "kod";
        private const string vetaTDGAtrDg = "dg";
        private const string vetaTDGAtrPlatnost = "plati_od";
        private const string vetaTDGAtrswho1 = "swho1";
        private const string elementVetaTDG = "VETA";

        public string AtrNaz = "naz";
        public string AtrRim = "rim";
        public string AtrKod = "kod";
        public string AtrDg = "dg";
        public string AtrPlatnost = "plati_od";
        public string Atrswho1 = "swho1";
        //public SWHO1 swhoIt = new SWHO1();
        public List<SWHO1> swhoList = new List<SWHO1>();

        public List<TDG> GetListOfTDG(XDocument xmlDok)
        {
            List<TDG> listTDG = new List<TDG>();

            var root = xmlDok.Root.Elements();
            foreach (var element in root)
            {
                TDG tDG = new TDG();
                tDG.AtrNaz = GetAtr("naz", element);
                tDG.AtrRim = GetAtr("rim", element);
                tDG.AtrKod = GetAtr("kod", element);
                tDG.AtrDg = GetAtr("dg", element);
                tDG.AtrPlatnost = GetAtr("plati_od", element);
                tDG.Atrswho1 = GetAtr("swho1", element);

                listTDG.Add(tDG);
            }

            return listTDG;

        }

        private string GetAtr(string nameAttribute, XElement element)
        {
            return String.IsNullOrWhiteSpace((string)element.Attribute(nameAttribute)) ? "" : element.Attribute(nameAttribute).Value;

        }
    }
}
