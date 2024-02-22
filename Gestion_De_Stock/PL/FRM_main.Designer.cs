namespace Gestion_De_Stock.PL
{
    partial class FRM_main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.créerUneSauvegardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurerUneSauvegardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnNouveauCatégoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnNouveauCatégoriesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBut = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlParametre = new System.Windows.Forms.Panel();
            this.btnDconx = new System.Windows.Forms.Button();
            this.btnRestaurer = new System.Windows.Forms.Button();
            this.btnCréer = new System.Windows.Forms.Button();
            this.btnConx = new System.Windows.Forms.Button();
            this.btnParametre = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnUserMenu = new System.Windows.Forms.Button();
            this.btnFourMenu = new System.Windows.Forms.Button();
            this.btnCatMenu = new System.Windows.Forms.Button();
            this.btnProduitMenu = new System.Windows.Forms.Button();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnNouveauProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeCatégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnNouvelUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlParametre.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.produitsToolStripMenuItem,
            this.catégoriesToolStripMenuItem,
            this.fournisseurToolStripMenuItem,
            this.utilisateursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.déconnexionToolStripMenuItem,
            this.toolStripSeparator1,
            this.créerUneSauvegardeToolStripMenuItem,
            this.restaurerUneSauvegardeToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            this.fichierToolStripMenuItem.Click += new System.EventHandler(this.fichierToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // créerUneSauvegardeToolStripMenuItem
            // 
            this.créerUneSauvegardeToolStripMenuItem.Name = "créerUneSauvegardeToolStripMenuItem";
            this.créerUneSauvegardeToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.créerUneSauvegardeToolStripMenuItem.Text = "Créer une sauvegarde";
            this.créerUneSauvegardeToolStripMenuItem.Click += new System.EventHandler(this.créerUneSauvegardeToolStripMenuItem_Click);
            // 
            // restaurerUneSauvegardeToolStripMenuItem
            // 
            this.restaurerUneSauvegardeToolStripMenuItem.Name = "restaurerUneSauvegardeToolStripMenuItem";
            this.restaurerUneSauvegardeToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.restaurerUneSauvegardeToolStripMenuItem.Text = "Restaurer une sauvegarde";
            // 
            // produitsToolStripMenuItem
            // 
            this.produitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnNouveauProduitToolStripMenuItem,
            this.gestionDeProduitToolStripMenuItem});
            this.produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            this.produitsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.produitsToolStripMenuItem.Text = "Produits";
            // 
            // catégoriesToolStripMenuItem
            // 
            this.catégoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnNouveauCatégoriesToolStripMenuItem,
            this.gestionDeCatégorieToolStripMenuItem});
            this.catégoriesToolStripMenuItem.Name = "catégoriesToolStripMenuItem";
            this.catégoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.catégoriesToolStripMenuItem.Text = "Catégories";
            // 
            // ajouterUnNouveauCatégoriesToolStripMenuItem
            // 
            this.ajouterUnNouveauCatégoriesToolStripMenuItem.Name = "ajouterUnNouveauCatégoriesToolStripMenuItem";
            this.ajouterUnNouveauCatégoriesToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.ajouterUnNouveauCatégoriesToolStripMenuItem.Text = "Ajouter un nouveau catégories";
            this.ajouterUnNouveauCatégoriesToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnNouveauCatégoriesToolStripMenuItem_Click);
            // 
            // fournisseurToolStripMenuItem
            // 
            this.fournisseurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnNouveauCatégoriesToolStripMenuItem1,
            this.gestionDeFournisseurToolStripMenuItem});
            this.fournisseurToolStripMenuItem.Name = "fournisseurToolStripMenuItem";
            this.fournisseurToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fournisseurToolStripMenuItem.Text = "Fournisseur";
            this.fournisseurToolStripMenuItem.Click += new System.EventHandler(this.fournisseurToolStripMenuItem_Click);
            // 
            // ajouterUnNouveauCatégoriesToolStripMenuItem1
            // 
            this.ajouterUnNouveauCatégoriesToolStripMenuItem1.Name = "ajouterUnNouveauCatégoriesToolStripMenuItem1";
            this.ajouterUnNouveauCatégoriesToolStripMenuItem1.Size = new System.Drawing.Size(243, 22);
            this.ajouterUnNouveauCatégoriesToolStripMenuItem1.Text = "Ajouter un nouveau Fournisseur";
            this.ajouterUnNouveauCatégoriesToolStripMenuItem1.Click += new System.EventHandler(this.ajouterUnNouveauCatégoriesToolStripMenuItem1_Click);
            // 
            // utilisateursToolStripMenuItem
            // 
            this.utilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnNouvelUtilisateurToolStripMenuItem,
            this.gestionDesUtilisateursToolStripMenuItem});
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.utilisateursToolStripMenuItem.Text = "Utilisateurs";
            // 
            // gestionDesUtilisateursToolStripMenuItem
            // 
            this.gestionDesUtilisateursToolStripMenuItem.Name = "gestionDesUtilisateursToolStripMenuItem";
            this.gestionDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.gestionDesUtilisateursToolStripMenuItem.Text = "Gestion des utilisateurs";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pnlBut);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnUserMenu);
            this.panel1.Controls.Add(this.btnFourMenu);
            this.panel1.Controls.Add(this.btnCatMenu);
            this.panel1.Controls.Add(this.btnProduitMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 537);
            this.panel1.TabIndex = 3;
            // 
            // pnlBut
            // 
            this.pnlBut.BackColor = System.Drawing.Color.Green;
            this.pnlBut.Location = new System.Drawing.Point(0, 104);
            this.pnlBut.Name = "pnlBut";
            this.pnlBut.Size = new System.Drawing.Size(10, 50);
            this.pnlBut.TabIndex = 5;
            this.pnlBut.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBut_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(223, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 10);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.pnlParametre);
            this.panel3.Controls.Add(this.btnParametre);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(223, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(568, 527);
            this.panel3.TabIndex = 5;
            // 
            // pnlParametre
            // 
            this.pnlParametre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlParametre.Controls.Add(this.btnDconx);
            this.pnlParametre.Controls.Add(this.btnRestaurer);
            this.pnlParametre.Controls.Add(this.btnCréer);
            this.pnlParametre.Controls.Add(this.btnConx);
            this.pnlParametre.Location = new System.Drawing.Point(36, 6);
            this.pnlParametre.Name = "pnlParametre";
            this.pnlParametre.Size = new System.Drawing.Size(312, 175);
            this.pnlParametre.TabIndex = 13;
            // 
            // btnDconx
            // 
            this.btnDconx.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDconx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnDconx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDconx.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDconx.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDconx.Image = global::Gestion_De_Stock.Properties.Resources.Deconnecte;
            this.btnDconx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDconx.Location = new System.Drawing.Point(3, 133);
            this.btnDconx.Name = "btnDconx";
            this.btnDconx.Size = new System.Drawing.Size(306, 37);
            this.btnDconx.TabIndex = 3;
            this.btnDconx.Text = "Déconnexion";
            this.btnDconx.UseVisualStyleBackColor = true;
            this.btnDconx.Click += new System.EventHandler(this.btnDconx_Click);
            // 
            // btnRestaurer
            // 
            this.btnRestaurer.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnRestaurer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnRestaurer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRestaurer.Image = global::Gestion_De_Stock.Properties.Resources.Download;
            this.btnRestaurer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurer.Location = new System.Drawing.Point(3, 90);
            this.btnRestaurer.Name = "btnRestaurer";
            this.btnRestaurer.Size = new System.Drawing.Size(306, 37);
            this.btnRestaurer.TabIndex = 2;
            this.btnRestaurer.Text = "Restaurer une sauvegarde";
            this.btnRestaurer.UseVisualStyleBackColor = true;
            // 
            // btnCréer
            // 
            this.btnCréer.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCréer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnCréer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCréer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCréer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCréer.Image = global::Gestion_De_Stock.Properties.Resources.Copier;
            this.btnCréer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCréer.Location = new System.Drawing.Point(3, 47);
            this.btnCréer.Name = "btnCréer";
            this.btnCréer.Size = new System.Drawing.Size(306, 37);
            this.btnCréer.TabIndex = 1;
            this.btnCréer.Text = "Créer une sauvegarde";
            this.btnCréer.UseVisualStyleBackColor = true;
            this.btnCréer.Click += new System.EventHandler(this.btnCréer_Click);
            // 
            // btnConx
            // 
            this.btnConx.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnConx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnConx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConx.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConx.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConx.Image = global::Gestion_De_Stock.Properties.Resources.Connected_16;
            this.btnConx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConx.Location = new System.Drawing.Point(3, 4);
            this.btnConx.Name = "btnConx";
            this.btnConx.Size = new System.Drawing.Size(306, 37);
            this.btnConx.TabIndex = 0;
            this.btnConx.Text = "Connexion";
            this.btnConx.UseVisualStyleBackColor = true;
            this.btnConx.Click += new System.EventHandler(this.btnConx_Click);
            // 
            // btnParametre
            // 
            this.btnParametre.FlatAppearance.BorderSize = 0;
            this.btnParametre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnParametre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametre.ForeColor = System.Drawing.Color.White;
            this.btnParametre.Image = global::Gestion_De_Stock.Properties.Resources.Settings_32;
            this.btnParametre.Location = new System.Drawing.Point(2, 4);
            this.btnParametre.Name = "btnParametre";
            this.btnParametre.Size = new System.Drawing.Size(31, 31);
            this.btnParametre.TabIndex = 12;
            this.btnParametre.UseVisualStyleBackColor = true;
            this.btnParametre.Click += new System.EventHandler(this.btnParametre_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::Gestion_De_Stock.Properties.Resources.Menu_32;
            this.btnMenu.Location = new System.Drawing.Point(186, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(31, 31);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnUserMenu
            // 
            this.btnUserMenu.FlatAppearance.BorderSize = 0;
            this.btnUserMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnUserMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserMenu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserMenu.ForeColor = System.Drawing.Color.White;
            this.btnUserMenu.Image = global::Gestion_De_Stock.Properties.Resources.customer_service_icon;
            this.btnUserMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserMenu.Location = new System.Drawing.Point(12, 434);
            this.btnUserMenu.Name = "btnUserMenu";
            this.btnUserMenu.Size = new System.Drawing.Size(211, 49);
            this.btnUserMenu.TabIndex = 8;
            this.btnUserMenu.Text = "           Utilisateurs";
            this.btnUserMenu.UseVisualStyleBackColor = true;
            this.btnUserMenu.Click += new System.EventHandler(this.btnUserMenu_Click);
            // 
            // btnFourMenu
            // 
            this.btnFourMenu.FlatAppearance.BorderSize = 0;
            this.btnFourMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnFourMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFourMenu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFourMenu.ForeColor = System.Drawing.Color.White;
            this.btnFourMenu.Image = global::Gestion_De_Stock.Properties.Resources.shopping_icon;
            this.btnFourMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFourMenu.Location = new System.Drawing.Point(12, 323);
            this.btnFourMenu.Name = "btnFourMenu";
            this.btnFourMenu.Size = new System.Drawing.Size(211, 49);
            this.btnFourMenu.TabIndex = 7;
            this.btnFourMenu.Text = "            Fournisseurs";
            this.btnFourMenu.UseVisualStyleBackColor = true;
            this.btnFourMenu.Click += new System.EventHandler(this.btnFourMenu_Click);
            // 
            // btnCatMenu
            // 
            this.btnCatMenu.FlatAppearance.BorderSize = 0;
            this.btnCatMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnCatMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatMenu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatMenu.ForeColor = System.Drawing.Color.White;
            this.btnCatMenu.Image = global::Gestion_De_Stock.Properties.Resources.Categorie;
            this.btnCatMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatMenu.Location = new System.Drawing.Point(12, 209);
            this.btnCatMenu.Name = "btnCatMenu";
            this.btnCatMenu.Size = new System.Drawing.Size(211, 49);
            this.btnCatMenu.TabIndex = 6;
            this.btnCatMenu.Text = "          Catégories";
            this.btnCatMenu.UseVisualStyleBackColor = true;
            this.btnCatMenu.Click += new System.EventHandler(this.btnCatMenu_Click);
            // 
            // btnProduitMenu
            // 
            this.btnProduitMenu.FlatAppearance.BorderSize = 0;
            this.btnProduitMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnProduitMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduitMenu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduitMenu.ForeColor = System.Drawing.Color.White;
            this.btnProduitMenu.Image = global::Gestion_De_Stock.Properties.Resources.shop_cart_add_icon;
            this.btnProduitMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduitMenu.Location = new System.Drawing.Point(12, 108);
            this.btnProduitMenu.Name = "btnProduitMenu";
            this.btnProduitMenu.Size = new System.Drawing.Size(211, 49);
            this.btnProduitMenu.TabIndex = 5;
            this.btnProduitMenu.Text = "    Produit";
            this.btnProduitMenu.UseVisualStyleBackColor = true;
            this.btnProduitMenu.Click += new System.EventHandler(this.btnProduitMenu_Click);
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Image = global::Gestion_De_Stock.Properties.Resources.connectmode;
            this.connexionToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.connexionToolStripMenuItem.Text = "Connexion";
            this.connexionToolStripMenuItem.Click += new System.EventHandler(this.connexionToolStripMenuItem_Click);
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Image = global::Gestion_De_Stock.Properties.Resources.Motdepasse_32;
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.déconnexionToolStripMenuItem_Click_1);
            // 
            // ajouterUnNouveauProduitToolStripMenuItem
            // 
            this.ajouterUnNouveauProduitToolStripMenuItem.Image = global::Gestion_De_Stock.Properties.Resources.shop_cart_add_icon;
            this.ajouterUnNouveauProduitToolStripMenuItem.Name = "ajouterUnNouveauProduitToolStripMenuItem";
            this.ajouterUnNouveauProduitToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ajouterUnNouveauProduitToolStripMenuItem.Text = "Ajouter un nouveau produit";
            this.ajouterUnNouveauProduitToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnNouveauProduitToolStripMenuItem_Click);
            // 
            // gestionDeProduitToolStripMenuItem
            // 
            this.gestionDeProduitToolStripMenuItem.Image = global::Gestion_De_Stock.Properties.Resources.shopping_icon;
            this.gestionDeProduitToolStripMenuItem.Name = "gestionDeProduitToolStripMenuItem";
            this.gestionDeProduitToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.gestionDeProduitToolStripMenuItem.Text = "Gestion de produit";
            this.gestionDeProduitToolStripMenuItem.Click += new System.EventHandler(this.gestionDeProduitToolStripMenuItem_Click);
            // 
            // gestionDeCatégorieToolStripMenuItem
            // 
            this.gestionDeCatégorieToolStripMenuItem.Image = global::Gestion_De_Stock.Properties.Resources.Categorie;
            this.gestionDeCatégorieToolStripMenuItem.Name = "gestionDeCatégorieToolStripMenuItem";
            this.gestionDeCatégorieToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.gestionDeCatégorieToolStripMenuItem.Text = "Gestion de catégorie";
            this.gestionDeCatégorieToolStripMenuItem.Click += new System.EventHandler(this.gestionDeCatégorieToolStripMenuItem_Click);
            // 
            // gestionDeFournisseurToolStripMenuItem
            // 
            this.gestionDeFournisseurToolStripMenuItem.Image = global::Gestion_De_Stock.Properties.Resources.adresse;
            this.gestionDeFournisseurToolStripMenuItem.Name = "gestionDeFournisseurToolStripMenuItem";
            this.gestionDeFournisseurToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.gestionDeFournisseurToolStripMenuItem.Text = "Gestion de fournisseur";
            this.gestionDeFournisseurToolStripMenuItem.Click += new System.EventHandler(this.gestionDeFournisseurToolStripMenuItem_Click);
            // 
            // ajouterUnNouvelUtilisateurToolStripMenuItem
            // 
            this.ajouterUnNouvelUtilisateurToolStripMenuItem.Image = global::Gestion_De_Stock.Properties.Resources.Office_Client_Male_Light_icon;
            this.ajouterUnNouvelUtilisateurToolStripMenuItem.Name = "ajouterUnNouvelUtilisateurToolStripMenuItem";
            this.ajouterUnNouvelUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.ajouterUnNouvelUtilisateurToolStripMenuItem.Text = "Ajouter un nouvel utilisateur";
            // 
            // FRM_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(791, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRM_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion De Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_main_FormClosing);
            this.Load += new System.EventHandler(this.FRM_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlParametre.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem créerUneSauvegardeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem restaurerUneSauvegardeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ajouterUnNouveauProduitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gestionDeProduitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem catégoriesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ajouterUnNouveauCatégoriesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gestionDeCatégorieToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ajouterUnNouveauCatégoriesToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem gestionDeFournisseurToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnNouvelUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.Button btnProduitMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUserMenu;
        private System.Windows.Forms.Button btnFourMenu;
        private System.Windows.Forms.Button btnCatMenu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlBut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlParametre;
        private System.Windows.Forms.Button btnParametre;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnDconx;
        public System.Windows.Forms.Button btnRestaurer;
        public System.Windows.Forms.Button btnCréer;
        public System.Windows.Forms.Button btnConx;
    }
}