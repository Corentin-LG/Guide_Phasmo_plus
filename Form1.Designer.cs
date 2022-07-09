using System.Linq;

namespace Guide_Phasmo_plus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tables_des_preuves = new System.Windows.Forms.TableLayoutPanel();
            this.Reboot_button = new System.Windows.Forms.Button();
            this.Temperature_button = new System.Windows.Forms.Button();
            this.Spirit_button = new System.Windows.Forms.Button();
            this.Dots_button = new System.Windows.Forms.Button();
            this.Orbes_button = new System.Windows.Forms.Button();
            this.Empreintes_button = new System.Windows.Forms.Button();
            this.EMF_button = new System.Windows.Forms.Button();
            this.Ecriture_button = new System.Windows.Forms.Button();
            this.Table_des_entites = new System.Windows.Forms.TableLayoutPanel();
            this.Moroi_button = new System.Windows.Forms.Button();
            this.Deogen_button = new System.Windows.Forms.Button();
            this.Thaye_button = new System.Windows.Forms.Button();
            this.Fantome_button = new System.Windows.Forms.Button();
            this.Mimic_button = new System.Windows.Forms.Button();
            this.Obake_button = new System.Windows.Forms.Button();
            this.Raiju_button = new System.Windows.Forms.Button();
            this.Jumeaux_button = new System.Windows.Forms.Button();
            this.Onryo_button = new System.Windows.Forms.Button();
            this.Myling_button = new System.Windows.Forms.Button();
            this.Goryo_button = new System.Windows.Forms.Button();
            this.Hantu_button = new System.Windows.Forms.Button();
            this.Yokai_button = new System.Windows.Forms.Button();
            this.Oni_button = new System.Windows.Forms.Button();
            this.Yurei_button = new System.Windows.Forms.Button();
            this.Demon_button = new System.Windows.Forms.Button();
            this.Ombre_button = new System.Windows.Forms.Button();
            this.Revenant_button = new System.Windows.Forms.Button();
            this.Cauchemar_button = new System.Windows.Forms.Button();
            this.Djinn_button = new System.Windows.Forms.Button();
            this.Banshee_button = new System.Windows.Forms.Button();
            this.Poltergeist_button = new System.Windows.Forms.Button();
            this.Spectre_button = new System.Windows.Forms.Button();
            this.Esprit_button = new System.Windows.Forms.Button();
            this.cooldown_domain = new System.Windows.Forms.DomainUpDown();
            this.liste_c = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.liste_s = new System.Windows.Forms.ListBox();
            this.seuil_domain = new System.Windows.Forms.DomainUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.liste_tips = new System.Windows.Forms.ListBox();
            this.liste_entite = new System.Windows.Forms.ListBox();
            this.test_label = new System.Windows.Forms.Label();
            this.truc = new System.Windows.Forms.Button();
            this.Tables_des_preuves.SuspendLayout();
            this.Table_des_entites.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tables_des_preuves
            // 
            this.Tables_des_preuves.ColumnCount = 2;
            this.Tables_des_preuves.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tables_des_preuves.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tables_des_preuves.Controls.Add(this.Reboot_button, 1, 3);
            this.Tables_des_preuves.Controls.Add(this.Temperature_button, 0, 3);
            this.Tables_des_preuves.Controls.Add(this.Spirit_button, 1, 2);
            this.Tables_des_preuves.Controls.Add(this.Dots_button, 0, 2);
            this.Tables_des_preuves.Controls.Add(this.Orbes_button, 1, 1);
            this.Tables_des_preuves.Controls.Add(this.Empreintes_button, 0, 1);
            this.Tables_des_preuves.Controls.Add(this.EMF_button, 1, 0);
            this.Tables_des_preuves.Controls.Add(this.Ecriture_button, 0, 0);
            this.Tables_des_preuves.Dock = System.Windows.Forms.DockStyle.Right;
            this.Tables_des_preuves.Location = new System.Drawing.Point(576, 0);
            this.Tables_des_preuves.Name = "Tables_des_preuves";
            this.Tables_des_preuves.RowCount = 4;
            this.Tables_des_preuves.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tables_des_preuves.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tables_des_preuves.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tables_des_preuves.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tables_des_preuves.Size = new System.Drawing.Size(224, 450);
            this.Tables_des_preuves.TabIndex = 1;
            // 
            // Reboot_button
            // 
            this.Reboot_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reboot_button.Location = new System.Drawing.Point(115, 339);
            this.Reboot_button.Name = "Reboot_button";
            this.Reboot_button.Size = new System.Drawing.Size(106, 108);
            this.Reboot_button.TabIndex = 7;
            this.Reboot_button.Text = "REBOOT";
            this.Reboot_button.UseVisualStyleBackColor = true;
            // 
            // Temperature_button
            // 
            this.Temperature_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Temperature_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Temperature_button.Image = ((System.Drawing.Image)(resources.GetObject("Temperature_button.Image")));
            this.Temperature_button.Location = new System.Drawing.Point(3, 339);
            this.Temperature_button.Name = "Temperature_button";
            this.Temperature_button.Size = new System.Drawing.Size(106, 108);
            this.Temperature_button.TabIndex = 6;
            this.Temperature_button.UseVisualStyleBackColor = false;
            this.Temperature_button.Click += new System.EventHandler(this.Preuve_Click);
            // 
            // Spirit_button
            // 
            this.Spirit_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Spirit_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spirit_button.Image = ((System.Drawing.Image)(resources.GetObject("Spirit_button.Image")));
            this.Spirit_button.Location = new System.Drawing.Point(115, 227);
            this.Spirit_button.Name = "Spirit_button";
            this.Spirit_button.Size = new System.Drawing.Size(106, 106);
            this.Spirit_button.TabIndex = 5;
            this.Spirit_button.UseVisualStyleBackColor = false;
            this.Spirit_button.Click += new System.EventHandler(this.Preuve_Click);
            // 
            // Dots_button
            // 
            this.Dots_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Dots_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dots_button.Image = ((System.Drawing.Image)(resources.GetObject("Dots_button.Image")));
            this.Dots_button.Location = new System.Drawing.Point(3, 227);
            this.Dots_button.Name = "Dots_button";
            this.Dots_button.Size = new System.Drawing.Size(106, 106);
            this.Dots_button.TabIndex = 4;
            this.Dots_button.UseVisualStyleBackColor = false;
            this.Dots_button.Click += new System.EventHandler(this.Preuve_Click);
            // 
            // Orbes_button
            // 
            this.Orbes_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Orbes_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Orbes_button.Image = ((System.Drawing.Image)(resources.GetObject("Orbes_button.Image")));
            this.Orbes_button.Location = new System.Drawing.Point(115, 115);
            this.Orbes_button.Name = "Orbes_button";
            this.Orbes_button.Size = new System.Drawing.Size(106, 106);
            this.Orbes_button.TabIndex = 3;
            this.Orbes_button.UseVisualStyleBackColor = false;
            this.Orbes_button.Click += new System.EventHandler(this.Preuve_Click);
            // 
            // Empreintes_button
            // 
            this.Empreintes_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Empreintes_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Empreintes_button.Image = ((System.Drawing.Image)(resources.GetObject("Empreintes_button.Image")));
            this.Empreintes_button.Location = new System.Drawing.Point(3, 115);
            this.Empreintes_button.Name = "Empreintes_button";
            this.Empreintes_button.Size = new System.Drawing.Size(106, 106);
            this.Empreintes_button.TabIndex = 2;
            this.Empreintes_button.UseVisualStyleBackColor = false;
            this.Empreintes_button.Click += new System.EventHandler(this.Preuve_Click);
            // 
            // EMF_button
            // 
            this.EMF_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EMF_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EMF_button.Image = ((System.Drawing.Image)(resources.GetObject("EMF_button.Image")));
            this.EMF_button.Location = new System.Drawing.Point(115, 3);
            this.EMF_button.Name = "EMF_button";
            this.EMF_button.Size = new System.Drawing.Size(106, 106);
            this.EMF_button.TabIndex = 1;
            this.EMF_button.UseVisualStyleBackColor = false;
            this.EMF_button.Click += new System.EventHandler(this.Preuve_Click);
            // 
            // Ecriture_button
            // 
            this.Ecriture_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Ecriture_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ecriture_button.Image = ((System.Drawing.Image)(resources.GetObject("Ecriture_button.Image")));
            this.Ecriture_button.Location = new System.Drawing.Point(3, 3);
            this.Ecriture_button.Name = "Ecriture_button";
            this.Ecriture_button.Size = new System.Drawing.Size(106, 106);
            this.Ecriture_button.TabIndex = 0;
            this.Ecriture_button.UseVisualStyleBackColor = false;
            this.Ecriture_button.Click += new System.EventHandler(this.Preuve_Click);
            // 
            // Table_des_entites
            // 
            this.Table_des_entites.ColumnCount = 3;
            this.Table_des_entites.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.Table_des_entites.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Table_des_entites.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Table_des_entites.Controls.Add(this.Moroi_button, 0, 7);
            this.Table_des_entites.Controls.Add(this.Deogen_button, 0, 7);
            this.Table_des_entites.Controls.Add(this.Thaye_button, 0, 7);
            this.Table_des_entites.Controls.Add(this.Fantome_button, 2, 0);
            this.Table_des_entites.Controls.Add(this.Mimic_button, 2, 6);
            this.Table_des_entites.Controls.Add(this.Obake_button, 1, 6);
            this.Table_des_entites.Controls.Add(this.Raiju_button, 0, 6);
            this.Table_des_entites.Controls.Add(this.Jumeaux_button, 2, 5);
            this.Table_des_entites.Controls.Add(this.Onryo_button, 1, 5);
            this.Table_des_entites.Controls.Add(this.Myling_button, 0, 5);
            this.Table_des_entites.Controls.Add(this.Goryo_button, 2, 4);
            this.Table_des_entites.Controls.Add(this.Hantu_button, 1, 4);
            this.Table_des_entites.Controls.Add(this.Yokai_button, 0, 4);
            this.Table_des_entites.Controls.Add(this.Oni_button, 2, 3);
            this.Table_des_entites.Controls.Add(this.Yurei_button, 1, 3);
            this.Table_des_entites.Controls.Add(this.Demon_button, 0, 3);
            this.Table_des_entites.Controls.Add(this.Ombre_button, 2, 2);
            this.Table_des_entites.Controls.Add(this.Revenant_button, 1, 2);
            this.Table_des_entites.Controls.Add(this.Cauchemar_button, 0, 2);
            this.Table_des_entites.Controls.Add(this.Djinn_button, 2, 1);
            this.Table_des_entites.Controls.Add(this.Banshee_button, 1, 1);
            this.Table_des_entites.Controls.Add(this.Poltergeist_button, 0, 1);
            this.Table_des_entites.Controls.Add(this.Spectre_button, 1, 0);
            this.Table_des_entites.Controls.Add(this.Esprit_button, 0, 0);
            this.Table_des_entites.Dock = System.Windows.Forms.DockStyle.Left;
            this.Table_des_entites.Location = new System.Drawing.Point(0, 0);
            this.Table_des_entites.Name = "Table_des_entites";
            this.Table_des_entites.RowCount = 8;
            this.Table_des_entites.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Table_des_entites.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Table_des_entites.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Table_des_entites.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Table_des_entites.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Table_des_entites.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Table_des_entites.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Table_des_entites.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Table_des_entites.Size = new System.Drawing.Size(300, 450);
            this.Table_des_entites.TabIndex = 0;
            // 
            // Moroi_button
            // 
            this.Moroi_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Moroi_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Moroi_button.Location = new System.Drawing.Point(0, 392);
            this.Moroi_button.Margin = new System.Windows.Forms.Padding(0);
            this.Moroi_button.Name = "Moroi_button";
            this.Moroi_button.Size = new System.Drawing.Size(99, 58);
            this.Moroi_button.TabIndex = 24;
            this.Moroi_button.Text = "Moroï";
            this.Moroi_button.UseVisualStyleBackColor = false;
            this.Moroi_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Deogen_button
            // 
            this.Deogen_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Deogen_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Deogen_button.Location = new System.Drawing.Point(99, 392);
            this.Deogen_button.Margin = new System.Windows.Forms.Padding(0);
            this.Deogen_button.Name = "Deogen_button";
            this.Deogen_button.Size = new System.Drawing.Size(100, 58);
            this.Deogen_button.TabIndex = 23;
            this.Deogen_button.Text = "Deogen";
            this.Deogen_button.UseVisualStyleBackColor = false;
            this.Deogen_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Thaye_button
            // 
            this.Thaye_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Thaye_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Thaye_button.Location = new System.Drawing.Point(199, 392);
            this.Thaye_button.Margin = new System.Windows.Forms.Padding(0);
            this.Thaye_button.Name = "Thaye_button";
            this.Thaye_button.Size = new System.Drawing.Size(101, 58);
            this.Thaye_button.TabIndex = 22;
            this.Thaye_button.Text = "Thayé";
            this.Thaye_button.UseVisualStyleBackColor = false;
            this.Thaye_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Fantome_button
            // 
            this.Fantome_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Fantome_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fantome_button.Location = new System.Drawing.Point(199, 0);
            this.Fantome_button.Margin = new System.Windows.Forms.Padding(0);
            this.Fantome_button.Name = "Fantome_button";
            this.Fantome_button.Size = new System.Drawing.Size(101, 56);
            this.Fantome_button.TabIndex = 21;
            this.Fantome_button.Text = "Fantôme";
            this.Fantome_button.UseVisualStyleBackColor = false;
            this.Fantome_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Mimic_button
            // 
            this.Mimic_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Mimic_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mimic_button.Location = new System.Drawing.Point(199, 336);
            this.Mimic_button.Margin = new System.Windows.Forms.Padding(0);
            this.Mimic_button.Name = "Mimic_button";
            this.Mimic_button.Size = new System.Drawing.Size(101, 56);
            this.Mimic_button.TabIndex = 20;
            this.Mimic_button.Text = "Le Mimic";
            this.Mimic_button.UseVisualStyleBackColor = false;
            this.Mimic_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Obake_button
            // 
            this.Obake_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Obake_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Obake_button.Location = new System.Drawing.Point(99, 336);
            this.Obake_button.Margin = new System.Windows.Forms.Padding(0);
            this.Obake_button.Name = "Obake_button";
            this.Obake_button.Size = new System.Drawing.Size(100, 56);
            this.Obake_button.TabIndex = 19;
            this.Obake_button.Text = "Obake";
            this.Obake_button.UseVisualStyleBackColor = false;
            this.Obake_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Raiju_button
            // 
            this.Raiju_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Raiju_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Raiju_button.Location = new System.Drawing.Point(0, 336);
            this.Raiju_button.Margin = new System.Windows.Forms.Padding(0);
            this.Raiju_button.Name = "Raiju_button";
            this.Raiju_button.Size = new System.Drawing.Size(99, 56);
            this.Raiju_button.TabIndex = 18;
            this.Raiju_button.Text = "Raiju";
            this.Raiju_button.UseVisualStyleBackColor = false;
            this.Raiju_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Jumeaux_button
            // 
            this.Jumeaux_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Jumeaux_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Jumeaux_button.Location = new System.Drawing.Point(199, 280);
            this.Jumeaux_button.Margin = new System.Windows.Forms.Padding(0);
            this.Jumeaux_button.Name = "Jumeaux_button";
            this.Jumeaux_button.Size = new System.Drawing.Size(101, 56);
            this.Jumeaux_button.TabIndex = 17;
            this.Jumeaux_button.Text = "Les Jumeaux";
            this.Jumeaux_button.UseVisualStyleBackColor = false;
            this.Jumeaux_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Onryo_button
            // 
            this.Onryo_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Onryo_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Onryo_button.Location = new System.Drawing.Point(99, 280);
            this.Onryo_button.Margin = new System.Windows.Forms.Padding(0);
            this.Onryo_button.Name = "Onryo_button";
            this.Onryo_button.Size = new System.Drawing.Size(100, 56);
            this.Onryo_button.TabIndex = 16;
            this.Onryo_button.Text = "Onryo";
            this.Onryo_button.UseVisualStyleBackColor = false;
            this.Onryo_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Myling_button
            // 
            this.Myling_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Myling_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Myling_button.Location = new System.Drawing.Point(0, 280);
            this.Myling_button.Margin = new System.Windows.Forms.Padding(0);
            this.Myling_button.Name = "Myling_button";
            this.Myling_button.Size = new System.Drawing.Size(99, 56);
            this.Myling_button.TabIndex = 15;
            this.Myling_button.Text = "Myling";
            this.Myling_button.UseVisualStyleBackColor = false;
            this.Myling_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Goryo_button
            // 
            this.Goryo_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Goryo_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Goryo_button.Location = new System.Drawing.Point(199, 224);
            this.Goryo_button.Margin = new System.Windows.Forms.Padding(0);
            this.Goryo_button.Name = "Goryo_button";
            this.Goryo_button.Size = new System.Drawing.Size(101, 56);
            this.Goryo_button.TabIndex = 14;
            this.Goryo_button.Text = "Goryo";
            this.Goryo_button.UseVisualStyleBackColor = false;
            this.Goryo_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Hantu_button
            // 
            this.Hantu_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Hantu_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Hantu_button.Location = new System.Drawing.Point(99, 224);
            this.Hantu_button.Margin = new System.Windows.Forms.Padding(0);
            this.Hantu_button.Name = "Hantu_button";
            this.Hantu_button.Size = new System.Drawing.Size(100, 56);
            this.Hantu_button.TabIndex = 13;
            this.Hantu_button.Text = "Hantu";
            this.Hantu_button.UseVisualStyleBackColor = false;
            this.Hantu_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Yokai_button
            // 
            this.Yokai_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Yokai_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Yokai_button.Location = new System.Drawing.Point(0, 224);
            this.Yokai_button.Margin = new System.Windows.Forms.Padding(0);
            this.Yokai_button.Name = "Yokai_button";
            this.Yokai_button.Size = new System.Drawing.Size(99, 56);
            this.Yokai_button.TabIndex = 12;
            this.Yokai_button.Text = "Yokai";
            this.Yokai_button.UseVisualStyleBackColor = false;
            this.Yokai_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Oni_button
            // 
            this.Oni_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Oni_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Oni_button.Location = new System.Drawing.Point(199, 168);
            this.Oni_button.Margin = new System.Windows.Forms.Padding(0);
            this.Oni_button.Name = "Oni_button";
            this.Oni_button.Size = new System.Drawing.Size(101, 56);
            this.Oni_button.TabIndex = 11;
            this.Oni_button.Text = "Oni";
            this.Oni_button.UseVisualStyleBackColor = false;
            this.Oni_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Yurei_button
            // 
            this.Yurei_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Yurei_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Yurei_button.Location = new System.Drawing.Point(99, 168);
            this.Yurei_button.Margin = new System.Windows.Forms.Padding(0);
            this.Yurei_button.Name = "Yurei_button";
            this.Yurei_button.Size = new System.Drawing.Size(100, 56);
            this.Yurei_button.TabIndex = 10;
            this.Yurei_button.Text = "Yurei";
            this.Yurei_button.UseVisualStyleBackColor = false;
            this.Yurei_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Demon_button
            // 
            this.Demon_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Demon_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Demon_button.Location = new System.Drawing.Point(0, 168);
            this.Demon_button.Margin = new System.Windows.Forms.Padding(0);
            this.Demon_button.Name = "Demon_button";
            this.Demon_button.Size = new System.Drawing.Size(99, 56);
            this.Demon_button.TabIndex = 9;
            this.Demon_button.Text = "Démon";
            this.Demon_button.UseVisualStyleBackColor = false;
            this.Demon_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Ombre_button
            // 
            this.Ombre_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Ombre_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ombre_button.Location = new System.Drawing.Point(199, 112);
            this.Ombre_button.Margin = new System.Windows.Forms.Padding(0);
            this.Ombre_button.Name = "Ombre_button";
            this.Ombre_button.Size = new System.Drawing.Size(101, 56);
            this.Ombre_button.TabIndex = 8;
            this.Ombre_button.Text = "Ombre";
            this.Ombre_button.UseVisualStyleBackColor = false;
            this.Ombre_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Revenant_button
            // 
            this.Revenant_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Revenant_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Revenant_button.Location = new System.Drawing.Point(99, 112);
            this.Revenant_button.Margin = new System.Windows.Forms.Padding(0);
            this.Revenant_button.Name = "Revenant_button";
            this.Revenant_button.Size = new System.Drawing.Size(100, 56);
            this.Revenant_button.TabIndex = 7;
            this.Revenant_button.Text = "Revenant";
            this.Revenant_button.UseVisualStyleBackColor = false;
            this.Revenant_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Cauchemar_button
            // 
            this.Cauchemar_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Cauchemar_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cauchemar_button.Location = new System.Drawing.Point(0, 112);
            this.Cauchemar_button.Margin = new System.Windows.Forms.Padding(0);
            this.Cauchemar_button.Name = "Cauchemar_button";
            this.Cauchemar_button.Size = new System.Drawing.Size(99, 56);
            this.Cauchemar_button.TabIndex = 6;
            this.Cauchemar_button.Text = "Cauchemar";
            this.Cauchemar_button.UseVisualStyleBackColor = false;
            this.Cauchemar_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Djinn_button
            // 
            this.Djinn_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Djinn_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Djinn_button.Location = new System.Drawing.Point(199, 56);
            this.Djinn_button.Margin = new System.Windows.Forms.Padding(0);
            this.Djinn_button.Name = "Djinn_button";
            this.Djinn_button.Size = new System.Drawing.Size(101, 56);
            this.Djinn_button.TabIndex = 5;
            this.Djinn_button.Text = "Djinn";
            this.Djinn_button.UseVisualStyleBackColor = false;
            this.Djinn_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Banshee_button
            // 
            this.Banshee_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Banshee_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Banshee_button.Location = new System.Drawing.Point(99, 56);
            this.Banshee_button.Margin = new System.Windows.Forms.Padding(0);
            this.Banshee_button.Name = "Banshee_button";
            this.Banshee_button.Size = new System.Drawing.Size(100, 56);
            this.Banshee_button.TabIndex = 4;
            this.Banshee_button.Text = "Banshee";
            this.Banshee_button.UseVisualStyleBackColor = false;
            this.Banshee_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Poltergeist_button
            // 
            this.Poltergeist_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Poltergeist_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Poltergeist_button.Location = new System.Drawing.Point(0, 56);
            this.Poltergeist_button.Margin = new System.Windows.Forms.Padding(0);
            this.Poltergeist_button.Name = "Poltergeist_button";
            this.Poltergeist_button.Size = new System.Drawing.Size(99, 56);
            this.Poltergeist_button.TabIndex = 3;
            this.Poltergeist_button.Text = "Poltergeist";
            this.Poltergeist_button.UseVisualStyleBackColor = false;
            this.Poltergeist_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Spectre_button
            // 
            this.Spectre_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Spectre_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spectre_button.Location = new System.Drawing.Point(99, 0);
            this.Spectre_button.Margin = new System.Windows.Forms.Padding(0);
            this.Spectre_button.Name = "Spectre_button";
            this.Spectre_button.Size = new System.Drawing.Size(100, 56);
            this.Spectre_button.TabIndex = 1;
            this.Spectre_button.Text = "Spectre";
            this.Spectre_button.UseVisualStyleBackColor = false;
            this.Spectre_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // Esprit_button
            // 
            this.Esprit_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Esprit_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Esprit_button.Location = new System.Drawing.Point(0, 0);
            this.Esprit_button.Margin = new System.Windows.Forms.Padding(0);
            this.Esprit_button.Name = "Esprit_button";
            this.Esprit_button.Size = new System.Drawing.Size(99, 56);
            this.Esprit_button.TabIndex = 0;
            this.Esprit_button.Text = "Esprit";
            this.Esprit_button.UseVisualStyleBackColor = false;
            this.Esprit_button.Click += new System.EventHandler(this.Afficher_infos_entite_button_Click);
            // 
            // cooldown_domain
            // 
            this.cooldown_domain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cooldown_domain.Location = new System.Drawing.Point(3, 3);
            this.cooldown_domain.Name = "cooldown_domain";
            this.cooldown_domain.Size = new System.Drawing.Size(132, 23);
            this.cooldown_domain.TabIndex = 2;
            this.cooldown_domain.Text = "Cooldown";
            this.cooldown_domain.SelectedItemChanged += new System.EventHandler(this.cooldown_domain_SelectedItemChanged);
            // 
            // liste_c
            // 
            this.liste_c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste_c.FormattingEnabled = true;
            this.liste_c.ItemHeight = 15;
            this.liste_c.Location = new System.Drawing.Point(3, 31);
            this.liste_c.Name = "liste_c";
            this.liste_c.Size = new System.Drawing.Size(132, 66);
            this.liste_c.TabIndex = 3;
            this.liste_c.SelectedIndexChanged += new System.EventHandler(this.liste_c_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.liste_s, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.seuil_domain, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cooldown_domain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.liste_c, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(300, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 100);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // liste_s
            // 
            this.liste_s.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste_s.FormattingEnabled = true;
            this.liste_s.ItemHeight = 15;
            this.liste_s.Location = new System.Drawing.Point(141, 31);
            this.liste_s.Name = "liste_s";
            this.liste_s.Size = new System.Drawing.Size(132, 66);
            this.liste_s.TabIndex = 4;
            this.liste_s.SelectedIndexChanged += new System.EventHandler(this.liste_s_SelectedIndexChanged);
            // 
            // seuil_domain
            // 
            this.seuil_domain.Dock = System.Windows.Forms.DockStyle.Top;
            this.seuil_domain.Location = new System.Drawing.Point(141, 3);
            this.seuil_domain.Name = "seuil_domain";
            this.seuil_domain.Size = new System.Drawing.Size(132, 23);
            this.seuil_domain.TabIndex = 3;
            this.seuil_domain.Text = "Seuil d\'attaque";
            this.seuil_domain.SelectedItemChanged += new System.EventHandler(this.seuil_domain_SelectedItemChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.liste_tips, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.liste_entite, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(300, 300);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(276, 150);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // liste_tips
            // 
            this.liste_tips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste_tips.FormattingEnabled = true;
            this.liste_tips.ItemHeight = 15;
            this.liste_tips.Location = new System.Drawing.Point(0, 45);
            this.liste_tips.Margin = new System.Windows.Forms.Padding(0);
            this.liste_tips.Name = "liste_tips";
            this.liste_tips.Size = new System.Drawing.Size(276, 105);
            this.liste_tips.TabIndex = 6;
            // 
            // liste_entite
            // 
            this.liste_entite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste_entite.FormattingEnabled = true;
            this.liste_entite.ItemHeight = 15;
            this.liste_entite.Location = new System.Drawing.Point(0, 0);
            this.liste_entite.Margin = new System.Windows.Forms.Padding(0);
            this.liste_entite.Name = "liste_entite";
            this.liste_entite.Size = new System.Drawing.Size(276, 45);
            this.liste_entite.TabIndex = 5;
            // 
            // test_label
            // 
            this.test_label.AutoSize = true;
            this.test_label.Location = new System.Drawing.Point(421, 193);
            this.test_label.Name = "test_label";
            this.test_label.Size = new System.Drawing.Size(38, 15);
            this.test_label.TabIndex = 7;
            this.test_label.Text = "label1";
            // 
            // truc
            // 
            this.truc.Location = new System.Drawing.Point(410, 141);
            this.truc.Name = "truc";
            this.truc.Size = new System.Drawing.Size(75, 23);
            this.truc.TabIndex = 8;
            this.truc.Text = "button30";
            this.truc.UseVisualStyleBackColor = true;
            this.truc.Click += new System.EventHandler(this.truc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.truc);
            this.Controls.Add(this.test_label);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Tables_des_preuves);
            this.Controls.Add(this.Table_des_entites);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tables_des_preuves.ResumeLayout(false);
            this.Table_des_entites.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TableLayoutPanel Tables_des_preuves;
        private Button Reboot_button;
        private Button Temperature_button;
        private Button Spirit_button;
        private Button Dots_button;
        private Button Orbes_button;
        private Button Empreintes_button;
        private Button EMF_button;
        private Button Ecriture_button;
        private TableLayoutPanel Table_des_entites;
        private Button Mimic_button;
        private Button Obake_button;
        private Button Raiju_button;
        private Button Jumeaux_button;
        private Button Onryo_button;
        private Button Myling_button;
        private Button Goryo_button;
        private Button Hantu_button;
        private Button Yokai_button;
        private Button Oni_button;
        private Button Yurei_button;
        private Button Demon_button;
        private Button Ombre_button;
        private Button Revenant_button;
        private Button Cauchemar_button;
        private Button Djinn_button;
        private Button Banshee_button;
        private Button Poltergeist_button;
        private Button Spectre_button;
        private Button Esprit_button;
        private DomainUpDown cooldown_domain;
        private ListBox liste_c;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox liste_s;
        private DomainUpDown seuil_domain;
        private TableLayoutPanel tableLayoutPanel2;
        private ListBox liste_tips;
        private ListBox liste_entite;
        private Label test_label;
        private Button truc;
        private Button Fantome_button;
        private Button Moroi_button;
        private Button Deogen_button;
        private Button Thaye_button;
        //Entite Esprit = new Entite("Esprit", 50, 25, true, true, false, false, false, true);
        public void Initier_les_entites()
        {
            Entite Esprit = new Entite("Esprit", 50, 25, true, true, false, false, false, true, false);
            Entite Spectre = new Entite("Spectre", 50, 25, false, true, false, false, true, true, false);
            Entite Fantome = new Entite("Fantome", 50, 0, false, false, true, false, true, true, false);
            Entite Poltergeist = new Entite("Poltergeist", 50, 0, true, false, true, false, false, true, false);
            Entite Banshee = new Entite("Banshee", 50, 0, false, false, true, true, true, false, false);
            Entite Djinn = new Entite("Djinn", 50, 0, false, true, true, false, false, false, true);
            Entite Cauchemar = new Entite("Cauchemar", 60, 0, true, false, false, true, false, true, false);
            Entite Revenant = new Entite("Revenant", 50, 0, true, false, false, true, false, false, true);
            Entite Ombre = new Entite("Ombre", 35, 0, true, true, false, false, false, false, true);
            Entite Demon = new Entite("Demon", 70, 20, true, false, true, false, false, false, true);
            Entite Yurei = new Entite("Yurei", 50, 0, false, false, false, true, true, false, true);
            Entite Oni = new Entite("Oni", 50, 0, false, true, false, false, true, false, true);
            Entite Yokai = new Entite("Yokai", 80, 0, false, false, false, true, true, true, false);
            Entite Hantu = new Entite("Hantu", 50, 25, false, false, true, true, false, false, true);
            Entite Goryo = new Entite("Goryo", 50, 0, false, true, true, false, true, false, false);
            Entite Myling = new Entite("Myling", 50, 0, true, true, true, false, false, false, false);
            Entite Onryo = new Entite("Onryo", 60, 0, false, false, false, true, false, true, true);
            Entite Jumeaux = new Entite("Jumeaux", 50, 0, false, true, false, false, false, true, true);
            Entite Raiju = new Entite("Raiju", 65, 0, false, true, false, true, true, false, false);
            Entite Obake = new Entite("Obake", 50, 0, false, true, true, true, false, false, false);
            Entite Mimic = new Entite("Mimic", 100, 0, false, false, true, true, false, true, true);
            Entite Moroi = new Entite("Moroi", 50, 0, true, false, false, false, false, true, true);
            Entite Deogen = new Entite("Deogen", 40, 0, true, false, false, false, true, true, false);
            Entite Thaye = new Entite("Thaye", 50, 0, true, false, false, true, true, false, false);
            //liste_entite.Items.Add(Jumeaux.Name);
            //liste_entite.Items.Add(GetPropValue(Fantome, "Dots"));
            //liste_entite.Items.Add(GetPropValue2(Fantome, "Dots"));
        }
        List<Entite> Liste_des_Entites = new List<Entite>();
        public void Lister_les_entites_rate()
        {
            Liste_des_Entites.Add(new Entite("Esprit", 50, 25, true, true, false, false, false, true, false));
            Liste_des_Entites.Add(new Entite("Spectre", 50, 25, false, true, false, false, true, true, false));
            Liste_des_Entites.Add(new Entite("Fantome", 50, 0, false, false, true, false, true, true, false));
            Liste_des_Entites.Add(new Entite("Poltergeist", 50, 0, true, false, true, false, false, true, false));
            Liste_des_Entites.Add(new Entite("Banshee", 50, 0, false, false, true, true, true, false, false));
            Liste_des_Entites.Add(new Entite("Djinn", 50, 0, false, true, true, false, false, false, true));
            Liste_des_Entites.Add(new Entite("Cauchemar", 60, 0, true, false, false, true, false, true, false));
            Liste_des_Entites.Add(new Entite("Revenant", 50, 0, true, false, false, true, false, false, true));
            Liste_des_Entites.Add(new Entite("Ombre", 35, 0, true, true, false, false, false, false, true));
            Liste_des_Entites.Add(new Entite("Demon", 70, 20, true, false, true, false, false, false, true));
            Liste_des_Entites.Add(new Entite("Yurei", 50, 0, false, false, false, true, true, false, true));
            Liste_des_Entites.Add(new Entite("Oni", 50, 0, false, true, false, false, true, false, true));
            Liste_des_Entites.Add(new Entite("Yokai", 80, 0, false, false, false, true, true, true, false));
            Liste_des_Entites.Add(new Entite("Hantu", 50, 25, false, false, true, true, false, false, true));
            Liste_des_Entites.Add(new Entite("Goryo", 50, 0, false, true, true, false, true, false, false));
            Liste_des_Entites.Add(new Entite("Myling", 50, 0, true, true, true, false, false, false, false));
            Liste_des_Entites.Add(new Entite("Onryo", 60, 0, false, false, false, true, false, true, true));
            Liste_des_Entites.Add(new Entite("Jumeaux", 50, 0, false, true, false, false, false, true, true));
            Liste_des_Entites.Add(new Entite("Raiju", 65, 0, false, true, false, true, true, false, false));
            Liste_des_Entites.Add(new Entite("Obake", 50, 0, false, true, true, true, false, false, false));
            Liste_des_Entites.Add(new Entite("Mimic", 100, 0, false, false, true, true, false, true, true));
            Liste_des_Entites.Add(new Entite("Moroi", 50, 0, true, false, false, false, false, true, true));
            Liste_des_Entites.Add(new Entite("Deogen", 40, 0, true, false, false, false, true, true, false));
            Liste_des_Entites.Add(new Entite("Thaye", 50, 0, true, false, false, true, true, false, false));
        }
        public void Lister_les_entites()
        {
            Entite Esprit = new Entite("Esprit", 50, 25, true, true, false, false, false, true, false);
            Entite Spectre = new Entite("Spectre", 50, 25, false, true, false, false, true, true, false);
            Entite Fantome = new Entite("Fantome", 50, 0, false, false, true, false, true, true, false);
            Entite Poltergeist = new Entite("Poltergeist", 50, 0, true, false, true, false, false, true, false);
            Entite Banshee = new Entite("Banshee", 50, 0, false, false, true, true, true, false, false);
            Entite Djinn = new Entite("Djinn", 50, 0, false, true, true, false, false, false, true);
            Entite Cauchemar = new Entite("Cauchemar", 60, 0, true, false, false, true, false, true, false);
            Entite Revenant = new Entite("Revenant", 50, 0, true, false, false, true, false, false, true);
            Entite Ombre = new Entite("Ombre", 35, 0, true, true, false, false, false, false, true);
            Entite Demon = new Entite("Demon", 70, 20, true, false, true, false, false, false, true);
            Entite Yurei = new Entite("Yurei", 50, 0, false, false, false, true, true, false, true);
            Entite Oni = new Entite("Oni", 50, 0, false, true, false, false, true, false, true);
            Entite Yokai = new Entite("Yokai", 80, 0, false, false, false, true, true, true, false);
            Entite Hantu = new Entite("Hantu", 50, 25, false, false, true, true, false, false, true);
            Entite Goryo = new Entite("Goryo", 50, 0, false, true, true, false, true, false, false);
            Entite Myling = new Entite("Myling", 50, 0, true, true, true, false, false, false, false);
            Entite Onryo = new Entite("Onryo", 60, 0, false, false, false, true, false, true, true);
            Entite Jumeaux = new Entite("Jumeaux", 50, 0, false, true, false, false, false, true, true);
            Entite Raiju = new Entite("Raiju", 65, 0, false, true, false, true, true, false, false);
            Entite Obake = new Entite("Obake", 50, 0, false, true, true, true, false, false, false);
            Entite Mimic = new Entite("Mimic", 100, 0, false, false, true, true, false, true, true);
            Entite Moroi = new Entite("Moroi", 50, 0, true, false, false, false, false, true, true);
            Entite Deogen = new Entite("Deogen", 40, 0, true, false, false, false, true, true, false);
            Entite Thaye = new Entite("Thaye", 50, 0, true, false, false, true, true, false, false);
            Liste_des_Entites.Add(Esprit);
            Liste_des_Entites.Add(Spectre);
            Liste_des_Entites.Add(Fantome);
            Liste_des_Entites.Add(Poltergeist);
            Liste_des_Entites.Add(Banshee);
            Liste_des_Entites.Add(Djinn);
            Liste_des_Entites.Add(Cauchemar);
            Liste_des_Entites.Add(Revenant);
            Liste_des_Entites.Add(Ombre);
            Liste_des_Entites.Add(Demon);
            Liste_des_Entites.Add(Yurei);
            Liste_des_Entites.Add(Oni);
            Liste_des_Entites.Add(Yokai);
            Liste_des_Entites.Add(Hantu);
            Liste_des_Entites.Add(Goryo);
            Liste_des_Entites.Add(Myling);
            Liste_des_Entites.Add(Onryo);
            Liste_des_Entites.Add(Jumeaux);
            Liste_des_Entites.Add(Raiju);
            Liste_des_Entites.Add(Obake);
            Liste_des_Entites.Add(Mimic);
            Liste_des_Entites.Add(Moroi);
            Liste_des_Entites.Add(Deogen);
            Liste_des_Entites.Add(Thaye);
        }
        public void afficher_attributs_entite(string nom_du_bouton)
        {

            liste_tips.Items.Clear();
            var find = Liste_des_Entites.FirstOrDefault(x => x.Name == nom_du_bouton);

            string Nom_e = find.Name;
            string Cool_e = find.Cooldown.ToString();
            string Seuil_e = find.Seuil_attack.ToString();

            string Ecriture_e = find.Ecriture.ToString();
            string EMF_e = find.EMF.ToString();
            string Empreintes_e = find.Empreintes.ToString();
            string Orbes_e = find.Orbes.ToString();
            string Dots_e = find.Dots.ToString();
            string Spirit_e = find.Spirit.ToString();
            string Temperature_e = find.Temperature.ToString();

            List<string> Liste_des_strings_bool = new List<string>();
            Liste_des_strings_bool.Add(Ecriture_e);
            Liste_des_strings_bool.Add(EMF_e);
            Liste_des_strings_bool.Add(Empreintes_e);
            Liste_des_strings_bool.Add(Orbes_e);
            Liste_des_strings_bool.Add(Dots_e);
            Liste_des_strings_bool.Add(Spirit_e);
            Liste_des_strings_bool.Add(Temperature_e);
            List<string> Liste_des_strings_nom_bouton = new List<string>();
            Liste_des_strings_nom_bouton.Add("Ecriture");
            Liste_des_strings_nom_bouton.Add("EMF");
            Liste_des_strings_nom_bouton.Add("Empreintes");
            Liste_des_strings_nom_bouton.Add("Orbes");
            Liste_des_strings_nom_bouton.Add("Dots");
            Liste_des_strings_nom_bouton.Add("Spirit");
            Liste_des_strings_nom_bouton.Add("Temperature");

            string ligne_1 = $"[{Nom_e}] de Cooldown [{Cool_e}] s.";
            string ligne_2 = $"Attaque à partir de [{Seuil_e}%]";
            string ligne_3 = "";
            //foreach (string s in Liste_des_strings)
            //{
            //    if (s.ToString() == "True")
            //    {
            //        //Liste_des_strings.FindIndex(s => s.ToString() == "True");
            //        ligne_3 = ligne_3 + Liste_des_strings.IndexOf(s) + " ; ";
            //    }

            //}
            //int index = Liste_des_strings.FindIndex(a => a.ToString() == "true");
            //ligne_3 = ligne_3 + index;
            
            for (int i = 0; i < Liste_des_strings_bool.Count; i++)
            {
                if (Liste_des_strings_bool[i].ToString() == "True")
                {
                    ligne_3 = ligne_3 + Liste_des_strings_nom_bouton[i].ToString() + " ; ";
                }
            }
            liste_tips.Items.Add(ligne_1);
            liste_tips.Items.Add(ligne_2);
            liste_tips.Items.Add(ligne_3);


            //liste_tips.Items.Add(Liste_des_strings.IndexOf(Ecriture_e));
            //liste_tips.Items.Add(Liste_des_strings.IndexOf(EMF_e));
            //liste_tips.Items.Add(Liste_des_strings.IndexOf(Empreintes_e));
            //liste_tips.Items.Add(Liste_des_strings.IndexOf(Orbes_e));
            //liste_tips.Items.Add(Liste_des_strings.IndexOf(Dots_e));
            //liste_tips.Items.Add(Liste_des_strings.IndexOf(Spirit_e));
            //liste_tips.Items.Add(Liste_des_strings.IndexOf(Temperature_e));
            //liste_tips.Items.Add(Liste_des_strings[1]);
            //liste_tips.Items.Add(Liste_des_strings[2]);
            //liste_tips.Items.Add(Liste_des_strings[3]);
            //liste_tips.Items.Add(Liste_des_strings[4]);

            //Dictionary<string, string> Liste_des_strings = new Dictionary<string, string>();
            //Liste_des_strings.Add(nameof(Ecriture_e), Ecriture_e.ToString());
            //Liste_des_strings.Add(nameof(EMF_e), EMF_e.ToString());
            //Liste_des_strings.Add(nameof(Empreintes_e), Empreintes_e.ToString());
            //Liste_des_strings.Add(nameof(Orbes_e), Orbes_e.ToString());
            //Liste_des_strings.Add(nameof(Dots_e), Dots_e.ToString());
            //Liste_des_strings.Add(nameof(Spirit_e), Spirit_e.ToString());
            //Liste_des_strings.Add(nameof(Temperature_e), Temperature_e.ToString());
        }
        List<int> Liste_des_Cooldown = new List<int>();
        public void Lister_les_cooldowns()
        {
            Liste_des_Cooldown.Add(0);
            Liste_des_Cooldown.Add(25);
        }
        List<int> Liste_des_Seuil = new List<int>();
        public void Lister_les_seuils()
        {
            Liste_des_Seuil.Add(35);
            Liste_des_Seuil.Add(40);
            Liste_des_Seuil.Add(50);
            Liste_des_Seuil.Add(60);
            Liste_des_Seuil.Add(65);
            Liste_des_Seuil.Add(70);
            Liste_des_Seuil.Add(80);
            Liste_des_Seuil.Add(100);
        }
        public void charger_liste_cooldown()
        {
            cooldown_domain.Items.Clear();
            cooldown_domain.Items.Add("Cooldown");
            foreach (int cool in Liste_des_Cooldown)
            {
                cooldown_domain.Items.Add(cool.ToString());
            }
        }
        public void charger_liste_seuil()
        {
            seuil_domain.Items.Clear();
            seuil_domain.Items.Add("Seuil d'attaque");
            foreach (int seuil in Liste_des_Seuil)
            {
                seuil_domain.Items.Add(seuil.ToString());
            }
        }
        public void afficher_entite_cooldown_corespondant()
        {
           foreach (Entite entite in Liste_des_Entites)
           {
               if (entite.Cooldown.ToString() == cooldown_domain.SelectedItem.ToString())
               {
                    liste_c.Items.Add(entite.Name);
               }
           }
        }
        public void afficher_entite_seuil_corespondant()
        {
            foreach (Entite entite in Liste_des_Entites)
            {
                if (entite.Seuil_attack.ToString() == seuil_domain.SelectedItem.ToString())
                {
                    liste_s.Items.Add(entite.Name);
                }
            }

        }
        public void changer_couleur_btn (string preuve)
        {
            //List<string> Liste_des_strings_bool = new List<string>();
            //Liste_des_strings_bool.Add("Ecriture_e");
            //Liste_des_strings_bool.Add("EMF_e");
            //Liste_des_strings_bool.Add("Empreintes_e");
            //Liste_des_strings_bool.Add("Orbes_e");
            //Liste_des_strings_bool.Add("Dots_e");
            //Liste_des_strings_bool.Add("Spirit_e");
            //Liste_des_strings_bool.Add("Temperature_e");
            //Liste_des_strings_bool.Add("Ecriture");
            //Liste_des_strings_bool.Add("EMF");
            //Liste_des_strings_bool.Add("Empreintes");
            //Liste_des_strings_bool.Add("Orbes");
            //Liste_des_strings_bool.Add("Dots");
            //Liste_des_strings_bool.Add("Spirit");
            //Liste_des_strings_bool.Add("Temperature");

            foreach (Entite entite in Liste_des_Entites)
            {
                if ((bool)entite.GetType().GetProperty(preuve).GetValue(entite, null))
                {
                    liste_entite.Items.Add(entite.Name);
                    liste_entite.Items.Add((string)entite.GetType().GetProperty(preuve).Name);
                    liste_entite.Items.Add((bool)entite.GetType().GetProperty(preuve).GetValue(entite, null));
                    foreach(Button btn_entite in Table_des_entites.Controls)
                    {
                        if ((string)btn_entite.Name.Replace("_button", "") == (string)entite.Name)
                        {
                            (btn_entite as Control).BackColor = Color.FromKnownColor(KnownColor.MenuHighlight);
                        }
                    }
                }
                else
                {

                }
            }
        }
        public bool GetPropValue(object src, string propName)
        {
            //ajouter static au besoin dans la def de la fonction
            return (bool)src.GetType().GetProperty(propName).GetValue(src, null);
        }
        public string GetPropValue2(object src, string propName)
        {
            //ajouter static au besoin dans la def de la fonction
            return (string)src.GetType().GetProperty(propName).Name;
        }
    }
}