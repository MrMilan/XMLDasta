﻿using System;
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

        public string AtrNaz = "";
        public string AtrRim = "";
        public string AtrKod = "";
        public string AtrDg = "";
        public string AtrPlatnost = "";
        public string Atrswho1 = "";
        //public SWHO1 swhoIt = new SWHO1();
        public List<SWHO1> swhoList = new List<SWHO1>();

        public static List<TDG> GetListOfTDG(XDocument xmlDok)
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

        private static string GetAtr(string nameAttribute, XElement element)
        {
            return String.IsNullOrWhiteSpace((string)element.Attribute(nameAttribute)) ? "" : element.Attribute(nameAttribute).Value;

        }

        public static XDocument NewTDGListByPMilan(List<TDG> tdgListek)
        {
            XDocument xTDGDok = new XDocument();

            XElement elementMKN10 = new XElement("MKN10");
            XElement elementDiagnosisArea = new XElement("Diagnosis_Area");
            XElement elementDiagnosisGroup = new XElement("Diagnosis_Group");
            XElement elementDiagnosisType = new XElement("Diagnosis_Type");
            XElement elementDiagnosis = new XElement("Diagnosis");
            int counterStrike;
            foreach (var itemTDG in tdgListek)
            {
                elementDiagnosisArea.Add(new XElement("Code", itemTDG.AtrRim));
                elementDiagnosisArea.Add(new XElement("Name", itemTDG.AtrNaz));
                elementDiagnosisArea.Add(new XElement("Included_codes", itemTDG.AtrDg));
                foreach (var itemSWHO in itemTDG.swhoList)
                {
                    elementDiagnosisGroup.Add(new XElement("Code", itemSWHO.AtrKod));
                    elementDiagnosisGroup.Add(new XElement("Name", itemSWHO.AtrName));
                    elementDiagnosisGroup.Add(new XElement("Included_codes", itemSWHO.AtrDg));
                    counterStrike = 0;
                    foreach (var itemMKN in itemSWHO.mkList)
                    {
                        if (itemMKN.MKN10AtrKod.Length <= 3)
                        {
                            if (counterStrike == 0) { counterStrike++; } else { elementDiagnosisGroup.Add(elementDiagnosisType); }
                            elementDiagnosisType = new XElement("Diagnosis_Type");
                            if (!String.IsNullOrWhiteSpace(itemMKN.MKN10AtrZnak)) { elementDiagnosisType.Add(new XAttribute("znak", itemMKN.MKN10AtrZnak)); }
                            if (!String.IsNullOrWhiteSpace(itemMKN.MKN10AtrPohlav)) { elementDiagnosisType.Add(new XAttribute("pohlav", itemMKN.MKN10AtrPohlav)); }
                            if (!String.IsNullOrWhiteSpace(itemMKN.MKN10AtrPumrti)) { elementDiagnosisType.Add(new XAttribute("pumrti", itemMKN.MKN10AtrPumrti)); }
                            elementDiagnosisType.Add(new XElement("Code", itemMKN.MKN10AtrKod));
                            elementDiagnosisType.Add(new XElement("Name", itemMKN.MKN10AtrName));
                            
                        }
                        if (itemMKN.MKN10AtrKod.Length>3)
                        {
                            elementDiagnosis = new XElement("Diagnosis");
                            if (!String.IsNullOrWhiteSpace(itemMKN.MKN10AtrZnak)) { elementDiagnosis.Add(new XAttribute("znak", itemMKN.MKN10AtrZnak)); }
                            if (!String.IsNullOrWhiteSpace(itemMKN.MKN10AtrPohlav)) { elementDiagnosis.Add(new XAttribute("pohlav", itemMKN.MKN10AtrPohlav)); }
                            if (!String.IsNullOrWhiteSpace(itemMKN.MKN10AtrPumrti)) { elementDiagnosis.Add(new XAttribute("pumrti", itemMKN.MKN10AtrPumrti)); }
                            elementDiagnosis.Add(new XElement("Code", itemMKN.MKN10AtrKod));
                            elementDiagnosis.Add(new XElement("Name", itemMKN.MKN10AtrName));
                            elementDiagnosisType.Add(elementDiagnosis);
                        }
                        
                    }

                }
                elementDiagnosisArea.Add(elementDiagnosisGroup);



            }

            elementMKN10.Add(elementDiagnosisArea);
            xTDGDok.Add(elementMKN10);


            //XElement kniha = new XElement("Kniha", new XAttribute("id", idpom + 1));
            //kniha.Add(new XElement("Nazev", txtNazev.Text));
            //kniha.Add(new XElement("Autor", txtAutor.Text));
            //kniha.Add(new XElement("ISBN", txtIsbn.Text));





            return xTDGDok;
        }
    }
}
