namespace New_UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTab = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.InputTab = new System.Windows.Forms.TabPage();
            this.InitTab = new System.Windows.Forms.TabPage();
            this.OutputTab = new System.Windows.Forms.TabPage();
            this.HelpTab = new System.Windows.Forms.TabPage();
            this.MainTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.HomeTab);
            this.MainTab.Controls.Add(this.InputTab);
            this.MainTab.Controls.Add(this.InitTab);
            this.MainTab.Controls.Add(this.OutputTab);
            this.MainTab.Controls.Add(this.HelpTab);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1016, 735);
            this.MainTab.TabIndex = 0;
            // 
            // HomeTab
            // 
            this.HomeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.HomeTab.Location = new System.Drawing.Point(4, 39);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(1008, 692);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            // 
            // InputTab
            // 
            this.InputTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.InputTab.Location = new System.Drawing.Point(4, 25);
            this.InputTab.Name = "InputTab";
            this.InputTab.Padding = new System.Windows.Forms.Padding(3);
            this.InputTab.Size = new System.Drawing.Size(1047, 706);
            this.InputTab.TabIndex = 1;
            this.InputTab.Text = "Input";
            // 
            // InitTab
            // 
            this.InitTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.InitTab.Location = new System.Drawing.Point(4, 25);
            this.InitTab.Name = "InitTab";
            this.InitTab.Size = new System.Drawing.Size(1047, 706);
            this.InitTab.TabIndex = 2;
            this.InitTab.Text = "Initialization";
            // 
            // OutputTab
            // 
            this.OutputTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.OutputTab.Location = new System.Drawing.Point(4, 25);
            this.OutputTab.Name = "OutputTab";
            this.OutputTab.Size = new System.Drawing.Size(1047, 706);
            this.OutputTab.TabIndex = 3;
            this.OutputTab.Text = "Output";
            // 
            // HelpTab
            // 
            this.HelpTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.HelpTab.Location = new System.Drawing.Point(4, 25);
            this.HelpTab.Name = "HelpTab";
            this.HelpTab.Size = new System.Drawing.Size(1047, 706);
            this.HelpTab.TabIndex = 4;
            this.HelpTab.Text = "Help";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1055, 735);
            this.Controls.Add(this.MainTab);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Post Rig";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TabPage InputTab;
        private System.Windows.Forms.TabPage InitTab;
        private System.Windows.Forms.TabPage OutputTab;
        private System.Windows.Forms.TabPage HelpTab;
    }
}

