
namespace Projet
{
    partial class AjouterCommande
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
            this.labelIDCommande = new System.Windows.Forms.Label();
            this.textBoxIDCommande = new System.Windows.Forms.TextBox();
            this.labelClientCommande = new System.Windows.Forms.Label();
            this.comboBoxNomClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCommande = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonAjouterCommande = new System.Windows.Forms.Button();
            this.buttonSupCommande = new System.Windows.Forms.Button();
            this.btnModfifier = new System.Windows.Forms.Button();
            this.dataGridViewPresta = new System.Windows.Forms.DataGridView();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.dataGridViewPrestation = new System.Windows.Forms.DataGridView();
            this.Entrer = new System.Windows.Forms.Button();
            this.recapfacture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestation)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIDCommande
            // 
            this.labelIDCommande.AutoSize = true;
            this.labelIDCommande.Location = new System.Drawing.Point(62, 12);
            this.labelIDCommande.Name = "labelIDCommande";
            this.labelIDCommande.Size = new System.Drawing.Size(24, 20);
            this.labelIDCommande.TabIndex = 0;
            this.labelIDCommande.Text = "ID";
            this.labelIDCommande.Visible = false;
            // 
            // textBoxIDCommande
            // 
            this.textBoxIDCommande.Location = new System.Drawing.Point(155, 12);
            this.textBoxIDCommande.Name = "textBoxIDCommande";
            this.textBoxIDCommande.Size = new System.Drawing.Size(125, 27);
            this.textBoxIDCommande.TabIndex = 1;
            this.textBoxIDCommande.Visible = false;
            // 
            // labelClientCommande
            // 
            this.labelClientCommande.AutoSize = true;
            this.labelClientCommande.Location = new System.Drawing.Point(36, 53);
            this.labelClientCommande.Name = "labelClientCommande";
            this.labelClientCommande.Size = new System.Drawing.Size(80, 20);
            this.labelClientCommande.TabIndex = 2;
            this.labelClientCommande.Text = "NomClient";
            // 
            // comboBoxNomClient
            // 
            this.comboBoxNomClient.FormattingEnabled = true;
            this.comboBoxNomClient.Location = new System.Drawing.Point(140, 45);
            this.comboBoxNomClient.Name = "comboBoxNomClient";
            this.comboBoxNomClient.Size = new System.Drawing.Size(195, 28);
            this.comboBoxNomClient.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 5;
            // 
            // dataGridViewCommande
            // 
            this.dataGridViewCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommande.Location = new System.Drawing.Point(468, 5);
            this.dataGridViewCommande.Name = "dataGridViewCommande";
            this.dataGridViewCommande.RowHeadersWidth = 51;
            this.dataGridViewCommande.RowTemplate.Height = 29;
            this.dataGridViewCommande.Size = new System.Drawing.Size(813, 204);
            this.dataGridViewCommande.TabIndex = 6;
            this.dataGridViewCommande.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCommande_CellClick);
            this.dataGridViewCommande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCommande_CellContentClick);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(116, 100);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker.TabIndex = 7;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(45, 100);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(41, 20);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Date";
            // 
            // buttonAjouterCommande
            // 
            this.buttonAjouterCommande.Location = new System.Drawing.Point(320, 143);
            this.buttonAjouterCommande.Name = "buttonAjouterCommande";
            this.buttonAjouterCommande.Size = new System.Drawing.Size(94, 29);
            this.buttonAjouterCommande.TabIndex = 9;
            this.buttonAjouterCommande.Text = "Ajouter";
            this.buttonAjouterCommande.UseVisualStyleBackColor = true;
            this.buttonAjouterCommande.Click += new System.EventHandler(this.buttonAjouterCommande_Click);
            // 
            // buttonSupCommande
            // 
            this.buttonSupCommande.Location = new System.Drawing.Point(197, 143);
            this.buttonSupCommande.Name = "buttonSupCommande";
            this.buttonSupCommande.Size = new System.Drawing.Size(94, 29);
            this.buttonSupCommande.TabIndex = 10;
            this.buttonSupCommande.Text = "Supprimer";
            this.buttonSupCommande.UseVisualStyleBackColor = true;
            this.buttonSupCommande.Click += new System.EventHandler(this.buttonSupCommande_Click);
            // 
            // btnModfifier
            // 
            this.btnModfifier.Location = new System.Drawing.Point(45, 142);
            this.btnModfifier.Name = "btnModfifier";
            this.btnModfifier.Size = new System.Drawing.Size(94, 29);
            this.btnModfifier.TabIndex = 11;
            this.btnModfifier.Text = "Modifier";
            this.btnModfifier.UseVisualStyleBackColor = true;
            this.btnModfifier.Click += new System.EventHandler(this.btnSupprimerCommande_Click);
            // 
            // dataGridViewPresta
            // 
            this.dataGridViewPresta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPresta.Location = new System.Drawing.Point(36, 261);
            this.dataGridViewPresta.Name = "dataGridViewPresta";
            this.dataGridViewPresta.RowHeadersWidth = 51;
            this.dataGridViewPresta.RowTemplate.Height = 29;
            this.dataGridViewPresta.Size = new System.Drawing.Size(352, 257);
            this.dataGridViewPresta.TabIndex = 12;
            this.dataGridViewPresta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(416, 339);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(94, 29);
            this.buttonAjouter.TabIndex = 13;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // dataGridViewPrestation
            // 
            this.dataGridViewPrestation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestation.Location = new System.Drawing.Point(547, 261);
            this.dataGridViewPrestation.Name = "dataGridViewPrestation";
            this.dataGridViewPrestation.RowHeadersWidth = 51;
            this.dataGridViewPrestation.RowTemplate.Height = 29;
            this.dataGridViewPrestation.Size = new System.Drawing.Size(348, 257);
            this.dataGridViewPrestation.TabIndex = 14;
            this.dataGridViewPrestation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrestation_CellContentClick);
            // 
            // Entrer
            // 
            this.Entrer.Location = new System.Drawing.Point(1106, 339);
            this.Entrer.Name = "Entrer";
            this.Entrer.Size = new System.Drawing.Size(94, 29);
            this.Entrer.TabIndex = 15;
            this.Entrer.Text = "Entrer";
            this.Entrer.UseVisualStyleBackColor = true;
            this.Entrer.Click += new System.EventHandler(this.Entrer_Click);
            // 
            // recapfacture
            // 
            this.recapfacture.Location = new System.Drawing.Point(1106, 392);
            this.recapfacture.Name = "recapfacture";
            this.recapfacture.Size = new System.Drawing.Size(94, 29);
            this.recapfacture.TabIndex = 16;
            this.recapfacture.Text = "Facture";
            this.recapfacture.UseVisualStyleBackColor = true;
            this.recapfacture.Click += new System.EventHandler(this.recapfacture_Click);
            // 
            // AjouterCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1310, 540);
            this.Controls.Add(this.recapfacture);
            this.Controls.Add(this.Entrer);
            this.Controls.Add(this.dataGridViewPrestation);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.dataGridViewPresta);
            this.Controls.Add(this.btnModfifier);
            this.Controls.Add(this.buttonSupCommande);
            this.Controls.Add(this.buttonAjouterCommande);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dataGridViewCommande);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNomClient);
            this.Controls.Add(this.labelClientCommande);
            this.Controls.Add(this.textBoxIDCommande);
            this.Controls.Add(this.labelIDCommande);
            this.Name = "AjouterCommande";
            this.Text = "AjouterCommande";
            this.Load += new System.EventHandler(this.AjuterCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIDCommande;
        private System.Windows.Forms.TextBox textBoxIDCommande;
        private System.Windows.Forms.Label labelClientCommande;
        private System.Windows.Forms.ComboBox comboBoxNomClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCommande;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonAjouterCommande;
        private System.Windows.Forms.Button buttonSupCommande;
        private System.Windows.Forms.Button btnModfifier;
        private System.Windows.Forms.DataGridView dataGridViewPresta;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.DataGridView dataGridViewPrestation;
        private System.Windows.Forms.Button Entrer;
        private System.Windows.Forms.Button recapfacture;
    }
}