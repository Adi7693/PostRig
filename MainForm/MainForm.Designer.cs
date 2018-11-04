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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.OutputButton = new System.Windows.Forms.Button();
            this.InitializationButton = new System.Windows.Forms.Button();
            this.InputButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Controls.Add(this.ExitButton);
            this.LeftPanel.Controls.Add(this.HelpButton);
            this.LeftPanel.Controls.Add(this.OutputButton);
            this.LeftPanel.Controls.Add(this.InitializationButton);
            this.LeftPanel.Controls.Add(this.InputButton);
            this.LeftPanel.Controls.Add(this.HomeButton);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(130, 735);
            this.LeftPanel.TabIndex = 0;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackgroundImage = global::New_UI.Properties.Resources.Logo;
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(130, 83);
            this.LogoPanel.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(0, 544);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(130, 85);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HelpButton.ForeColor = System.Drawing.Color.White;
            this.HelpButton.Location = new System.Drawing.Point(0, 453);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(130, 85);
            this.HelpButton.TabIndex = 1;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // OutputButton
            // 
            this.OutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OutputButton.ForeColor = System.Drawing.Color.White;
            this.OutputButton.Location = new System.Drawing.Point(0, 362);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(130, 85);
            this.OutputButton.TabIndex = 1;
            this.OutputButton.Text = "Output";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // InitializationButton
            // 
            this.InitializationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InitializationButton.ForeColor = System.Drawing.Color.White;
            this.InitializationButton.Location = new System.Drawing.Point(0, 271);
            this.InitializationButton.Name = "InitializationButton";
            this.InitializationButton.Size = new System.Drawing.Size(130, 85);
            this.InitializationButton.TabIndex = 1;
            this.InitializationButton.Text = "Initialization";
            this.InitializationButton.UseVisualStyleBackColor = true;
            this.InitializationButton.Click += new System.EventHandler(this.InitializationButton_Click);
            // 
            // InputButton
            // 
            this.InputButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InputButton.ForeColor = System.Drawing.Color.White;
            this.InputButton.Location = new System.Drawing.Point(0, 180);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(130, 85);
            this.InputButton.TabIndex = 1;
            this.InputButton.Text = "Input";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(0, 89);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(130, 85);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(584, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(471, 735);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1055, 735);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.Button InitializationButton;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Panel LogoPanel;
    }
}

