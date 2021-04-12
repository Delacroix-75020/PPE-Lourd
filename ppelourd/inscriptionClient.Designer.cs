
namespace ppelourd
{
    partial class inscriptionClient
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelVerif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulaire d\'Inscription";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(274, 396);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(118, 38);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Valider";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(120, 108);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(205, 22);
            this.txtusername.TabIndex = 6;
            this.txtusername.TextChanged += new System.EventHandler(this.txtnom_TextChanged);
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(120, 154);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(205, 22);
            this.txttel.TabIndex = 7;
            // 
            // txtadresse
            // 
            this.txtadresse.Location = new System.Drawing.Point(120, 195);
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(205, 22);
            this.txtadresse.TabIndex = 8;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(120, 234);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(205, 22);
            this.txtemail.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 38);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelVerif
            // 
            this.labelVerif.AutoSize = true;
            this.labelVerif.Location = new System.Drawing.Point(85, 313);
            this.labelVerif.Name = "labelVerif";
            this.labelVerif.Size = new System.Drawing.Size(46, 17);
            this.labelVerif.TabIndex = 11;
            this.labelVerif.Text = "label6";
            this.labelVerif.Visible = false;
            // 
            // inscriptionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(404, 446);
            this.Controls.Add(this.labelVerif);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtadresse);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "inscriptionClient";
            this.Text = "Formulaire d\'inscription";
            this.Load += new System.EventHandler(this.inscriptionParticipant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelVerif;
    }
}