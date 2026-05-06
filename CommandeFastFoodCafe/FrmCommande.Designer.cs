namespace CommandeFastFoodCafe
{
    partial class FrmCommande
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
            grpChoixProduit = new GroupBox();
            grpCommande = new GroupBox();
            grpActions = new GroupBox();
            lblPrduit = new Label();
            lblQuantite = new Label();
            cmbProduit = new ComboBox();
            btnAjouter = new Button();
            numQuantite = new NumericUpDown();
            dgvCommande = new DataGridView();
            btnSupprimer = new Button();
            btnVider = new Button();
            lblTexteTotal = new Label();
            lblTotal = new Label();
            grpChoixProduit.SuspendLayout();
            grpCommande.SuspendLayout();
            grpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommande).BeginInit();
            SuspendLayout();
            // 
            // grpChoixProduit
            // 
            grpChoixProduit.Controls.Add(numQuantite);
            grpChoixProduit.Controls.Add(btnAjouter);
            grpChoixProduit.Controls.Add(cmbProduit);
            grpChoixProduit.Controls.Add(lblQuantite);
            grpChoixProduit.Controls.Add(lblPrduit);
            grpChoixProduit.Location = new Point(20, 20);
            grpChoixProduit.Name = "grpChoixProduit";
            grpChoixProduit.Size = new Size(300, 250);
            grpChoixProduit.TabIndex = 0;
            grpChoixProduit.TabStop = false;
            grpChoixProduit.Text = "Choix du produit";
            // 
            // grpCommande
            // 
            grpCommande.Controls.Add(dgvCommande);
            grpCommande.Location = new Point(332, 20);
            grpCommande.Name = "grpCommande";
            grpCommande.Size = new Size(640, 528);
            grpCommande.TabIndex = 1;
            grpCommande.TabStop = false;
            grpCommande.Text = "Commande en cours";
            // 
            // grpActions
            // 
            grpActions.Controls.Add(lblTotal);
            grpActions.Controls.Add(lblTexteTotal);
            grpActions.Controls.Add(btnVider);
            grpActions.Controls.Add(btnSupprimer);
            grpActions.Location = new Point(20, 290);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(300, 258);
            grpActions.TabIndex = 2;
            grpActions.TabStop = false;
            grpActions.Text = "Actions et total";
            // 
            // lblPrduit
            // 
            lblPrduit.AutoSize = true;
            lblPrduit.Location = new Point(20, 40);
            lblPrduit.Name = "lblPrduit";
            lblPrduit.Size = new Size(64, 20);
            lblPrduit.TabIndex = 0;
            lblPrduit.Tag = " ";
            lblPrduit.Text = "Produit :";
            // 
            // lblQuantite
            // 
            lblQuantite.AutoSize = true;
            lblQuantite.Location = new Point(20, 110);
            lblQuantite.Name = "lblQuantite";
            lblQuantite.Size = new Size(73, 20);
            lblQuantite.TabIndex = 1;
            lblQuantite.Text = "Quantité :";
            lblQuantite.Click += label2_Click;
            // 
            // cmbProduit
            // 
            cmbProduit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduit.FormattingEnabled = true;
            cmbProduit.Location = new Point(20, 65);
            cmbProduit.Name = "cmbProduit";
            cmbProduit.Size = new Size(240, 28);
            cmbProduit.TabIndex = 2;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(20, 185);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(180, 35);
            btnAjouter.TabIndex = 4;
            btnAjouter.Text = "Ajouter la commande";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += button1_Click;
            // 
            // numQuantite
            // 
            numQuantite.Location = new Point(20, 135);
            numQuantite.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numQuantite.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantite.Name = "numQuantite";
            numQuantite.Size = new Size(120, 27);
            numQuantite.TabIndex = 5;
            numQuantite.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dgvCommande
            // 
            dgvCommande.AllowUserToAddRows = false;
            dgvCommande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCommande.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommande.Location = new Point(20, 35);
            dgvCommande.MultiSelect = false;
            dgvCommande.Name = "dgvCommande";
            dgvCommande.ReadOnly = true;
            dgvCommande.RowHeadersVisible = false;
            dgvCommande.RowHeadersWidth = 51;
            dgvCommande.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCommande.Size = new Size(600, 340);
            dgvCommande.TabIndex = 0;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(20, 35);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(180, 35);
            btnSupprimer.TabIndex = 0;
            btnSupprimer.Text = "Supprimer l'article";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnVider
            // 
            btnVider.Location = new Point(20, 76);
            btnVider.Name = "btnVider";
            btnVider.Size = new Size(180, 35);
            btnVider.TabIndex = 1;
            btnVider.Text = "Vider la commande";
            btnVider.UseVisualStyleBackColor = true;
            // 
            // lblTexteTotal
            // 
            lblTexteTotal.AutoSize = true;
            lblTexteTotal.Location = new Point(20, 130);
            lblTexteTotal.Name = "lblTexteTotal";
            lblTexteTotal.Size = new Size(49, 20);
            lblTexteTotal.TabIndex = 2;
            lblTexteTotal.Tag = " ";
            lblTexteTotal.Text = "Total :";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(80, 130);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(62, 20);
            lblTotal.TabIndex = 3;
            lblTotal.Tag = " ";
            lblTotal.Text = "0,00 DH";
            // 
            // FrmCommande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(grpActions);
            Controls.Add(grpCommande);
            Controls.Add(grpChoixProduit);
            Name = "FrmCommande";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Commande Fast-Food";
            Load += FrmCommande_Load;
            grpChoixProduit.ResumeLayout(false);
            grpChoixProduit.PerformLayout();
            grpCommande.ResumeLayout(false);
            grpActions.ResumeLayout(false);
            grpActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantite).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommande).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpChoixProduit;
        private GroupBox grpCommande;
        private GroupBox grpActions;
        private NumericUpDown numQuantite;
        private Button btnAjouter;
        private ComboBox cmbProduit;
        private Label lblQuantite;
        private Label lblPrduit;
        private DataGridView dgvCommande;
        private Label lblTotal;
        private Label lblTexteTotal;
        private Button btnVider;
        private Button btnSupprimer;
    }
}
