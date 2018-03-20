namespace Thesaurus
{
    partial class frmThesaurus
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
            this.lblTittle = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLuck = new System.Windows.Forms.Button();
            this.cBoxTemp = new System.Windows.Forms.CheckBox();
            this.cBoxWeb = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(237, 28);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(284, 39);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Smart Thésaurus";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(64, 112);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(264, 20);
            this.txtBoxSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(64, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnLuck
            // 
            this.btnLuck.Location = new System.Drawing.Point(148, 138);
            this.btnLuck.Name = "btnLuck";
            this.btnLuck.Size = new System.Drawing.Size(105, 23);
            this.btnLuck.TabIndex = 3;
            this.btnLuck.Text = "J\'ai de la chance";
            this.btnLuck.UseVisualStyleBackColor = true;
            // 
            // cBoxTemp
            // 
            this.cBoxTemp.AutoSize = true;
            this.cBoxTemp.Checked = true;
            this.cBoxTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBoxTemp.Location = new System.Drawing.Point(495, 145);
            this.cBoxTemp.Name = "cBoxTemp";
            this.cBoxTemp.Size = new System.Drawing.Size(53, 17);
            this.cBoxTemp.TabIndex = 4;
            this.cBoxTemp.Text = "Temp";
            this.cBoxTemp.UseVisualStyleBackColor = true;
            // 
            // cBoxWeb
            // 
            this.cBoxWeb.AutoSize = true;
            this.cBoxWeb.Checked = true;
            this.cBoxWeb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBoxWeb.Location = new System.Drawing.Point(554, 145);
            this.cBoxWeb.Name = "cBoxWeb";
            this.cBoxWeb.Size = new System.Drawing.Size(55, 17);
            this.cBoxWeb.TabIndex = 5;
            this.cBoxWeb.Text = "ETML";
            this.cBoxWeb.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 358);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(592, 28);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Mettre à jour Thésaurus";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmThesaurus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cBoxWeb);
            this.Controls.Add(this.cBoxTemp);
            this.Controls.Add(this.btnLuck);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.lblTittle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmThesaurus";
            this.ShowIcon = false;
            this.Text = " Smart Thésaurus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLuck;
        private System.Windows.Forms.CheckBox cBoxTemp;
        private System.Windows.Forms.CheckBox cBoxWeb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
    }
}

