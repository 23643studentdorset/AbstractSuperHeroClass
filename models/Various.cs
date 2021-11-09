using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSuperHeroClass.models
{

    public abstract class Superhero
    {

    }
    public abstract class Alien: Superhero
    {

    }
    public abstract class Human: Superhero
    {

    }
    
    interface IFly
    {
        void Fly();
    }
    interface ILookTroughObjects
    {
        void LookTroughObjects();
    }

    
    
    
    
    public class SuperMan: Alien, ILookTroughObjects, IFly
    {
        public void LookTroughObjects()
        {
            Console.WriteLine("X-RAY");
        }

        public void Fly()
        {
            Console.WriteLine("With no limits");
        }

    }


    
   
}
