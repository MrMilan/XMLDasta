using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XmlDasta
{
    class MKN10
    {

        #region Atributy
        private const string vetaMKN10AtrName = "naz";
        private const string vetaMKN10AtrKod = "kod";
        private const string vetaMKN10AtrTdg = "tdg";
        private const string vetaMKN10AtrZnak = "znak";
        private const string vetaMKN10AtrSnzis = "snzis";
        private const string vetaMKN10AtrPumrti = "pumrti";
        private const string vetaMKN10AtrSwho1 = "swho1";
        private const string vetaMKN10AtrSwho2 = "swho2";
        private const string vetaMKN10AtrSwho3 = "swho3";
        private const string vetaMKN10AtrSwho4 = "swho4";
        private const string vetaMKN10AtrSwho5 = "swho5";
        private const string vetaMKN10AtrSkupla1 = "skupla1";
        private const string vetaMKN10AtrSkupla2 = "skupla2";
        private const string vetaMKN10AtrSkupla3 = "skupla3";
        private const string vetaMKN10AtrSkupla4 = "skupla4";
        private const string vetaMKN10AtrSkupla5 = "skupla5";
        private const string vetaMKN10AtrSkupla6 = "skupla6";
        private const string vetaMKN10AtrSkupla7 = "skupla7";
        private const string vetaMKN10AtrSkupla8 = "skupla8";
        private const string vetaMKN10AtrPlatnost = "plati_od";
        private const string vetaMKN10AtrPohlav = "pohlav";
        private const string elementVetaMKN10 = "VETA";
        #endregion
        #region Promene
        public string MKN10AtrName = "";
        public string MKN10AtrKod = "";
        public string MKN10AtrTdg = "";
        public string MKN10AtrZnak = "";
        public string MKN10AtrSnzis = "";
        public string MKN10AtrPumrti = "";
        public string MKN10AtrSwho1 = "";
        public string MKN10AtrSwho2 = "";
        public string MKN10AtrSwho3 = "";
        public string MKN10AtrSwho4 = "";
        public string MKN10AtrSwho5 = "";
        public string MKN10AtrSkupla1 = "";
        public string MKN10AtrSkupla2 = "";
        public string MKN10AtrSkupla3 = "";
        public string MKN10AtrSkupla4 = "";
        public string MKN10AtrSkupla5 = "";
        public string MKN10AtrSkupla6 = "";
        public string MKN10AtrSkupla7 = "";
        public string MKN10AtrSkupla8 = "";
        public string MKN10AtrPlatnost = "";
        public string MKN10AtrPohlav = "";
        public Pumrti pumrti = new Pumrti();
        public Pohlav pohlavar = new Pohlav();
        #endregion
        public static List<MKN10> GetListOfMKN10(XDocument xmlDok)
        {
            List<MKN10> listMKN = new List<MKN10>();

            var root = xmlDok.Root.Elements();
            foreach (var element in root)
            {
                MKN10 mkn = new MKN10();
                mkn.MKN10AtrKod = GetAtr(vetaMKN10AtrKod, element);
                mkn.MKN10AtrName = GetAtr(vetaMKN10AtrName, element);
                mkn.MKN10AtrTdg = GetAtr(vetaMKN10AtrTdg, element);
                mkn.MKN10AtrZnak = GetAtr("znak", element);
                mkn.MKN10AtrSnzis = GetAtr("snzis", element);
                mkn.MKN10AtrPumrti = GetAtr("pumrti", element);
                mkn.MKN10AtrSwho1 = GetAtr("swho1", element);
                mkn.MKN10AtrSwho2 = GetAtr("swho2", element);
                mkn.MKN10AtrSwho3 = GetAtr("swho3", element);
                mkn.MKN10AtrSwho4 = GetAtr("swho4", element);
                mkn.MKN10AtrSwho5 = GetAtr("swho5", element);
                mkn.MKN10AtrSkupla1 = GetAtr("skupla1", element);
                mkn.MKN10AtrSkupla2 = GetAtr("skupla2", element);
                mkn.MKN10AtrSkupla3 = GetAtr("skupla3", element);
                mkn.MKN10AtrSkupla4 = GetAtr("skupla4", element);
                mkn.MKN10AtrSkupla5 = GetAtr("skupla5", element);
                mkn.MKN10AtrSkupla6 = GetAtr("skupla6", element);
                mkn.MKN10AtrSkupla7 = GetAtr("skupla7", element);
                mkn.MKN10AtrSkupla8 = GetAtr("skupla8", element);
                mkn.MKN10AtrPlatnost = GetAtr("plati_od", element);
                listMKN.Add(mkn);
            }

            return listMKN;

        }

        private static string GetAtr(string nameAttribute, XElement element)
        {
            return String.IsNullOrWhiteSpace((string)element.Attribute(nameAttribute)) ? "" : element.Attribute(nameAttribute).Value;

        }
        
    }
}
