
namespace ppelourd
{
    partial class InsertProduit
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
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelVerif = new System.Windows.Forms.Label();
            this.nudprix = new System.Windows.Forms.NumericUpDown();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtMots = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudprix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formulaire d\'Insertion de Produit\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Libelle";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(140, 124);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(214, 22);
            this.txtLibelle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mots Clés";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantité";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(222, 446);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 38);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Annuler";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(347, 446);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(105, 38);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Ajouter";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelVerif
            // 
            this.labelVerif.AutoSize = true;
            this.labelVerif.Location = new System.Drawing.Point(207, 387);
            this.labelVerif.Name = "labelVerif";
            this.labelVerif.Size = new System.Drawing.Size(46, 17);
            this.labelVerif.TabIndex = 12;
            this.labelVerif.Text = "label6";
            this.labelVerif.Visible = false;
            // 
            // nudprix
            // 
            this.nudprix.Location = new System.Drawing.Point(137, 318);
            this.nudprix.Name = "nudprix";
            this.nudprix.Size = new System.Drawing.Size(217, 22);
            this.nudprix.TabIndex = 13;
            // 
            // nudQuantite
            // 
            this.nudQuantite.Location = new System.Drawing.Point(137, 270);
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(217, 22);
            this.nudQuantite.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Prix";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(137, 221);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(217, 22);
            this.txtdesc.TabIndex = 16;
            // 
            // txtMots
            // 
            this.txtMots.Location = new System.Drawing.Point(137, 173);
            this.txtMots.Name = "txtMots";
            this.txtMots.Size = new System.Drawing.Size(216, 22);
            this.txtMots.TabIndex = 17;
            // 
            // insertSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 511);
            this.Controls.Add(this.txtMots);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudQuantite);
            this.Controls.Add(this.nudprix);
            this.Controls.Add(this.labelVerif);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "insertSalon";
            this.Text = "Formulaire de création de salon";
            ((System.ComponentModel.ISupportInitialize)(this.nudprix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labelVerif;
        private System.Windows.Forms.NumericUpDown nudprix;
        private System.Windows.Forms.NumericUpDown nudQuantite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtMots;
    }
}