using System;

namespace ex4_udo10
{
    class Electrodomestico
    {
        private int PrecioBase;
        public int _PrecioBase { get { return PrecioBase; } set { PrecioBase = value; } }
        private string Color;
        public string _Color { get { return Color; } set { Color = value; } }
        private char Consumo;
        public char _Consumo { get { return Consumo; } set { Consumo = value; } }
        private int Peso;
        public int _Peso { get { return Peso; } set { Peso = value; } }
        protected const string ConstColor = "blanco";
        protected const char ConstConsumo = 'F';
        protected const int ConstPrecio = 100;
        protected const int ConstPeso = 5;


        public Electrodomestico()
        {
            _Color = ConstColor;
            _Consumo = ConstConsumo;
            _PrecioBase = ConstPrecio;
            _Peso = ConstPeso;
        }
        public Electrodomestico(int Pr, int Pe)
        {
            _Color = ConstColor;
            _Consumo = ConstConsumo;
            _PrecioBase = Pr;
            _Peso = Pe;
        }
        public Electrodomestico(int Pr, int Pe, char Con, string Col)
        {
            _Color = Col;
            _Consumo = Con;
            _PrecioBase = Pr;
            _Peso = Pe;
        }
        public char ValidarConsumo(char c)
        {
            if ((c == 'A') | (c == 'B') | (c == 'C') | (c == 'D') | (c == 'E') | (c == 'F'))
            {
                return c;
            }
            else
            {
                Console.WriteLine("Consumo incorrecto. Valor por defecto 'F'");
                return ConstConsumo;
            }
        }
        public string ValidarColor(string c)
        {
            if ((c == "blanco") | (c == "negro") | (c == "rojo") | (c == "azul") | (c == "gris"))
            {
                return c;
            }
            else
            {
                Console.WriteLine("Color incorrecto. Valor por defecto 'blanco'");
                return ConstColor;
            }
        }
        public int PrecioFinal()
        {
            int BonusConsumo = 0, BonusPeso = 0;
            this.Consumo = ValidarConsumo(this._Consumo);
            switch (this._Consumo)
            {
                case 'A':
                    BonusConsumo = 100;
                    break;
                case 'B':
                    BonusConsumo = 80;
                    break;
                case 'C':
                    BonusConsumo = 60;
                    break;
                case 'D':
                    BonusConsumo = 50;
                    break;
                case 'E':
                    BonusConsumo = 30;
                    break;
                case 'F':
                    BonusConsumo = 10;
                    break;
            }
            if (this._Peso < 20)
            {
                BonusPeso = 10;
            }
            else
            {
                if (this._Peso < 50)
                {
                    BonusPeso = 50;
                }
                else
                {
                    if (this._Peso < 80)
                    {
                        BonusPeso = 80;
                    }
                    else
                    {
                        BonusPeso = 100;
                    }
                }
            }
            this._PrecioBase = this._PrecioBase + BonusPeso + BonusConsumo;
            return this.PrecioBase;
        }
        public new string ToString()
        {
            string a = "Tipo:" + this.GetType().Name + "\nPrecioBase:" + this._PrecioBase + "\nColor:" + this._Color + "\nConsumo:" + this._Consumo + "\nPeso:" + this._Peso;
            //return base.ToString();
            if (this.GetType().Name == "Electrodomestico")
            {
                Console.WriteLine(a);
            }
            return a;
        }

        class Lavadora : Electrodomestico
        {
            private int Carga { get; set; }
            public int _Carga { get { return Carga; } set { Carga = value; } }
            public const int ConstCarga = 5;

            public Lavadora()
            {
                _Color = ConstColor;
                _Consumo = ConstConsumo;
                _PrecioBase = ConstPrecio;
                _Peso = ConstPeso;
                _Carga = ConstCarga;
            }
            public Lavadora(int Pr, int Pe)
            {
                _Color = ConstColor;
                _Consumo = ConstConsumo;
                _PrecioBase = Pr;
                _Peso = Pe;
                _Carga = ConstCarga;
            }
            public Lavadora(int Ca, int Pr, int Pe, char Con, string Col) /*: base (Pr, Pe, Con, Col)*/
            {
                _Color = Col;
                _Consumo = Con;
                _PrecioBase = Pr;
                _Peso = Pe;
                _Carga = Ca;
            }
            public int precioFinal()
            {
                if (_Carga > 30)
                {
                    return _PrecioBase = base.PrecioFinal() + 50;
                }
                else
                {
                    return _PrecioBase = base.PrecioFinal();
                }
            }
            public new string ToString()
            {
                //string a = "Tipo:" + this.GetType().Name + "\nPrecioBase:" + this._PrecioBase + "\nColor:" + this._Color + "\nConsumo:" + this._Consumo + "\nPeso:" + this._Peso;
                string a = base.ToString() + "\nCarga:" + this._Carga;
                Console.WriteLine(a);
                return a;
            }

            class Television : Electrodomestico
            {
                private int Resolucion { get; set; }
                public int _Resolucion { get { return Resolucion; } set { Resolucion = value; } }
                private bool SintonizadorTDT { get; set; }
                public bool _SintonizadorTDT { get { return SintonizadorTDT; } set { SintonizadorTDT = value; } }

                public Television()
                {
                    _Color = ConstColor;
                    _Consumo = ConstConsumo;
                    _PrecioBase = ConstPrecio;
                    _Peso = ConstPeso;
                    _Resolucion = 20;
                    _SintonizadorTDT = false;
                }
                public Television(int Pr, int Pe)
                {
                    _Color = ConstColor;
                    _Consumo = ConstConsumo;
                    _PrecioBase = Pr;
                    _Peso = Pe;
                    _Resolucion = 20;
                    _SintonizadorTDT = false;
                }
                public Television(bool stdt, int Re, int Pr, int Pe, char Con, string Col) /*: base (Pr, Pe, Con, Col)*/
                {
                    _Color = Col;
                    _Consumo = Con;
                    _PrecioBase = Pr;
                    _Peso = Pe;
                    _Resolucion = Re;
                    _SintonizadorTDT = stdt;
                }
                public int precioFinal()
                {
                    int auxi = 0;
                    if (_Resolucion > 40)
                    {
                        _PrecioBase = (int)(base.PrecioFinal() * 1.3);
                        auxi = 1;
                    }
                    if (_SintonizadorTDT)
                    {
                        if (auxi == 1)
                        {
                            _PrecioBase = _PrecioBase + 50;
                        }
                        else
                        {
                            _PrecioBase = base.PrecioFinal() + 50;
                        }
                    }
                    return _PrecioBase;
                }
                public new string ToString()
                {
                    //string a = "Tipo:" + this.GetType().Name + "\nPrecioBase:" + this._PrecioBase + "\nColor:" + this._Color + "\nConsumo:" + this._Consumo + "\nPeso:" + this._Peso;
                    string a = base.ToString() + "\nResolucion:" + this._Resolucion + "\nTDT:" + this._SintonizadorTDT;
                    Console.WriteLine(a);
                    return a;
                }

            }
            public static void Exercici4()
            {

                Electrodomestico A = new Electrodomestico(299, 11, 'C', "rojo");
                //Tienda[0] = A;
                Television B = new Television(false, 60, 599, 25, 'A', "gris");
                //Tienda[1] = B;
                Lavadora C = new Lavadora(9, 399, 60, 'D', "negro");
                //Tienda[2] = C;
                Electrodomestico D = new Electrodomestico(299, 11, 'C', "rojo");
                //Tienda[3] = D;
                Television E = new Television(false, 60, 599, 25, 'A', "gris");
                //Tienda[4] = E;
                Lavadora F = new Lavadora(9, 399, 60, 'D', "negro");
                //Tienda[5] = F;
                Electrodomestico G = new Electrodomestico(299, 11, 'C', "rojo");
                //Tienda[6] = G;
                Television H = new Television(false, 60, 599, 25, 'A', "gris");
                //Tienda[7] = H;
                Lavadora I = new Lavadora(9, 399, 60, 'D', "negro");
                //Tienda[8] = I;
                Electrodomestico J = new Electrodomestico(299, 11, 'C', "rojo");
                //Tienda[9] = J;
                Object[] Tienda = new Object[10] { A, B, C, D, E, F, G, H, I, J };

                int PrecioElectrodomesticos = 0, PrecioLavadoras = 0, PrecioTelevisores = 0;
                Television T;
                Lavadora L;
                Electrodomestico EE;
                foreach (Object x in Tienda)
                {
                    EE = (Electrodomestico)x;
                    if (x.GetType().Name == "Television")
                    {
                        T = (Television)x;
                        PrecioTelevisores = PrecioTelevisores + T.PrecioFinal();
                        T.ToString();
                    }
                    if (x.GetType().Name == "Lavadora")
                    {
                        L = (Lavadora)x;
                        PrecioLavadoras = PrecioLavadoras + L.PrecioFinal();
                        L.ToString();
                    }
                    if (x.GetType().Name == "Electrodomestico")
                    {
                        EE.ToString();
                    }
                    PrecioElectrodomesticos = PrecioElectrodomesticos + E.PrecioFinal();
                }
                Console.WriteLine("TOTAL:" + PrecioElectrodomesticos + " Lavadoras:" + PrecioLavadoras + " Televisores:" + PrecioTelevisores);



            }
            static void Main(string[] args)
            {
                Exercici4();
            }
        }
        }
    }