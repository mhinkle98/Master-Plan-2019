namespace HPARReaderV3
{
    partial class mainWindow
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
            this.stationLabel = new System.Windows.Forms.Label();
            this.stationSelector = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.heightBox = new System.Windows.Forms.ComboBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.wetAreaLabel = new System.Windows.Forms.Label();
            this.wetPerimeterLabel = new System.Windows.Forms.Label();
            this.rValueLabel = new System.Windows.Forms.Label();
            this.conveyanceLabel = new System.Windows.Forms.Label();
            this.wetAreaNumber = new System.Windows.Forms.Label();
            this.wetPerimeterNumber = new System.Windows.Forms.Label();
            this.rValueNumber = new System.Windows.Forms.Label();
            this.conveyanceNumber = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crossSectionPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // stationLabel
            // 
            this.stationLabel.AutoSize = true;
            this.stationLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.stationLabel.Location = new System.Drawing.Point(12, 44);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(81, 23);
            this.stationLabel.TabIndex = 3;
            this.stationLabel.Text = "Stations";
            // 
            // stationSelector
            // 
            this.stationSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.stationSelector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stationSelector.ForeColor = System.Drawing.Color.Orange;
            this.stationSelector.FormattingEnabled = true;
            this.stationSelector.ItemHeight = 21;
            this.stationSelector.Location = new System.Drawing.Point(12, 87);
            this.stationSelector.Name = "stationSelector";
            this.stationSelector.Size = new System.Drawing.Size(266, 651);
            this.stationSelector.TabIndex = 4;
            this.stationSelector.SelectedIndexChanged += new System.EventHandler(this.stationSelector_SelectedIndexChanged);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.LightCoral;
            this.closeButton.Location = new System.Drawing.Point(1141, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(59, 30);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // heightBox
            // 
            this.heightBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.heightBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.heightBox.ForeColor = System.Drawing.Color.SandyBrown;
            this.heightBox.FormattingEnabled = true;
            this.heightBox.Location = new System.Drawing.Point(284, 87);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(92, 29);
            this.heightBox.TabIndex = 7;
            this.heightBox.SelectedIndexChanged += new System.EventHandler(this.heightBox_SelectedIndexChanged);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.ForeColor = System.Drawing.Color.Bisque;
            this.heightLabel.Location = new System.Drawing.Point(278, 44);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(98, 32);
            this.heightLabel.TabIndex = 6;
            this.heightLabel.Text = "Height";
            // 
            // wetAreaLabel
            // 
            this.wetAreaLabel.AutoSize = true;
            this.wetAreaLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wetAreaLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.wetAreaLabel.Location = new System.Drawing.Point(409, 44);
            this.wetAreaLabel.Name = "wetAreaLabel";
            this.wetAreaLabel.Size = new System.Drawing.Size(136, 32);
            this.wetAreaLabel.TabIndex = 8;
            this.wetAreaLabel.Text = "Wet Area";
            // 
            // wetPerimeterLabel
            // 
            this.wetPerimeterLabel.AutoSize = true;
            this.wetPerimeterLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wetPerimeterLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.wetPerimeterLabel.Location = new System.Drawing.Point(551, 44);
            this.wetPerimeterLabel.Name = "wetPerimeterLabel";
            this.wetPerimeterLabel.Size = new System.Drawing.Size(195, 32);
            this.wetPerimeterLabel.TabIndex = 9;
            this.wetPerimeterLabel.Text = "Wet Perimeter";
            // 
            // rValueLabel
            // 
            this.rValueLabel.AutoSize = true;
            this.rValueLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rValueLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.rValueLabel.Location = new System.Drawing.Point(752, 44);
            this.rValueLabel.Name = "rValueLabel";
            this.rValueLabel.Size = new System.Drawing.Size(190, 32);
            this.rValueLabel.TabIndex = 10;
            this.rValueLabel.Text = "R Value (A/P)";
            // 
            // conveyanceLabel
            // 
            this.conveyanceLabel.AutoSize = true;
            this.conveyanceLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conveyanceLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.conveyanceLabel.Location = new System.Drawing.Point(948, 44);
            this.conveyanceLabel.Name = "conveyanceLabel";
            this.conveyanceLabel.Size = new System.Drawing.Size(185, 32);
            this.conveyanceLabel.TabIndex = 11;
            this.conveyanceLabel.Text = "Conveyance";
            // 
            // wetAreaNumber
            // 
            this.wetAreaNumber.AutoSize = true;
            this.wetAreaNumber.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wetAreaNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.wetAreaNumber.Location = new System.Drawing.Point(410, 91);
            this.wetAreaNumber.Name = "wetAreaNumber";
            this.wetAreaNumber.Size = new System.Drawing.Size(24, 25);
            this.wetAreaNumber.TabIndex = 12;
            this.wetAreaNumber.Text = "0";
            // 
            // wetPerimeterNumber
            // 
            this.wetPerimeterNumber.AutoSize = true;
            this.wetPerimeterNumber.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wetPerimeterNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wetPerimeterNumber.Location = new System.Drawing.Point(552, 91);
            this.wetPerimeterNumber.Name = "wetPerimeterNumber";
            this.wetPerimeterNumber.Size = new System.Drawing.Size(24, 25);
            this.wetPerimeterNumber.TabIndex = 13;
            this.wetPerimeterNumber.Text = "0";
            // 
            // rValueNumber
            // 
            this.rValueNumber.AutoSize = true;
            this.rValueNumber.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rValueNumber.ForeColor = System.Drawing.Color.DarkOrange;
            this.rValueNumber.Location = new System.Drawing.Point(753, 91);
            this.rValueNumber.Name = "rValueNumber";
            this.rValueNumber.Size = new System.Drawing.Size(24, 25);
            this.rValueNumber.TabIndex = 14;
            this.rValueNumber.Text = "0";
            // 
            // conveyanceNumber
            // 
            this.conveyanceNumber.AutoSize = true;
            this.conveyanceNumber.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conveyanceNumber.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.conveyanceNumber.Location = new System.Drawing.Point(972, 91);
            this.conveyanceNumber.Name = "conveyanceNumber";
            this.conveyanceNumber.Size = new System.Drawing.Size(24, 25);
            this.conveyanceNumber.TabIndex = 15;
            this.conveyanceNumber.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // crossSectionPanel
            // 
            this.crossSectionPanel.Location = new System.Drawing.Point(284, 122);
            this.crossSectionPanel.Name = "crossSectionPanel";
            this.crossSectionPanel.Size = new System.Drawing.Size(904, 616);
            this.crossSectionPanel.TabIndex = 17;
            this.crossSectionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.crossSectionPanel_Paint);
            // 
            // mainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.crossSectionPanel);
            this.Controls.Add(this.conveyanceNumber);
            this.Controls.Add(this.rValueNumber);
            this.Controls.Add(this.wetPerimeterNumber);
            this.Controls.Add(this.wetAreaNumber);
            this.Controls.Add(this.conveyanceLabel);
            this.Controls.Add(this.rValueLabel);
            this.Controls.Add(this.wetPerimeterLabel);
            this.Controls.Add(this.wetAreaLabel);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.stationSelector);
            this.Controls.Add(this.stationLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "mainWindow";
            this.Text = "G02 Reader V3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stationLabel;
        private System.Windows.Forms.ListBox stationSelector;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox heightBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label wetAreaLabel;
        private System.Windows.Forms.Label wetPerimeterLabel;
        private System.Windows.Forms.Label rValueLabel;
        private System.Windows.Forms.Label conveyanceLabel;
        private System.Windows.Forms.Label wetAreaNumber;
        private System.Windows.Forms.Label wetPerimeterNumber;
        private System.Windows.Forms.Label rValueNumber;
        private System.Windows.Forms.Label conveyanceNumber;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel crossSectionPanel;
    }
}

