using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Unit
{

    public string nom;
    public int points_de_vie;
    public int points_armure;
    public bool est_en_vie;

    public Unit()
    {
        nom = "Bidulle";
        points_de_vie = 100;
        points_armure = 30;
    }

    public Unit(string name, int pdv, int pdd)
    {
        nom = name;
        points_de_vie = pdv;
        points_armure = pdd;
    }

    private int RandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }

    public void attaque(String name)
    {
        Console.WriteLine(name + " attaque " + this.nom);
    }

    public void subit_attaque()
    {
        int degats = RandomNumber(7, 10);
        this.points_de_vie -= degats;
        if (this.points_de_vie < 0)
        {
            this.points_de_vie = 0;
            Console.WriteLine(this.nom + " subit une attaque de " + degats + " de dégats, il lui reste " + this.points_de_vie + " de points de vie");
        }
        else
        {
            Console.WriteLine(this.nom + " subit une attaque de " + degats + " de dégats, il lui reste " + this.points_de_vie + " de points de vie");
        }

        if (this.points_de_vie <= 0)
        {
            est_en_vie = false;
            Console.WriteLine(this.nom + " est vaincu");
        }
    }

    public void soin()
    {
        int soin = RandomNumber(100, 110);
        this.points_de_vie += soin;

        if (this.points_de_vie > 100)
        {
            this.points_de_vie = 100;
            Console.WriteLine(this.nom + " gagne " + soin + " de points de vie");
        }
        else
        {
            Console.WriteLine(this.nom + " gagne " + soin + " de points de vie");
        }

    }
}

