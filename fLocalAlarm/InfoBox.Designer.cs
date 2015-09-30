namespace fLocalAlarm
{
    partial class InfoBox
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
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enemyAlarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neutralAlarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.Label();
            this.testAlarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.testAlarmToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(153, 114);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onTopToolStripMenuItem,
            this.enemyAlarmToolStripMenuItem,
            this.neutralAlarmToolStripMenuItem,
            this.advancedSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // onTopToolStripMenuItem
            // 
            this.onTopToolStripMenuItem.Name = "onTopToolStripMenuItem";
            this.onTopToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.onTopToolStripMenuItem.Text = "OnTop";
            this.onTopToolStripMenuItem.Click += new System.EventHandler(this.onTopToolStripMenuItem_Click);
            // 
            // enemyAlarmToolStripMenuItem
            // 
            this.enemyAlarmToolStripMenuItem.Name = "enemyAlarmToolStripMenuItem";
            this.enemyAlarmToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.enemyAlarmToolStripMenuItem.Text = "Enemy alarm";
            this.enemyAlarmToolStripMenuItem.Click += new System.EventHandler(this.enemyAlarmToolStripMenuItem_Click);
            // 
            // neutralAlarmToolStripMenuItem
            // 
            this.neutralAlarmToolStripMenuItem.Name = "neutralAlarmToolStripMenuItem";
            this.neutralAlarmToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.neutralAlarmToolStripMenuItem.Text = "Neutral alarm";
            this.neutralAlarmToolStripMenuItem.Click += new System.EventHandler(this.neutralAlarmToolStripMenuItem_Click);
            // 
            // advancedSettingsToolStripMenuItem
            // 
            this.advancedSettingsToolStripMenuItem.Name = "advancedSettingsToolStripMenuItem";
            this.advancedSettingsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.advancedSettingsToolStripMenuItem.Text = "Advanced settings";
            this.advancedSettingsToolStripMenuItem.Click += new System.EventHandler(this.advancedSettingsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(2, 2);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(93, 17);
            this.status.TabIndex = 2;
            this.status.Text = "fLocalAlarm";
            this.status.MouseDown += new System.Windows.Forms.MouseEventHandler(this.status_MouseDown);
            this.status.MouseMove += new System.Windows.Forms.MouseEventHandler(this.status_MouseMove);
            this.status.MouseUp += new System.Windows.Forms.MouseEventHandler(this.status_MouseUp);
            // 
            // testAlarmToolStripMenuItem
            // 
            this.testAlarmToolStripMenuItem.Name = "testAlarmToolStripMenuItem";
            this.testAlarmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testAlarmToolStripMenuItem.Text = "Test alarm";
            this.testAlarmToolStripMenuItem.Click += new System.EventHandler(this.testAlarmToolStripMenuItem_Click);
            // 
            // InfoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(280, 161);
            this.ControlBox = false;
            this.Controls.Add(this.status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoBox";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InfoBox";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InfoBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InfoBox_MouseUp);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ToolStripMenuItem enemyAlarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neutralAlarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testAlarmToolStripMenuItem;

    }
}

