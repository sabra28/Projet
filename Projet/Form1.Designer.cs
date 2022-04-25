
namespace Projet
{
    partial class Form1
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
            this.buttonPrestation = new System.Windows.Forms.Button();
            this.buttonCient = new System.Windows.Forms.Button();
            this.buttonCommande = new System.Windows.Forms.Button();
            this.Facture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrestation
            // 
            this.buttonPrestation.Location = new System.Drawing.Point(71, 75);
            this.buttonPrestation.Name = "buttonPrestation";
            this.buttonPrestation.Size = new System.Drawing.Size(131, 56);
            this.buttonPrestation.TabIndex = 0;
            this.buttonPrestation.Text = "Ajouter Prestation";
            this.buttonPrestation.UseVisualStyleBackColor = true;
            this.buttonPrestation.Click += new System.EventHandler(this.buttonPrestation_Click);
            // 
            // buttonCient
            // 
            this.buttonCient.Location = new System.Drawing.Point(71, 171);
            this.buttonCient.Name = "buttonCient";
            this.buttonCient.Size = new System.Drawing.Size(131, 65);
            this.buttonCient.TabIndex = 1;
            this.buttonCient.Text = "Ajouter Client";
            this.buttonCient.UseVisualStyleBackColor = true;
            this.buttonCient.Click += new System.EventHandler(this.buttonCient_Click);
            // 
            // buttonCommande
            // 
            this.buttonCommande.Location = new System.Drawing.Point(71, 281);
            this.buttonCommande.Name = "buttonCommande";
            this.buttonCommande.Size = new System.Drawing.Size(131, 68);
            this.buttonCommande.TabIndex = 2;
            this.buttonCommande.Text = "Ajouter Commande";
            this.buttonCommande.UseVisualStyleBackColor = true;
            this.buttonCommande.Click += new System.EventHandler(this.buttonCommande_Click);
            // 
            // Facture
            // 
            this.Facture.Location = new System.Drawing.Point(71, 393);
            this.Facture.Name = "Facture";
            this.Facture.Size = new System.Drawing.Size(131, 62);
            this.Facture.TabIndex = 3;
            this.Facture.Text = "Commande";
            this.Facture.UseVisualStyleBackColor = true;
            this.Facture.Click += new System.EventHandler(this.Facture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(747, 562);
            this.Controls.Add(this.Facture);
            this.Controls.Add(this.buttonCommande);
            this.Controls.Add(this.buttonCient);
            this.Controls.Add(this.buttonPrestation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrestation;
        private System.Windows.Forms.Button buttonCient;
        private System.Windows.Forms.Button buttonCommande;
        private System.Windows.Forms.Button Facture;
    }
}

