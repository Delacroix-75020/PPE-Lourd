
namespace ppelourd
{
    partial class admin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabParticipant = new System.Windows.Forms.TabPage();
            this.btnDeleteParticipant = new System.Windows.Forms.Button();
            this.DGVClient = new System.Windows.Forms.DataGridView();
            this.tabSalon = new System.Windows.Forms.TabPage();
            this.btnDeleteProduit = new System.Windows.Forms.Button();
            this.btnAddProduit = new System.Windows.Forms.Button();
            this.DGVProduit = new System.Windows.Forms.DataGridView();
            this.tabConnexion = new System.Windows.Forms.TabPage();
            this.DGVJournal = new System.Windows.Forms.DataGridView();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.btndeleteAdmin = new System.Windows.Forms.Button();
            this.DGVAdmin = new System.Windows.Forms.DataGridView();
            this.insertoperator = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabParticipant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClient)).BeginInit();
            this.tabSalon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduit)).BeginInit();
            this.tabConnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVJournal)).BeginInit();
            this.tabUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrateur :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabParticipant);
            this.tabControl1.Controls.Add(this.tabSalon);
            this.tabControl1.Controls.Add(this.tabConnexion);
            this.tabControl1.Controls.Add(this.tabUser);
            this.tabControl1.Location = new System.Drawing.Point(12, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 519);
            this.tabControl1.TabIndex = 1;
            // 
            // tabParticipant
            // 
            this.tabParticipant.Controls.Add(this.btnDeleteParticipant);
            this.tabParticipant.Controls.Add(this.DGVClient);
            this.tabParticipant.Location = new System.Drawing.Point(4, 25);
            this.tabParticipant.Name = "tabParticipant";
            this.tabParticipant.Padding = new System.Windows.Forms.Padding(3);
            this.tabParticipant.Size = new System.Drawing.Size(1004, 490);
            this.tabParticipant.TabIndex = 0;
            this.tabParticipant.Text = "Client";
            this.tabParticipant.UseVisualStyleBackColor = true;
            // 
            // btnDeleteParticipant
            // 
            this.btnDeleteParticipant.Location = new System.Drawing.Point(15, 434);
            this.btnDeleteParticipant.Name = "btnDeleteParticipant";
            this.btnDeleteParticipant.Size = new System.Drawing.Size(101, 42);
            this.btnDeleteParticipant.TabIndex = 3;
            this.btnDeleteParticipant.Text = "Supprimer Client";
            this.btnDeleteParticipant.UseVisualStyleBackColor = true;
            this.btnDeleteParticipant.Click += new System.EventHandler(this.btnDeleteParticipant_Click);
            // 
            // DGVClient
            // 
            this.DGVClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClient.Location = new System.Drawing.Point(0, 3);
            this.DGVClient.Name = "DGVClient";
            this.DGVClient.RowHeadersWidth = 51;
            this.DGVClient.RowTemplate.Height = 24;
            this.DGVClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVClient.Size = new System.Drawing.Size(998, 425);
            this.DGVClient.TabIndex = 0;
            this.DGVClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVClient_CellContentClick);
            this.DGVClient.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVParticipant_CellEndEdit);
            // 
            // tabSalon
            // 
            this.tabSalon.Controls.Add(this.btnDeleteProduit);
            this.tabSalon.Controls.Add(this.btnAddProduit);
            this.tabSalon.Controls.Add(this.DGVProduit);
            this.tabSalon.Location = new System.Drawing.Point(4, 25);
            this.tabSalon.Name = "tabSalon";
            this.tabSalon.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalon.Size = new System.Drawing.Size(1004, 490);
            this.tabSalon.TabIndex = 1;
            this.tabSalon.Text = "Produit";
            this.tabSalon.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduit
            // 
            this.btnDeleteProduit.Location = new System.Drawing.Point(134, 428);
            this.btnDeleteProduit.Name = "btnDeleteProduit";
            this.btnDeleteProduit.Size = new System.Drawing.Size(90, 51);
            this.btnDeleteProduit.TabIndex = 3;
            this.btnDeleteProduit.Text = "Supprmier Produit";
            this.btnDeleteProduit.UseVisualStyleBackColor = true;
            this.btnDeleteProduit.Click += new System.EventHandler(this.btnDeleteSalon_Click);
            // 
            // btnAddProduit
            // 
            this.btnAddProduit.Location = new System.Drawing.Point(17, 428);
            this.btnAddProduit.Name = "btnAddProduit";
            this.btnAddProduit.Size = new System.Drawing.Size(90, 51);
            this.btnAddProduit.TabIndex = 1;
            this.btnAddProduit.Text = "Ajouter Produit";
            this.btnAddProduit.UseVisualStyleBackColor = true;
            this.btnAddProduit.Click += new System.EventHandler(this.btnAddProduit_Click);
            // 
            // DGVProduit
            // 
            this.DGVProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProduit.Location = new System.Drawing.Point(-4, 1);
            this.DGVProduit.Name = "DGVProduit";
            this.DGVProduit.RowHeadersWidth = 51;
            this.DGVProduit.RowTemplate.Height = 24;
            this.DGVProduit.Size = new System.Drawing.Size(1002, 421);
            this.DGVProduit.TabIndex = 0;
            this.DGVProduit.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSalon_CellEndEdit);
            // 
            // tabConnexion
            // 
            this.tabConnexion.Controls.Add(this.DGVJournal);
            this.tabConnexion.Location = new System.Drawing.Point(4, 25);
            this.tabConnexion.Name = "tabConnexion";
            this.tabConnexion.Size = new System.Drawing.Size(1004, 490);
            this.tabConnexion.TabIndex = 2;
            this.tabConnexion.Text = "Journal de connexion";
            this.tabConnexion.UseVisualStyleBackColor = true;
            // 
            // DGVJournal
            // 
            this.DGVJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVJournal.Location = new System.Drawing.Point(-4, 1);
            this.DGVJournal.Name = "DGVJournal";
            this.DGVJournal.RowHeadersWidth = 51;
            this.DGVJournal.RowTemplate.Height = 24;
            this.DGVJournal.Size = new System.Drawing.Size(1012, 508);
            this.DGVJournal.TabIndex = 0;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.btndeleteAdmin);
            this.tabUser.Controls.Add(this.DGVAdmin);
            this.tabUser.Controls.Add(this.insertoperator);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(1004, 490);
            this.tabUser.TabIndex = 3;
            this.tabUser.Text = "Employés/Admin";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // btndeleteAdmin
            // 
            this.btndeleteAdmin.Location = new System.Drawing.Point(158, 435);
            this.btndeleteAdmin.Name = "btndeleteAdmin";
            this.btndeleteAdmin.Size = new System.Drawing.Size(128, 46);
            this.btndeleteAdmin.TabIndex = 4;
            this.btndeleteAdmin.Text = "Supprimer Employé";
            this.btndeleteAdmin.UseVisualStyleBackColor = true;
            this.btndeleteAdmin.Click += new System.EventHandler(this.btndeleteAdmin_Click);
            // 
            // DGVAdmin
            // 
            this.DGVAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAdmin.Location = new System.Drawing.Point(0, 6);
            this.DGVAdmin.Name = "DGVAdmin";
            this.DGVAdmin.RowHeadersWidth = 51;
            this.DGVAdmin.RowTemplate.Height = 24;
            this.DGVAdmin.Size = new System.Drawing.Size(998, 411);
            this.DGVAdmin.TabIndex = 3;
            this.DGVAdmin.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAdmin_CellEndEdit);
            // 
            // insertoperator
            // 
            this.insertoperator.Location = new System.Drawing.Point(6, 435);
            this.insertoperator.Name = "insertoperator";
            this.insertoperator.Size = new System.Drawing.Size(128, 46);
            this.insertoperator.TabIndex = 2;
            this.insertoperator.Text = "Ajouter Employé";
            this.insertoperator.UseVisualStyleBackColor = true;
            this.insertoperator.Click += new System.EventHandler(this.insertoperator_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1086, 585);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "admin";
            this.Text = "Partie Administrateur";
            this.Load += new System.EventHandler(this.admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabParticipant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVClient)).EndInit();
            this.tabSalon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduit)).EndInit();
            this.tabConnexion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVJournal)).EndInit();
            this.tabUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabParticipant;
        private System.Windows.Forms.TabPage tabSalon;
        private System.Windows.Forms.TabPage tabConnexion;
        private System.Windows.Forms.Button btnDeleteParticipant;
        private System.Windows.Forms.DataGridView DGVJournal;
        private System.Windows.Forms.DataGridView DGVProduit;
        private System.Windows.Forms.Button btnDeleteProduit;
        private System.Windows.Forms.Button btnAddProduit;
        private System.Windows.Forms.DataGridView DGVClient;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.DataGridView DGVAdmin;
        private System.Windows.Forms.Button insertoperator;
        private System.Windows.Forms.Button btndeleteAdmin;
    }
}