using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_udo10
{
    class Persona
    {
        private string nombre { get; set; }
        private int edad { get; set; }
        private string DNI { get; }
        private char sexo { get; set; }
        private int peso { get; set; }
        private int altura { get; set; }
        private const char s = 'H';
        private const int peso_malo = -1;
        private const int peso_debajo = 0;
        private const int peso_sobre = 1;
        private const string LetraDNI = "TRWAGMYFPDXBNJZSQVHLCKE";
        public string _nombre { get { return nombre; } set { nombre = value; } }
        public int _edad { get { return edad; } set { edad = value; } }
        public char _sexo { get { return sexo; } set { sexo = value; } }
        public int _peso { get { return peso; } set { peso = value; } }
        public int _altura { get { return altura; } set { altura = value; } }



        public Persona()
        {
            this.nombre = "";
            this.edad = 0;
            this.DNI = GeneraDNI();
            this.sexo = s;
            this.peso = 0;
            this.altura = 0;
        }
        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.DNI = GeneraDNI();
            this.sexo = sexo;
            this.peso = 0;
            this.altura = 0;
        }
        public Persona(string nombre, int edad, string DNI, char sexo, int peso, int altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.DNI = DNI;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }
        public int CalcularIMC()
        {
            int resultado = peso_malo;
            if ((this.peso / (Math.Pow(this.altura / 100, 2))) >= 20)
            {
                resultado = peso_debajo;
            }
            if ((this.peso / (Math.Pow(this.altura / 100, 2))) >= 26)
            {
                resultado = peso_sobre;
            }
            return resultado;
        }
        public bool EsMayorDeEdad()
        {
            bool E = false;
            if (this.edad > 17)
            {
                E = true;
            }
            return E;
        }
        private void comprobarSexo(char sexo)
        {
            if ((this.sexo == 'H') | (this.sexo == 'M'))
            {
                //ok
            }
            else
            {
                this.sexo = 'H';
                Console.WriteLine("Valor sexo H por defecto");
            }
        }
        public override string ToString()
        {
            string a = "Nombre:" + this.nombre + "\nEdad:" + this.edad + "\nDNI:" + this.DNI + "\nSexo:" + this.sexo + "\nPeso:" + this.peso + "\nAltura:" + this.altura;
            //return base.ToString();
            Console.WriteLine(a);
            return a;
        }
        private string GeneraDNI()
        {
            Random r = new Random();
            int c = r.Next(10000000, 99999999);

            return Convert.ToString(c) + LetraDNI[c % 23];
        }

    }
    public static void Ex2_udo10()
    {

        Persona P1 = new Persona();
        Console.WriteLine("Introduce el nombre de la Persona 1:");
        P1._nombre = Console.ReadLine();

        Console.WriteLine("Introduce la edad de la Persona 1:");
        P1._edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el sexo de la Persona 1:");
        P1._sexo = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Introduce el peso de la Persona 1:");
        P1._peso = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce la altura de la Persona 1:");
        P1._altura = Convert.ToInt32(Console.ReadLine());

        Persona P2 = new Persona(P1._nombre, P1._edad, P1._sexo);
        P2._altura = 180;
        P2._peso = 100;

        Persona P3 = new Persona();
        P3._nombre = "Lluis";
        P3._edad =23;
        P3._sexo = 'H';
        P3._peso = 98;
        P3._altura = 190;
        int i = P1.CalcularIMC();
        switch (i)
        {
            case 0:
                Console.WriteLine("Persona 1 esta en su peso ideal");
                break;
            case 1:
                Console.WriteLine("Persona 1 esta por encima de su peso ideal");
                break;
            default:
                Console.WriteLine("Persona 1 esta por debajo de su peso ideal");
                break;
        }
        i = P2.CalcularIMC();
        switch (i)
        {
            case 0:
                Console.WriteLine("Persona 2 esta en su peso ideal");
                break;
            case 1:
                Console.WriteLine("Persona 2 esta por encima de su peso ideal");
                break;
            default:
                Console.WriteLine("Persona 2 esta por debajo de su peso ideal");
                break;
        }
        i = P3.CalcularIMC();
        switch (i)
        {
            case 0:
                Console.WriteLine("Persona 3 esta en su peso ideal");
                break;
            case 1:
                Console.WriteLine("Persona 3 esta por encima de su peso ideal");
                break;
            default:
                Console.WriteLine("Persona 3 esta por debajo de su peso ideal");
                break;
        }
        if (P1.EsMayorDeEdad())
        {
            Console.WriteLine("Persona 1 es mayor de edad");
        }
        else
        {
            Console.WriteLine("Persona 1 es menor de edad");
        }
        if (P2.EsMayorDeEdad())
        {
            Console.WriteLine("Persona 2 es mayor de edad");
        }
        else
        {
            Console.WriteLine("Persona 2 es menor de edad");
        }
        if (P3.EsMayorDeEdad())
        {
            Console.WriteLine("Persona 3 es mayor de edad");
        }
        else
        {
            Console.WriteLine("Persona 3 es menor de edad");
        }
        P1.ToString();
        P2.ToString();
        P3.ToString();
    }
}

    

    

