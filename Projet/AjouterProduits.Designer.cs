
namespace Projet
{
    partial class AjouterProduits
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
            this.dataGridViewProduit = new System.Windows.Forms.DataGridView();
            this.labelPrestation = new System.Windows.Forms.Label();
            this.textBoxPrestation = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.comboBoxEtat = new System.Windows.Forms.ComboBox();
            this.labelEtat = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.labelRecherche = new System.Windows.Forms.Label();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.labelnb = new System.Windows.Forms.Label();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // dataGridViewProduit
            // 
            this.dataGridViewProduit.AllowUserToAddRows = false;
            this.dataGridViewProduit.AllowUserToDeleteRows = false;
            this.dataGridViewProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduit.Location = new System.Drawing.Point(601, 89);
            this.dataGridViewProduit.Name = "dataGridViewProduit";
            this.dataGridViewProduit.RowHeadersWidth = 51;
            this.dataGridViewProduit.RowTemplate.Height = 29;
            this.dataGridViewProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProduit.Size = new System.Drawing.Size(809, 441);
            this.dataGridViewProduit.TabIndex = 1;
            this.dataGridViewProduit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduit_CellContentClick);
            this.dataGridViewProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduit_CellContentClick);
            // 
            // labelPrestation
            // 
            this.labelPrestation.AutoSize = true;
            this.labelPrestation.Location = new System.Drawing.Point(25, 109);
            this.labelPrestation.Name = "labelPrestation";
            this.labelPrestation.Size = new System.Drawing.Size(75, 20);
            this.labelPrestation.TabIndex = 2;
            this.labelPrestation.Text = "Prestation";
            // 
            // textBoxPrestation
            // 
            this.textBoxPrestation.Location = new System.Drawing.Point(151, 109);
            this.textBoxPrestation.Name = "textBoxPrestation";
            this.textBoxPrestation.Size = new System.Drawing.Size(201, 27);
            this.textBoxPrestation.TabIndex = 3;
            this.textBoxPrestation.TextChanged += new System.EventHandler(this.textBoxPrestation_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(35, 182);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(85, 20);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Location = new System.Drawing.Point(47, 256);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(33, 20);
            this.labelPrix.TabIndex = 5;
            this.labelPrix.Text = "Prix";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(151, 182);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(189, 27);
            this.textBoxDescription.TabIndex = 6;
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Location = new System.Drawing.Point(151, 241);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(189, 27);
            this.textBoxPrix.TabIndex = 7;
            // 
            // comboBoxEtat
            // 
            this.comboBoxEtat.FormattingEnabled = true;
            this.comboBoxEtat.Items.AddRange(new object[] {
            "Active",
            "Desactive"});
            this.comboBoxEtat.Location = new System.Drawing.Point(151, 313);
            this.comboBoxEtat.Name = "comboBoxEtat";
            this.comboBoxEtat.Size = new System.Drawing.Size(151, 28);
            this.comboBoxEtat.TabIndex = 8;
            // 
            // labelEtat
            // 
            this.labelEtat.AutoSize = true;
            this.labelEtat.Location = new System.Drawing.Point(47, 313);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(35, 20);
            this.labelEtat.TabIndex = 9;
            this.labelEtat.Text = "Etat";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(47, 432);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(110, 42);
            this.buttonAjouter.TabIndex = 10;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // labelRecherche
            // 
            this.labelRecherche.AutoSize = true;
            this.labelRecherche.Location = new System.Drawing.Point(611, 13);
            this.labelRecherche.Name = "labelRecherche";
            this.labelRecherche.Size = new System.Drawing.Size(77, 20);
            this.labelRecherche.TabIndex = 11;
            this.labelRecherche.Text = "Recherche";
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(694, 13);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(176, 27);
            this.textBoxRecherche.TabIndex = 12;
            this.textBoxRecherche.TextChanged += new System.EventHandler(this.textBoxRecherche_TextChanged);
            // 
            // labelnb
            // 
            this.labelnb.AutoSize = true;
            this.labelnb.Location = new System.Drawing.Point(821, 537);
            this.labelnb.Name = "labelnb";
            this.labelnb.Size = new System.Drawing.Size(163, 20);
            this.labelnb.TabIndex = 13;
            this.labelnb.Text = "Nombre de prestation :";
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(190, 432);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(107, 42);
            this.buttonModifier.TabIndex = 14;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(160, 52);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(125, 27);
            this.textBoxID.TabIndex = 15;
            this.textBoxID.Visible = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(35, 52);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(22, 20);
            this.labelID.TabIndex = 16;
            this.labelID.Text = "id";
            this.labelID.Visible = false;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(333, 433);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(101, 41);
            this.buttonSupprimer.TabIndex = 17;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // AjouterProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1432, 560);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.labelnb);
            this.Controls.Add(this.textBoxRecherche);
            this.Controls.Add(this.labelRecherche);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.labelEtat);
            this.Controls.Add(this.comboBoxEtat);
            this.Controls.Add(this.textBoxPrix);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxPrestation);
            this.Controls.Add(this.labelPrestation);
            this.Controls.Add(this.dataGridViewProduit);
            this.Controls.Add(this.label1);
            this.Name = "AjouterProduits";
            this.Text = "AjouterProduits";
            this.Load += new System.EventHandler(this.AjouterProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProduit;
        private System.Windows.Forms.Label labelPrestation;
        private System.Windows.Forms.TextBox textBoxPrestation;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.ComboBox comboBoxEtat;
        private System.Windows.Forms.Label labelEtat;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Label labelRecherche;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.Label labelnb;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonSupprimer;
    }
}