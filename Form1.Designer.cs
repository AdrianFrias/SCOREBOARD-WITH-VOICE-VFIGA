namespace Scoreboard_with_voice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelT1 = new System.Windows.Forms.Label();
            this.labelT2 = new System.Windows.Forms.Label();
            this.SimpleLabelVS = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAnotacionT2 = new System.Windows.Forms.Button();
            this.btnAnotacionT1 = new System.Windows.Forms.Button();
            this.lbResT1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.marcadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularAnotaciónEquipo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularAnotaciónEquipo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definirNombreAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxT1 = new System.Windows.Forms.ToolStripTextBox();
            this.definirNombreBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxT2 = new System.Windows.Forms.ToolStripTextBox();
            this.contactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSimpleA = new System.Windows.Forms.Label();
            this.lbSimpleB = new System.Windows.Forms.Label();
            this.lbNameT1 = new System.Windows.Forms.Label();
            this.lbNameT2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelT1
            // 
            this.labelT1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelT1.AutoSize = true;
            this.labelT1.Font = new System.Drawing.Font("Arial Black", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT1.ForeColor = System.Drawing.Color.Red;
            this.labelT1.Location = new System.Drawing.Point(119, 155);
            this.labelT1.Name = "labelT1";
            this.labelT1.Size = new System.Drawing.Size(251, 282);
            this.labelT1.TabIndex = 0;
            this.labelT1.Text = "0";
            this.labelT1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelT2
            // 
            this.labelT2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelT2.AutoSize = true;
            this.labelT2.Font = new System.Drawing.Font("Arial Black", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT2.ForeColor = System.Drawing.Color.Red;
            this.labelT2.Location = new System.Drawing.Point(836, 155);
            this.labelT2.Name = "labelT2";
            this.labelT2.Size = new System.Drawing.Size(251, 282);
            this.labelT2.TabIndex = 1;
            this.labelT2.Text = "0";
            this.labelT2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SimpleLabelVS
            // 
            this.SimpleLabelVS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SimpleLabelVS.AutoSize = true;
            this.SimpleLabelVS.Font = new System.Drawing.Font("Arial Black", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleLabelVS.ForeColor = System.Drawing.Color.White;
            this.SimpleLabelVS.Location = new System.Drawing.Point(514, 208);
            this.SimpleLabelVS.Name = "SimpleLabelVS";
            this.SimpleLabelVS.Size = new System.Drawing.Size(243, 188);
            this.SimpleLabelVS.TabIndex = 2;
            this.SimpleLabelVS.Text = "vs";
            this.SimpleLabelVS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(571, 578);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 37);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAnotacionT2
            // 
            this.btnAnotacionT2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAnotacionT2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAnotacionT2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnotacionT2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnotacionT2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnotacionT2.ForeColor = System.Drawing.Color.Transparent;
            this.btnAnotacionT2.Location = new System.Drawing.Point(917, 431);
            this.btnAnotacionT2.Name = "btnAnotacionT2";
            this.btnAnotacionT2.Size = new System.Drawing.Size(170, 87);
            this.btnAnotacionT2.TabIndex = 5;
            this.btnAnotacionT2.Text = "Anotación";
            this.btnAnotacionT2.UseVisualStyleBackColor = false;
            this.btnAnotacionT2.Click += new System.EventHandler(this.btnAnotacionT2_Click);
            // 
            // btnAnotacionT1
            // 
            this.btnAnotacionT1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAnotacionT1.BackColor = System.Drawing.Color.Blue;
            this.btnAnotacionT1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnotacionT1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnotacionT1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnotacionT1.ForeColor = System.Drawing.Color.Transparent;
            this.btnAnotacionT1.Location = new System.Drawing.Point(200, 431);
            this.btnAnotacionT1.Name = "btnAnotacionT1";
            this.btnAnotacionT1.Size = new System.Drawing.Size(170, 87);
            this.btnAnotacionT1.TabIndex = 6;
            this.btnAnotacionT1.Text = "Anotación";
            this.btnAnotacionT1.UseVisualStyleBackColor = false;
            this.btnAnotacionT1.Click += new System.EventHandler(this.btnAnotacionT1_Click);
            // 
            // lbResT1
            // 
            this.lbResT1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbResT1.AutoSize = true;
            this.lbResT1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbResT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResT1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbResT1.Location = new System.Drawing.Point(195, 578);
            this.lbResT1.Name = "lbResT1";
            this.lbResT1.Size = new System.Drawing.Size(167, 25);
            this.lbResT1.TabIndex = 7;
            this.lbResT1.Text = "Restar puntos a A";
            this.lbResT1.Click += new System.EventHandler(this.lbResT1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(912, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Restar puntos a B";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcadorToolStripMenuItem,
            this.nombresToolStripMenuItem,
            this.contactoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // marcadorToolStripMenuItem
            // 
            this.marcadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetearToolStripMenuItem,
            this.anularAnotaciónEquipo1ToolStripMenuItem,
            this.anularAnotaciónEquipo2ToolStripMenuItem});
            this.marcadorToolStripMenuItem.Name = "marcadorToolStripMenuItem";
            this.marcadorToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.marcadorToolStripMenuItem.Text = "Marcador";
            // 
            // resetearToolStripMenuItem
            // 
            this.resetearToolStripMenuItem.Name = "resetearToolStripMenuItem";
            this.resetearToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.resetearToolStripMenuItem.Text = "Resetear";
            this.resetearToolStripMenuItem.Click += new System.EventHandler(this.resetearToolStripMenuItem_Click);
            // 
            // anularAnotaciónEquipo1ToolStripMenuItem
            // 
            this.anularAnotaciónEquipo1ToolStripMenuItem.Name = "anularAnotaciónEquipo1ToolStripMenuItem";
            this.anularAnotaciónEquipo1ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.anularAnotaciónEquipo1ToolStripMenuItem.Text = "Anular anotación A";
            this.anularAnotaciónEquipo1ToolStripMenuItem.Click += new System.EventHandler(this.anularAnotaciónEquipo1ToolStripMenuItem_Click);
            // 
            // anularAnotaciónEquipo2ToolStripMenuItem
            // 
            this.anularAnotaciónEquipo2ToolStripMenuItem.Name = "anularAnotaciónEquipo2ToolStripMenuItem";
            this.anularAnotaciónEquipo2ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.anularAnotaciónEquipo2ToolStripMenuItem.Text = "Anular anotación B";
            this.anularAnotaciónEquipo2ToolStripMenuItem.Click += new System.EventHandler(this.anularAnotaciónEquipo2ToolStripMenuItem_Click);
            // 
            // nombresToolStripMenuItem
            // 
            this.nombresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.definirNombreAToolStripMenuItem,
            this.definirNombreBToolStripMenuItem});
            this.nombresToolStripMenuItem.Name = "nombresToolStripMenuItem";
            this.nombresToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.nombresToolStripMenuItem.Text = "Nombres";
            // 
            // definirNombreAToolStripMenuItem
            // 
            this.definirNombreAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textBoxT1});
            this.definirNombreAToolStripMenuItem.Name = "definirNombreAToolStripMenuItem";
            this.definirNombreAToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.definirNombreAToolStripMenuItem.Text = "Definir nombre A";
            // 
            // textBoxT1
            // 
            this.textBoxT1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxT1.Name = "textBoxT1";
            this.textBoxT1.Size = new System.Drawing.Size(100, 23);
            this.textBoxT1.TextChanged += new System.EventHandler(this.textBoxT1_TextChanged);
            // 
            // definirNombreBToolStripMenuItem
            // 
            this.definirNombreBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textBoxT2});
            this.definirNombreBToolStripMenuItem.Name = "definirNombreBToolStripMenuItem";
            this.definirNombreBToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.definirNombreBToolStripMenuItem.Text = "Definir nombre B";
            // 
            // textBoxT2
            // 
            this.textBoxT2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxT2.Name = "textBoxT2";
            this.textBoxT2.Size = new System.Drawing.Size(100, 23);
            this.textBoxT2.TextChanged += new System.EventHandler(this.textBoxT2_TextChanged_1);
            // 
            // contactoToolStripMenuItem
            // 
            this.contactoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créditosToolStripMenuItem,
            this.gitHubToolStripMenuItem});
            this.contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            this.contactoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.contactoToolStripMenuItem.Text = "Contacto";
            // 
            // créditosToolStripMenuItem
            // 
            this.créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            this.créditosToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.créditosToolStripMenuItem.Text = "Créditos";
            this.créditosToolStripMenuItem.Click += new System.EventHandler(this.créditosToolStripMenuItem_Click);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // lbSimpleA
            // 
            this.lbSimpleA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSimpleA.AutoSize = true;
            this.lbSimpleA.Font = new System.Drawing.Font("Arial Black", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimpleA.ForeColor = System.Drawing.Color.White;
            this.lbSimpleA.Location = new System.Drawing.Point(43, 259);
            this.lbSimpleA.Name = "lbSimpleA";
            this.lbSimpleA.Size = new System.Drawing.Size(92, 95);
            this.lbSimpleA.TabIndex = 10;
            this.lbSimpleA.Text = "A";
            this.lbSimpleA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSimpleB
            // 
            this.lbSimpleB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSimpleB.AutoSize = true;
            this.lbSimpleB.Font = new System.Drawing.Font("Arial Black", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimpleB.ForeColor = System.Drawing.Color.White;
            this.lbSimpleB.Location = new System.Drawing.Point(1160, 259);
            this.lbSimpleB.Name = "lbSimpleB";
            this.lbSimpleB.Size = new System.Drawing.Size(92, 95);
            this.lbSimpleB.TabIndex = 11;
            this.lbSimpleB.Text = "B";
            this.lbSimpleB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbNameT1
            // 
            this.lbNameT1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNameT1.AutoSize = true;
            this.lbNameT1.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameT1.ForeColor = System.Drawing.Color.White;
            this.lbNameT1.Location = new System.Drawing.Point(160, 155);
            this.lbNameT1.Name = "lbNameT1";
            this.lbNameT1.Size = new System.Drawing.Size(133, 31);
            this.lbNameT1.TabIndex = 12;
            this.lbNameT1.Text = "EQUIPO A";
            this.lbNameT1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbNameT2
            // 
            this.lbNameT2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNameT2.AutoSize = true;
            this.lbNameT2.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameT2.ForeColor = System.Drawing.Color.White;
            this.lbNameT2.Location = new System.Drawing.Point(877, 155);
            this.lbNameT2.Name = "lbNameT2";
            this.lbNameT2.Size = new System.Drawing.Size(133, 31);
            this.lbNameT2.TabIndex = 13;
            this.lbNameT2.Text = "EQUIPO B";
            this.lbNameT2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lbNameT2);
            this.Controls.Add(this.lbNameT1);
            this.Controls.Add(this.lbSimpleB);
            this.Controls.Add(this.lbSimpleA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResT1);
            this.Controls.Add(this.btnAnotacionT1);
            this.Controls.Add(this.btnAnotacionT2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.SimpleLabelVS);
            this.Controls.Add(this.labelT2);
            this.Controls.Add(this.labelT1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Scoreboard - Marcador con voz";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelT1;
        private System.Windows.Forms.Label labelT2;
        private System.Windows.Forms.Label SimpleLabelVS;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAnotacionT2;
        private System.Windows.Forms.Button btnAnotacionT1;
        private System.Windows.Forms.Label lbResT1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem marcadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularAnotaciónEquipo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularAnotaciónEquipo2ToolStripMenuItem;
        private System.Windows.Forms.Label lbSimpleA;
        private System.Windows.Forms.ToolStripMenuItem nombresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definirNombreAToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox textBoxT1;
        private System.Windows.Forms.ToolStripMenuItem definirNombreBToolStripMenuItem;
        private System.Windows.Forms.Label lbSimpleB;
        private System.Windows.Forms.ToolStripMenuItem contactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créditosToolStripMenuItem;
        private System.Windows.Forms.Label lbNameT1;
        private System.Windows.Forms.Label lbNameT2;
        private System.Windows.Forms.ToolStripTextBox textBoxT2;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
    }
}

