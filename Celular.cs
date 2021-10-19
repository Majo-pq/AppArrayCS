using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArrayCS
{
    class Celular
    {
        private string marca;
        private string color;
        private string capacidadAlmacenamiento;

        public string Marca
        { 
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public string CapacidadAlmacenamiento
        {
            get
            {
                return capacidadAlmacenamiento;
            }
            set
            {
                capacidadAlmacenamiento = value;
            }
        }
        public Celular()
        {
            marca = "";
            color = "";
            capacidadAlmacenamiento = "";
        }
        public Celular(string marca, string color, string capacidadAlmacenamiento)
        {
            this.marca = marca;
            this.color = color;
            this.capacidadAlmacenamiento = capacidadAlmacenamiento;
        }
        public override string ToString()
        {
            return marca + " - " + color + " - " + capacidadAlmacenamiento;
        }
    }
}
