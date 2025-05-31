namespace MediaTek86
{
    partial class FrmAbsences
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
            this.lblNomPersonnel = new System.Windows.Forms.Label();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.btnAjouterAbsence = new System.Windows.Forms.Button();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomPersonnel
            // 
            this.lblNomPersonnel.AutoSize = true;
            this.lblNomPersonnel.Location = new System.Drawing.Point(13, 28);
            this.lblNomPersonnel.Name = "lblNomPersonnel";
            this.lblNomPersonnel.Size = new System.Drawing.Size(93, 13);
            this.lblNomPersonnel.TabIndex = 0;
            this.lblNomPersonnel.Text = "Nom du personnel";
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(16, 63);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.ReadOnly = true;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.Size = new System.Drawing.Size(325, 160);
            this.dgvAbsences.TabIndex = 1;
            // 
            // btnAjouterAbsence
            // 
            this.btnAjouterAbsence.Location = new System.Drawing.Point(16, 260);
            this.btnAjouterAbsence.Name = "btnAjouterAbsence";
            this.btnAjouterAbsence.Size = new System.Drawing.Size(113, 30);
            this.btnAjouterAbsence.TabIndex = 2;
            this.btnAjouterAbsence.Text = "Ajouter absences";
            this.btnAjouterAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(228, 260);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(113, 30);
            this.btnSupprimerAbsence.TabIndex = 3;
            this.btnSupprimerAbsence.Text = "Supprimer absence";
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            // 
            // FrmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 312);
            this.Controls.Add(this.btnSupprimerAbsence);
            this.Controls.Add(this.btnAjouterAbsence);
            this.Controls.Add(this.dgvAbsences);
            this.Controls.Add(this.lblNomPersonnel);
            this.Name = "FrmAbsences";
            this.Text = "FrmAbsences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomPersonnel;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.Button btnAjouterAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
    }
}