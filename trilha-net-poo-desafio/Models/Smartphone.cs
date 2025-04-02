namespace DesafioPOO.Models
{ 
    public abstract class Smartphone
    {
        public string _numero;
        private string _modelo;
        private string _imei;
        private int _memoria;
        public string Numero { 
            get
            {
                return _numero;
            }
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O numero nao pode ser vazio");
                }
                _numero = value;
            } 
            
        }
        public string Modelo { 
            get
            {
                return _modelo;
            }
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O modelo nao pode ser vazio");
                }
                _modelo = value;
            } 
            
        }
        public string Imei { 
            get
            {
                return _imei;
            }
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O imei nao pode ser vazio");
                }
                _imei = value;
            } 
            
        }
        public int Memoria { 
            get
            {
                return _memoria;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Esse Telefone nao pode ter memoria negativa");
                }
                _memoria = value;
            } 
        }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        public abstract void Reiniciar();
    }
}