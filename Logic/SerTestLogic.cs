
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SerTestCore.Models;
using Dapper;
using MySqlConnector;

namespace SerTestCore.Logic
{
    /// <summary>
    /// Classe SerTestLogic
    /// </summary>
    public class SerTestLogic
    {
        internal AppDb Db { get; set; }

        internal SerTestLogic(AppDb db)
        {
            Db = db;
        }
        /// <summary>
        /// Recupero tutti i record della tabella SerTestCore
        /// </summary>
        /// <returns>Records tabella SerTestCore</returns>
        public List<SerTestObj> GetTable()
        {
            List<SerTestObj> cls=new List<SerTestObj>();
            using(var cnn = Db.Connection){
                string query="select * from SerTestTable";
                cls=cnn.Query<SerTestObj>(query).ToList();
            }
            return cls;
        }
    }
}