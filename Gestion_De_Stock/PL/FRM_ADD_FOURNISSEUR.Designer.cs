namespace Gestion_De_Stock.PL
{
    partial class FRM_ADD_FOURNISSEUR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADD_FOURNISSEUR));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomFour = new System.Windows.Forms.TextBox();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgListe = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.exportToPdfAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.eportToPdfSingle = new System.Windows.Forms.Button();
            this.btnPrintSingel = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListe)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fournisseurs";
            // 
            // txtNomFour
            // 
            this.txtNomFour.Location = new System.Drawing.Point(178, 65);
            this.txtNomFour.Name = "txtNomFour";
            this.txtNomFour.Size = new System.Drawing.Size(220, 23);
            this.txtNomFour.TabIndex = 1;
            // 
            // txtPC
            // 
            this.txtPC.Location = new System.Drawing.Point(179, 101);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(220, 23);
            this.txtPC.TabIndex = 3;
            this.txtPC.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personne a contacter";
            // 
            // txtPP
            // 
            this.txtPP.Location = new System.Drawing.Point(178, 137);
            this.txtPP.Name = "txtPP";
            this.txtPP.Size = new System.Drawing.Size(220, 23);
            this.txtPP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prénom de la personne";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(179, 209);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtA.Size = new System.Drawing.Size(220, 72);
            this.txtA.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adresse";
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(179, 173);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(220, 23);
            this.txtT.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Téléphone";
            // 
            // btnFirst
            // 
            this.btnFirst.ImageIndex = 12;
            this.btnFirst.ImageList = this.imageList1;
            this.btnFirst.Location = new System.Drawing.Point(30, 298);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(57, 23);
            this.btnFirst.TabIndex = 10;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "disk.png");
            this.imageList1.Images.SetKeyName(2, "cancel.png");
            this.imageList1.Images.SetKeyName(3, "arrow_refresh.png");
            this.imageList1.Images.SetKeyName(4, "accept.png");
            this.imageList1.Images.SetKeyName(5, "zoom.png");
            this.imageList1.Images.SetKeyName(6, "control_end.png");
            this.imageList1.Images.SetKeyName(7, "control_fastforward.png");
            this.imageList1.Images.SetKeyName(8, "control_rewind.png");
            this.imageList1.Images.SetKeyName(9, "control_start.png");
            this.imageList1.Images.SetKeyName(10, "printer.png");
            this.imageList1.Images.SetKeyName(11, "printer_empty.png");
            this.imageList1.Images.SetKeyName(12, "resultset_first.png");
            this.imageList1.Images.SetKeyName(13, "resultset_last.png");
            this.imageList1.Images.SetKeyName(14, "resultset_next.png");
            this.imageList1.Images.SetKeyName(15, "resultset_previous.png");
            this.imageList1.Images.SetKeyName(16, "cross.png");
            this.imageList1.Images.SetKeyName(17, "b_pdfdoc.png");
            this.imageList1.Images.SetKeyName(18, "pdf.png");
            // 
            // btnPrevious
            // 
            this.btnPrevious.ImageIndex = 15;
            this.btnPrevious.ImageList = this.imageList1;
            this.btnPrevious.Location = new System.Drawing.Point(93, 298);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(57, 23);
            this.btnPrevious.TabIndex = 11;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(177, 29);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(220, 23);
            this.txtID.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID";
            // 
            // btnLast
            // 
            this.btnLast.ImageIndex = 13;
            this.btnLast.ImageList = this.imageList1;
            this.btnLast.Location = new System.Drawing.Point(335, 298);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(57, 23);
            this.btnLast.TabIndex = 15;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.ImageIndex = 14;
            this.btnNext.ImageList = this.imageList1;
            this.btnNext.Location = new System.Drawing.Point(272, 298);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(57, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPosition);
            this.groupBox1.Controls.Add(this.txtPP);
            this.groupBox1.Controls.Add(this.btnLast);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.txtNomFour);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPC);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtT);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 349);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information des Fournisseurs";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(195, 299);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(50, 19);
            this.lblPosition.TabIndex = 16;
            this.lblPosition.Text = "label7";
            this.lblPosition.Click += new System.EventHandler(this.lblPosition_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgListe);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(431, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 349);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste de tout les fournisseur";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgListe
            // 
            this.dgListe.AllowUserToDeleteRows = false;
            this.dgListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListe.Location = new System.Drawing.Point(13, 22);
            this.dgListe.Name = "dgListe";
            this.dgListe.ReadOnly = true;
            this.dgListe.Size = new System.Drawing.Size(619, 321);
            this.dgListe.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.exportToPdfAll);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.eportToPdfSingle);
            this.groupBox3.Controls.Add(this.btnPrintSingel);
            this.groupBox3.Controls.Add(this.btnPrintAll);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.btnNew);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1057, 135);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Les options possible";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // exportToPdfAll
            // 
            this.exportToPdfAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToPdfAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportToPdfAll.ImageIndex = 17;
            this.exportToPdfAll.ImageList = this.imageList1;
            this.exportToPdfAll.Location = new System.Drawing.Point(81, 76);
            this.exportToPdfAll.Name = "exportToPdfAll";
            this.exportToPdfAll.Size = new System.Drawing.Size(344, 23);
            this.exportToPdfAll.TabIndex = 9;
            this.exportToPdfAll.Text = "Enregistrer la liste des fournisseurs dans un fichier pdf";
            this.exportToPdfAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportToPdfAll.UseVisualStyleBackColor = true;
            this.exportToPdfAll.Click += new System.EventHandler(this.exportToPdfAll_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.ImageIndex = 16;
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(834, 76);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Quitter";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // eportToPdfSingle
            // 
            this.eportToPdfSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eportToPdfSingle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eportToPdfSingle.ImageIndex = 18;
            this.eportToPdfSingle.ImageList = this.imageList1;
            this.eportToPdfSingle.Location = new System.Drawing.Point(480, 76);
            this.eportToPdfSingle.Name = "eportToPdfSingle";
            this.eportToPdfSingle.Size = new System.Drawing.Size(290, 23);
            this.eportToPdfSingle.TabIndex = 7;
            this.eportToPdfSingle.Text = "Enregistrer de fournisseur dans un fichier pdf";
            this.eportToPdfSingle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eportToPdfSingle.UseVisualStyleBackColor = true;
            this.eportToPdfSingle.Click += new System.EventHandler(this.eportToPdfSingle_Click);
            // 
            // btnPrintSingel
            // 
            this.btnPrintSingel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSingel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintSingel.ImageIndex = 11;
            this.btnPrintSingel.ImageList = this.imageList1;
            this.btnPrintSingel.Location = new System.Drawing.Point(781, 34);
            this.btnPrintSingel.Name = "btnPrintSingel";
            this.btnPrintSingel.Size = new System.Drawing.Size(235, 23);
            this.btnPrintSingel.TabIndex = 5;
            this.btnPrintSingel.Text = "Imprimer  le fournisseur sélectionné";
            this.btnPrintSingel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintSingel.UseVisualStyleBackColor = true;
            this.btnPrintSingel.Click += new System.EventHandler(this.btnPrintSingel_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintAll.ImageIndex = 10;
            this.btnPrintAll.ImageList = this.imageList1;
            this.btnPrintAll.Location = new System.Drawing.Point(544, 34);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(192, 23);
            this.btnPrintAll.TabIndex = 4;
            this.btnPrintAll.Text = "Imprimer tout les fournisseur";
            this.btnPrintAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.ImageIndex = 3;
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(416, 34);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Éditer";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.ImageIndex = 2;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(290, 34);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.ImageIndex = 1;
            this.btnAdd.ImageList = this.imageList1;
            this.btnAdd.Location = new System.Drawing.Point(167, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.ImageIndex = 0;
            this.btnNew.ImageList = this.imageList1;
            this.btnNew.Location = new System.Drawing.Point(40, 34);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(84, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nouveau";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FRM_ADD_FOURNISSEUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1076, 535);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ADD_FOURNISSEUR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FROURNISSEUR";
            this.Load += new System.EventHandler(this.FRM_ADD_FOURNISSEUR_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListe)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomFour;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgListe;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button eportToPdfSingle;
        private System.Windows.Forms.Button btnPrintSingel;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button exportToPdfAll;
        private System.Windows.Forms.ImageList imageList1;
    }
}