namespace BroadcastIngestTerminal
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateiHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeLeerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pfadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausgabeordnerÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausgabeordnerZuruecksetzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spracheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoCreditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfoSource = new System.Windows.Forms.Label();
            this.lblInfoOutput = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(12, 35);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(490, 21);
            this.comboBoxFormat.TabIndex = 0;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.AllowDrop = true;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(12, 70);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(490, 147);
            this.listBoxFiles.TabIndex = 1;
            this.listBoxFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxFiles_DragDrop);
            this.listBoxFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxFiles_MouseDown);
            this.listBoxFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxFiles_DragEnter);
            // 
            // buttonClear
            // 
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonClear.Location = new System.Drawing.Point(12, 345);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(120, 36);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Liste leeren";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(140, 345);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(362, 36);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Verarbeitung starten";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddFiles.Location = new System.Drawing.Point(12, 305);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(490, 28);
            this.btnAddFiles.TabIndex = 7;
            this.btnAddFiles.Text = "Dateien hinzufügen (oder per Drag && Drop)";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelStatus.Location = new System.Drawing.Point(12, 390);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Bereit.";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 410);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(490, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.pfadToolStripMenuItem,
            this.spracheToolStripMenuItem,
            this.infoToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiHinzufügenToolStripMenuItem,
            this.listeLeerenToolStripMenuItem,
            this.toolStripSeparator1,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // dateiHinzufügenToolStripMenuItem
            // 
            this.dateiHinzufügenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dateiHinzufügenToolStripMenuItem.Image")));
            this.dateiHinzufügenToolStripMenuItem.Name = "dateiHinzufügenToolStripMenuItem";
            this.dateiHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.dateiHinzufügenToolStripMenuItem.Text = "Dateien hinzufügen...";
            this.dateiHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.dateiHinzufügenToolStripMenuItem_Click);
            // 
            // listeLeerenToolStripMenuItem
            // 
            this.listeLeerenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeLeerenToolStripMenuItem.Image")));
            this.listeLeerenToolStripMenuItem.Name = "listeLeerenToolStripMenuItem";
            this.listeLeerenToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listeLeerenToolStripMenuItem.Text = "Liste leeren";
            this.listeLeerenToolStripMenuItem.Click += new System.EventHandler(this.listeLeerenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("beendenToolStripMenuItem.Image")));
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // pfadToolStripMenuItem
            // 
            this.pfadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausgabeordnerÄndernToolStripMenuItem,
            this.ausgabeordnerZuruecksetzenToolStripMenuItem});
            this.pfadToolStripMenuItem.Name = "pfadToolStripMenuItem";
            this.pfadToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.pfadToolStripMenuItem.Text = "Pfad";
            // 
            // ausgabeordnerÄndernToolStripMenuItem
            // 
            this.ausgabeordnerÄndernToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ausgabeordnerÄndernToolStripMenuItem.Image")));
            this.ausgabeordnerÄndernToolStripMenuItem.Name = "ausgabeordnerÄndernToolStripMenuItem";
            this.ausgabeordnerÄndernToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.ausgabeordnerÄndernToolStripMenuItem.Text = "Ausgabeordner ändern...";
            this.ausgabeordnerÄndernToolStripMenuItem.Click += new System.EventHandler(this.ausgabeordnerÄndernToolStripMenuItem_Click);
            // 
            // ausgabeordnerZuruecksetzenToolStripMenuItem
            // 
            this.ausgabeordnerZuruecksetzenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ausgabeordnerZuruecksetzenToolStripMenuItem.Image")));
            this.ausgabeordnerZuruecksetzenToolStripMenuItem.Name = "ausgabeordnerZuruecksetzenToolStripMenuItem";
            this.ausgabeordnerZuruecksetzenToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.ausgabeordnerZuruecksetzenToolStripMenuItem.Text = "Ausgabeordner zurücksetzen";
            this.ausgabeordnerZuruecksetzenToolStripMenuItem.Click += new System.EventHandler(this.ausgabeordnerZuruecksetzenToolStripMenuItem_Click);
            // 
            // spracheToolStripMenuItem
            // 
            this.spracheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deutschToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.spracheToolStripMenuItem.Name = "spracheToolStripMenuItem";
            this.spracheToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.spracheToolStripMenuItem.Text = "Sprache";
            // 
            // deutschToolStripMenuItem
            // 
            this.deutschToolStripMenuItem.Checked = true;
            this.deutschToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deutschToolStripMenuItem.Name = "deutschToolStripMenuItem";
            this.deutschToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.deutschToolStripMenuItem.Text = "Deutsch";
            this.deutschToolStripMenuItem.Click += new System.EventHandler(this.deutschToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem1
            // 
            this.infoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoCreditsToolStripMenuItem});
            this.infoToolStripMenuItem1.Name = "infoToolStripMenuItem1";
            this.infoToolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem1.Text = "Info";
            // 
            // infoCreditsToolStripMenuItem
            // 
            this.infoCreditsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("infoCreditsToolStripMenuItem.Image")));
            this.infoCreditsToolStripMenuItem.Name = "infoCreditsToolStripMenuItem";
            this.infoCreditsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.infoCreditsToolStripMenuItem.Text = "Info / Credits";
            this.infoCreditsToolStripMenuItem.Click += new System.EventHandler(this.infoCreditsToolStripMenuItem_Click);
            // 
            // lblInfoSource
            // 
            this.lblInfoSource.AutoSize = true;
            this.lblInfoSource.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblInfoSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoSource.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInfoSource.Location = new System.Drawing.Point(12, 230);
            this.lblInfoSource.Name = "lblInfoSource";
            this.lblInfoSource.Size = new System.Drawing.Size(234, 13);
            this.lblInfoSource.TabIndex = 8;
            this.lblInfoSource.Text = "WICHTIG: Quellmaterial muss 16:9 sein!";
            // 
            // lblInfoOutput
            // 
            this.lblInfoOutput.AutoSize = true;
            this.lblInfoOutput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblInfoOutput.Location = new System.Drawing.Point(12, 250);
            this.lblInfoOutput.Name = "lblInfoOutput";
            this.lblInfoOutput.Size = new System.Drawing.Size(180, 13);
            this.lblInfoOutput.TabIndex = 9;
            this.lblInfoOutput.Text = "Output: Erzeugt zwei .mov Dateien...";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entfernenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 26);
            // 
            // entfernenToolStripMenuItem
            // 
            this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
            this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.entfernenToolStripMenuItem.Text = "Datei entfernen";
            this.entfernenToolStripMenuItem.Click += new System.EventHandler(this.entfernenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 451);
            this.Controls.Add(this.lblInfoOutput);
            this.Controls.Add(this.lblInfoSource);
            this.Controls.Add(this.btnAddFiles);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.comboBoxFormat);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Broadcast Ingest Terminal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateiHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeLeerenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spracheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem infoCreditsToolStripMenuItem;
        private System.Windows.Forms.Label lblInfoSource;
        private System.Windows.Forms.Label lblInfoOutput;
        private System.Windows.Forms.ToolStripMenuItem pfadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausgabeordnerÄndernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausgabeordnerZuruecksetzenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem;
    }
}
