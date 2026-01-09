namespace NepessegGUI
{
    partial class FrmAdatbovites
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
            lblUi02 = new Label();
            btnKilepes = new Button();
            txtOrszagNev = new TextBox();
            lblUi03 = new Label();
            lblUi04 = new Label();
            lblUi05 = new Label();
            lblUi06 = new Label();
            lblUi01 = new Label();
            txtTerulet = new TextBox();
            txtNepesseg = new TextBox();
            txtFovaros = new TextBox();
            txtFovarosLakossag = new TextBox();
            btnMentes = new Button();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // lblUi02
            // 
            lblUi02.AutoSize = true;
            lblUi02.Location = new Point(144, 104);
            lblUi02.Name = "lblUi02";
            lblUi02.Size = new Size(62, 21);
            lblUi02.TabIndex = 0;
            lblUi02.Text = "Ország:";
            // 
            // btnKilepes
            // 
            btnKilepes.Location = new Point(469, 512);
            btnKilepes.Name = "btnKilepes";
            btnKilepes.Size = new Size(103, 37);
            btnKilepes.TabIndex = 1;
            btnKilepes.Text = "kilépés";
            btnKilepes.UseVisualStyleBackColor = true;
            // 
            // txtOrszagNev
            // 
            txtOrszagNev.Location = new Point(212, 101);
            txtOrszagNev.Name = "txtOrszagNev";
            txtOrszagNev.Size = new Size(211, 29);
            txtOrszagNev.TabIndex = 2;
            txtOrszagNev.Text = "Chile";
            // 
            // lblUi03
            // 
            lblUi03.AutoSize = true;
            lblUi03.Location = new Point(147, 159);
            lblUi03.Name = "lblUi03";
            lblUi03.Size = new Size(59, 21);
            lblUi03.TabIndex = 0;
            lblUi03.Text = "Terület:";
            // 
            // lblUi04
            // 
            lblUi04.AutoSize = true;
            lblUi04.Location = new Point(125, 214);
            lblUi04.Name = "lblUi04";
            lblUi04.Size = new Size(81, 21);
            lblUi04.TabIndex = 0;
            lblUi04.Text = "Népesség:";
            // 
            // lblUi05
            // 
            lblUi05.AutoSize = true;
            lblUi05.Location = new Point(138, 269);
            lblUi05.Name = "lblUi05";
            lblUi05.Size = new Size(68, 21);
            lblUi05.TabIndex = 0;
            lblUi05.Text = "Főváros:";
            // 
            // lblUi06
            // 
            lblUi06.AutoSize = true;
            lblUi06.Location = new Point(66, 324);
            lblUi06.Name = "lblUi06";
            lblUi06.Size = new Size(140, 21);
            lblUi06.TabIndex = 0;
            lblUi06.Text = "Főváros lakossága:";
            // 
            // lblUi01
            // 
            lblUi01.Font = new Font("Segoe UI", 22F);
            lblUi01.Location = new Point(12, 9);
            lblUi01.Name = "lblUi01";
            lblUi01.Size = new Size(560, 75);
            lblUi01.TabIndex = 0;
            lblUi01.Text = "Új ország felvétele";
            lblUi01.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTerulet
            // 
            txtTerulet.Location = new Point(212, 156);
            txtTerulet.Name = "txtTerulet";
            txtTerulet.Size = new Size(211, 29);
            txtTerulet.TabIndex = 2;
            txtTerulet.Text = "756950";
            txtTerulet.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNepesseg
            // 
            txtNepesseg.Location = new Point(212, 211);
            txtNepesseg.Name = "txtNepesseg";
            txtNepesseg.Size = new Size(211, 29);
            txtNepesseg.TabIndex = 2;
            txtNepesseg.Text = "19458000";
            txtNepesseg.TextAlign = HorizontalAlignment.Right;
            // 
            // txtFovaros
            // 
            txtFovaros.Location = new Point(212, 266);
            txtFovaros.Name = "txtFovaros";
            txtFovaros.Size = new Size(211, 29);
            txtFovaros.TabIndex = 2;
            txtFovaros.Text = "Santiago";
            // 
            // txtFovarosLakossag
            // 
            txtFovarosLakossag.Location = new Point(212, 321);
            txtFovarosLakossag.Name = "txtFovarosLakossag";
            txtFovarosLakossag.Size = new Size(211, 29);
            txtFovarosLakossag.TabIndex = 2;
            txtFovarosLakossag.Text = "6257516";
            txtFovarosLakossag.TextAlign = HorizontalAlignment.Right;
            // 
            // btnMentes
            // 
            btnMentes.Location = new Point(469, 101);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(103, 79);
            btnMentes.TabIndex = 1;
            btnMentes.Text = "mentés";
            btnMentes.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            lblInfo.Location = new Point(12, 387);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(560, 122);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Kérem adja meg az adatokat!";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmAdatbovites
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(txtFovarosLakossag);
            Controls.Add(txtFovaros);
            Controls.Add(txtNepesseg);
            Controls.Add(txtTerulet);
            Controls.Add(txtOrszagNev);
            Controls.Add(btnMentes);
            Controls.Add(btnKilepes);
            Controls.Add(lblInfo);
            Controls.Add(lblUi06);
            Controls.Add(lblUi05);
            Controls.Add(lblUi04);
            Controls.Add(lblUi03);
            Controls.Add(lblUi01);
            Controls.Add(lblUi02);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmAdatbovites";
            Text = "Új ország felvétele";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUi02;
        private Button btnKilepes;
        private TextBox txtOrszagNev;
        private Label lblUi03;
        private Label lblUi04;
        private Label lblUi05;
        private Label lblUi06;
        private Label lblUi01;
        private TextBox txtTerulet;
        private TextBox txtNepesseg;
        private TextBox txtFovaros;
        private TextBox txtFovarosLakossag;
        private Button btnMentes;
        private Label lblInfo;
    }
}
