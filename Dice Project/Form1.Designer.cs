namespace Dice_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.RollButton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.DiceCount = new System.Windows.Forms.NumericUpDown();
            this.D20button = new System.Windows.Forms.Button();
            this.D12button = new System.Windows.Forms.Button();
            this.D10button = new System.Windows.Forms.Button();
            this.D6button = new System.Windows.Forms.Button();
            this.D4button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DiceCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "How Many?";
            // 
            // ResultBox
            // 
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBox.Location = new System.Drawing.Point(737, 255);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultBox.Size = new System.Drawing.Size(326, 82);
            this.ResultBox.TabIndex = 12;
            // 
            // RollButton
            // 
            this.RollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollButton.Location = new System.Drawing.Point(391, 218);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(310, 168);
            this.RollButton.TabIndex = 13;
            this.RollButton.Text = "ROLL";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalLabel.Location = new System.Drawing.Point(728, 340);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(130, 51);
            this.TotalLabel.TabIndex = 14;
            this.TotalLabel.Text = "Total:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(868, 340);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(51, 55);
            this.ResultLabel.TabIndex = 15;
            this.ResultLabel.Text = "0";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResultLabel.Click += new System.EventHandler(this.ResultLabel_Click);
            // 
            // DiceCount
            // 
            this.DiceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiceCount.Location = new System.Drawing.Point(177, 300);
            this.DiceCount.Name = "DiceCount";
            this.DiceCount.Size = new System.Drawing.Size(132, 62);
            this.DiceCount.TabIndex = 16;
            this.DiceCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DiceCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DiceCount.ValueChanged += new System.EventHandler(this.DiceCount_ValueChanged);
            // 
            // D20button
            // 
            this.D20button.BackgroundImage = global::Dice_Project.Properties.Resources.d20;
            this.D20button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.D20button.Location = new System.Drawing.Point(895, 25);
            this.D20button.Name = "D20button";
            this.D20button.Size = new System.Drawing.Size(179, 147);
            this.D20button.TabIndex = 9;
            this.D20button.UseVisualStyleBackColor = true;
            this.D20button.Click += new System.EventHandler(this.D20button_Click);
            // 
            // D12button
            // 
            this.D12button.BackgroundImage = global::Dice_Project.Properties.Resources.d12;
            this.D12button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.D12button.Location = new System.Drawing.Point(682, 25);
            this.D12button.Name = "D12button";
            this.D12button.Size = new System.Drawing.Size(179, 147);
            this.D12button.TabIndex = 8;
            this.D12button.UseVisualStyleBackColor = true;
            this.D12button.Click += new System.EventHandler(this.D12button_Click);
            // 
            // D10button
            // 
            this.D10button.BackgroundImage = global::Dice_Project.Properties.Resources.d10;
            this.D10button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.D10button.Location = new System.Drawing.Point(473, 25);
            this.D10button.Name = "D10button";
            this.D10button.Size = new System.Drawing.Size(179, 147);
            this.D10button.TabIndex = 7;
            this.D10button.UseVisualStyleBackColor = true;
            this.D10button.Click += new System.EventHandler(this.D10button_Click);
            // 
            // D6button
            // 
            this.D6button.BackgroundImage = global::Dice_Project.Properties.Resources.d6;
            this.D6button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.D6button.Location = new System.Drawing.Point(259, 25);
            this.D6button.Name = "D6button";
            this.D6button.Size = new System.Drawing.Size(179, 147);
            this.D6button.TabIndex = 1;
            this.D6button.UseVisualStyleBackColor = true;
            this.D6button.Click += new System.EventHandler(this.D6button_Click);
            // 
            // D4button
            // 
            this.D4button.BackgroundImage = global::Dice_Project.Properties.Resources.d4;
            this.D4button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.D4button.Location = new System.Drawing.Point(48, 25);
            this.D4button.Name = "D4button";
            this.D4button.Size = new System.Drawing.Size(179, 147);
            this.D4button.TabIndex = 0;
            this.D4button.UseVisualStyleBackColor = true;
            this.D4button.Click += new System.EventHandler(this.d4Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1127, 485);
            this.Controls.Add(this.DiceCount);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.D20button);
            this.Controls.Add(this.D12button);
            this.Controls.Add(this.D10button);
            this.Controls.Add(this.D6button);
            this.Controls.Add(this.D4button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiceCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button D4button;
        private System.Windows.Forms.Button D6button;
        private System.Windows.Forms.Button D10button;
        private System.Windows.Forms.Button D12button;
        private System.Windows.Forms.Button D20button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.NumericUpDown DiceCount;
    }
}

