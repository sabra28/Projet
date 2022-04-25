
namespace Projet
{
    partial class AjouterClient
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
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.textBoxRechercheClient = new System.Windows.Forms.TextBox();
            this.labelRecherche = new System.Windows.Forms.Label();
            this.labelIDClient = new System.Windows.Forms.Label();
            this.textBoxIDClient = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.buttonAjouterClient = new System.Windows.Forms.Button();
            this.buttonModifierClient = new System.Windows.Forms.Button();
            this.buttonSupprimerClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClient.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(630, 73);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.RowTemplate.Height = 29;
            this.dataGridViewClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClient.Size = new System.Drawing.Size(809, 441);
            this.dataGridViewClient.TabIndex = 2;
            this.dataGridViewClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellContentClick);
            // 
            // textBoxRechercheClient
            // 
            this.textBoxRechercheClient.Location = new System.Drawing.Point(825, 26);
            this.textBoxRechercheClient.Name = "textBoxRechercheClient";
            this.textBoxRechercheClient.Size = new System.Drawing.Size(176, 27);
            this.textBoxRechercheClient.TabIndex = 13;
            this.textBoxRechercheClient.TextChanged += new System.EventHandler(this.textBoxRechercheClient_TextChanged);
            // 
            // labelRecherche
            // 
            this.labelRecherche.AutoSize = true;
            this.labelRecherche.Location = new System.Drawing.Point(726, 29);
            this.labelRecherche.Name = "labelRecherche";
            this.labelRecherche.Size = new System.Drawing.Size(77, 20);
            this.labelRecherche.TabIndex = 14;
            this.labelRecherche.Text = "Recherche";
            // 
            // labelIDClient
            // 
            this.labelIDClient.AutoSize = true;
            this.labelIDClient.Location = new System.Drawing.Point(38, 60);
            this.labelIDClient.Name = "labelIDClient";
            this.labelIDClient.Size = new System.Drawing.Size(22, 20);
            this.labelIDClient.TabIndex = 17;
            this.labelIDClient.Text = "id";
            this.labelIDClient.Visible = false;
            // 
            // textBoxIDClient
            // 
            this.textBoxIDClient.Location = new System.Drawing.Point(121, 60);
            this.textBoxIDClient.Name = "textBoxIDClient";
            this.textBoxIDClient.Size = new System.Drawing.Size(125, 27);
            this.textBoxIDClient.TabIndex = 18;
            this.textBoxIDClient.Visible = false;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(121, 129);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(201, 27);
            this.textBoxNom.TabIndex = 19;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(25, 129);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(42, 20);
            this.labelNom.TabIndex = 20;
            this.labelNom.Text = "Nom";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(121, 201);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(201, 27);
            this.textBoxPrenom.TabIndex = 21;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(25, 208);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(60, 20);
            this.labelPrenom.TabIndex = 22;
            this.labelPrenom.Text = "Prenom";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(121, 274);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(201, 27);
            this.textBoxAdresse.TabIndex = 23;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(25, 281);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(61, 20);
            this.labelAdresse.TabIndex = 24;
            this.labelAdresse.Text = "Adresse";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(121, 355);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(201, 27);
            this.textBoxTel.TabIndex = 25;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(25, 362);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(78, 20);
            this.labelTel.TabIndex = 26;
            this.labelTel.Text = "Telephone";
            // 
            // buttonAjouterClient
            // 
            this.buttonAjouterClient.Location = new System.Drawing.Point(38, 441);
            this.buttonAjouterClient.Name = "buttonAjouterClient";
            this.buttonAjouterClient.Size = new System.Drawing.Size(110, 42);
            this.buttonAjouterClient.TabIndex = 27;
            this.buttonAjouterClient.Text = "Ajouter";
            this.buttonAjouterClient.UseVisualStyleBackColor = true;
            this.buttonAjouterClient.Click += new System.EventHandler(this.buttonAjouterClient_Click);
            // 
            // buttonModifierClient
            // 
            this.buttonModifierClient.Location = new System.Drawing.Point(195, 441);
            this.buttonModifierClient.Name = "buttonModifierClient";
            this.buttonModifierClient.Size = new System.Drawing.Size(107, 42);
            this.buttonModifierClient.TabIndex = 28;
            this.buttonModifierClient.Text = "Modifier";
            this.buttonModifierClient.UseVisualStyleBackColor = true;
            this.buttonModifierClient.Click += new System.EventHandler(this.buttonModifierClient_Click);
            // 
            // buttonSupprimerClient
            // 
            this.buttonSupprimerClient.Location = new System.Drawing.Point(360, 442);
            this.buttonSupprimerClient.Name = "buttonSupprimerClient";
            this.buttonSupprimerClient.Size = new System.Drawing.Size(101, 41);
            this.buttonSupprimerClient.TabIndex = 29;
            this.buttonSupprimerClient.Text = "Supprimer";
            this.buttonSupprimerClient.UseVisualStyleBackColor = true;
            this.buttonSupprimerClient.Click += new System.EventHandler(this.buttonSupprimerClient_Click);
            // 
            // AjouterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1463, 526);
            this.Controls.Add(this.buttonSupprimerClient);
            this.Controls.Add(this.buttonModifierClient);
            this.Controls.Add(this.buttonAjouterClient);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxIDClient);
            this.Controls.Add(this.labelIDClient);
            this.Controls.Add(this.labelRecherche);
            this.Controls.Add(this.textBoxRechercheClient);
            this.Controls.Add(this.dataGridViewClient);
            this.Name = "AjouterClient";
            this.Text = "AjouterClient";
            this.Load += new System.EventHandler(this.AjouterClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.TextBox textBoxRechercheClient;
        private System.Windows.Forms.Label labelRecherche;
        private System.Windows.Forms.Label labelIDClient;
        private System.Windows.Forms.TextBox textBoxIDClient;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Button buttonAjouterClient;
        private System.Windows.Forms.Button buttonModifierClient;
        private System.Windows.Forms.Button buttonSupprimerClient;
    }
}