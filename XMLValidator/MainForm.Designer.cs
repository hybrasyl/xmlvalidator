namespace XMLValidator
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxOnlyErrors = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonValidateAll = new System.Windows.Forms.Button();
            this.richTextBoxWorldDir = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(1138, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(347, 33);
            this.comboBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1002, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "XML Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Information / Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 415);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Validator Output";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(30, 446);
            this.richTextBoxOutput.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(1455, 283);
            this.richTextBoxOutput.TabIndex = 13;
            this.richTextBoxOutput.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 758);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(288, 44);
            this.button3.TabIndex = 14;
            this.button3.Text = "Validate Type";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.Location = new System.Drawing.Point(29, 100);
            this.richTextBoxStatus.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.ReadOnly = true;
            this.richTextBoxStatus.Size = new System.Drawing.Size(1456, 283);
            this.richTextBoxStatus.TabIndex = 15;
            this.richTextBoxStatus.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "World Directory";
            // 
            // checkBoxOnlyErrors
            // 
            this.checkBoxOnlyErrors.AutoSize = true;
            this.checkBoxOnlyErrors.Checked = true;
            this.checkBoxOnlyErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOnlyErrors.Location = new System.Drawing.Point(1261, 767);
            this.checkBoxOnlyErrors.Name = "checkBoxOnlyErrors";
            this.checkBoxOnlyErrors.Size = new System.Drawing.Size(224, 29);
            this.checkBoxOnlyErrors.TabIndex = 19;
            this.checkBoxOnlyErrors.Text = "Only display errors";
            this.checkBoxOnlyErrors.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(630, 758);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(288, 44);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "Clear Output";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonValidateAll
            // 
            this.buttonValidateAll.Location = new System.Drawing.Point(330, 757);
            this.buttonValidateAll.Margin = new System.Windows.Forms.Padding(6);
            this.buttonValidateAll.Name = "buttonValidateAll";
            this.buttonValidateAll.Size = new System.Drawing.Size(288, 44);
            this.buttonValidateAll.TabIndex = 21;
            this.buttonValidateAll.Text = "Validate All XML / Types";
            this.buttonValidateAll.UseVisualStyleBackColor = true;
            this.buttonValidateAll.Click += new System.EventHandler(this.buttonValidateAll_Click);
            // 
            // richTextBoxWorldDir
            // 
            this.richTextBoxWorldDir.Location = new System.Drawing.Point(197, 14);
            this.richTextBoxWorldDir.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBoxWorldDir.Name = "richTextBoxWorldDir";
            this.richTextBoxWorldDir.ReadOnly = true;
            this.richTextBoxWorldDir.Size = new System.Drawing.Size(677, 44);
            this.richTextBoxWorldDir.TabIndex = 22;
            this.richTextBoxWorldDir.Text = "";
            this.richTextBoxWorldDir.Click += new System.EventHandler(this.richTextBoxWorldDir_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 816);
            this.Controls.Add(this.richTextBoxWorldDir);
            this.Controls.Add(this.buttonValidateAll);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.checkBoxOnlyErrors);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxStatus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Hybrasyl XML Validator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBoxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxOnlyErrors;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonValidateAll;
        private System.Windows.Forms.RichTextBox richTextBoxWorldDir;
    }
}

