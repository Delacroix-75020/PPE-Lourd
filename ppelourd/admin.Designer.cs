
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
            this.btnUpdateParticipant = new System.Windows.Forms.Button();
            this.btnAddParticipant = new System.Windows.Forms.Button();
            this.DGVClient = new System.Windows.Forms.DataGridView();
            this.tabSalon = new System.Windows.Forms.TabPage();
            this.btnDeleteSalon = new System.Windows.Forms.Button();
            this.btnUpdateSalon = new System.Windows.Forms.Button();
            this.btnAddSalon = new System.Windows.Forms.Button();
            this.DGVSalon = new System.Windows.Forms.DataGridView();
            this.tabConnexion = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.DGVAdmin = new System.Windows.Forms.DataGridView();
            this.insertoperator = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabParticipant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClient)).BeginInit();
            this.tabSalon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSalon)).BeginInit();
            this.tabConnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.tabParticipant.Controls.Add(this.btnUpdateParticipant);
            this.tabParticipant.Controls.Add(this.btnAddParticipant);
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
            this.btnDeleteParticipant.Location = new System.Drawing.Point(148, 434);
            this.btnDeleteParticipant.Name = "btnDeleteParticipant";
            this.btnDeleteParticipant.Size = new System.Drawing.Size(101, 42);
            this.btnDeleteParticipant.TabIndex = 3;
            this.btnDeleteParticipant.Text = "Supprimer Participant";
            this.btnDeleteParticipant.UseVisualStyleBackColor = true;
            this.btnDeleteParticipant.Click += new System.EventHandler(this.btnDeleteParticipant_Click);
            // 
            // btnUpdateParticipant
            // 
            this.btnUpdateParticipant.Location = new System.Drawing.Point(276, 434);
            this.btnUpdateParticipant.Name = "btnUpdateParticipant";
            this.btnUpdateParticipant.Size = new System.Drawing.Size(101, 42);
            this.btnUpdateParticipant.TabIndex = 2;
            this.btnUpdateParticipant.Text = "Modifier Participant";
            this.btnUpdateParticipant.UseVisualStyleBackColor = true;
            this.btnUpdateParticipant.Click += new System.EventHandler(this.btnUpdateParticipant_Click);
            // 
            // btnAddParticipant
            // 
            this.btnAddParticipant.Location = new System.Drawing.Point(20, 436);
            this.btnAddParticipant.Name = "btnAddParticipant";
            this.btnAddParticipant.Size = new System.Drawing.Size(101, 42);
            this.btnAddParticipant.TabIndex = 1;
            this.btnAddParticipant.Text = "Ajouter Participant";
            this.btnAddParticipant.UseVisualStyleBackColor = true;
            this.btnAddParticipant.Click += new System.EventHandler(this.btnAddParticipant_Click);
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
            this.DGVClient.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVParticipant_CellEndEdit);
            // 
            // tabSalon
            // 
            this.tabSalon.Controls.Add(this.btnDeleteSalon);
            this.tabSalon.Controls.Add(this.btnUpdateSalon);
            this.tabSalon.Controls.Add(this.btnAddSalon);
            this.tabSalon.Controls.Add(this.DGVSalon);
            this.tabSalon.Location = new System.Drawing.Point(4, 25);
            this.tabSalon.Name = "tabSalon";
            this.tabSalon.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalon.Size = new System.Drawing.Size(1004, 490);
            this.tabSalon.TabIndex = 1;
            this.tabSalon.Text = "Produit";
            this.tabSalon.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSalon
            // 
            this.btnDeleteSalon.Location = new System.Drawing.Point(313, 428);
            this.btnDeleteSalon.Name = "btnDeleteSalon";
            this.btnDeleteSalon.Size = new System.Drawing.Size(90, 51);
            this.btnDeleteSalon.TabIndex = 3;
            this.btnDeleteSalon.Text = "Supprmier Salon";
            this.btnDeleteSalon.UseVisualStyleBackColor = true;
            this.btnDeleteSalon.Click += new System.EventHandler(this.btnDeleteSalon_Click);
            // 
            // btnUpdateSalon
            // 
            this.btnUpdateSalon.Location = new System.Drawing.Point(159, 427);
            this.btnUpdateSalon.Name = "btnUpdateSalon";
            this.btnUpdateSalon.Size = new System.Drawing.Size(90, 51);
            this.btnUpdateSalon.TabIndex = 2;
            this.btnUpdateSalon.Text = "Modifier Salon";
            this.btnUpdateSalon.UseVisualStyleBackColor = true;
            this.btnUpdateSalon.Click += new System.EventHandler(this.btnUpdateSalon_Click);
            // 
            // btnAddSalon
            // 
            this.btnAddSalon.Location = new System.Drawing.Point(17, 428);
            this.btnAddSalon.Name = "btnAddSalon";
            this.btnAddSalon.Size = new System.Drawing.Size(90, 51);
            this.btnAddSalon.TabIndex = 1;
            this.btnAddSalon.Text = "Ajouter Salon";
            this.btnAddSalon.UseVisualStyleBackColor = true;
            this.btnAddSalon.Click += new System.EventHandler(this.btnAddSalon_Click);
            // 
            // DGVSalon
            // 
            this.DGVSalon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSalon.Location = new System.Drawing.Point(-4, 1);
            this.DGVSalon.Name = "DGVSalon";
            this.DGVSalon.RowHeadersWidth = 51;
            this.DGVSalon.RowTemplate.Height = 24;
            this.DGVSalon.Size = new System.Drawing.Size(1002, 421);
            this.DGVSalon.TabIndex = 0;
            this.DGVSalon.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSalon_CellEndEdit);
            // 
            // tabConnexion
            // 
            this.tabConnexion.Controls.Add(this.dataGridView2);
            this.tabConnexion.Location = new System.Drawing.Point(4, 25);
            this.tabConnexion.Name = "tabConnexion";
            this.tabConnexion.Size = new System.Drawing.Size(1004, 490);
            this.tabConnexion.TabIndex = 2;
            this.tabConnexion.Text = "Journal de connexion";
            this.tabConnexion.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-4, 1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1012, 508);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabUser
            // 
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
            // DGVAdmin
            // 
            this.DGVAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAdmin.Location = new System.Drawing.Point(6, 6);
            this.DGVAdmin.Name = "DGVAdmin";
            this.DGVAdmin.RowHeadersWidth = 51;
            this.DGVAdmin.RowTemplate.Height = 24;
            this.DGVAdmin.Size = new System.Drawing.Size(992, 411);
            this.DGVAdmin.TabIndex = 3;
            // 
            // insertoperator
            // 
            this.insertoperator.Location = new System.Drawing.Point(17, 435);
            this.insertoperator.Name = "insertoperator";
            this.insertoperator.Size = new System.Drawing.Size(89, 42);
            this.insertoperator.TabIndex = 2;
            this.insertoperator.Text = "Insertion d\'operateur";
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
            ((System.ComponentModel.ISupportInitialize)(this.DGVSalon)).EndInit();
            this.tabConnexion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Button btnUpdateParticipant;
        private System.Windows.Forms.Button btnAddParticipant;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView DGVSalon;
        private System.Windows.Forms.Button btnDeleteSalon;
        private System.Windows.Forms.Button btnUpdateSalon;
        private System.Windows.Forms.Button btnAddSalon;
        private System.Windows.Forms.DataGridView DGVClient;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.DataGridView DGVAdmin;
        private System.Windows.Forms.Button insertoperator;
    }
}