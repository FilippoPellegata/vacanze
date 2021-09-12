using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrWebCam.Demo
{
    class biglietto
    {

       
        private string nome;
        private string cognome;
        private string data;
        private string settore;
        private string fila;
        private string posto;
        private string sesso;





        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Data { get => data; set => data = value; }
        public string Sesso { get => sesso; set => sesso = value; }
        public string Settore { get => settore; set => settore = value; }
        public string Fila { get => fila; set => fila = value; }
        public string Posto { get =>posto; set => posto = value; }
       

        public biglietto()
        {
            
            nome = "nome";
            cognome = "cognome";
            data = "data";
            settore = "settore";
            sesso = "sesso";
            fila = "fila";
            posto = "posto";

        }
       

        public string toString()
        {
            return nome + " " + cognome + " " + data + " " + settore + "  " + fila + "  " + posto;
        }
        public string toCSV()
        {
            return nome + ";" + cognome + ";" + data + ";" + settore + ";" + fila + ";" + posto + ";";
        }

        public string toCSVQr()
        {
            return nome + "." + cognome;
        }
        public void fromQr(string qr)
        {
            string[] temp = qr.Split(';');
            List<int> lista = new List<int>();
            cognome = temp[0];
            nome = temp[1];
            data = temp[2];
            sesso = temp[3];
            settore = temp[4];
            fila = temp[5];
            posto = temp[6];


        }
    }
}
