using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XmlDasta
{
    class Pumrti
    {
        private const string vetaPumrtiAtrName = "naz";
        private const string vetaPumrtiAtrKod = "kod";
        private const string vetaPumrtiAtrDg = "dg1";
        private const string elementVetaPumrti = "VETA";

        public string AtrName = "naz";
        public string AtrKod = "kod";
        public string AtrDg = "dg1";

        public List<Pumrti> GetListOfPumrti(XDocument xmlDok)
        {
            List<Pumrti> listPumrti = new List<Pumrti>();

            var root = xmlDok.Root.Elements();
            foreach (var element in root)
            {
                Pumrti umrti = new Pumrti();
                umrti.AtrName = GetAtr("naz", element);
                umrti.AtrKod = GetAtr("kod", element);
                umrti.AtrDg = GetAtr("dg1", element);

                listPumrti.Add(umrti);
            }

            return listPumrti;

        }

        private string GetAtr(string nameAttribute, XElement element)
        {
            return String.IsNullOrWhiteSpace((string)element.Attribute(nameAttribute)) ? "" : element.Attribute(nameAttribute).Value;

        }
    }
}
