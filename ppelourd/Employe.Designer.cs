
namespace ppelourd
{
    partial class Employe
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
            this.cbProduit = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelnom = new System.Windows.Forms.Label();
            this.DGVBuy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produit";
            // 
            // cbProduit
            // 
            this.cbProduit.FormattingEnabled = true;
            this.cbProduit.Location = new System.Drawing.Point(101, 96);
            this.cbProduit.Name = "cbProduit";
            this.cbProduit.Size = new System.Drawing.Size(285, 24);
            this.cbProduit.TabIndex = 4;
            this.cbProduit.SelectedIndexChanged += new System.EventHandler(this.cbProduit_SelectedIndexChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(676, 19);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(65, 27);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "label3";
            // 
            // labelnom
            // 
            this.labelnom.AutoSize = true;
            this.labelnom.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnom.Location = new System.Drawing.Point(12, 19);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(89, 37);
            this.labelnom.TabIndex = 6;
            this.labelnom.Text = "label4";
            // 
            // DGVBuy
            // 
            this.DGVBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBuy.Location = new System.Drawing.Point(15, 163);
            this.DGVBuy.Name = "DGVBuy";
            this.DGVBuy.RowHeadersWidth = 51;
            this.DGVBuy.RowTemplate.Height = 24;
            this.DGVBuy.Size = new System.Drawing.Size(809, 288);
            this.DGVBuy.TabIndex = 7;
            // 
            // Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 463);
            this.Controls.Add(this.DGVBuy);
            this.Controls.Add(this.labelnom);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.cbProduit);
            this.Controls.Add(this.label1);
            this.Name = "Employe";
            this.Text = "Partie Employée ";
            this.Load += new System.EventHandler(this.Operateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProduit;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.DataGridView DGVBuy;
    }
}