using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Joueur : Unit
{
    public Joueur()
    {
        this.nom = "Bidouille";
        this.points_de_vie = 100;
        this.points_armure = 30;
    }

    public Joueur(String name, int pv, int pa)
    {
        this.nom = name;
        this.points_de_vie = pv;
        this.points_armure = pa;
    }
}
