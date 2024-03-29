﻿using iTextSharp.text;
using OrgaHackat.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace OrgaHackat
{
    public partial class statistique : Form
    {
        public statistique()
        {
            InitializeComponent();
        }

        private void btn_retour_accueil_Click(object sender, EventArgs e)
        {
            accueil Form1 = new accueil();
            Form1.Show();
            this.Hide();
        }

        private void statistique_Load(object sender, EventArgs e)
        {
            bddboudero5Context cnx = new bddboudero5Context();

            List<Hackathon> listHackathon = cnx.Hackathons.Include(i => i.Inscriptions).ToList();

            dgv_nbParticipantHackathon.ColumnCount = 3;
            dgv_nbParticipantHackathon.Columns[0].Name = "ID Hackathon";
            dgv_nbParticipantHackathon.Columns[1].Name = "Hackathon";
            dgv_nbParticipantHackathon.Columns[2].Name = "Nombre d'Inscrit";
            for (int i = 0; i < listHackathon.Count; i++)
            {
                int nbInsc = listHackathon[i].Inscriptions.Count();
                dgv_nbParticipantHackathon.Rows.Add(listHackathon[i].Id, listHackathon[i].Theme, nbInsc);
                if (nbInsc >= listHackathon[i].NbPlaces / 2)
                {
                    dgv_nbParticipantHackathon.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                }
                if (nbInsc == listHackathon[i].NbPlaces)
                {
                    dgv_nbParticipantHackathon.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
            }

            List<Initiation> listInitiation = cnx.Initiations.ToList();
            dgv_nbParticipantAtelier.ColumnCount = 3;
            dgv_nbParticipantAtelier.Columns[0].Name = "ID Initiation";
            dgv_nbParticipantAtelier.Columns[1].Name = "Initiation";
            dgv_nbParticipantAtelier.Columns[2].Name = "Nombre Participant";
            for (int i = 0; i < listInitiation.Count; i++)
            {
                ICollection<Participant> listParticipant = cnx.Participants.Where(part => part.InitiationId == listInitiation[i].Id).ToList();
                List<Evenement> nomInitiation = cnx.Evenements.Where(even => even.Id == listInitiation[i].Id).ToList();
                dgv_nbParticipantAtelier.Rows.Add(listInitiation[i].Id, nomInitiation[0].Libelle, listParticipant.Count());
                if (listParticipant.Count() >= listInitiation[i].NbPlaceLimite / 2)
                {
                    dgv_nbParticipantAtelier.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                }
                if (listParticipant.Count() == listInitiation[i].NbPlaceLimite)
                {
                    dgv_nbParticipantAtelier.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
            }
        }
    }
}
