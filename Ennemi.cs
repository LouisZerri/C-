using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ennemi : Unit
{
    public Ennemi()
    {
        this.nom = "Bidule";
        this.points_de_vie = 100;
        this.points_armure = 20;
    }

    public Ennemi(String name, int pv, int pa)
    {
        this.nom = name;
        this.points_de_vie = pv;
        this.points_armure = pa;
    }
}
