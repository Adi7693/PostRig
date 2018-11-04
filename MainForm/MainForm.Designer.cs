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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewRibbon = new System.Windows.Forms.Ribbon();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.DesignRibbonTab = new System.Windows.Forms.RibbonTab();
            this.BuildCarRibbonPanel = new System.Windows.Forms.RibbonPanel();
            this.CarDrpRibbonButton = new System.Windows.Forms.RibbonButton();
            this.NewCarRibbonButton = new System.Windows.Forms.RibbonButton();
            this.ExisitingCarRibbonButton = new System.Windows.Forms.RibbonButton();
            this.SimSetupRibbonTab = new System.Windows.Forms.RibbonTab();
            this.ResultsRibbonTab = new System.Windows.Forms.RibbonTab();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseStudyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertiesPanel = new System.Windows.Forms.Panel();
            this.VehicleMassLabel = new System.Windows.Forms.Label();
            this.SpringStiffnessLabel = new System.Windows.Forms.Label();
            this.DampingCoeffLabel = new System.Windows.Forms.Label();
            this.VehicleMassTextBox = new System.Windows.Forms.TextBox();
            this.VehicleMassUnitLabel = new System.Windows.Forms.Label();
            this.SpringStiffnessTextBox = new System.Windows.Forms.TextBox();
            this.DampingCoeffTextBox = new System.Windows.Forms.TextBox();
            this.SpringStiffnessUnitLabel = new System.Windows.Forms.Label();
            this.DampingCoeffUnitLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.PropertiesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // NewRibbon
            // 
            this.NewRibbon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewRibbon.Location = new System.Drawing.Point(0, 24);
            this.NewRibbon.Minimized = false;
            this.NewRibbon.Name = "NewRibbon";
            // 
            // 
            // 
            this.NewRibbon.OrbDropDown.BorderRoundness = 8;
            this.NewRibbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.NewRibbon.OrbDropDown.Name = "";
            this.NewRibbon.OrbDropDown.TabIndex = 0;
            this.NewRibbon.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.NewRibbon.OrbVisible = false;
            // 
            // 
            // 
            this.NewRibbon.QuickAccessToolbar.Items.Add(this.ribbonButton1);
            this.NewRibbon.QuickAccessToolbar.Visible = false;
            this.NewRibbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.NewRibbon.Size = new System.Drawing.Size(1055, 152);
            this.NewRibbon.TabIndex = 0;
            this.NewRibbon.Tabs.Add(this.DesignRibbonTab);
            this.NewRibbon.Tabs.Add(this.SimSetupRibbonTab);
            this.NewRibbon.Tabs.Add(this.ResultsRibbonTab);
            this.NewRibbon.TabsMargin = new System.Windows.Forms.Padding(5, 26, 20, 0);
            this.NewRibbon.TabSpacing = 4;
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            // 
            // DesignRibbonTab
            // 
            this.DesignRibbonTab.Name = "DesignRibbonTab";
            this.DesignRibbonTab.Panels.Add(this.BuildCarRibbonPanel);
            this.DesignRibbonTab.Text = "Design";
            // 
            // BuildCarRibbonPanel
            // 
            this.BuildCarRibbonPanel.Items.Add(this.CarDrpRibbonButton);
            this.BuildCarRibbonPanel.Name = "BuildCarRibbonPanel";
            this.BuildCarRibbonPanel.Text = "Build Car";
            // 
            // CarDrpRibbonButton
            // 
            this.CarDrpRibbonButton.DropDownItems.Add(this.NewCarRibbonButton);
            this.CarDrpRibbonButton.DropDownItems.Add(this.ExisitingCarRibbonButton);
            this.CarDrpRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("CarDrpRibbonButton.Image")));
            this.CarDrpRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("CarDrpRibbonButton.LargeImage")));
            this.CarDrpRibbonButton.Name = "CarDrpRibbonButton";
            this.CarDrpRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("CarDrpRibbonButton.SmallImage")));
            this.CarDrpRibbonButton.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.CarDrpRibbonButton.Text = "Car";
            // 
            // NewCarRibbonButton
            // 
            this.NewCarRibbonButton.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.NewCarRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("NewCarRibbonButton.Image")));
            this.NewCarRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("NewCarRibbonButton.LargeImage")));
            this.NewCarRibbonButton.Name = "NewCarRibbonButton";
            this.NewCarRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("NewCarRibbonButton.SmallImage")));
            this.NewCarRibbonButton.Text = "New";
            // 
            // ExisitingCarRibbonButton
            // 
            this.ExisitingCarRibbonButton.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ExisitingCarRibbonButton.Image = ((System.Drawing.Image)(resources.GetObject("ExisitingCarRibbonButton.Image")));
            this.ExisitingCarRibbonButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("ExisitingCarRibbonButton.LargeImage")));
            this.ExisitingCarRibbonButton.Name = "ExisitingCarRibbonButton";
            this.ExisitingCarRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("ExisitingCarRibbonButton.SmallImage")));
            this.ExisitingCarRibbonButton.Text = "Existing";
            // 
            // SimSetupRibbonTab
            // 
            this.SimSetupRibbonTab.Name = "SimSetupRibbonTab";
            this.SimSetupRibbonTab.Text = "Simulation Setup";
            // 
            // ResultsRibbonTab
            // 
            this.ResultsRibbonTab.Name = "ResultsRibbonTab";
            this.ResultsRibbonTab.Text = "Results";
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readMeToolStripMenuItem,
            this.caseStudyToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.readMeToolStripMenuItem.Text = "Tutorial";
            // 
            // caseStudyToolStripMenuItem
            // 
            this.caseStudyToolStripMenuItem.Name = "caseStudyToolStripMenuItem";
            this.caseStudyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.caseStudyToolStripMenuItem.Text = "Case Study";
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenu.Text = "Exit";
            this.exitToolStripMenu.Click += new System.EventHandler(this.exitToolStripMenu_Click_1);
            // 
            // PropertiesPanel
            // 
            this.PropertiesPanel.BackColor = System.Drawing.Color.Silver;
            this.PropertiesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PropertiesPanel.Controls.Add(this.DampingCoeffTextBox);
            this.PropertiesPanel.Controls.Add(this.SpringStiffnessTextBox);
            this.PropertiesPanel.Controls.Add(this.VehicleMassTextBox);
            this.PropertiesPanel.Controls.Add(this.DampingCoeffLabel);
            this.PropertiesPanel.Controls.Add(this.SpringStiffnessLabel);
            this.PropertiesPanel.Controls.Add(this.DampingCoeffUnitLabel);
            this.PropertiesPanel.Controls.Add(this.SpringStiffnessUnitLabel);
            this.PropertiesPanel.Controls.Add(this.VehicleMassUnitLabel);
            this.PropertiesPanel.Controls.Add(this.VehicleMassLabel);
            this.PropertiesPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PropertiesPanel.Location = new System.Drawing.Point(0, 176);
            this.PropertiesPanel.Name = "PropertiesPanel";
            this.PropertiesPanel.Size = new System.Drawing.Size(282, 559);
            this.PropertiesPanel.TabIndex = 2;
            this.PropertiesPanel.Visible = false;
            // 
            // VehicleMassLabel
            // 
            this.VehicleMassLabel.AutoSize = true;
            this.VehicleMassLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleMassLabel.Location = new System.Drawing.Point(3, 4);
            this.VehicleMassLabel.Name = "VehicleMassLabel";
            this.VehicleMassLabel.Size = new System.Drawing.Size(89, 17);
            this.VehicleMassLabel.TabIndex = 0;
            this.VehicleMassLabel.Text = "Vehicle Mass";
            // 
            // SpringStiffnessLabel
            // 
            this.SpringStiffnessLabel.AutoSize = true;
            this.SpringStiffnessLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpringStiffnessLabel.Location = new System.Drawing.Point(3, 38);
            this.SpringStiffnessLabel.Name = "SpringStiffnessLabel";
            this.SpringStiffnessLabel.Size = new System.Drawing.Size(99, 17);
            this.SpringStiffnessLabel.TabIndex = 0;
            this.SpringStiffnessLabel.Text = "Spring Stiffness";
            // 
            // DampingCoeffLabel
            // 
            this.DampingCoeffLabel.AutoSize = true;
            this.DampingCoeffLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DampingCoeffLabel.Location = new System.Drawing.Point(3, 72);
            this.DampingCoeffLabel.Name = "DampingCoeffLabel";
            this.DampingCoeffLabel.Size = new System.Drawing.Size(144, 17);
            this.DampingCoeffLabel.TabIndex = 0;
            this.DampingCoeffLabel.Text = "Damping Coefficient";
            // 
            // VehicleMassTextBox
            // 
            this.VehicleMassTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleMassTextBox.Location = new System.Drawing.Point(153, 1);
            this.VehicleMassTextBox.Name = "VehicleMassTextBox";
            this.VehicleMassTextBox.Size = new System.Drawing.Size(63, 22);
            this.VehicleMassTextBox.TabIndex = 1;
            // 
            // VehicleMassUnitLabel
            // 
            this.VehicleMassUnitLabel.AutoSize = true;
            this.VehicleMassUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleMassUnitLabel.Location = new System.Drawing.Point(222, 4);
            this.VehicleMassUnitLabel.Name = "VehicleMassUnitLabel";
            this.VehicleMassUnitLabel.Size = new System.Drawing.Size(25, 17);
            this.VehicleMassUnitLabel.TabIndex = 0;
            this.VehicleMassUnitLabel.Text = "Kg";
            // 
            // SpringStiffnessTextBox
            // 
            this.SpringStiffnessTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpringStiffnessTextBox.Location = new System.Drawing.Point(153, 35);
            this.SpringStiffnessTextBox.Name = "SpringStiffnessTextBox";
            this.SpringStiffnessTextBox.Size = new System.Drawing.Size(63, 22);
            this.SpringStiffnessTextBox.TabIndex = 1;
            // 
            // DampingCoeffTextBox
            // 
            this.DampingCoeffTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DampingCoeffTextBox.Location = new System.Drawing.Point(153, 69);
            this.DampingCoeffTextBox.Name = "DampingCoeffTextBox";
            this.DampingCoeffTextBox.Size = new System.Drawing.Size(63, 22);
            this.DampingCoeffTextBox.TabIndex = 1;
            // 
            // SpringStiffnessUnitLabel
            // 
            this.SpringStiffnessUnitLabel.AutoSize = true;
            this.SpringStiffnessUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpringStiffnessUnitLabel.Location = new System.Drawing.Point(222, 38);
            this.SpringStiffnessUnitLabel.Name = "SpringStiffnessUnitLabel";
            this.SpringStiffnessUnitLabel.Size = new System.Drawing.Size(37, 17);
            this.SpringStiffnessUnitLabel.TabIndex = 0;
            this.SpringStiffnessUnitLabel.Text = "N/m";
            // 
            // DampingCoeffUnitLabel
            // 
            this.DampingCoeffUnitLabel.AutoSize = true;
            this.DampingCoeffUnitLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DampingCoeffUnitLabel.Location = new System.Drawing.Point(222, 72);
            this.DampingCoeffUnitLabel.Name = "DampingCoeffUnitLabel";
            this.DampingCoeffUnitLabel.Size = new System.Drawing.Size(57, 17);
            this.DampingCoeffUnitLabel.TabIndex = 0;
            this.DampingCoeffUnitLabel.Text = "N/(m/s)";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1055, 735);
            this.Controls.Add(this.PropertiesPanel);
            this.Controls.Add(this.NewRibbon);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Post Rig";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PropertiesPanel.ResumeLayout(false);
            this.PropertiesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Ribbon NewRibbon;
        private System.Windows.Forms.RibbonTab DesignRibbonTab;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonTab SimSetupRibbonTab;
        private System.Windows.Forms.RibbonTab ResultsRibbonTab;
        private System.Windows.Forms.RibbonPanel BuildCarRibbonPanel;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonButton CarDrpRibbonButton;
        private System.Windows.Forms.RibbonButton NewCarRibbonButton;
        private System.Windows.Forms.RibbonButton ExisitingCarRibbonButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseStudyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenu;
        private System.Windows.Forms.Panel PropertiesPanel;
        private System.Windows.Forms.Label DampingCoeffLabel;
        private System.Windows.Forms.Label SpringStiffnessLabel;
        private System.Windows.Forms.Label VehicleMassLabel;
        private System.Windows.Forms.TextBox VehicleMassTextBox;
        private System.Windows.Forms.Label VehicleMassUnitLabel;
        private System.Windows.Forms.TextBox DampingCoeffTextBox;
        private System.Windows.Forms.TextBox SpringStiffnessTextBox;
        private System.Windows.Forms.Label SpringStiffnessUnitLabel;
        private System.Windows.Forms.Label DampingCoeffUnitLabel;
        //private System.Windows.Forms.RibbonPanel NewCarRibbonPanel;
    }
}

