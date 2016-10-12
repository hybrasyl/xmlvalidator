using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Hybrasyl.Castables;
using Hybrasyl.Items;
using Hybrasyl.Maps;
using Hybrasyl.Nations;
using Hybrasyl.XML;

namespace XMLGui
{
    public partial class MainForm : Form
    {
        private string curDir = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string xml = File.ReadAllText(((ListBox) sender).SelectedItem.ToString());
            ValidateXML(curDir, xml);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (var folder in Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\hybrasyl\\world\\xml\\"))
            {
                comboBox1.Items.Add(folder);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var path = (string)((ComboBox)sender).SelectedItem;
            if (((ComboBox)sender).SelectedItem.ToString().Contains("castables")) curDir = "castable";
            if (((ComboBox)sender).SelectedItem.ToString().Contains("items")) curDir = "item";
            if (((ComboBox)sender).SelectedItem.ToString().Contains("itemvariants")) curDir = "variant";
            if (((ComboBox)sender).SelectedItem.ToString().Contains("maps")) curDir = "map";
            if (((ComboBox)sender).SelectedItem.ToString().Contains("nations")) curDir = "nation";
            if (((ComboBox)sender).SelectedItem.ToString().Contains("worldmaps")) curDir = "worldmap";
            foreach (var file in Directory.GetFiles(path).Where(x => x.ToLower().EndsWith(".xml")).ToList())
            {
                listBox1.Items.Add(file);
            }
        }


        private void ValidateXML(string curDir, string xml)
        {
            switch (curDir)
            {
                case "castable":
                {
                    try
                    {
                        var castable = Serializer.Deserialize(XmlReader.Create(new StringReader(xml)), new Castable());
                        richTextBox1.Text = "Valid Xml.";
                    }
                    catch (Exception ex)
                    {
                        richTextBox1.Text = string.Empty;
                        richTextBox1.Text += ex.Message + "\r\n";
                        if (ex.InnerException != null)
                            richTextBox1.Text += ex.InnerException.Message + "\r\n";
                    }

                    richTextBox2.Text = xml;
                }
                    break;
                case "item":
                    {
                        try
                        {
                            var item = Serializer.Deserialize(XmlReader.Create(new StringReader(xml)), new Item());
                            richTextBox1.Text = "Valid Xml.";
                        }
                        catch (Exception ex)
                        {
                            richTextBox1.Text = string.Empty;
                            richTextBox1.Text += ex.Message + "\r\n";
                            if (ex.InnerException != null)
                                richTextBox1.Text += ex.InnerException.Message + "\r\n";
                        }
                        
                        richTextBox2.Text = xml;

                    }
                    break;
                case "variant":
                {
                    richTextBox1.Text = "No longer used. Not implemented.";
                    richTextBox2.Text = string.Empty;
                }
                    break;
                case "map":
                    {
                        try
                        {
                            var map = Serializer.Deserialize(XmlReader.Create(new StringReader(xml)), new Map());
                            richTextBox1.Text = "Valid Xml.";
                        }
                        catch (Exception ex)
                        {
                            richTextBox1.Text = string.Empty;
                            richTextBox1.Text += ex.Message + "\r\n";
                            if (ex.InnerException != null)
                                richTextBox1.Text += ex.InnerException.Message + "\r\n";
                        }
                        richTextBox2.Text = xml;
                    }
                    break;
                case "nation":
                    {
                        try
                        {
                            var nation = Serializer.Deserialize(XmlReader.Create(new StringReader(xml)), new Nation());
                            richTextBox1.Text = "Valid Xml.";
                        }
                        catch (Exception ex)
                        {
                            richTextBox1.Text = string.Empty;
                            richTextBox1.Text += ex.Message + "\r\n";
                            if (ex.InnerException != null)
                                richTextBox1.Text += ex.InnerException.Message + "\r\n";
                        }
                        richTextBox2.Text = xml;

                    }
                    break;
                case "worldmap":
                    {
                        try
                        {
                            var worldmap = Serializer.Deserialize(XmlReader.Create(new StringReader(xml)), new WorldMap());
                            richTextBox1.Text = "Valid Xml.";
                        }
                        catch (Exception ex)
                        {
                            richTextBox1.Text = string.Empty;
                            richTextBox1.Text += ex.Message + "\r\n";
                            if (ex.InnerException != null)
                                richTextBox1.Text += ex.InnerException.Message + "\r\n";
                        }
                        richTextBox2.Text = xml;
                    }
                    break;
                default:
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text != string.Empty)
            ValidateXML(curDir, richTextBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var path = listBox1.SelectedItem.ToString();
            File.WriteAllText(path, richTextBox2.Text);
        }
    }
}
