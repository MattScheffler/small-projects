namespace TemperatureConverter
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
            this.comboBoxConvertFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxConvertTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.textBoxConvertResult = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nebulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxConvertFrom
            // 
            this.comboBoxConvertFrom.FormattingEnabled = true;
            this.comboBoxConvertFrom.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius",
            "Kelvin"});
            this.comboBoxConvertFrom.Location = new System.Drawing.Point(188, 133);
            this.comboBoxConvertFrom.Name = "comboBoxConvertFrom";
            this.comboBoxConvertFrom.Size = new System.Drawing.Size(189, 21);
            this.comboBoxConvertFrom.TabIndex = 0;
            this.comboBoxConvertFrom.Text = "Choose...";
            // 
            // comboBoxConvertTo
            // 
            this.comboBoxConvertTo.FormattingEnabled = true;
            this.comboBoxConvertTo.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius",
            "Kelvin"});
            this.comboBoxConvertTo.Location = new System.Drawing.Point(188, 186);
            this.comboBoxConvertTo.Name = "comboBoxConvertTo";
            this.comboBoxConvertTo.Size = new System.Drawing.Size(189, 21);
            this.comboBoxConvertTo.TabIndex = 1;
            this.comboBoxConvertTo.Text = "Choose...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(187, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Convert from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(187, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Convert to";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(243, 279);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 4;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // textBoxConvertResult
            // 
            this.textBoxConvertResult.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxConvertResult.Location = new System.Drawing.Point(188, 331);
            this.textBoxConvertResult.Name = "textBoxConvertResult";
            this.textBoxConvertResult.ReadOnly = true;
            this.textBoxConvertResult.Size = new System.Drawing.Size(189, 20);
            this.textBoxConvertResult.TabIndex = 5;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(188, 244);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(189, 20);
            this.textBoxInput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(187, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Temperature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(187, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Result";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.skyToolStripMenuItem,
            this.nebulaToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.themesToolStripMenuItem.Text = "Themes";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // skyToolStripMenuItem
            // 
            this.skyToolStripMenuItem.Name = "skyToolStripMenuItem";
            this.skyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.skyToolStripMenuItem.Text = "Sky ";
            this.skyToolStripMenuItem.Click += new System.EventHandler(this.skyToolStripMenuItem_Click);
            // 
            // nebulaToolStripMenuItem
            // 
            this.nebulaToolStripMenuItem.Name = "nebulaToolStripMenuItem";
            this.nebulaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nebulaToolStripMenuItem.Text = "Nebula";
            this.nebulaToolStripMenuItem.Click += new System.EventHandler(this.nebulaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 588);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxConvertResult);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxConvertTo);
            this.Controls.Add(this.comboBoxConvertFrom);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxConvertFrom;
        private System.Windows.Forms.ComboBox comboBoxConvertTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox textBoxConvertResult;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nebulaToolStripMenuItem;
    }
}

