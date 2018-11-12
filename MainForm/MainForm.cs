using System;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using System.Collections.Generic;
using System.Linq;

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

            if (double.TryParse(DampingCoeffTextBox.Text, out newDampingCoeff))
            {
                Doc.Input.DampingCoefficient = newDampingCoeff;
            }
        }

        private void StepIPRibbonButton_Click(object sender, EventArgs e)
        {
            this.PropertiesPanel.Visible = false;
            this.StepInputPanel.Visible = true;
            this.StepInputCartesianChart.Visible = true;
            UpdateUIFromDocument();


            Doc.Input.Calculate();


            StepInputCartesianChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title="Step Input",
                    Values = new ChartValues<double>(Doc.Input.StepInput),
                    PointGeometry=null
                },

            };


            StepInputCartesianChart.AxisX.Add(new Axis
            {
                Title = "Time",
                Labels = new List<string>(Doc.Input.TimeIntervals.Select(x => x.ToString()))
            });



        }

       





        private void StartTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            double newStartTime = 0.0;

            if (double.TryParse(StartTimeTextBox.Text, out newStartTime))
            {
                Doc.Input.StartTime = newStartTime;
            }
        }

        private void EndTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            double newEndTime = 0.0;

            if (double.TryParse(EndTimeTextBox.Text, out newEndTime))
            {
                Doc.Input.EndTime = newEndTime;
            }
        }

        private void TimeStepTextBox_TextChanged(object sender, EventArgs e)
        {
            double newTimeStep = 0.0;

            if (double.TryParse(TimeStepTextBox.Text, out newTimeStep))
            {
                Doc.Input.TimeStep = newTimeStep;
            }
        }

        private void StepTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            double newStepTime = 0.0;

            if (double.TryParse(StepTimeTextBox.Text, out newStepTime))
            {
                Doc.Input.StepAmplitudeChangeTime = newStepTime;
            }
        }

        private void StepAmplitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            double newStepAmplitude = 0.0;

            if (double.TryParse(StepAmplitudeTextBox.Text, out newStepAmplitude))
            {
                Doc.Input.StepAmplitude = newStepAmplitude;
            }
        }


        private void CarDrpRibbonButton_Click(object sender, EventArgs e)
        {
            this.PropertiesPanel.Visible = true;
        }

        private void SimSetupRibbonTab_ActiveChanged(object sender, EventArgs e)
        {
            this.StepInputPanel.Visible = true;
            this.PropertiesPanel.Visible = false;

        }

        private void DesignRibbonTab_ActiveChanged(object sender, EventArgs e)
        {
            this.PropertiesPanel.Visible = true;
            this.StepInputPanel.Visible = false;
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
                StartTimeTextBox.Text = Doc.Input.StartTime.ToString();
                EndTimeTextBox.Text = Doc.Input.EndTime.ToString();
                TimeStepTextBox.Text = Doc.Input.TimeStep.ToString();
                StepTimeTextBox.Text = Doc.Input.StepAmplitudeChangeTime.ToString();
                StepAmplitudeTextBox.Text = Doc.Input.StepAmplitude.ToString();
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




    

