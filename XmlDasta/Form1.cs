using System;
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
    public partial class NacitaniXML : Form
    {
        #region Globalvariables
        XDocument xDocument;
        List<TDG> listTDGF = new List<TDG>();
        List<Pohlav> listPohF = new List<Pohlav>();
        List<MKN10> listMKNF = new List<MKN10>();
        List<Pumrti> listPumF = new List<Pumrti>();
        List<SWHO1> listSWHOF = new List<SWHO1>();
        //list vybranych
        List<SWHO1> litikSW = new List<SWHO1>();
        List<MKN10> litikMK = new List<MKN10>();

        OpenFileDialog openFileDialogNemoci = new OpenFileDialog();

        #endregion

        public NacitaniXML()
        {
            InitializeComponent();
            btnNewDis.Enabled=(false);

        }

        #region EvensKlik
        #region Otvirani souboru
        private void btnReadDisXMLMKN_Click(object sender, EventArgs e)
        {
            string seznamCtenychSouboru = ListFileTerminalsOpen();



            openFileDialogNemoci.Filter = seznamCtenychSouboru;
            openFileDialogNemoci.RestoreDirectory = true;
            openFileDialogNemoci.Title = "Otevri MKN";
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

            try
            {
                xDocument.Elements();
                listMKNF = MKN10.GetListOfMKN10(xDocument);
            }
            catch
            {
                MessageBox.Show("Nenacetl si dokument");
                //throw new Exception("Nenacetl si dokument");
            }



        }

        private void btnReadDisXMLPoh_Click(object sender, EventArgs e)
        {
            string seznamCtenychSouboru = ListFileTerminalsOpen();



            openFileDialogNemoci.Filter = seznamCtenychSouboru;
            openFileDialogNemoci.RestoreDirectory = true;
            openFileDialogNemoci.Title = "Otevri Pohlavi";
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
            try
            {
                xDocument.Elements();
                listPohF = Pohlav.GetListOfPohlav(xDocument);
            }
            catch
            {
                MessageBox.Show("Nenacetl si dokument");
                //throw new Exception("Nenacetl si dokument");
            }
            


        }

        private void btnReadDisXMLTDG_Click(object sender, EventArgs e)
        {
            string seznamCtenychSouboru = ListFileTerminalsOpen();



            openFileDialogNemoci.Filter = seznamCtenychSouboru;
            openFileDialogNemoci.RestoreDirectory = true;
            openFileDialogNemoci.Title = "Otevri TDG";
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
            try
            {
                xDocument.Elements();
                listTDGF = TDG.GetListOfTDG(xDocument);
            }
            catch
            {
                MessageBox.Show("Nenacetl si dokument");
                //throw new Exception("Nenacetl si dokument");
            }
            


        }

        private void btnReadDisXMLPumrti_Click(object sender, EventArgs e)
        {
            string seznamCtenychSouboru = ListFileTerminalsOpen();



            openFileDialogNemoci.Filter = seznamCtenychSouboru;
            openFileDialogNemoci.RestoreDirectory = true;
            openFileDialogNemoci.Title = "Otevri Pumrti";
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

            try
            {
                xDocument.Elements();
                listPumF = Pumrti.GetListOfPumrti(xDocument);
            }
            catch
            {
                MessageBox.Show("Nenacetl si dokument");
                //throw new Exception("Nenacetl si dokument");
            }
            


        }

        private void btnReadDisXMLSWHO_Click(object sender, EventArgs e)
        {
            string seznamCtenychSouboru = ListFileTerminalsOpen();



            openFileDialogNemoci.Filter = seznamCtenychSouboru;
            openFileDialogNemoci.RestoreDirectory = true;
            openFileDialogNemoci.Title = "Otevri SWHO";
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

            try
            {
               xDocument.Elements();
               listSWHOF = SWHO1.GetListOfSWHO1(xDocument);
            }
            catch
            {
                MessageBox.Show("Nenacetl si dokument");
                //throw new Exception("Nenacetl si dokument");
            }
            

        }

        #endregion
        #region Zmeny listboxu
        private void listBoxTDG_SelectedIndexChanged(object sender, EventArgs e)
        {


            //var root = xDocument.Root.Elements();
            var query = from veta in listTDGF
                        where (veta.AtrNaz == listBoxTDG.SelectedItem.ToString())
                        select veta;


            foreach (var setnens in query)
            {
                litikSW = setnens.swhoList;
            }
            fillListBox(listBoxSWHO, litikSW);
            listBoxMKN.Items.Clear();
            lbSWHO.Text = "SWHO ";
            lbMKN.Text = "MKN ";

        }

        private void listBoxSWH_SelectedIndexChanged(object sender, EventArgs e)
        {

            //var root = xDocument.Root.Elements();
            var query = from veta in litikSW
                        where (veta.AtrName == listBoxSWHO.SelectedItem.ToString())
                        select veta;


            foreach (var setnens in query)
            {
                litikMK = setnens.mkList;
                lbSWHO.Text = "SWHO " + setnens.AtrKod + "\n " + setnens.AtrName + " " + setnens.AtrDg + " " + setnens.AtrPlatnost;
            }
            fillListBox(listBoxMKN, litikMK);


        }

        private void listBoxMKN_SelectedIndexChanged(object sender, EventArgs e)
        {

            //var root = xDocument.Root.Elements();
            var query = from veta in litikMK
                        where (veta.MKN10AtrName == listBoxMKN.SelectedItem.ToString())
                        select veta;

            foreach (var setnens in query)
            {
                lbMKN.Text = "MKN --> " + setnens.MKN10AtrKod + "\n " + setnens.MKN10AtrName + "\n " + setnens.MKN10AtrTdg + "\n " + setnens.MKN10AtrPlatnost
                    + "\n Je pricinou umrti --> " + "\n " + setnens.pumrti.AtrName + "\n " + setnens.pumrti.AtrKod + "\n " + setnens.pumrti.AtrDg;
            }

        }
        #endregion

        private void btnSpoj_Click(object sender, EventArgs e)
        {

            try
            {
               #region Nacitani MKN do SWHO
                foreach (var itemMKN in listMKNF)
                {

                    foreach (var itemSWH in listSWHOF)
                    {
                        if (itemMKN.MKN10AtrSwho1 == itemSWH.AtrKod)
                        {
                            itemSWH.mkList.Add(itemMKN);
                        }

                    }

                }

                #endregion
               #region Nacitani SWHOF do TGF
                foreach (var itemSWH in listSWHOF)
                {
                    foreach (var itemTFG in listTDGF)
                    {
                        foreach (var itemMKN in itemSWH.mkList)
                        {
                            if (itemMKN.MKN10AtrTdg == itemTFG.AtrKod)
                            {
                                itemTFG.swhoList.Add(itemSWH);
                                break;
                            }
                        }
                    }

                }
                #endregion
               #region Nacteni Pumrti a Pohl
                foreach (var itemTFG in listTDGF)
                {
                    foreach (var itemSWH in itemTFG.swhoList)
                    {
                        foreach (var itemMKN in itemSWH.mkList)
                        {
                            //nactu pohlavi
                            foreach (var itemPohl in listPohF)
                            {
                                if (itemMKN.MKN10AtrPohlav == itemPohl.AtrKod)
                                {
                                    itemMKN.pohlavar = itemPohl;
                                }
                            }
                            //nactu umrti
                            foreach (var itemPumr in listPumF)
                            {
                                if (itemMKN.MKN10AtrPumrti == itemPumr.AtrKod)
                                {
                                    itemMKN.pumrti = itemPumr;
                                }
                            }

                        }
                    }
                }
                #endregion

            }
            catch (Exception exc)
            {

                throw new Exception("Nekde si zapomel neco nacist" + exc.Message);
            }
            btnNewDis.Enabled = true;
            fillListBox(listBoxTDG, listTDGF);

        }

        private void btnNewDis_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "Uloy MKN";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XDocument xOut = TDG.NewTDGListByPMilan(listTDGF);
                       xOut.Save(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Pojebalo se to nekde pri ukladani \r\n Puvodni error: " + ex.Message);
                }
            }


            //int count = 0;
            //var query = from veta in xDocument.Descendants(elementVetaDis)
            //            where (veta.Attribute(vetaDisAtrKod).Value == tBKod.Text)
            //            select veta;

            //foreach (var setnens in query)
            //{
            //    count++;
            //}

            //if (count >0)
            //{
            //    DialogResult dialogResult = MessageBox.Show("Opravdu", "Chces opravdu premazat starz zaznam", MessageBoxButtons.OKCancel);
            //    if (dialogResult == DialogResult.OK)
            //    {
            //        addSentensToDis(xDocument,tbNazev.Text,tBKod.Text,tBDiagnosa.Text,tbPlatnostOd.Text); 
            //    }

            //}
            //else
            //{
            //    addSentensToDis(xDocument, tbNazev.Text, tBKod.Text, tBDiagnosa.Text, tbPlatnostOd.Text);        
            //}
            //fillListBox(listBoxNemoci, xDocument, vetaDisAtrName);
        }


        #endregion

        #region Splitova parsovani plneni

        private void fillListBox(ListBox listBoxName, List<MKN10> mkn)
        {
            listBoxName.Items.Clear();
            foreach (var itemMKN in mkn)
            {
                listBoxName.Items.Add(itemMKN.MKN10AtrName);
            }

        }

        private void fillListBox(ListBox listBoxName, List<TDG> tDG)
        {
            listBoxName.Items.Clear();
            foreach (var itemTDG in tDG)
            {
                listBoxName.Items.Add(itemTDG.AtrNaz);
            }

        }

        private void fillListBox(ListBox listBoxName, List<SWHO1> sWHO1)
        {
            listBoxName.Items.Clear();
            foreach (var itemSWH in sWHO1)
            {
                listBoxName.Items.Add(itemSWH.AtrName);
            }

        }

        private void addSentensToDis(XDocument xmlDok, string nazevNem, string kod, string diagnosa, string platnostodd)
        {
            //XElement veta = new XElement(elementVetaDis, new XAttribute(vetaDisAtrKod, kod),
            //    new XAttribute(vetaDisAtrName, nazevNem),
            //    new XAttribute(vetaDisAtrDg, diagnosa),
            //    new XAttribute(vetaDisAtrPlatnost, platnostodd));
            //    xDocument.Descendants(elementVetaDis).Single().Add(veta);
            //    xDocument.Save(openFileDialogNemoci.FileName);

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
