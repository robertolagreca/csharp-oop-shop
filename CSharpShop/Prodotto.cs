using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop
{
    public class Prodotto
    {
        //dichiariazione variabili private
        private int code;
        private string name;
        private string description;
        private float price;
        private int iva;

        
        
        //COSTRUTTORE
        public Prodotto(int code, string name, string description, float price, int iva)
        {
            this.code = code;
            this.name = name;
            this.description = description;
            this.price = price;
            this.iva = iva;
        }

        
        
        //SETTERS

        public void SetName (string name)
        {
            this.name = name;
        }

        public void SetDescription (string description)
        {
            this.description = description;
        }

        public void SetPrice (float price)
        {
            this.price = price;
        }

        public void SetIva(int iva)
        {
            this.iva = iva;
        }

        /*public void SetCode (int code)
       {
           this.code = code;
       }*/




        //GETTERS

        public int GetCode() { return code; }
        public string GetName() { return name; }
        public string GetDescription() { return description; }
        public float GetPrice() { return price; }
        public int GetIva() { return iva; }

        
        
        //METODI

        //Generazione numero casuale
        public void CreateCode()
        {   
            Random rnd = new Random();
            int randCode;
            randCode = rnd.Next(1, 101);
            code = randCode;
            
        }

        //Stampa prezzo senza IVA
        public void BasicPrice(float price)
        {
            Console.WriteLine("Il prezzo base è " + price + " euro");
        }

        //Stampa prezzo con IVA
        public void FullPrice(float price, int iva)
        {
            float fullPrice;

            fullPrice = (float)Math.Round(price + (price * (iva / 100f)), 2);

            Console.WriteLine("Il prezzo compreso di IVA è  " + fullPrice.ToString() + " euro");
        }

        //Stampa nome+codice
        public void FullName(string name, int code)
        {
            string fullName;

            fullName = code.ToString() + name; 
            Console.WriteLine("Il nome completo è " + fullName);
        }

    }
}
