using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass
{
    public static class Banco // classe estática?? não necessita instancia para consumir os métodos da classe
    {
        public static MySqlCommand Abrir() 
        {
            MySqlCommand comm = new MySqlCommand();
            string strconecta = @"server=127.0.0.1;user id=root;database=dbsncmusic;password=";//caminho do banco
            MySqlConnection cn = new MySqlConnection(strconecta);
            try
            {
                cn.Open();
                comm.Connection = cn;
            }
            catch (Exception)
            {
                
            }
            return comm;
        }
    }
}
