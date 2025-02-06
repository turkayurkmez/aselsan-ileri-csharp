using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class SqlHelper
    {
        private SqlConnection connection;

        public SqlHelper(string connectionString)
        {
            connection = new(connectionString);

        }

        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            var command = createCommand(query, parameters);
            command.Connection.Open();
            var result = command.ExecuteNonQuery();
            command.Connection.Close();

            return result;
        }

        private SqlCommand createCommand(string query, Dictionary<string, object> parameters)
        {
            var command = connection.CreateCommand();
            command.CommandText = query;
            addParameterToCommand(command, parameters);

            return command;
        }

        private void addParameterToCommand(SqlCommand command, Dictionary<string, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }
        }
    }
}

/*
 *   Kelime listesinden rastgele bir kelime seç.
 *   Bu kelimeyi (*) ile puzzle'a dönüştür.
 *   Bu puzzle'ı kullanıcıya göster.
 *   Kullanıcıdan harf iste.
 *   Eğer harf varsa:
 *        - puzzle içinde harfin yerini bul ve harf ile değiştir.
 *        - puzzle'ı kullanıcıya göster.
 *   harf yoksa:
 *        - hakkını bir azalt.
 *   kelimeyi tahmin etmesini iste.
 *   tahmin edilen ve tutulan kelimeyi karşılaştır.
 *   Eğer doğruysa:
 *        - "Bravo" mesajı göster.
 *   Eğer yanlışsa:
 *        - "Bilemediniz" de. 
 *   
 */