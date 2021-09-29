using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cirque
{
    public abstract class Etre : IEquatable<Etre>
    {
        private string nom;
        //public Type Types{ get; set; }
        // public   string nom { get; private set; }

      /*  public Etre(string nom, Type Types) 
         {
             this.nom = nom;
            this.Types = Types;
         }
         */
         
        public Etre(string nom)
        {
            this.nom = nom;   
        }
        private void SetNom(string Nom)
         {
             nom = Nom;
         }
         public void GetNom(string Nom)
         {
             nom = Nom ;
         }
         public string infos()
        {
            return nom;
        }

        public bool Equals(Etre etre)
        {
            return this.nom == etre.nom;
        }

        //public Etre() { }
    }
}
