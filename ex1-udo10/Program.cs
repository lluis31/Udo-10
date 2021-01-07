using System;

namespace ex1_udo10
{
    class Cuenta
    {
        //atributos
        private string titular;
        private double cantidad;

        //constructor
        public Cuenta()
        {
        }

        public Cuenta (string titular, double cantidad)
        {
            this.titular = titular;

            if (cantidad <0)
            {
                this.cantidad = 0;
            }
            else
            {
                this.cantidad = cantidad;
            }
        }

        //metodos
        public string Gettitular()
        {
            return titular;
        }

        public void settitular()
        {
            this.titular = titular;
        }

        public double getcantidad()
        {
            return cantidad;
        }

        //metodos "especiales"
        public void ingresar(double cantidad)
        {
            if(cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }

        public void retirar (double cantidad)
        {
            if(this.cantidad - cantidad < 0)
            {
                this.cantidad = 0;
            }
            else
            {
                this.cantidad -= cantidad;
            }
        }


        static void Main(string[] args)
        {
            
        }
    }
}
