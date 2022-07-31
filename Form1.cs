namespace Guide_Phasmo_plus
{
    public partial class Fenetre_application_phasmo_plus : Form
    {
        public Fenetre_application_phasmo_plus()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lister_les_entites();
            Lister_les_cooldowns();
            Lister_les_seuils();
            charger_liste_cooldown();
            charger_liste_seuil();
            this.Cursor = new Cursor(changer_skin_souris().GetHicon());
        }

        private void liste_c_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liste_c.SelectedItem != null)
            {
                afficher_attributs_entite(liste_c.SelectedItem.ToString());
            }
        }

        private void seuil_domain_SelectedItemChanged(object sender, EventArgs e)
        {
            liste_s.Items.Clear();
            afficher_entite_seuil_corespondant();
        }

        private void liste_s_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liste_s.SelectedItem != null)
            {
                afficher_attributs_entite(liste_s.SelectedItem.ToString());
            }
        }

        private void cooldown_domain_SelectedItemChanged(object sender, EventArgs e)
        {
            liste_c.Items.Clear();
            afficher_entite_cooldown_corespondant();
        }

        private void Preuve_Click(object sender, EventArgs e)
        {
            changer_couleur_btn_entite(sender);
            afficher_entites_dans_liste();
        }

        private void Afficher_infos_entite_button_Click(object sender, EventArgs e)
        {
            string nom_du_btn = (sender as Control).Name.Replace("_button", "");
            afficher_attributs_entite(nom_du_btn);
        }

        private void liste_entite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liste_entite.SelectedItem != null)
            {
                afficher_attributs_entite(liste_entite.SelectedItem.ToString());
            }
        }

        private void Reboot_button_Click(object sender, EventArgs e)
        {
            reboot_couleur();
            reboot_cooldown_seuil_tips();
            afficher_entites_dans_liste();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            credits_corentin_legoff();
        }
    }
}