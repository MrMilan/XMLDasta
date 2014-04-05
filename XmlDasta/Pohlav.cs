using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XmlDasta
{
    class Pohlav
    {
        private const string vetaPohlavAtrName = "naz";
        private const string vetaPohlavAtrKod = "kod";
        private const string vetaPohlavAtrSkupla1 = "skupla1";
        private const string vetaPohlavAtrSkupla2 = "skupla2";
        private const string vetaPohlavAtrSkupla3 = "skupla3";
        private const string elementVetaPohlav = "VETA";

        public string AtrName = "naz";
        public string AtrKod = "kod";
        public string AtrSkupla1 = "skupla1";
        public string AtrSkupla2 = "skupla2";
        public string AtrSkupla3 = "skupla3";


        public List<Pohlav> GetListOfPohlav(XDocument xmlDok)
        {
            List<Pohlav> listPoh = new List<Pohlav>();

            var root = xmlDok.Root.Elements();
            foreach (var element in root)
            {
                Pohlav poh = new Pohlav();
                poh.AtrName = GetAtr("naz", element);
                poh.AtrKod = GetAtr("kod", element);
                poh.AtrSkupla1 = GetAtr("skupla1", element);
                poh.AtrSkupla2 = GetAtr("skupla2", element);
                poh.AtrSkupla3 = GetAtr("skupla3", element);
                listPoh.Add(poh);
            }

            return listPoh;

        }

        private string GetAtr(string nameAttribute, XElement element)
        {
            return String.IsNullOrWhiteSpace((string)element.Attribute(nameAttribute)) ? "" : element.Attribute(nameAttribute).Value;
        }
    }
}
