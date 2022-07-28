namespace Guide_Phasmo_plus
{
    public partial class Form1 : Form
    {
        public Form1()
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
        }

        private void truc_Click(object sender, EventArgs e)
        {
            //test_label.Text = (sender as Control).Name;
            Initier_les_entites();
            
        }

        private void liste_c_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void seuil_domain_SelectedItemChanged(object sender, EventArgs e)
        {
            liste_s.Items.Clear();
            afficher_entite_seuil_corespondant();
        }

        private void liste_s_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cooldown_domain_SelectedItemChanged(object sender, EventArgs e)
        {
            liste_c.Items.Clear();
            afficher_entite_cooldown_corespondant();
        }

        private void Preuve_Click(object sender, EventArgs e)
        {
            //if (Color.FromKnownColor(KnownColor.ControlLight).ToArgb().Equals((sender as Control).BackColor.ToArgb()))
            //{
            //    (sender as Control).BackColor = Color.FromKnownColor(KnownColor.MenuHighlight);
            //    changer_couleur_btn((sender as Control).Name.Replace("_button", ""));
            //}
            //else if (Color.FromKnownColor(KnownColor.MenuHighlight).ToArgb().Equals((sender as Control).BackColor.ToArgb()))
            //{
            //    (sender as Control).BackColor = Color.FromKnownColor(KnownColor.GrayText);
            //    changer_couleur_btn((sender as Control).Name.Replace("_button", ""));
            //}
            //else if (Color.FromKnownColor(KnownColor.GrayText).ToArgb().Equals((sender as Control).BackColor.ToArgb()))
            //{
            //    (sender as Control).BackColor = Color.FromKnownColor(KnownColor.ControlLight);
            //    changer_couleur_btn((sender as Control).Name.Replace("_button", ""));
            //}
            //grand_changement(sender);
            changer_couleur_btn3(sender);
        }

        private void Afficher_infos_entite_button_Click(object sender, EventArgs e)
        {
            string nom_du_btn = (sender as Control).Name.Replace("_button", "");
            test_label.Text = nom_du_btn;
            afficher_attributs_entite(nom_du_btn);
        }

        private void liste_entite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reboot_button_Click(object sender, EventArgs e)
        {
            reboot_couleur();
        }
    }
}