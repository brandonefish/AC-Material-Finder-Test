using AC_Test.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AC_Test
{
    public class Controller
    {
        public List<Materials> GetMaterials()
        {
            List<Materials> MaterialsList = new List<Materials>();
            SqlConnection AC = new SqlConnection();
            AC.ConnectionString = @"Persist Security Info=False;Integrated Security=True;Database=AC;server=(localdb)\MSSQLLocalDB;";
            AC.Open();

            SqlDataReader reader;

            SqlCommand GetMaterialsCommand = new SqlCommand
            {
                Connection = AC,
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "GetMaterialsList"
            };

            reader = GetMaterialsCommand.ExecuteReader();

            while (reader.Read())
            {
                MaterialsList.Add(new Materials()
                {
                    MaterialID = int.Parse(reader["MaterialID"].ToString()),
                    MaterialName = reader["MaterialName"].ToString()
                });
            };

            reader.Close();

            AC.Close();

            return MaterialsList;
        }
    } 
}
    

