using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private delegate void LastActiveTab(object sender, EventArgs e);

        private LastActiveTab lastActiveTab;

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeButton.BackColor = Color.Red;
            InputButton.BackColor = Color.FromArgb(41, 44, 51);
            InitializationButton.BackColor = Color.FromArgb(41, 44, 51);
            OutputButton.BackColor = Color.FromArgb(41, 44, 51);
            HelpButton.BackColor = Color.FromArgb(41, 44, 51);
            ExitButton.BackColor = Color.FromArgb(41, 44, 51);

            lastActiveTab = new LastActiveTab(HomeButton_Click);
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            HomeButton.BackColor = Color.FromArgb(41, 44, 51);
            InputButton.BackColor = Color.Red;
            InitializationButton.BackColor = Color.FromArgb(41, 44, 51);
            OutputButton.BackColor = Color.FromArgb(41, 44, 51);
            HelpButton.BackColor = Color.FromArgb(41, 44, 51);
            ExitButton.BackColor = Color.FromArgb(41, 44, 51);

            lastActiveTab = new LastActiveTab(InputButton_Click);
        }

        private void InitializationButton_Click(object sender, EventArgs e)
        {
            HomeButton.BackColor = Color.FromArgb(41, 44, 51);
            InputButton.BackColor = Color.FromArgb(41, 44, 51);
            InitializationButton.BackColor = Color.Red;
            OutputButton.BackColor = Color.FromArgb(41, 44, 51);
            HelpButton.BackColor = Color.FromArgb(41, 44, 51);
            ExitButton.BackColor = Color.FromArgb(41, 44, 51);

            lastActiveTab = new LastActiveTab(InitializationButton_Click);
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            HomeButton.BackColor = Color.FromArgb(41, 44, 51);
            InputButton.BackColor = Color.FromArgb(41, 44, 51);
            InitializationButton.BackColor = Color.FromArgb(41, 44, 51);
            OutputButton.BackColor = Color.Red;
            HelpButton.BackColor = Color.FromArgb(41, 44, 51);
            ExitButton.BackColor = Color.FromArgb(41, 44, 51);

            lastActiveTab = new LastActiveTab(OutputButton_Click);
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HomeButton.BackColor = Color.FromArgb(41, 44, 51);
            InputButton.BackColor = Color.FromArgb(41, 44, 51);
            InitializationButton.BackColor = Color.FromArgb(41, 44, 51);
            OutputButton.BackColor = Color.FromArgb(41, 44, 51);
            HelpButton.BackColor = Color.Red;
            ExitButton.BackColor = Color.FromArgb(41, 44, 51);

            lastActiveTab = new LastActiveTab(HelpButton_Click);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            HomeButton.BackColor = Color.FromArgb(41, 44, 51);
            InputButton.BackColor = Color.FromArgb(41, 44, 51);
            InitializationButton.BackColor = Color.FromArgb(41, 44, 51);
            OutputButton.BackColor = Color.FromArgb(41, 44, 51);
            HelpButton.BackColor = Color.FromArgb(41, 44, 51);

            DialogResult dialog = MessageBox.Show("Do You Really Want To Close The Program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                lastActiveTab.Invoke(sender, e);
            }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            //this.MainPanel.Controls.Add()
        }
    }
}
