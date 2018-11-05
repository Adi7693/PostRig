using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Input;

namespace PostRig
{
    public partial class MainForm : Form
    {
        public Document Doc { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private delegate void LastActiveTab(object sender, EventArgs e);

        private LastActiveTab lastActiveTab;

        //Display Ribbon on Clicking New
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRibbon.Visible = true;
            Doc = new Document();
        }


        private void exitToolStripMenu_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want To Close The Program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        //Make Property Panel Visible New Car Button Click
        private void NewCarRibbonButton_Click(object sender, EventArgs e)
        {
            this.PropertiesPanel.Visible = true;
            this.PropertiesPanel.BringToFront();


        }

        private void VehicleMassTextBox_TextChanged(object sender, EventArgs e)
        {
            double newVehicleMass = 0.0;

            if (double.TryParse(VehicleMassTextBox.Text, out newVehicleMass))
            {
                Doc.Input.VehicleMass = newVehicleMass;
            }
        }

        private void SpringStiffnessTextBox_TextChanged(object sender, EventArgs e)
        {
            double newSpringStiffness = 0.0;

            if (double.TryParse(SpringStiffnessTextBox.Text, out newSpringStiffness))
            {
                Doc.Input.SpringStiffness = newSpringStiffness;
            }
        }

        private void DampingCoeffTextBox_TextChanged(object sender, EventArgs e)
        {
            double newDampingCoeff = 0.0;

            if(double.TryParse(DampingCoeffTextBox.Text,out newDampingCoeff))
            {
                Doc.Input.DampingCoefficient = newDampingCoeff;
            }
        }


        //Hide Property Panel and Open Initialization Panel
       private void test(object sender, MouseEventArgs e)
        {

        }

        private void CarDrpRibbonButton_Click(object sender, EventArgs e)
        {
            this.PropertiesPanel.Visible = true;
        }

        private void SimSetupRibbonTab_ActiveChanged(object sender, EventArgs e)
        {
            this.PropertiesPanel.Visible = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = "C:\\";

            dlg.Filter = "PostRig Files (*.postrig)|*.postrig";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Doc = new Document(dlg.FileName);
            }

            if (Doc != null)
            {
                UpdateUIFromDocument();
            }
        }


        public void UpdateUIFromDocument()
        {
            if (Doc != null)
            {
                VehicleMassTextBox.Text = Doc.Input.VehicleMass.ToString();
                DampingCoeffTextBox.Text = Doc.Input.DampingCoefficient.ToString();
                SpringStiffnessTextBox.Text = Doc.Input.SpringStiffness.ToString();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Doc != null && !string.IsNullOrWhiteSpace(Doc.FileName))
            {
                Doc.Save();
            }
            else if (Doc != null)
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Doc != null)
            {
                SaveFileDialog dlg = new SaveFileDialog();

                dlg.InitialDirectory = "C:\\";

                dlg.DefaultExt = "*.postrig";

                dlg.AddExtension = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Doc.SaveAs(dlg.FileName);
                }
            }
        }
    }
}
