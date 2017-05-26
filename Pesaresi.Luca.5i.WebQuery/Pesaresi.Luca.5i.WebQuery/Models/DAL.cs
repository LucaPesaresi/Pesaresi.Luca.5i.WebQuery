using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Pesaresi.Luca._5i.WebQuery
{
    public class DAL
    {

        string NomeServer = @"";
        string tipoSicurezza = @";Persist Security Info=False";

        System.Data.OleDb.OleDbConnection cn { get; set; }

        // Nome del file .MDB
        public string DBFileName { get; set; }

        // Connection string
        public string ConnectionString { get; set; }

        // La stringa di connessione
        public DAL() { }

        public DAL(string dbFileName)
        {
            string NomeFileDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\" + dbFileName;
            ConnectionString = NomeServer + NomeFileDb + tipoSicurezza;
            cn = new System.Data.OleDb.OleDbConnection(ConnectionString);
        }

        public DataTable Getdata(string query)
        {

            DataTable tbl = new DataTable();
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, cn);
            System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter(cmd);
            adapter.Fill(tbl);
            return tbl;
        }
    }
}