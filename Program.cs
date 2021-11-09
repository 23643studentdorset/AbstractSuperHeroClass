using AbstractSuperHeroClass.models;
using AbstractSuperHeroWithInterface01.Models;
using System;

namespace AbstractSuperHeroClass
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMan superman = new SuperMan ();
            superman.Fly();
            superman.LookTroughObjects();

            Sword sword = new Sword("BatSword");
            sword.TakeDamage(5);

        }
    }
}
