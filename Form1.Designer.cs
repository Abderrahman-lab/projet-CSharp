namespace Gestion_Commerciale
{
    partial class Gestion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Quitter = new System.Windows.Forms.Button();
            this.Suprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.formulaireSC = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.TextBox();
            this.Adressee = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.Label();
            this.ClienID = new System.Windows.Forms.Label();
            this.Vider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.formulaireSC)).BeginInit();
            this.SuspendLayout();
            // 
            // Quitter
            // 
            this.Quitter.Location = new System.Drawing.Point(132, 343);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(75, 23);
            this.Quitter.TabIndex = 35;
            this.Quitter.Text = "QUITTER";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // Suprimer
            // 
            this.Suprimer.Location = new System.Drawing.Point(224, 297);
            this.Suprimer.Name = "Suprimer";
            this.Suprimer.Size = new System.Drawing.Size(75, 23);
            this.Suprimer.TabIndex = 34;
            this.Suprimer.Text = "SUPRIMER";
            this.Suprimer.UseVisualStyleBackColor = true;
            this.Suprimer.Click += new System.EventHandler(this.Suprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(132, 297);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 23);
            this.Modifier.TabIndex = 33;
            this.Modifier.Text = "MODIFIER";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(26, 297);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 32;
            this.Ajouter.Text = "AJOUTER";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // formulaireSC
            // 
            this.formulaireSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formulaireSC.Location = new System.Drawing.Point(330, 22);
            this.formulaireSC.Name = "formulaireSC";
            this.formulaireSC.Size = new System.Drawing.Size(544, 310);
            this.formulaireSC.TabIndex = 31;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(105, 59);
            this.Nom.Multiline = true;
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(219, 28);
            this.Nom.TabIndex = 30;
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(105, 96);
            this.Tel.Multiline = true;
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(219, 28);
            this.Tel.TabIndex = 29;
            // 
            // Adressee
            // 
            this.Adressee.Location = new System.Drawing.Point(105, 144);
            this.Adressee.Multiline = true;
            this.Adressee.Name = "Adressee";
            this.Adressee.Size = new System.Drawing.Size(219, 45);
            this.Adressee.TabIndex = 28;
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(105, 200);
            this.Mail.Multiline = true;
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(219, 28);
            this.Mail.TabIndex = 27;
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Numero.Location = new System.Drawing.Point(23, 59);
            this.Numero.Name = "Numero";
            this.Numero.Padding = new System.Windows.Forms.Padding(5);
            this.Numero.Size = new System.Drawing.Size(55, 27);
            this.Numero.TabIndex = 25;
            this.Numero.Text = "Nom :";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Email.Location = new System.Drawing.Point(20, 201);
            this.Email.Name = "Email";
            this.Email.Padding = new System.Windows.Forms.Padding(5);
            this.Email.Size = new System.Drawing.Size(60, 27);
            this.Email.TabIndex = 24;
            this.Email.Text = "Email :";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adresse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Adresse.Location = new System.Drawing.Point(11, 145);
            this.Adresse.Name = "Adresse";
            this.Adresse.Padding = new System.Windows.Forms.Padding(5);
            this.Adresse.Size = new System.Drawing.Size(78, 27);
            this.Adresse.TabIndex = 22;
            this.Adresse.Text = "Adresse :";
            // 
            // Telephone
            // 
            this.Telephone.AutoSize = true;
            this.Telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telephone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Telephone.Location = new System.Drawing.Point(3, 96);
            this.Telephone.Name = "Telephone";
            this.Telephone.Padding = new System.Windows.Forms.Padding(5);
            this.Telephone.Size = new System.Drawing.Size(94, 27);
            this.Telephone.TabIndex = 21;
            this.Telephone.Text = "Telephone :";
            // 
            // ClienID
            // 
            this.ClienID.AutoSize = true;
            this.ClienID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClienID.Location = new System.Drawing.Point(13, 22);
            this.ClienID.Name = "ClienID";
            this.ClienID.Padding = new System.Windows.Forms.Padding(5);
            this.ClienID.Size = new System.Drawing.Size(74, 27);
            this.ClienID.TabIndex = 20;
            this.ClienID.Text = "ClientID :";
            // 
            // Vider
            // 
            this.Vider.Location = new System.Drawing.Point(224, 343);
            this.Vider.Name = "Vider";
            this.Vider.Size = new System.Drawing.Size(75, 23);
            this.Vider.TabIndex = 36;
            this.Vider.Text = "VIDER";
            this.Vider.UseVisualStyleBackColor = true;
            this.Vider.Click += new System.EventHandler(this.Vider_Click);
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(871, 370);
            this.Controls.Add(this.Vider);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Suprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.formulaireSC);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.Adressee);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.ClienID);
            this.Name = "Gestion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formulaireSC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Button Suprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.DataGridView formulaireSC;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.TextBox Adressee;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.Label Telephone;
        private System.Windows.Forms.Label ClienID;
        private System.Windows.Forms.Button Vider;
    }
}

