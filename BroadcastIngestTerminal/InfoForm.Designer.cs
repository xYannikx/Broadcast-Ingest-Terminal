namespace BroadcastIngestTerminal
{
    partial class InfoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupSystem = new System.Windows.Forms.GroupBox();
            this.lblEngineValue = new System.Windows.Forms.Label();
            this.lblEngine = new System.Windows.Forms.Label();
            this.lblVersionValue = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblOSValue = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.groupCredits = new System.Windows.Forms.GroupBox();
            this.linkIcon = new System.Windows.Forms.LinkLabel();
            this.lblIcon = new System.Windows.Forms.Label();
            this.linkCreator = new System.Windows.Forms.LinkLabel();
            this.lblCreator = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupSystem.SuspendLayout();
            this.groupCredits.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(252, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Broadcast Ingest Terminal";
            // 
            // groupSystem
            // 
            this.groupSystem.Controls.Add(this.lblEngineValue);
            this.groupSystem.Controls.Add(this.lblEngine);
            this.groupSystem.Controls.Add(this.lblVersionValue);
            this.groupSystem.Controls.Add(this.lblVersion);
            this.groupSystem.Controls.Add(this.lblOSValue);
            this.groupSystem.Controls.Add(this.lblOS);
            this.groupSystem.Location = new System.Drawing.Point(15, 50);
            this.groupSystem.Name = "groupSystem";
            this.groupSystem.Size = new System.Drawing.Size(390, 95);
            this.groupSystem.TabIndex = 1;
            this.groupSystem.TabStop = false;
            this.groupSystem.Text = "System-Informationen";
            // 
            // lblEngineValue
            // 
            this.lblEngineValue.AutoSize = true;
            this.lblEngineValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngineValue.Location = new System.Drawing.Point(110, 71);
            this.lblEngineValue.Name = "lblEngineValue";
            this.lblEngineValue.Size = new System.Drawing.Size(19, 13);
            this.lblEngineValue.TabIndex = 5;
            this.lblEngineValue.Text = "...";
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Location = new System.Drawing.Point(15, 71);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(43, 13);
            this.lblEngine.TabIndex = 4;
            this.lblEngine.Text = "Engine:";
            // 
            // lblVersionValue
            // 
            this.lblVersionValue.AutoSize = true;
            this.lblVersionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersionValue.Location = new System.Drawing.Point(110, 48);
            this.lblVersionValue.Name = "lblVersionValue";
            this.lblVersionValue.Size = new System.Drawing.Size(19, 13);
            this.lblVersionValue.TabIndex = 3;
            this.lblVersionValue.Text = "...";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(15, 48);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(91, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Programmversion:";
            // 
            // lblOSValue
            // 
            this.lblOSValue.AutoSize = true;
            this.lblOSValue.Location = new System.Drawing.Point(110, 25);
            this.lblOSValue.Name = "lblOSValue";
            this.lblOSValue.Size = new System.Drawing.Size(16, 13);
            this.lblOSValue.TabIndex = 1;
            this.lblOSValue.Text = "...";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(15, 25);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(80, 13);
            this.lblOS.TabIndex = 0;
            this.lblOS.Text = "Betriebssystem:";
            // 
            // groupCredits
            // 
            this.groupCredits.Controls.Add(this.linkIcon);
            this.groupCredits.Controls.Add(this.lblIcon);
            this.groupCredits.Controls.Add(this.linkCreator);
            this.groupCredits.Controls.Add(this.lblCreator);
            this.groupCredits.Location = new System.Drawing.Point(15, 155);
            this.groupCredits.Name = "groupCredits";
            this.groupCredits.Size = new System.Drawing.Size(390, 85);
            this.groupCredits.TabIndex = 2;
            this.groupCredits.TabStop = false;
            this.groupCredits.Text = "Credits";
            // 
            // linkIcon
            // 
            this.linkIcon.AutoSize = true;
            this.linkIcon.Location = new System.Drawing.Point(220, 55);
            this.linkIcon.Name = "linkIcon";
            this.linkIcon.Size = new System.Drawing.Size(66, 13);
            this.linkIcon.TabIndex = 3;
            this.linkIcon.TabStop = true;
            this.linkIcon.Text = "GitHub Profil";
            this.linkIcon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkIcon_LinkClicked);
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(15, 55);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(95, 13);
            this.lblIcon.TabIndex = 2;
            this.lblIcon.Text = "Icon Ersteller: Trisii";
            // 
            // linkCreator
            // 
            this.linkCreator.AutoSize = true;
            this.linkCreator.Location = new System.Drawing.Point(220, 25);
            this.linkCreator.Name = "linkCreator";
            this.linkCreator.Size = new System.Drawing.Size(66, 13);
            this.linkCreator.TabIndex = 1;
            this.linkCreator.TabStop = true;
            this.linkCreator.Text = "GitHub Profil";
            this.linkCreator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreator_LinkClicked);
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Location = new System.Drawing.Point(15, 25);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(93, 13);
            this.lblCreator.TabIndex = 0;
            this.lblCreator.Text = "Ersteller: xYannikx";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(165, 250);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 28);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 290);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupCredits);
            this.Controls.Add(this.groupSystem);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Info / Credits";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.groupSystem.ResumeLayout(false);
            this.groupSystem.PerformLayout();
            this.groupCredits.ResumeLayout(false);
            this.groupCredits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupSystem;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblOSValue;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblVersionValue;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.Label lblEngineValue;
        private System.Windows.Forms.GroupBox groupCredits;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.LinkLabel linkCreator;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.LinkLabel linkIcon;
        private System.Windows.Forms.Button btnOk;
    }
}
