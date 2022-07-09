using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guide_Phasmo_plus
{
    internal class Entite
    {
        // constructor that takes no arguments:
        public Entite()
        {
            Name = "unknown";
            Seuil_attack = 100;
            Cooldown = 0;
            Ecriture = false;
            EMF = false;
            Empreintes = false;
            Orbes = false;
            Dots = false;
            Spirit = false;
            Temperature = false;
            //tips = 
        }
        public string Name { get; set; }
        public int Seuil_attack { get; set; }
        public int Cooldown { get; set; }
        public bool Ecriture { get; set; }
        public bool EMF { get; set; }
        public bool Empreintes { get; set; }
        public bool Orbes { get; set; }
        public bool Dots { get; set; }
        public bool Spirit { get; set; }
        public bool Temperature { get; set; }

        public Entite(string name, int seuil_attack, int cooldown, bool ecriture, bool eMF, bool empreintes, bool orbes, bool dots, bool spirit, bool temperature)
        {
            Name = name;
            Seuil_attack = seuil_attack;
            Cooldown = cooldown;
            Ecriture = ecriture;
            EMF = eMF;
            Empreintes = empreintes;
            Orbes = orbes;
            Dots = dots;
            Spirit = spirit;
            Temperature = temperature;
            //tips = 
        }
    }
}
