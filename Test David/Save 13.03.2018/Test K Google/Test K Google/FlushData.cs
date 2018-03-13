using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_K_Google
{
    class FlushData
    {
        private Connexion connect = new Connexion();
        private string sqlCommandWord = "DELETE  FROM `db_thesaurus`.`t_word`";
        private string sqlCommandOccurence = "DELETE  FROM `db_thesaurus`.`t_occurence`";
        private string sqlCommandFile = "DELETE  FROM `t_file`";

        /// <summary>
        /// Constructor qui va effacer tout le contenu des tables
        /// </summary>
        public FlushData()
        {
            connect.SqlCommandINSDEL(sqlCommandOccurence, null);

            connect.SqlCommandINSDEL(sqlCommandFile , null);
            
            
            
            connect.SqlCommandINSDEL(sqlCommandWord , null);


        }
    }
}
