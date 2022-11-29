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

        //Costruttore
        public Prodotto(string name, string description, float price, int iva)
        {
            this.code = code;
            this.name = name;
            this.description = description;
            this.price = price;
            this.iva = iva;
        }

        //Setters

        /*public void SetCode (int code)
        {
            this.code = code;
        }*/

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

        //Getters

        public int GetCode() { return code; }
        public string GetName() { return name; }
        public string GetDescription() { return description; }
        public float GetPrice() { return price; }
        public int GetIva() { return iva; }

        //metodi
        public int CreateCode()
        {   
            Random rnd = new Random();
            int randCode;
            randCode = rnd.Next(1, 100);
            this.code = randCode;

            return randCode;
        }
    }
}
