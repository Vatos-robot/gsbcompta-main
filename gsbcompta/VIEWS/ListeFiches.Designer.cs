
namespace gsbcompta
{
    partial class ListeFiches
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
            this.dataGridViewBills = new System.Windows.Forms.DataGridView();
            this.groupBoxFixedFees = new System.Windows.Forms.GroupBox();
            this.buttonFixedFeesUpdate = new System.Windows.Forms.Button();
            this.labelFixedFeesREP = new System.Windows.Forms.Label();
            this.labelFixedFeesNUI = new System.Windows.Forms.Label();
            this.labelFixedFeesKM = new System.Windows.Forms.Label();
            this.textBoxFixedFeesREP = new System.Windows.Forms.TextBox();
            this.textBoxFixedFeesNUI = new System.Windows.Forms.TextBox();
            this.textBoxFixedFeesKM = new System.Windows.Forms.TextBox();
            this.groupBoxOffPrice = new System.Windows.Forms.GroupBox();
            this.dataGridViewOffPrice = new System.Windows.Forms.DataGridView();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.cbxEtat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxEtat = new System.Windows.Forms.TextBox();
            this.btnUpdateEtat = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).BeginInit();
            this.groupBoxFixedFees.SuspendLayout();
            this.groupBoxOffPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffPrice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBills
            // 
            this.dataGridViewBills.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBills.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewBills.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewBills.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewBills.MultiSelect = false;
            this.dataGridViewBills.Name = "dataGridViewBills";
            this.dataGridViewBills.RowHeadersWidth = 51;
            this.dataGridViewBills.RowTemplate.Height = 24;
            this.dataGridViewBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBills.Size = new System.Drawing.Size(612, 306);
            this.dataGridViewBills.TabIndex = 0;
            this.dataGridViewBills.SelectionChanged += new System.EventHandler(this.dataGridViewBills_SelectionChanged);
            // 
            // groupBoxFixedFees
            // 
            this.groupBoxFixedFees.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxFixedFees.Controls.Add(this.buttonFixedFeesUpdate);
            this.groupBoxFixedFees.Controls.Add(this.labelFixedFeesREP);
            this.groupBoxFixedFees.Controls.Add(this.labelFixedFeesNUI);
            this.groupBoxFixedFees.Controls.Add(this.labelFixedFeesKM);
            this.groupBoxFixedFees.Controls.Add(this.textBoxFixedFeesREP);
            this.groupBoxFixedFees.Controls.Add(this.textBoxFixedFeesNUI);
            this.groupBoxFixedFees.Controls.Add(this.textBoxFixedFeesKM);
            this.groupBoxFixedFees.Location = new System.Drawing.Point(650, 34);
            this.groupBoxFixedFees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFixedFees.Name = "groupBoxFixedFees";
            this.groupBoxFixedFees.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFixedFees.Size = new System.Drawing.Size(315, 107);
            this.groupBoxFixedFees.TabIndex = 1;
            this.groupBoxFixedFees.TabStop = false;
            this.groupBoxFixedFees.Text = "Frais Forfait";
            // 
            // buttonFixedFeesUpdate
            // 
            this.buttonFixedFeesUpdate.Location = new System.Drawing.Point(226, 67);
            this.buttonFixedFeesUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFixedFeesUpdate.Name = "buttonFixedFeesUpdate";
            this.buttonFixedFeesUpdate.Size = new System.Drawing.Size(68, 19);
            this.buttonFixedFeesUpdate.TabIndex = 5;
            this.buttonFixedFeesUpdate.Text = "Modifier";
            this.buttonFixedFeesUpdate.UseVisualStyleBackColor = true;
            this.buttonFixedFeesUpdate.Click += new System.EventHandler(this.buttonFixedFeesUpdate_Click);
            // 
            // labelFixedFeesREP
            // 
            this.labelFixedFeesREP.AutoSize = true;
            this.labelFixedFeesREP.Location = new System.Drawing.Point(23, 67);
            this.labelFixedFeesREP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFixedFeesREP.Name = "labelFixedFeesREP";
            this.labelFixedFeesREP.Size = new System.Drawing.Size(38, 13);
            this.labelFixedFeesREP.TabIndex = 5;
            this.labelFixedFeesREP.Text = "Repas";
            // 
            // labelFixedFeesNUI
            // 
            this.labelFixedFeesNUI.AutoSize = true;
            this.labelFixedFeesNUI.Location = new System.Drawing.Point(188, 32);
            this.labelFixedFeesNUI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFixedFeesNUI.Name = "labelFixedFeesNUI";
            this.labelFixedFeesNUI.Size = new System.Drawing.Size(26, 13);
            this.labelFixedFeesNUI.TabIndex = 4;
            this.labelFixedFeesNUI.Text = "Nuit";
            // 
            // labelFixedFeesKM
            // 
            this.labelFixedFeesKM.AutoSize = true;
            this.labelFixedFeesKM.Location = new System.Drawing.Point(10, 31);
            this.labelFixedFeesKM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFixedFeesKM.Name = "labelFixedFeesKM";
            this.labelFixedFeesKM.Size = new System.Drawing.Size(55, 13);
            this.labelFixedFeesKM.TabIndex = 3;
            this.labelFixedFeesKM.Text = "Kilomètres";
            // 
            // textBoxFixedFeesREP
            // 
            this.textBoxFixedFeesREP.Location = new System.Drawing.Point(70, 63);
            this.textBoxFixedFeesREP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFixedFeesREP.Name = "textBoxFixedFeesREP";
            this.textBoxFixedFeesREP.Size = new System.Drawing.Size(76, 20);
            this.textBoxFixedFeesREP.TabIndex = 3;
            // 
            // textBoxFixedFeesNUI
            // 
            this.textBoxFixedFeesNUI.Location = new System.Drawing.Point(226, 28);
            this.textBoxFixedFeesNUI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFixedFeesNUI.Name = "textBoxFixedFeesNUI";
            this.textBoxFixedFeesNUI.Size = new System.Drawing.Size(76, 20);
            this.textBoxFixedFeesNUI.TabIndex = 4;
            // 
            // textBoxFixedFeesKM
            // 
            this.textBoxFixedFeesKM.Location = new System.Drawing.Point(70, 28);
            this.textBoxFixedFeesKM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFixedFeesKM.Name = "textBoxFixedFeesKM";
            this.textBoxFixedFeesKM.Size = new System.Drawing.Size(76, 20);
            this.textBoxFixedFeesKM.TabIndex = 2;
            // 
            // groupBoxOffPrice
            // 
            this.groupBoxOffPrice.Controls.Add(this.dataGridViewOffPrice);
            this.groupBoxOffPrice.Location = new System.Drawing.Point(12, 171);
            this.groupBoxOffPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOffPrice.Name = "groupBoxOffPrice";
            this.groupBoxOffPrice.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOffPrice.Size = new System.Drawing.Size(341, 179);
            this.groupBoxOffPrice.TabIndex = 2;
            this.groupBoxOffPrice.TabStop = false;
            this.groupBoxOffPrice.Text = "Frais Hors Forfait";
            // 
            // dataGridViewOffPrice
            // 
            this.dataGridViewOffPrice.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewOffPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffPrice.Location = new System.Drawing.Point(11, 17);
            this.dataGridViewOffPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewOffPrice.Name = "dataGridViewOffPrice";
            this.dataGridViewOffPrice.RowHeadersWidth = 51;
            this.dataGridViewOffPrice.RowTemplate.Height = 24;
            this.dataGridViewOffPrice.Size = new System.Drawing.Size(318, 146);
            this.dataGridViewOffPrice.TabIndex = 6;
            this.dataGridViewOffPrice.SelectionChanged += new System.EventHandler(this.dataGridViewOffPrice_SelectionChanged);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAddUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddUser.Location = new System.Drawing.Point(24, 376);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(318, 47);
            this.buttonAddUser.TabIndex = 7;
            this.buttonAddUser.Text = "AJOUTER UTILISATEUR";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // cbxEtat
            // 
            this.cbxEtat.FormattingEnabled = true;
            this.cbxEtat.Items.AddRange(new object[] {
            "CR",
            "CL",
            "VA",
            "RB"});
            this.cbxEtat.Location = new System.Drawing.Point(150, 392);
            this.cbxEtat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxEtat.Name = "cbxEtat";
            this.cbxEtat.Size = new System.Drawing.Size(314, 21);
            this.cbxEtat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 353);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Etat de la fiche de frais :";
            // 
            // txtBoxEtat
            // 
            this.txtBoxEtat.Enabled = false;
            this.txtBoxEtat.Location = new System.Drawing.Point(150, 353);
            this.txtBoxEtat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxEtat.Name = "txtBoxEtat";
            this.txtBoxEtat.Size = new System.Drawing.Size(314, 20);
            this.txtBoxEtat.TabIndex = 6;
            // 
            // btnUpdateEtat
            // 
            this.btnUpdateEtat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateEtat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEtat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateEtat.Location = new System.Drawing.Point(150, 445);
            this.btnUpdateEtat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateEtat.Name = "btnUpdateEtat";
            this.btnUpdateEtat.Size = new System.Drawing.Size(313, 47);
            this.btnUpdateEtat.TabIndex = 8;
            this.btnUpdateEtat.Text = "MODIFIER L\'ETAT DE LA FICHE";
            this.btnUpdateEtat.UseVisualStyleBackColor = false;
            this.btnUpdateEtat.Click += new System.EventHandler(this.btnUpdateEtat_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDisconnect.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDisconnect.Location = new System.Drawing.Point(647, 445);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(318, 47);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "DECONNEXION";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBoxOffPrice);
            this.panel1.Controls.Add(this.buttonAddUser);
            this.panel1.Location = new System.Drawing.Point(626, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 529);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(9, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 197);
            this.panel2.TabIndex = 11;
            // 
            // ListeFiches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 517);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnUpdateEtat);
            this.Controls.Add(this.txtBoxEtat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEtat);
            this.Controls.Add(this.groupBoxFixedFees);
            this.Controls.Add(this.dataGridViewBills);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ListeFiches";
            this.Text = "ListeFiches";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).EndInit();
            this.groupBoxFixedFees.ResumeLayout(false);
            this.groupBoxFixedFees.PerformLayout();
            this.groupBoxOffPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffPrice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBills;
        private System.Windows.Forms.GroupBox groupBoxFixedFees;
        private System.Windows.Forms.TextBox textBoxFixedFeesKM;
        private System.Windows.Forms.GroupBox groupBoxOffPrice;
        private System.Windows.Forms.TextBox textBoxFixedFeesREP;
        private System.Windows.Forms.TextBox textBoxFixedFeesNUI;
        private System.Windows.Forms.Label labelFixedFeesREP;
        private System.Windows.Forms.Label labelFixedFeesNUI;
        private System.Windows.Forms.Label labelFixedFeesKM;
        private System.Windows.Forms.DataGridView dataGridViewOffPrice;
        private System.Windows.Forms.Button buttonFixedFeesUpdate;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.ComboBox cbxEtat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxEtat;
        private System.Windows.Forms.Button btnUpdateEtat;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}