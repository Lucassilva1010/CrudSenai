using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaciona.Bd
{
    static class ConecxaoBd
    {


        //Constantes para sempre serem os mesmo valores, pois são as credencias do banco de não podem serem alteradas
        private const string servidor = "localhost";
        private const string bancoDados = "dbCadPessoas";
        private const string usuario = "root";
        private const string senha = "root";

        //String de conexão de banco de dados
        public static string conectaBD = $"server={servidor}; user id={usuario}; database={bancoDados}; password={senha}";

    }
}
