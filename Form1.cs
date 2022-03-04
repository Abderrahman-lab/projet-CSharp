using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_Commerciale
{
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
        }
        ADO d = new ADO();
        //declaration de la mthode nombre
        public int nombre()
        {
            int cpt;
            d.cmd.CommandText = "select count(ClientID) from Client where CLientID='" +ClientID.Text+"'";
            d.cmd.Connection = d.cnx;
            cpt = (int) d.cmd.ExecuteScalar(); //la requte contient un seul donnée pas trop si non j'utilise ExecteReader
            return cpt;
        }
        //declaration de la methode Ajouter
        public bool ajouter()
        {
            if(nombre()==0)
            {
                d.cmd.CommandText="insert into Client values ('"+Nom.Text+"','"+Tel.Text+"','"+Adressee.Text+"','"+Mail.Text+"')";
                d.cmd.Connection = d.cnx;
                d.cmd.ExecuteNonQuery(); //cette methode juste pour la mise à jour 
                return true;
            }
            else
            {
                return false;
            }
        }
        //remplir le DataGridView 
        public void RemplirGrid()
        {
            if(d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            d.cmd.CommandText = "select * from Client";
            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            formulaireSC.DataSource = d.dt;
            d.dr.Close();
        }
        //Vider tous les champs de formulaire
        public void vider(Control f)
        {
            foreach(Control ct in f.Controls)
            {
                if(ct.GetType()== typeof(TextBox))
                {
                    ct.Text = "";
                }
                if(Controls.Count !=0)
                {
                    vider(ct);
                }
            }
        }
        //methode suprimmer
        public bool suprimmer()
        {
            if (nombre() != 0)
            {
                d.cmd.CommandText = " delete from Client where ClientID ='" + ClientID.Text + "'";
                d.cmd.Connection = d.cnx;
                d.cmd.ExecuteNonQuery(); //cette methode juste pour la mise à jour 
                return true;
            }
            else
            {
                return false;
            }
        }
        //methode supprimer
        //methode modifier
        public bool modifier()
        {
            if (nombre() != 0)
            {
                d.cmd.CommandText = "update Client set Nom='"+Nom.Text+"',Tel='"+Tel.Text+"',Adressee='"+Adressee.Text+"',Mail='"+Mail.Text+"' where ClientID='"+ClientID.Text+"'";
                d.cmd.Connection = d.cnx;
                d.cmd.ExecuteNonQuery(); //cette methode juste pour la mise à jour 
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Quitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voulez vraiment fermer cette page?", "confirmation" , MessageBoxButtons.YesNo)== DialogResult.Yes);
            {
                d.Deconnecter();
                this.Close();
            }
        }

        private void Vider_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voulez vraiment vider cette page?", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
            {
               
                vider(this);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            d.Connecter();
            d.cmd.CommandText = "select * from Client";
            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr); //prend les info qui se trouve à dr et le met dans dt
            formulaireSC.DataSource = d.dt;
            d.dr.Close();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (ClientID.Text == "" || Nom.Text == "" || Tel.Text == "" || Adressee.Text == "" || Mail.Text == "")
            {
                MessageBox.Show("Merci de remplir tous les champs");
                return;
            }
            if(ajouter() ==true)
            {
                MessageBox.Show("votre Client est bien jouter");
                RemplirGrid();
            }
            else
            {
                MessageBox.Show("Ce client existe deja");
            }
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            if (ClientID.Text == "")
            {
                MessageBox.Show("Merci de remplir le champ");
                return;
            }
            if (suprimmer() == true)
            {
                MessageBox.Show("votre Client est bien suprimmer");
                RemplirGrid();
            }
            else
            {
                MessageBox.Show("Ce client n'existe pas");
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {

            if (ClientID.Text == "" || Nom.Text == "" || Tel.Text == "" || Adressee.Text == "" || Mail.Text == "")
            {
                MessageBox.Show("Merci de remplir tous les champs");
                return;
            }
            if (modifier() == true)
            {
                MessageBox.Show("votre Client est bien Modifier");
                RemplirGrid();
            }
            else
            {
                MessageBox.Show("Ce client existe deja");
            }
        }
    }


        // cnx.Open();
        // cmd = new SqlCommand("insert into stock values ("+ClientID.Text+",'"+Name.Text+"','"+Email0.Text+"',"+Telephone0.Text+",'"+Adresse0.Text+"')",cnx);
        // cmd.ExecuteNonQuery();
        // cnx.Close();
    }
