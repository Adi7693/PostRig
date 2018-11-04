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
            this.FileTab = new System.Windows.Forms.TabPage();
            this.InputTab = new System.Windows.Forms.TabPage();
            this.InitTab = new System.Windows.Forms.TabPage();
            this.OutputTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveAsButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MainTab.SuspendLayout();
            this.FileTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.FileTab);
            this.MainTab.Controls.Add(this.InputTab);
            this.MainTab.Controls.Add(this.InitTab);
            this.MainTab.Controls.Add(this.OutputTab);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1055, 735);
            this.MainTab.TabIndex = 0;
            // 
            // FileTab
            // 
            this.FileTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.FileTab.Controls.Add(this.panel1);
            this.FileTab.Location = new System.Drawing.Point(4, 31);
            this.FileTab.Name = "FileTab";
            this.FileTab.Padding = new System.Windows.Forms.Padding(3);
            this.FileTab.Size = new System.Drawing.Size(1047, 700);
            this.FileTab.TabIndex = 0;
            this.FileTab.Text = "File";
            // 
            // InputTab
            // 
            this.InputTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.InputTab.Location = new System.Drawing.Point(4, 31);
            this.InputTab.Name = "InputTab";
            this.InputTab.Padding = new System.Windows.Forms.Padding(3);
            this.InputTab.Size = new System.Drawing.Size(1047, 700);
            this.InputTab.TabIndex = 1;
            this.InputTab.Text = "Input";
            // 
            // InitTab
            // 
            this.InitTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.InitTab.Location = new System.Drawing.Point(4, 31);
            this.InitTab.Name = "InitTab";
            this.InitTab.Size = new System.Drawing.Size(1047, 700);
            this.InitTab.TabIndex = 2;
            this.InitTab.Text = "Initialization";
            // 
            // OutputTab
            // 
            this.OutputTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.OutputTab.Location = new System.Drawing.Point(4, 31);
            this.OutputTab.Name = "OutputTab";
            this.OutputTab.Size = new System.Drawing.Size(1047, 700);
            this.OutputTab.TabIndex = 3;
            this.OutputTab.Text = "Output";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.HelpButton);
            this.panel1.Controls.Add(this.OpenButton);
            this.panel1.Controls.Add(this.SaveAsButton);
            this.panel1.Controls.Add(this.NewButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 694);
            this.panel1.TabIndex = 0;
            // 
            // NewButton
            // 
            this.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewButton.ForeColor = System.Drawing.Color.White;
            this.NewButton.Location = new System.Drawing.Point(5, 3);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(119, 34);
            this.NewButton.TabIndex = 0;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(5, 163);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(119, 34);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveAsButton.ForeColor = System.Drawing.Color.White;
            this.SaveAsButton.Location = new System.Drawing.Point(5, 243);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(119, 34);
            this.SaveAsButton.TabIndex = 0;
            this.SaveAsButton.Text = "Save As";
            this.SaveAsButton.UseVisualStyleBackColor = true;
            // 
            // OpenButton
            // 
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenButton.ForeColor = System.Drawing.Color.White;
            this.OpenButton.Location = new System.Drawing.Point(5, 83);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(119, 34);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            // 
            // HelpButton
            // 
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HelpButton.ForeColor = System.Drawing.Color.White;
            this.HelpButton.Location = new System.Drawing.Point(5, 323);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(119, 34);
            this.HelpButton.TabIndex = 0;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(5, 403);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(119, 34);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(5, 483);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(119, 34);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
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
            this.FileTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage FileTab;
        private System.Windows.Forms.TabPage InputTab;
        private System.Windows.Forms.TabPage InitTab;
        private System.Windows.Forms.TabPage OutputTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveAsButton;
        private System.Windows.Forms.Button NewButton;
    }
}

