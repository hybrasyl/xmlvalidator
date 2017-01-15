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
using Hybrasyl.XML;
using Hybrasyl.Castables;
using Hybrasyl.Creatures;
using Hybrasyl.Items;
using Hybrasyl.Maps;
using Hybrasyl.Nations;

namespace XMLValidator
{

    public partial class MainForm : Form
    {
        private string WorldDataDir = string.Empty;

        private FolderBrowserDialog FolderDialog;

        private static Dictionary<string, Type> XMLTypes = new Dictionary<string, Type>() {
            { "castables", typeof(Hybrasyl.Castables.Castable) },
            { "creatures", typeof(Creature) },
            { "nations", typeof(Nation) },
            { "maps", typeof(Hybrasyl.Maps.Map) },
            { "npcs", typeof(Hybrasyl.Creatures.Npc) },
            { "items", typeof(Item) },
            { "spawngroups", typeof(SpawnGroup) },
            { "worldmaps", typeof(WorldMap) }
        };

        public MainForm()
        {
            InitializeComponent();
            FolderDialog = new FolderBrowserDialog();
            FolderDialog.Description = "Please select a Hybrasyl world data directory.";
        }

        private void GetWorldDirectory()
        {
            var dirKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Hybrasyl").CreateSubKey("XMLValidator");
            if (FolderDialog.ShowDialog() == DialogResult.OK)
            {
                WorldDataDir = FolderDialog.SelectedPath;
                dirKey.SetValue("WorldDir", WorldDataDir);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            var dirKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Hybrasyl").CreateSubKey("XMLValidator");

            if (dirKey.GetValue("WorldDir") == null)
            {
                GetWorldDirectory();
                
            }
            WorldDataDir = dirKey.GetValue("WorldDir").ToString();
            ReloadXMLDirectories();
        }
        private void ReloadXMLDirectories()
        {
            comboBox1.Items.Clear();
            foreach (var folder in Directory.GetDirectories($"{WorldDataDir}\\xml\\"))
            {
                comboBox1.Items.Add(new DirectoryInfo(folder).Name);
            }
            richTextBoxWorldDir.Text = WorldDataDir;
            comboBox1.SelectedIndex = 0;

        }

        private void ProcessXMLDirectory(string path)
        {
            var valid = 0;
            var invalid = 0;
            var fullPath = Path.Combine(WorldDataDir, "xml", path);
            foreach (var file in Directory.GetFiles(fullPath).Where(x => x.ToLower().EndsWith(".xml")).ToList())
            {
                var xml = File.ReadAllText(file);
                if (ValidateXML(path, xml, file)) { valid++; }
                else { invalid++; }
            }
            var message = $"{path}: {valid + invalid} total files - {valid} valid, {invalid} invalid\n";
            if (invalid == 0)
            {
                richTextBoxStatus.AppendText(message, Color.Green);
            }
            else
            {
                richTextBoxStatus.AppendText(message, Color.Red);
            }
        }

        private bool ValidateXML(string type, string xml, string filePath)
        {
            var stringReader = new StringReader(xml);
            Type serializerType;
            var fileName = Path.GetFileName(filePath);
            if (!XMLTypes.TryGetValue(type, out serializerType))
            {
                richTextBoxOutput.AppendText($"{fileName}: {type} are currently unsupported. Sorry.\r\n", Color.Red);
                return false;
            }
            try
            {
                var xmlObject = Serializer.Deserialize(XmlReader.Create(stringReader), (dynamic)Activator.CreateInstance(serializerType));
                if (!checkBoxOnlyErrors.Checked)
                {
                    richTextBoxOutput.AppendText($"{fileName}: valid.\r\n", Color.Green);
                }
            }
            catch (Exception ex)
            {
                richTextBoxOutput.AppendText($"{fileName}: INVALID - {ex.Message}", Color.Red);
                if (ex.InnerException.Message != String.Empty) { richTextBoxOutput.AppendText($"{ex.InnerException.Message}\r\n", Color.Red); }
                return false;
            }
            return true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ProcessXMLDirectory((string)comboBox1.SelectedItem);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Text = string.Empty;
        }

        private void buttonValidateAll_Click(object sender, EventArgs e)
        {
            foreach (var file in Directory.GetDirectories(Path.Combine(WorldDataDir,"xml")))
            {
                ProcessXMLDirectory(new DirectoryInfo(file).Name);
            }
        }

        private void richTextBoxWorldDir_Click(object sender, EventArgs e)
        {
            GetWorldDirectory();
            ReloadXMLDirectories();
        }
    }
}
