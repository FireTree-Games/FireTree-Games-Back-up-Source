
namespace EAS_Maker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stateDrop = new System.Windows.Forms.ComboBox();
            this.Preview = new System.Windows.Forms.Panel();
            this.maintext = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.issuerText = new System.Windows.Forms.Label();
            this.AlertTypeText = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.easTypes = new System.Windows.Forms.ComboBox();
            this.Apply = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Start_Speech = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EASSenderTypes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Preview.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("VCR OSD Mono", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "EAS Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("VCR OSD Mono", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 59);
            this.label3.TabIndex = 5;
            this.label3.Text = "State";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // stateDrop
            // 
            this.stateDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stateDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stateDrop.Enabled = false;
            this.stateDrop.FormattingEnabled = true;
            this.stateDrop.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.stateDrop.Location = new System.Drawing.Point(22, 163);
            this.stateDrop.Name = "stateDrop";
            this.stateDrop.Size = new System.Drawing.Size(234, 27);
            this.stateDrop.TabIndex = 4;
            this.stateDrop.SelectedIndexChanged += new System.EventHandler(this.stateDrop_SelectedIndexChanged);
            // 
            // Preview
            // 
            this.Preview.BackColor = System.Drawing.Color.Black;
            this.Preview.Controls.Add(this.maintext);
            this.Preview.Controls.Add(this.label6);
            this.Preview.Controls.Add(this.issuerText);
            this.Preview.Controls.Add(this.AlertTypeText);
            this.Preview.Controls.Add(this.Header);
            this.Preview.Location = new System.Drawing.Point(674, 9);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(784, 624);
            this.Preview.TabIndex = 6;
            this.Preview.Paint += new System.Windows.Forms.PaintEventHandler(this.Preview_Paint);
            // 
            // maintext
            // 
            this.maintext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maintext.AutoSize = true;
            this.maintext.BackColor = System.Drawing.Color.Transparent;
            this.maintext.Font = new System.Drawing.Font("VCR OSD Mono", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintext.ForeColor = System.Drawing.Color.White;
            this.maintext.Location = new System.Drawing.Point(-928, 170);
            this.maintext.Name = "maintext";
            this.maintext.Size = new System.Drawing.Size(735, 34);
            this.maintext.TabIndex = 5;
            this.maintext.Text = "Press Aply Changes Before Continuing";
            this.maintext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("VCR OSD Mono", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(304, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 34);
            this.label6.TabIndex = 4;
            this.label6.Text = "Issued a";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // issuerText
            // 
            this.issuerText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issuerText.BackColor = System.Drawing.Color.Transparent;
            this.issuerText.Font = new System.Drawing.Font("VCR OSD Mono", 25F);
            this.issuerText.ForeColor = System.Drawing.Color.White;
            this.issuerText.Location = new System.Drawing.Point(3, 277);
            this.issuerText.Name = "issuerText";
            this.issuerText.Size = new System.Drawing.Size(781, 82);
            this.issuerText.TabIndex = 2;
            this.issuerText.Text = "*Issuer*";
            this.issuerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlertTypeText
            // 
            this.AlertTypeText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlertTypeText.BackColor = System.Drawing.Color.Transparent;
            this.AlertTypeText.Font = new System.Drawing.Font("VCR OSD Mono", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertTypeText.ForeColor = System.Drawing.Color.White;
            this.AlertTypeText.Location = new System.Drawing.Point(0, 420);
            this.AlertTypeText.Name = "AlertTypeText";
            this.AlertTypeText.Size = new System.Drawing.Size(784, 134);
            this.AlertTypeText.TabIndex = 1;
            this.AlertTypeText.Text = "*Alert Type*";
            this.AlertTypeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AlertTypeText.Click += new System.EventHandler(this.label2_Click);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.Font = new System.Drawing.Font("VCR OSD Mono", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(32, 36);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(729, 54);
            this.Header.TabIndex = 0;
            this.Header.Text = "Emergency Alert System";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // easTypes
            // 
            this.easTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.easTypes.FormattingEnabled = true;
            this.easTypes.Location = new System.Drawing.Point(22, 71);
            this.easTypes.Name = "easTypes";
            this.easTypes.Size = new System.Drawing.Size(295, 27);
            this.easTypes.TabIndex = 7;
            this.easTypes.SelectedIndexChanged += new System.EventHandler(this.easTypes_SelectedIndexChanged);
            // 
            // Apply
            // 
            this.Apply.BackColor = System.Drawing.Color.DarkRed;
            this.Apply.Location = new System.Drawing.Point(22, 286);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(268, 54);
            this.Apply.TabIndex = 10;
            this.Apply.Text = "Apply Changes";
            this.Apply.UseVisualStyleBackColor = false;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(296, 301);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 251);
            this.textBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("VCR OSD Mono", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Spoken Text";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Start_Speech
            // 
            this.Start_Speech.BackColor = System.Drawing.Color.DarkRed;
            this.Start_Speech.Location = new System.Drawing.Point(22, 346);
            this.Start_Speech.Name = "Start_Speech";
            this.Start_Speech.Size = new System.Drawing.Size(268, 54);
            this.Start_Speech.TabIndex = 13;
            this.Start_Speech.Text = "Start Speech";
            this.Start_Speech.UseVisualStyleBackColor = false;
            this.Start_Speech.Click += new System.EventHandler(this.Start_Speech_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("VCR OSD Mono", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 565);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(656, 68);
            this.label4.TabIndex = 14;
            this.label4.Text = "Record Preview To Use In A Video\r\nBefore Pressing Start Speech\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("VCR OSD Mono", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 54);
            this.label5.TabIndex = 16;
            this.label5.Text = "EAS Sender";
            // 
            // EASSenderTypes
            // 
            this.EASSenderTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EASSenderTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EASSenderTypes.Enabled = false;
            this.EASSenderTypes.FormattingEnabled = true;
            this.EASSenderTypes.Location = new System.Drawing.Point(22, 250);
            this.EASSenderTypes.Name = "EASSenderTypes";
            this.EASSenderTypes.Size = new System.Drawing.Size(234, 27);
            this.EASSenderTypes.TabIndex = 15;
            this.EASSenderTypes.SelectedIndexChanged += new System.EventHandler(this.EASSenderTypes_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(319, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 90);
            this.button1.TabIndex = 17;
            this.button1.Text = "Edit Main Files";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1470, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EASSenderTypes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Start_Speech);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.easTypes);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stateDrop);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("VCR OSD Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "EAS Maker V0.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Preview.ResumeLayout(false);
            this.Preview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox stateDrop;
        private System.Windows.Forms.Panel Preview;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label AlertTypeText;
        private System.Windows.Forms.Label issuerText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox easTypes;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Label maintext;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Start_Speech;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox EASSenderTypes;
        private System.Windows.Forms.Button button1;
    }
}

