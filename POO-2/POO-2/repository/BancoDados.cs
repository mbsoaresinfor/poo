using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2.repository
{
    public class BancoDados
    {
        string ip;
        string url;


        public BancoDados() { }
        public BancoDados(string ip, string url)
        {
            this.ip = ip;
            this.url = url;
        }

        public void conectar()
        {
            Console.WriteLine($"conectando no banco de dados de ip {ip} e url {url}");
        }

        public void conectar(String ip)
        {
            Console.WriteLine($"conectando no banco de dados de ip {ip} e url {url}");
        }
    }
}
