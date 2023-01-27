using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace VoiceAssistant
{
    public partial class OptionsPage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public OptionsPage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        void SaveCommand()
        {
            try
            {
                XmlDocument i = new XmlDocument();
                DataSet ds = new DataSet();
                XmlReader xmlFile;
                xmlFile = XmlReader.Create(@"AddCommand.xml", new XmlReaderSettings());
                ds.ReadXml(xmlFile);
                AddCommDGV.DataSource = ds.Tables[0];
                xmlFile.Close();
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Please add a command and try again.", "There are no commands",MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {

                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
            

            DataSet dset = new DataSet();
            XmlReader xmlFiles;
            xmlFiles = XmlReader.Create(@"DefaultCommand.xml", new XmlReaderSettings());
            dset.ReadXml(xmlFiles);
            DefaultCommDGV.DataSource = dset.Tables[0];
            xmlFiles.Close();

            this.Refresh();
            
        }
        private void OptionsPage_Load(object sender, EventArgs e)
        {
            SaveCommand();
        }

        XDocument x = XDocument.Load(@"AddCommand.xml");
        private void SaveCommandBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.ShowDialog();
                string DosyaYolu = file.FileName;

                x.Element("AddCommands").Add(
                new XElement("Commands",
                new XElement("Command", CommandTB.Text),
                new XElement("Location", DosyaYolu)
                ));

                x.Save(@"AddCommand.xml");
                SaveCommand();
            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("An error occurred while adding the command. Please try again later.", "Unexpected Error", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.Cancel)
                {

                }
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void AddCommDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CommandTB.Text = AddCommDGV.CurrentRow.Cells[0].Value.ToString();
        }

        private void DeleteCommandBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AddCommDGV.Rows.Count-1; i++)
            {
                int rowcount = AddCommDGV.Rows.Count-1;
                if (rowcount == 1)
                {
                    MessageBox.Show("If you delete this command, the program may become faulty. Please add another command and then delete this command.", "This command cannot be deleted!");
                }
                else if (rowcount > 1)
                {
                    x.Root.Elements().Where(a => a.Element("Command").Value == CommandTB.Text).Remove();
                    x.Save(@"AddCommand.xml");
                    SaveCommand();
                }
            }
        }
    }
}
