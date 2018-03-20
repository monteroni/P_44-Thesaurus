namespace Thesaurus.view
{
    partial class frmUpdate
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.txtbUpdateTemp = new System.Windows.Forms.TextBox();
            this.txtbUpdateWeb = new System.Windows.Forms.TextBox();
            this.btnUpdateTemp = new System.Windows.Forms.Button();
            this.btnUpdateWeb = new System.Windows.Forms.Button();
            this.pnlUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(99, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(332, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mise à jour de la base de donnée";
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.txtbUpdateTemp);
            this.pnlUpdate.Controls.Add(this.txtbUpdateWeb);
            this.pnlUpdate.Controls.Add(this.btnUpdateTemp);
            this.pnlUpdate.Controls.Add(this.btnUpdateWeb);
            this.pnlUpdate.Controls.Add(this.lblTitle);
            this.pnlUpdate.Location = new System.Drawing.Point(12, 12);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(510, 321);
            this.pnlUpdate.TabIndex = 1;
            // 
            // txtbUpdateTemp
            // 
            this.txtbUpdateTemp.Location = new System.Drawing.Point(50, 161);
            this.txtbUpdateTemp.Name = "txtbUpdateTemp";
            this.txtbUpdateTemp.Size = new System.Drawing.Size(155, 20);
            this.txtbUpdateTemp.TabIndex = 4;
            // 
            // txtbUpdateWeb
            // 
            this.txtbUpdateWeb.Location = new System.Drawing.Point(289, 161);
            this.txtbUpdateWeb.Name = "txtbUpdateWeb";
            this.txtbUpdateWeb.Size = new System.Drawing.Size(169, 20);
            this.txtbUpdateWeb.TabIndex = 3;
            // 
            // btnUpdateTemp
            // 
            this.btnUpdateTemp.Location = new System.Drawing.Point(79, 187);
            this.btnUpdateTemp.Name = "btnUpdateTemp";
            this.btnUpdateTemp.Size = new System.Drawing.Size(100, 56);
            this.btnUpdateTemp.TabIndex = 2;
            this.btnUpdateTemp.Text = "synchronisation du Temps";
            this.btnUpdateTemp.UseVisualStyleBackColor = true;
            this.btnUpdateTemp.Click += new System.EventHandler(this.btnUpdateTemp_Click);
            // 
            // btnUpdateWeb
            // 
            this.btnUpdateWeb.Location = new System.Drawing.Point(322, 187);
            this.btnUpdateWeb.Name = "btnUpdateWeb";
            this.btnUpdateWeb.Size = new System.Drawing.Size(96, 56);
            this.btnUpdateWeb.TabIndex = 1;
            this.btnUpdateWeb.Text = "synchronisation du site Web";
            this.btnUpdateWeb.UseVisualStyleBackColor = true;
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 345);
            this.Controls.Add(this.pnlUpdate);
            this.Name = "frmUpdate";
            this.Text = "Mise à jour";
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.TextBox txtbUpdateTemp;
        private System.Windows.Forms.TextBox txtbUpdateWeb;
        private System.Windows.Forms.Button btnUpdateTemp;
        private System.Windows.Forms.Button btnUpdateWeb;
    }
}