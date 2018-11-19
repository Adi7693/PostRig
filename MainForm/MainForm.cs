using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace PostRig
{
    public partial class MainForm : Form
    {
        public Document Doc { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }


        private bool ResponseToICNeedsToRecalculate = true;
        private bool HarmonicInputNeedsToRecalculate = true;
        private bool ResponseToHarmonicInputNeedsToRecalculate = true;
        private bool CombinedResponseNeedsToRecalculate = true;

        private delegate void LastActiveTab(object sender, EventArgs e);

        private LastActiveTab lastActiveTab;

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
                InitialDisplacementTextBox.Text = Doc.Input.InitialDisplacement.ToString();
                InitialVelocityTextBox.Text = Doc.Input.InitialVelocity.ToString();
                OscillationFrequencyTextBox.Text = Doc.Input.ExcitationFrequencyHz.ToString();
                ForceAmplitudeTextBox.Text = Doc.Input.Force.ToString();
            }
        }

        //Display Ribbon on Clicking New
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRibbon.Visible = true;
            Doc = new Document();
            UpdateUIFromDocument();
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

                NewRibbon.Visible = true;
                PropertiesPanel.Visible = true;
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

                dlg.Filter = "PostRig Files|*.postrig";

                dlg.AddExtension = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Doc.SaveAs(dlg.FileName);
                }
            }
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
        private void RoadCarRibbonButton_Click(object sender, EventArgs e)
        {
            Doc.Input.VehicleMass = 1600; // kg
            Doc.Input.SpringStiffness = 100000; // N/m
            Doc.Input.DampingCoefficient = 6000; // N/(m/s)
            UpdateUIFromDocument();
        }

        private void TouringCarRibbonButton_Click(object sender, EventArgs e)
        {
            Doc.Input.VehicleMass = 1000; // kg
            Doc.Input.SpringStiffness = 120000; // N/m
            Doc.Input.DampingCoefficient = 8000; // N/(m/s)
            UpdateUIFromDocument();
        }

        private void SingleSeaterRibbonButton_Click(object sender, EventArgs e)
        {
            Doc.Input.VehicleMass = 700; // kg
            Doc.Input.SpringStiffness = 150000; // N/m
            Doc.Input.DampingCoefficient = 15000; // N/(m/s)
            UpdateUIFromDocument();
        }

        private void VehicleMassTextBox_TextChanged(object sender, EventArgs e)
        {
            double newVehicleMass = 0.0;

            if (double.TryParse(VehicleMassTextBox.Text, out newVehicleMass))
            {
                Doc.Input.VehicleMass = newVehicleMass;
                ResponseToICNeedsToRecalculate = true;
                ResponseToHarmonicInputNeedsToRecalculate = true;
                HarmonicInputNeedsToRecalculate = true;
                CombinedResponseNeedsToRecalculate = true;
            }
        }

        private void SpringStiffnessTextBox_TextChanged(object sender, EventArgs e)
        {
            double newSpringStiffness = 0.0;

            if (double.TryParse(SpringStiffnessTextBox.Text, out newSpringStiffness))
            {
                Doc.Input.SpringStiffness = newSpringStiffness;
                ResponseToICNeedsToRecalculate = true;
                HarmonicInputNeedsToRecalculate = true;
                ResponseToHarmonicInputNeedsToRecalculate = true;
                CombinedResponseNeedsToRecalculate = true;
            }
        }

        private void DampingCoeffTextBox_TextChanged(object sender, EventArgs e)
        {
            double newDampingCoeff = 0.0;

            if (double.TryParse(DampingCoeffTextBox.Text, out newDampingCoeff))
            {
                Doc.Input.DampingCoefficient = newDampingCoeff;
                ResponseToICNeedsToRecalculate = true;
                HarmonicInputNeedsToRecalculate = true;
                ResponseToHarmonicInputNeedsToRecalculate = true;
                CombinedResponseNeedsToRecalculate = true;
            }
        }

        private void StartTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            double newStartTime = 0.0;

            if (double.TryParse(StartTimeTextBox.Text, out newStartTime))
            {
                Doc.Input.StartTime = newStartTime;

                ResponseToICNeedsToRecalculate = true;
                ResponseToHarmonicInputNeedsToRecalculate = true;
                HarmonicInputNeedsToRecalculate = true;
                CombinedResponseNeedsToRecalculate = true;
            }
        }

        private void EndTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            double newEndTime = 0.0;

            if (double.TryParse(EndTimeTextBox.Text, out newEndTime))
            {
                Doc.Input.EndTime = newEndTime;
                ResponseToICNeedsToRecalculate = true;
                ResponseToHarmonicInputNeedsToRecalculate = true;
                HarmonicInputNeedsToRecalculate = true;
                CombinedResponseNeedsToRecalculate = true;
            }
        }

        private void TimeStepTextBox_TextChanged(object sender, EventArgs e)
        {
            double newTimeStep = 0.0;

            if (double.TryParse(TimeStepTextBox.Text, out newTimeStep))
            {
                Doc.Input.TimeStep = newTimeStep;
                ResponseToICNeedsToRecalculate = true;
                ResponseToHarmonicInputNeedsToRecalculate = true;
                CombinedResponseNeedsToRecalculate = true;
            }
        }

        private void InitialDisplacement_TextChanged(object sender, EventArgs e)
        {
            double newID = 0.0;

            if (double.TryParse(InitialDisplacementTextBox.Text, out newID))
            {
                Doc.Input.InitialDisplacement = newID;
                ResponseToICNeedsToRecalculate = true;
                CombinedResponseNeedsToRecalculate = true;
            }
        }

        private void InitialVelocityTextBox_TextChanged(object sender, EventArgs e)
        {
            double newStepAmplitude = 0.0;

            if (double.TryParse(InitialVelocityTextBox.Text, out newStepAmplitude))
            {
                Doc.Input.StepAmplitude = newStepAmplitude;
                ResponseToICNeedsToRecalculate = true;
                CombinedResponseNeedsToRecalculate = true;
            }
        }

        private void OscillationFrequencyTextBox_TextChanged(object sender, EventArgs e)
        {
            double newOscillationFrequency = 0.0;

            if (double.TryParse(OscillationFrequencyTextBox.Text, out newOscillationFrequency))
            {
                Doc.Input.ExcitationFrequencyHz = newOscillationFrequency;
                ResponseToHarmonicInputNeedsToRecalculate = true;
                CombinedResponseNeedsToRecalculate = true;
            }
        }

        private void ForceAmplitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            double newForceAmplitude = 0.0;

            if (double.TryParse(ForceAmplitudeTextBox.Text, out newForceAmplitude))
            {
                Doc.Input.Force = newForceAmplitude;
                ResponseToHarmonicInputNeedsToRecalculate = true;
                CombinedResponseNeedsToRecalculate = true;
            }

        }

        // Run Button Not Working

        private void RunRibbonButton_Click(object sender, EventArgs e)
        {
            Doc.Input.Calculate();

            DateTime time = DateTime.Now;

            // Plot Response To Initial Condition

            if (this.ICCheckBox.Checked)
            {
                if (ResponseToICNeedsToRecalculate)
                {
                    ResponseToICCartesianChart.Series.Clear();

                    ResponseToICCartesianChart.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                    Title="Response To Initial Conditions",
                    Values = new ChartValues<double>(Doc.Input.ResponseToInitialConditions),
                    PointGeometry=null
                    }

                };

                    ResponseToICCartesianChart.AxisX.Clear();

                    ResponseToICCartesianChart.AxisX.Add(new Axis
                    {
                        Title = "Time",
                        FontSize = 15,
                        Labels = new List<string>(Doc.Input.TimeIntervals.Select(x => x.ToString())),

                        Sections = new SectionsCollection
                    {
                        new AxisSection
                        {
                            Value=0.0,
                            Stroke=Brushes.GreenYellow,
                            StrokeThickness=3
                        }
                    }

                    });

                    ResponseToICCartesianChart.AxisY.Clear();

                    ResponseToICCartesianChart.AxisY.Add(new Axis
                    {
                        Title = "Displacement (m)",
                        FontSize = 15,

                        Sections = new SectionsCollection
                    {
                        new AxisSection
                        {
                            Value=0.0,
                            Stroke=Brushes.GreenYellow,
                            StrokeThickness=3
                        }
                    }
                    });

                    ResponseToICNeedsToRecalculate = false;
                    this.InputSignalPanel.Visible = false;
                    this.ResponseToICPanel.Visible = true;
                    this.ResponseToHarmonicIPPanel.Visible = false;
                    this.CombinedResponsePanel.Visible = false;


                }

            }

            // Plot Harmonic Input

            if (this.HarmonicInputCheckBox.Checked)
            {
                if (HarmonicInputNeedsToRecalculate)
                {
                    HarmonicInputCartesianChart.Series.Clear();

                    HarmonicInputCartesianChart.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title="Harmonic Force Input",
                        Values = new ChartValues<double>(Doc.Input.InputForceOscillations),
                        PointGeometry = null
                    }};

                    HarmonicInputCartesianChart.AxisX.Clear();

                    HarmonicInputCartesianChart.AxisX.Add(new Axis
                    {
                        Title = "Time (s)",
                        FontSize = 15,
                        Labels = new List<string>(Doc.Input.TimeIntervals.Select(x => x.ToString())),

                        Sections = new SectionsCollection
                    {
                        new AxisSection
                        {
                            Value=0.0,
                            Stroke=Brushes.GreenYellow,
                            StrokeThickness=3
                        }

                    }

                    });

                    HarmonicInputCartesianChart.AxisY.Clear();

                    HarmonicInputCartesianChart.AxisY.Add(new Axis
                    {
                        Title = "Force (N)",
                        FontSize = 15,
                        Sections = new SectionsCollection
                    {
                        new AxisSection
                        {
                            Value = 0.0,
                            Stroke = Brushes.GreenYellow,
                            StrokeThickness=3,
                        }
                    }

                    });


                    HarmonicInputNeedsToRecalculate = false;
                    this.InputSignalPanel.Visible = true;
                    this.ResponseToICPanel.Visible = false;
                    this.ResponseToHarmonicIPPanel.Visible = true;
                    this.CombinedResponsePanel.Visible = false;

                }
            }

            // Plot Harmonic Response

            if (this.HarmonicInputCheckBox.Checked)
            {
                if (ResponseToHarmonicInputNeedsToRecalculate)
                {
                    ResponseToHarmonicInputCartesianChart.Series.Clear();

                    ResponseToHarmonicInputCartesianChart.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title="Response To Harmonic Input",
                        Values= new ChartValues<double>(Doc.Input.ResponseToHarmonicInput),
                        PointGeometry = null

                    }
                };

                    ResponseToHarmonicInputCartesianChart.AxisX.Clear();

                    ResponseToHarmonicInputCartesianChart.AxisX.Add(new Axis
                    {
                        Title = "Time",
                        FontSize = 15,
                        Labels = new List<string>(Doc.Input.TimeIntervals.Select(x => x.ToString())),

                        Sections = new SectionsCollection
                    {
                        new AxisSection
                        {
                            Value=0.0,
                            Stroke=Brushes.GreenYellow,
                            StrokeThickness=3
                        }
                    }
                    });

                    ResponseToHarmonicInputCartesianChart.AxisY.Clear();

                    ResponseToHarmonicInputCartesianChart.AxisY.Add(new Axis
                    {
                        Title = "Displacement (m)",
                        FontSize = 15,

                        Sections = new SectionsCollection
                    {
                        new AxisSection
                        {
                            Value=0.0,
                            Stroke=Brushes.GreenYellow,
                            StrokeThickness=3
                        }
                    }
                    });

                    ResponseToHarmonicInputNeedsToRecalculate = false;
                }
            }

            // Plot Combined Response

            if (CombinedResponseNeedsToRecalculate)
            {
                CombinedResponseCartesianChart.Series.Clear();

                CombinedResponseCartesianChart.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title="Total Response",
                        Values= new ChartValues<double>(Doc.Input.TotalResponse),
                        PointGeometry = null

                    }
                };

                CombinedResponseCartesianChart.AxisX.Clear();

                CombinedResponseCartesianChart.AxisX.Add(new Axis
                {
                    Title = "Time",
                    FontSize = 15,
                    Labels = new List<string>(Doc.Input.TimeIntervals.Select(x => x.ToString())),

                    Sections = new SectionsCollection
                    {
                        new AxisSection
                        {
                            Value=0.0,
                            Stroke=Brushes.GreenYellow,
                            StrokeThickness=3
                        }
                    }
                });

                CombinedResponseCartesianChart.AxisY.Clear();

                CombinedResponseCartesianChart.AxisY.Add(new Axis
                {
                    Title = "Displacement (m)",
                    FontSize = 15,

                    Sections = new SectionsCollection
                    {
                        new AxisSection
                        {
                            Value=0.0,
                            Stroke=Brushes.GreenYellow,
                            StrokeThickness=3
                        }
                    }
                });

                //double t = (DateTime.Now - time).TotalMilliseconds;
                //MessageBox.Show("Calc: " + CalcTime.ToString() + "\n" + "plot: " + t.ToString());
                CombinedResponseNeedsToRecalculate = false;
                this.InputSignalPanel.Visible = true;
                this.ResponseToICPanel.Visible = true;
                this.ResponseToHarmonicIPPanel.Visible = true;
                this.CombinedResponsePanel.Visible = true;

            }
        }

        // Hide Property Panel and Open Initialization Panel

        private void DesignRibbonTab_ActiveChanged(object sender, EventArgs e)
        {
            this.PropertiesPanel.Visible = true;
            this.SimulationSetupPanel.Visible = false;
            this.ICCheckBox.Visible = false;
            this.HarmonicInputCheckBox.Visible = false;
            this.CombinedResponseCheckBox.Visible = false;

        }

        private void SimSetupRibbonTab_ActiveChanged(object sender, EventArgs e)
        {
            this.SimulationSetupPanel.Visible = true;
            this.PropertiesPanel.Visible = true;
            this.ICCheckBox.Visible = true;
            this.HarmonicInputCheckBox.Visible = true;
            this.CombinedResponseCheckBox.Visible = true;
        }

        private void ResultRibbonTab_ActiveChanged(object sender, EventArgs e)
        {
            this.SimulationSetupPanel.Visible = false;
            this.PropertiesPanel.Visible = true;
            this.ICCheckBox.Visible = false;
            this.HarmonicInputCheckBox.Visible = false;
            this.CombinedResponseCheckBox.Visible = false;
        }

        private void ICCheckBox_Click(object sender, EventArgs e)
        {
            this.ICCheckBox.Checked = true;
            this.HarmonicInputCheckBox.Checked = false;
            this.CombinedResponseCheckBox.Checked = false;
            this.InitialConditionGroupBox.Visible = true;
            this.HarmonicInputDataGroupBox.Visible = false;

            ResponseToICNeedsToRecalculate = true;
            HarmonicInputNeedsToRecalculate = false;
            CombinedResponseNeedsToRecalculate = false;
        }

        private void HarmonicInputCheckBox_Click(object sender, EventArgs e)
        {
            this.ICCheckBox.Checked = false;
            this.HarmonicInputCheckBox.Checked = true;
            this.CombinedResponseCheckBox.Checked = false;
            this.InitialConditionGroupBox.Visible = false;
            this.HarmonicInputDataGroupBox.Visible = true;

            ResponseToICNeedsToRecalculate = false;
            HarmonicInputNeedsToRecalculate = true;
            CombinedResponseNeedsToRecalculate = false;
        }

        private void CombinedResponseCheckBox_Click(object sender, EventArgs e)
        {
            this.ICCheckBox.Checked = true;
            this.HarmonicInputCheckBox.Checked = true;
            this.CombinedResponseCheckBox.Checked = true;
            this.InitialConditionGroupBox.Visible = true;
            this.HarmonicInputDataGroupBox.Visible = true;

            ResponseToICNeedsToRecalculate = true;
            HarmonicInputNeedsToRecalculate = true;
            CombinedResponseNeedsToRecalculate = true;
        }


        private void ResponseToICRibbonButton_Click(object sender, EventArgs e)
        {
            this.ICCheckBox.Checked = true;
            this.HarmonicInputCheckBox.Checked = false;
            this.CombinedResponseCheckBox.Checked = false;
            this.InitialConditionGroupBox.Visible = true;
            this.HarmonicInputDataGroupBox.Visible = false;

            ResponseToICNeedsToRecalculate = true;
            HarmonicInputNeedsToRecalculate = false;
            CombinedResponseNeedsToRecalculate = false;
        }

        private void HarmonicIPRibbonButton_Click(object sender, EventArgs e)
        {
            this.ICCheckBox.Checked = false;
            this.HarmonicInputCheckBox.Checked = true;
            this.CombinedResponseCheckBox.Checked = false;
            this.InitialConditionGroupBox.Visible = false;
            this.HarmonicInputDataGroupBox.Visible = true;

            ResponseToICNeedsToRecalculate = false;
            HarmonicInputNeedsToRecalculate = true;
            CombinedResponseNeedsToRecalculate = false;
        }

        private void CombinedResponseRibbonButton_Click(object sender, EventArgs e)
        {
            this.ICCheckBox.Checked = true;
            this.HarmonicInputCheckBox.Checked = true;
            this.CombinedResponseCheckBox.Checked = true;
            this.InitialConditionGroupBox.Visible = true;
            this.HarmonicInputDataGroupBox.Visible = true;

            ResponseToICNeedsToRecalculate = true;
            HarmonicInputNeedsToRecalculate = true;
            CombinedResponseNeedsToRecalculate = true;
        }
    }
}