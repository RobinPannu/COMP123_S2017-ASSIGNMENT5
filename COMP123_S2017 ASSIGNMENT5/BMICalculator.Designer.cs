namespace COMP123_S2017_ASSIGNMENT5
{
    partial class BMICalculator
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
            this.HeightWeightTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightValueLabel = new System.Windows.Forms.Label();
            this.WeightValueLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.ResultsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BMIResultLabel = new System.Windows.Forms.Label();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.BMICalculateButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HeightWeightTableLayoutPanel.SuspendLayout();
            this.ResultsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeightWeightTableLayoutPanel
            // 
            this.HeightWeightTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.HeightWeightTableLayoutPanel.ColumnCount = 3;
            this.HeightWeightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.36237F));
            this.HeightWeightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.36237F));
            this.HeightWeightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.27527F));
            this.HeightWeightTableLayoutPanel.Controls.Add(this.HeightLabel, 0, 0);
            this.HeightWeightTableLayoutPanel.Controls.Add(this.HeightTextBox, 1, 0);
            this.HeightWeightTableLayoutPanel.Controls.Add(this.WeightLabel, 0, 1);
            this.HeightWeightTableLayoutPanel.Controls.Add(this.HeightValueLabel, 2, 0);
            this.HeightWeightTableLayoutPanel.Controls.Add(this.WeightValueLabel, 2, 1);
            this.HeightWeightTableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 1);
            this.HeightWeightTableLayoutPanel.Location = new System.Drawing.Point(12, 64);
            this.HeightWeightTableLayoutPanel.Name = "HeightWeightTableLayoutPanel";
            this.HeightWeightTableLayoutPanel.RowCount = 2;
            this.HeightWeightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeightWeightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeightWeightTableLayoutPanel.Size = new System.Drawing.Size(280, 159);
            this.HeightWeightTableLayoutPanel.TabIndex = 0;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(7, 29);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(76, 20);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "MyHeight";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.HeightTextBox.Location = new System.Drawing.Point(93, 20);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(84, 38);
            this.HeightTextBox.TabIndex = 4;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(5, 109);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(79, 20);
            this.WeightLabel.TabIndex = 6;
            this.WeightLabel.Text = "MyWeight";
            // 
            // HeightValueLabel
            // 
            this.HeightValueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightValueLabel.AutoSize = true;
            this.HeightValueLabel.Location = new System.Drawing.Point(187, 24);
            this.HeightValueLabel.Name = "HeightValueLabel";
            this.HeightValueLabel.Size = new System.Drawing.Size(86, 31);
            this.HeightValueLabel.TabIndex = 7;
            this.HeightValueLabel.Text = "label1";
            // 
            // WeightValueLabel
            // 
            this.WeightValueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightValueLabel.AutoSize = true;
            this.WeightValueLabel.Location = new System.Drawing.Point(187, 103);
            this.WeightValueLabel.Name = "WeightValueLabel";
            this.WeightValueLabel.Size = new System.Drawing.Size(86, 31);
            this.WeightValueLabel.TabIndex = 8;
            this.WeightValueLabel.Text = "label2";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.WeightTextBox.Location = new System.Drawing.Point(93, 100);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(84, 38);
            this.WeightTextBox.TabIndex = 5;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.MetricRadioButton.Checked = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.Location = new System.Drawing.Point(65, 21);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(70, 24);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = false;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.Location = new System.Drawing.Point(151, 21);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(83, 24);
            this.ImperialRadioButton.TabIndex = 2;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = false;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // ResultsTableLayoutPanel
            // 
            this.ResultsTableLayoutPanel.ColumnCount = 2;
            this.ResultsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.16667F));
            this.ResultsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.83333F));
            this.ResultsTableLayoutPanel.Controls.Add(this.BMIResultTextBox, 1, 0);
            this.ResultsTableLayoutPanel.Controls.Add(this.BMITextBox, 1, 1);
            this.ResultsTableLayoutPanel.Controls.Add(this.BMIResultLabel, 0, 0);
            this.ResultsTableLayoutPanel.Location = new System.Drawing.Point(12, 342);
            this.ResultsTableLayoutPanel.Name = "ResultsTableLayoutPanel";
            this.ResultsTableLayoutPanel.RowCount = 2;
            this.ResultsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.25532F));
            this.ResultsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.74468F));
            this.ResultsTableLayoutPanel.Size = new System.Drawing.Size(273, 94);
            this.ResultsTableLayoutPanel.TabIndex = 4;
            // 
            // BMIResultLabel
            // 
            this.BMIResultLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BMIResultLabel.AutoSize = true;
            this.BMIResultLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BMIResultLabel.Location = new System.Drawing.Point(4, 31);
            this.BMIResultLabel.Name = "BMIResultLabel";
            this.ResultsTableLayoutPanel.SetRowSpan(this.BMIResultLabel, 2);
            this.BMIResultLabel.Size = new System.Drawing.Size(70, 31);
            this.BMIResultLabel.TabIndex = 0;
            this.BMIResultLabel.Text = "BMI:";
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BMIResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BMIResultTextBox.Enabled = false;
            this.BMIResultTextBox.Location = new System.Drawing.Point(129, 6);
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.Size = new System.Drawing.Size(94, 38);
            this.BMIResultTextBox.TabIndex = 1;
            // 
            // BMICalculateButton
            // 
            this.BMICalculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BMICalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMICalculateButton.Location = new System.Drawing.Point(12, 241);
            this.BMICalculateButton.Name = "BMICalculateButton";
            this.BMICalculateButton.Size = new System.Drawing.Size(169, 43);
            this.BMICalculateButton.TabIndex = 5;
            this.BMICalculateButton.Text = "CALCULATE BMI";
            this.BMICalculateButton.UseVisualStyleBackColor = false;
            this.BMICalculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ResultLabel.Location = new System.Drawing.Point(111, 287);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(92, 31);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Result";
            // 
            // BMITextBox
            // 
            this.BMITextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BMITextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BMITextBox.Enabled = false;
            this.BMITextBox.Location = new System.Drawing.Point(97, 53);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(158, 38);
            this.BMITextBox.TabIndex = 2;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(205, 241);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 43);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BMICalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.BMICalculateButton);
            this.Controls.Add(this.ResultsTableLayoutPanel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ImperialRadioButton);
            this.Controls.Add(this.MetricRadioButton);
            this.Controls.Add(this.HeightWeightTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI CALCULATOR";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.HeightWeightTableLayoutPanel.ResumeLayout(false);
            this.HeightWeightTableLayoutPanel.PerformLayout();
            this.ResultsTableLayoutPanel.ResumeLayout(false);
            this.ResultsTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HeightWeightTableLayoutPanel;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightValueLabel;
        private System.Windows.Forms.Label WeightValueLabel;
        private System.Windows.Forms.TableLayoutPanel ResultsTableLayoutPanel;
        private System.Windows.Forms.Label BMIResultLabel;
        private System.Windows.Forms.TextBox BMIResultTextBox;
        private System.Windows.Forms.Button BMICalculateButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Button ResetButton;
    }
}

