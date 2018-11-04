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

        private void exitToolStripMenu_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want To Close The Program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        private void NewCarRibbonButton_Click(object sender, EventArgs e)
        {
            this.PropertiesPanel.Visible = true;
        }
    }
}
