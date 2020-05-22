using System;

namespace primeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
             personagem capitao = new personagem ();
            Console.WriteLine("Ataque de capitao: "+capitao.Atacar());
            Console.WriteLine("Coragem de capitao: " + capitao.coragem);
            Console.WriteLine("Resestencia de capitao: " + capitao.resistencia);
        }
    }
}
