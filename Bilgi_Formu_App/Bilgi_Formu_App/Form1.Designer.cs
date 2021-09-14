namespace Bilgi_Formu_App
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lvBilgiler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "TELEFON:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-MAİL:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "ADRES:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(149, 32);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(224, 22);
            this.txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(149, 66);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(224, 22);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(149, 100);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(224, 22);
            this.txtTelefon.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(149, 134);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(149, 172);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(224, 106);
            this.txtAdres.TabIndex = 9;
            // 
            // lvBilgiler
            // 
            this.lvBilgiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvBilgiler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvBilgiler.FullRowSelect = true;
            this.lvBilgiler.GridLines = true;
            this.lvBilgiler.Location = new System.Drawing.Point(0, 327);
            this.lvBilgiler.MultiSelect = false;
            this.lvBilgiler.Name = "lvBilgiler";
            this.lvBilgiler.Size = new System.Drawing.Size(847, 346);
            this.lvBilgiler.TabIndex = 10;
            this.lvBilgiler.UseCompatibleStateImageBehavior = false;
            this.lvBilgiler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ADI";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SOYADI";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TELEFON";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E-MAİL";
            this.columnHeader4.Width = 195;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ADRES";
            this.columnHeader5.Width = 316;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(466, 170);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(142, 43);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(466, 235);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(142, 43);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 673);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lvBilgiler);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.ListView lvBilgiler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
    }
}

