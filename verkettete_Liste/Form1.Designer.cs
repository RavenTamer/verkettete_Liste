namespace verkettete_Liste
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumberInputLabel = new System.Windows.Forms.Label();
            this.NumberInputText = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SortRadioLabel = new System.Windows.Forms.Label();
            this.AscendingRadio = new System.Windows.Forms.RadioButton();
            this.DescendingRadio = new System.Windows.Forms.RadioButton();
            this.GetButton = new System.Windows.Forms.Button();
            this.NumberOutputBox = new System.Windows.Forms.TextBox();
            this.ClearLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberInputLabel
            // 
            this.NumberInputLabel.AutoSize = true;
            this.NumberInputLabel.Location = new System.Drawing.Point(12, 18);
            this.NumberInputLabel.Name = "NumberInputLabel";
            this.NumberInputLabel.Size = new System.Drawing.Size(33, 15);
            this.NumberInputLabel.TabIndex = 0;
            this.NumberInputLabel.Text = "Zahl:";
            // 
            // NumberInputText
            // 
            this.NumberInputText.Location = new System.Drawing.Point(64, 14);
            this.NumberInputText.Name = "NumberInputText";
            this.NumberInputText.Size = new System.Drawing.Size(100, 23);
            this.NumberInputText.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(170, 14);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.NumberOutputBox);
            this.groupBox1.Controls.Add(this.GetButton);
            this.groupBox1.Controls.Add(this.DescendingRadio);
            this.groupBox1.Controls.Add(this.AscendingRadio);
            this.groupBox1.Controls.Add(this.SortRadioLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // SortRadioLabel
            // 
            this.SortRadioLabel.AutoSize = true;
            this.SortRadioLabel.Location = new System.Drawing.Point(6, 19);
            this.SortRadioLabel.Name = "SortRadioLabel";
            this.SortRadioLabel.Size = new System.Drawing.Size(101, 15);
            this.SortRadioLabel.TabIndex = 0;
            this.SortRadioLabel.Text = "Sortierreihenfolge";
            // 
            // AscendingRadio
            // 
            this.AscendingRadio.AutoSize = true;
            this.AscendingRadio.Location = new System.Drawing.Point(26, 37);
            this.AscendingRadio.Name = "AscendingRadio";
            this.AscendingRadio.Size = new System.Drawing.Size(81, 19);
            this.AscendingRadio.TabIndex = 1;
            this.AscendingRadio.TabStop = true;
            this.AscendingRadio.Text = "Ascending";
            this.AscendingRadio.UseVisualStyleBackColor = true;
            // 
            // DescendingRadio
            // 
            this.DescendingRadio.AutoSize = true;
            this.DescendingRadio.Location = new System.Drawing.Point(26, 62);
            this.DescendingRadio.Name = "DescendingRadio";
            this.DescendingRadio.Size = new System.Drawing.Size(87, 19);
            this.DescendingRadio.TabIndex = 2;
            this.DescendingRadio.TabStop = true;
            this.DescendingRadio.Text = "Descending";
            this.DescendingRadio.UseVisualStyleBackColor = true;
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(158, 60);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(75, 23);
            this.GetButton.TabIndex = 3;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // NumberOutputBox
            // 
            this.NumberOutputBox.Location = new System.Drawing.Point(6, 89);
            this.NumberOutputBox.Name = "NumberOutputBox";
            this.NumberOutputBox.Size = new System.Drawing.Size(227, 23);
            this.NumberOutputBox.TabIndex = 4;
            // 
            // ClearLabel
            // 
            this.ClearLabel.AutoSize = true;
            this.ClearLabel.Location = new System.Drawing.Point(12, 189);
            this.ClearLabel.Name = "ClearLabel";
            this.ClearLabel.Size = new System.Drawing.Size(122, 15);
            this.ClearLabel.TabIndex = 4;
            this.ClearLabel.Text = "Zahlenspeicher leeren";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(170, 185);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 228);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ClearLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NumberInputText);
            this.Controls.Add(this.NumberInputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NumberInputLabel;
        private TextBox NumberInputText;
        private Button AddButton;
        private GroupBox groupBox1;
        private TextBox NumberOutputBox;
        private Button GetButton;
        private RadioButton DescendingRadio;
        private RadioButton AscendingRadio;
        private Label SortRadioLabel;
        private Label ClearLabel;
        private Button ClearButton;
    }
}