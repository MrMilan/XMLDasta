﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace XmlDasta
{
    public partial class Form1 : Form
    {
        #region Globalvariables
        XDocument xDocument;

        private const string vetaDisAtrName = "naz";
        private const string vetaDisAtrKod = "kod";
        private const string vetaDisAtrDg = "dg";
        private const string vetaDisAtrPlatnost = "plati_od";
        private const string elementVetaDis = "VETA";

        OpenFileDialog openFileDialogNemoci = new OpenFileDialog();

        #endregion
        
        public Form1()
        {
            InitializeComponent();
            
        }

        #region EvensKlik
        

        private void btnReadDisXML_Click(object sender, EventArgs e)
        {
            string seznamCtenychSouboru = ListFileTerminalsOpen();

            

            openFileDialogNemoci.Filter = seznamCtenychSouboru;
            openFileDialogNemoci.RestoreDirectory = true;

            if (openFileDialogNemoci.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    xDocument = ReadDataFromXMLFile(openFileDialogNemoci.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Pojebalo se to nekde pri nacitani \r\n Puvodni error: " + ex.Message);
                }
            }

            fillListBox(listBoxNemoci, xDocument,vetaDisAtrName);
            

        }

        private void listBoxNemoci_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var root = xDocument.Root.Elements();
            var query = from veta in xDocument.Descendants(elementVetaDis)
                        where (veta.Attribute(vetaDisAtrName).Value == listBoxNemoci.SelectedItem.ToString())
                        select veta;

            foreach (var setnens in query)
            {
                tbNazev.Text = setnens.Attribute(vetaDisAtrName).Value.ToString();
                tBKod.Text = setnens.Attribute(vetaDisAtrKod).Value.ToString();
                tBDiagnosa.Text = setnens.Attribute(vetaDisAtrDg).Value.ToString();
                tbPlatnostOd.Text = setnens.Attribute(vetaDisAtrPlatnost).Value.ToString();
            }

        }

        private void btnNewDis_Click(object sender, EventArgs e)
        {
            int count = 0;
            var query = from veta in xDocument.Descendants(elementVetaDis)
                        where (veta.Attribute(vetaDisAtrKod).Value == tBKod.Text)
                        select veta;

            foreach (var setnens in query)
            {
                count++;
            }

            if (count >0)
            {
                DialogResult dialogResult = MessageBox.Show("Opravdu", "Chces opravdu premazat starz zaznam", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    addSentensToDis(xDocument,tbNazev.Text,tBKod.Text,tBDiagnosa.Text,tbPlatnostOd.Text); 
                }

            }
            else
            {
                addSentensToDis(xDocument, tbNazev.Text, tBKod.Text, tBDiagnosa.Text, tbPlatnostOd.Text);        
            }
            fillListBox(listBoxNemoci, xDocument, vetaDisAtrName);
        }


        #endregion

        #region Splitova parsovani plneni

        private void fillListBox(ListBox listBoxName, XDocument xmlDok, string nameAttribute)
        {
            var root = xmlDok.Root.Elements();
            foreach (var element in root)
            {
                listBoxName.Items.Add(element.Attribute(nameAttribute).Value);
            }
        
        }

        private void addSentensToDis(XDocument xmlDok,string nazevNem,string kod,string diagnosa,string platnostodd)
        {
            XElement veta = new XElement(elementVetaDis, new XAttribute(vetaDisAtrKod, kod),
                new XAttribute(vetaDisAtrName, nazevNem),
                new XAttribute(vetaDisAtrDg, diagnosa),
                new XAttribute(vetaDisAtrPlatnost, platnostodd));
                xDocument.Descendants(elementVetaDis).Single().Add(veta);
                xDocument.Save(openFileDialogNemoci.FileName);
        
        }

        #endregion

        #region Bezne rutiny

        /// <summary>
        /// Funkce pro nacitani dat ze souboru
        /// </summary>
        /// <param name="route">Cesta k souboru</param>
        private XDocument ReadDataFromXMLFile(string route)
        {
            return XDocument.Load(route);
        }

        private string ListFileTerminalsOpen()
        {
            List<string> cteneTypySouboru = new List<string>();
            cteneTypySouboru.Add("XML files (*.xml)|*.xml");
            cteneTypySouboru.Add("Javascr files (*.js*)|*.js*");
            cteneTypySouboru.Add("NMEA file (*.NMEA)|*.NMEA");
            cteneTypySouboru.Add("Textak file (*.txt)|*.txt");
            cteneTypySouboru.Add("Textak file (*.TXT)|*.TXT");
            cteneTypySouboru.Add("Html files (*.html*)|*.html*");
            cteneTypySouboru.Add("All files (*.*)|*.*");

            string seznamCtenychSouboru = "";

            for (int i = 0; i < cteneTypySouboru.Count(); i++)
            {
                if (i < cteneTypySouboru.Count() - 1)
                { seznamCtenychSouboru += cteneTypySouboru[i] + "|"; }
                else
                { seznamCtenychSouboru += cteneTypySouboru[i]; }
            }

            return seznamCtenychSouboru;

        }
        private string ListFileTerminalsSave()
        {
            List<string> cteneTypySouboru = new List<string>();
            cteneTypySouboru.Add("XML files (*.xml*)|*.xml*");
            cteneTypySouboru.Add("Textak file (*.txt)|*.txt");

            string seznamCtenychSouboru = "";

            for (int i = 0; i < cteneTypySouboru.Count(); i++)
            {
                if (i < cteneTypySouboru.Count() - 1)
                { seznamCtenychSouboru += cteneTypySouboru[i] + "|"; }
                else
                { seznamCtenychSouboru += cteneTypySouboru[i]; }
            }

            return seznamCtenychSouboru;

        }
     
        #region rReplace metody

        private string[] ReplaceSeparator(string[] inputStringArray, string oldSeparator, string newSeparator)
        {
            string[] newArrayWithNewSeparator = new string[inputStringArray.Length];
            for (int i = 0; i < inputStringArray.Length; i++)
            {
                newArrayWithNewSeparator[i] = inputStringArray[i].Replace(oldSeparator, newSeparator);
            }
            return newArrayWithNewSeparator;
        }

        /// <summary>
        /// Funkce pro vykresleni dat
        /// </summary>
        /// <param name="inputDataArray">Nacita vstupni double pole</param>
        /// <param name="nameLine">Nazev rady</param>
        public string[] ReplaceNull(string[] inputStringArray)
        {

            for (int i = 0; i < inputStringArray.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(inputStringArray[i]))
                {
                    inputStringArray[i] = "0";
                }
            }
            return inputStringArray;
        }

        #endregion

       
        
        #endregion
    }
}