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
        InputData Input = new InputData();
        private bool NeedToCalculate;

        
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
        }


        private void exitToolStripMenu_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want To Close The Program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }


        //Make Property Panel Visible New Car Button Click
        private void NewCarRibbonButton_Click(object sender, EventArgs e)
        {
            this.PropertiesPanel.Visible = true;
        }

        private void VehicleMassTextBox_TextChanged(object sender, EventArgs e)
        {
            double newVehicleMass = 0.0;

            if (double.TryParse(VehicleMassTextBox.Text, out newVehicleMass))
            {
                Input.VehicleMass = newVehicleMass;
                NeedToCalculate = true;
            }
        }

        private void SpringStiffnessTextBox_TextChanged(object sender, EventArgs e)
        {
            double newSpringStiffness = 0.0;

            if (double.TryParse(SpringStiffnessTextBox.Text, out newSpringStiffness))
            {
                Input.SpringStiffness = newSpringStiffness;
                NeedToCalculate = true;
            }
        }

        private void DampingCoeffTextBox_TextChanged(object sender, EventArgs e)
        {
            double newDampingCoeff = 0.0;

            if(double.TryParse(DampingCoeffTextBox.Text,out newDampingCoeff))
            {
                Input.DampingCoefficient = newDampingCoeff;
                NeedToCalculate = true;
            }
        }


        //Hide Property Panel and Open Initialization Panel
       

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
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
