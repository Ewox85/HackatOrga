﻿namespace OrgaHackat
{
    partial class statistique
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
            components = new System.ComponentModel.Container();
            btn_retour_accueil = new Button();
            gbx_nbparticipantHackathon = new GroupBox();
            dgv_nbParticipantHackathon = new DataGridView();
            lbl_stat_nbParticipantHackathon = new Label();
            bddboudero5ContextBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            dgv_nbParticipantAtelier = new DataGridView();
            label1 = new Label();
            lbl_moitierPlace = new Label();
            lbl_yellow = new Label();
            lbl_red = new Label();
            lbl_plusPlace = new Label();
            gbx_nbparticipantHackathon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_nbParticipantHackathon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bddboudero5ContextBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_nbParticipantAtelier).BeginInit();
            SuspendLayout();
            // 
            // btn_retour_accueil
            // 
            btn_retour_accueil.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_retour_accueil.Location = new Point(12, 395);
            btn_retour_accueil.Name = "btn_retour_accueil";
            btn_retour_accueil.Size = new Size(106, 43);
            btn_retour_accueil.TabIndex = 2;
            btn_retour_accueil.Text = "Accueil";
            btn_retour_accueil.UseVisualStyleBackColor = true;
            btn_retour_accueil.Click += btn_retour_accueil_Click;
            // 
            // gbx_nbparticipantHackathon
            // 
            gbx_nbparticipantHackathon.Controls.Add(dgv_nbParticipantHackathon);
            gbx_nbparticipantHackathon.Controls.Add(lbl_stat_nbParticipantHackathon);
            gbx_nbparticipantHackathon.Location = new Point(12, 12);
            gbx_nbparticipantHackathon.Name = "gbx_nbparticipantHackathon";
            gbx_nbparticipantHackathon.Size = new Size(403, 377);
            gbx_nbparticipantHackathon.TabIndex = 3;
            gbx_nbparticipantHackathon.TabStop = false;
            // 
            // dgv_nbParticipantHackathon
            // 
            dgv_nbParticipantHackathon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_nbParticipantHackathon.Location = new Point(24, 52);
            dgv_nbParticipantHackathon.Name = "dgv_nbParticipantHackathon";
            dgv_nbParticipantHackathon.ReadOnly = true;
            dgv_nbParticipantHackathon.RowTemplate.Height = 25;
            dgv_nbParticipantHackathon.Size = new Size(342, 314);
            dgv_nbParticipantHackathon.TabIndex = 1;
            // 
            // lbl_stat_nbParticipantHackathon
            // 
            lbl_stat_nbParticipantHackathon.AutoSize = true;
            lbl_stat_nbParticipantHackathon.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_stat_nbParticipantHackathon.Location = new Point(6, 19);
            lbl_stat_nbParticipantHackathon.Name = "lbl_stat_nbParticipantHackathon";
            lbl_stat_nbParticipantHackathon.Size = new Size(389, 30);
            lbl_stat_nbParticipantHackathon.TabIndex = 0;
            lbl_stat_nbParticipantHackathon.Text = "Nombre de participant par Hackathon";
            // 
            // bddboudero5ContextBindingSource
            // 
            bddboudero5ContextBindingSource.DataSource = typeof(Models.bddboudero5Context);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_nbParticipantAtelier);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(421, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 377);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // dgv_nbParticipantAtelier
            // 
            dgv_nbParticipantAtelier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_nbParticipantAtelier.Location = new Point(24, 52);
            dgv_nbParticipantAtelier.Name = "dgv_nbParticipantAtelier";
            dgv_nbParticipantAtelier.ReadOnly = true;
            dgv_nbParticipantAtelier.RowTemplate.Height = 25;
            dgv_nbParticipantAtelier.Size = new Size(342, 314);
            dgv_nbParticipantAtelier.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(343, 30);
            label1.TabIndex = 0;
            label1.Text = "Nombre de participant par atelier\r\n";
            // 
            // lbl_moitierPlace
            // 
            lbl_moitierPlace.AutoSize = true;
            lbl_moitierPlace.Location = new Point(628, 395);
            lbl_moitierPlace.Name = "lbl_moitierPlace";
            lbl_moitierPlace.Size = new Size(162, 15);
            lbl_moitierPlace.TabIndex = 5;
            lbl_moitierPlace.Text = "Moitié des places déjà prisent";
            // 
            // lbl_yellow
            // 
            lbl_yellow.AutoSize = true;
            lbl_yellow.BackColor = Color.Yellow;
            lbl_yellow.Location = new Point(796, 395);
            lbl_yellow.Name = "lbl_yellow";
            lbl_yellow.Size = new Size(28, 15);
            lbl_yellow.TabIndex = 6;
            lbl_yellow.Text = "       ";
            // 
            // lbl_red
            // 
            lbl_red.AutoSize = true;
            lbl_red.BackColor = Color.Red;
            lbl_red.Location = new Point(796, 414);
            lbl_red.Name = "lbl_red";
            lbl_red.Size = new Size(28, 15);
            lbl_red.TabIndex = 8;
            lbl_red.Text = "       ";
            // 
            // lbl_plusPlace
            // 
            lbl_plusPlace.AutoSize = true;
            lbl_plusPlace.Location = new Point(653, 414);
            lbl_plusPlace.Name = "lbl_plusPlace";
            lbl_plusPlace.Size = new Size(134, 15);
            lbl_plusPlace.TabIndex = 7;
            lbl_plusPlace.Text = "Plus de place disponible";
            // 
            // statistique
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 445);
            Controls.Add(lbl_red);
            Controls.Add(lbl_plusPlace);
            Controls.Add(lbl_yellow);
            Controls.Add(lbl_moitierPlace);
            Controls.Add(groupBox1);
            Controls.Add(gbx_nbparticipantHackathon);
            Controls.Add(btn_retour_accueil);
            Name = "statistique";
            Text = "statistique";
            Load += statistique_Load;
            gbx_nbparticipantHackathon.ResumeLayout(false);
            gbx_nbparticipantHackathon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_nbParticipantHackathon).EndInit();
            ((System.ComponentModel.ISupportInitialize)bddboudero5ContextBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_nbParticipantAtelier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_retour_accueil;
        private GroupBox gbx_nbparticipantHackathon;
        private Label lbl_stat_nbParticipantHackathon;
        private DataGridView dgv_nbParticipantHackathon;
        private BindingSource bddboudero5ContextBindingSource;
        private GroupBox groupBox1;
        private DataGridView dgv_nbParticipantAtelier;
        private Label label1;
        private Label lbl_moitierPlace;
        private Label lbl_yellow;
        private Label lbl_red;
        private Label lbl_plusPlace;
    }
}