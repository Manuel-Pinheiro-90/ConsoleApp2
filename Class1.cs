using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Persona
    {
        private string nome;
        private string cognome;
        private int eta;


        public Persona(string nome, string cognome, int eta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
        }
        public string GetNome()
        { return nome; }

        public string GetCognome()
        { return cognome; }

        public int Geteta()
        { return eta; }

        public string GetDettagli()
        { return "nome:" + GetNome() + " cognome: " + GetCognome() + " età: " + Geteta(); }

        
        
        
        
        
        
      

       



    }
}
