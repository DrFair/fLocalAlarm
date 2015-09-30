namespace fLocalAlarm
{
    partial class SettingsForm
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
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.hLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.enemyAlarm = new System.Windows.Forms.CheckBox();
            this.neutAlarm = new System.Windows.Forms.CheckBox();
            this.xBox = new System.Windows.Forms.NumericUpDown();
            this.yBox = new System.Windows.Forms.NumericUpDown();
            this.hBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.xBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBox)).BeginInit();
            this.SuspendLayout();
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(13, 13);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(90, 13);
            this.xLabel.TabIndex = 0;
            this.xLabel.Text = "Screen X position";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(13, 53);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(90, 13);
            this.yLabel.TabIndex = 1;
            this.yLabel.Text = "Screen Y position";
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Location = new System.Drawing.Point(13, 93);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(110, 13);
            this.hLabel.TabIndex = 4;
            this.hLabel.Text = "Local height in names";
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.confirmButton.Location = new System.Drawing.Point(12, 184);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(97, 184);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // enemyAlarm
            // 
            this.enemyAlarm.AutoSize = true;
            this.enemyAlarm.Location = new System.Drawing.Point(12, 137);
            this.enemyAlarm.Name = "enemyAlarm";
            this.enemyAlarm.Size = new System.Drawing.Size(86, 17);
            this.enemyAlarm.TabIndex = 8;
            this.enemyAlarm.Text = "Enemy alarm";
            this.enemyAlarm.UseVisualStyleBackColor = true;
            // 
            // neutAlarm
            // 
            this.neutAlarm.AutoSize = true;
            this.neutAlarm.Location = new System.Drawing.Point(12, 161);
            this.neutAlarm.Name = "neutAlarm";
            this.neutAlarm.Size = new System.Drawing.Size(88, 17);
            this.neutAlarm.TabIndex = 9;
            this.neutAlarm.Text = "Neutral alarm";
            this.neutAlarm.UseVisualStyleBackColor = true;
            // 
            // xBox
            // 
            this.xBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.xBox.InterceptArrowKeys = false;
            this.xBox.Location = new System.Drawing.Point(12, 30);
            this.xBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.xBox.Controls[0].Visible = false; // Removes up and down buttons
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(160, 20);
            this.xBox.TabIndex = 10;
            // 
            // yBox
            // 
            this.yBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.yBox.InterceptArrowKeys = false;
            this.yBox.Location = new System.Drawing.Point(12, 70);
            this.yBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.yBox.Controls[0].Visible = false;
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(160, 20);
            this.yBox.TabIndex = 11;
            // 
            // hBox
            // 
            this.hBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hBox.InterceptArrowKeys = false;
            this.hBox.Location = new System.Drawing.Point(12, 111);
            this.hBox.Controls[0].Visible = false;
            this.hBox.Name = "hBox";
            this.hBox.Size = new System.Drawing.Size(160, 20);
            this.hBox.TabIndex = 12;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 219);
            this.ControlBox = false;
            this.Controls.Add(this.hBox);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.neutAlarm);
            this.Controls.Add(this.enemyAlarm);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.hLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.xBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox enemyAlarm;
        private System.Windows.Forms.CheckBox neutAlarm;
        private System.Windows.Forms.NumericUpDown xBox;
        private System.Windows.Forms.NumericUpDown yBox;
        private System.Windows.Forms.NumericUpDown hBox;
    }
}