using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices
{
  class Program
  {
    static void Main(string[] args)
    {
      List<object> products = new List<object>();

      using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Steve\\documents\\visual studio 2015\\Projects\\Invoices\\Invoices\\Invoices.mdf\";Integrated Security=True"))
      using (SqlCommand cmd = new SqlCommand("SELECT p.IdProduct, p.Name, p.Description, pt.Name Type  FROM Product p LEFT JOIN ProductType pt ON p.IdProductType = pt.IdProductType", connection))
      {
        connection.Open();
        using (SqlDataReader reader = cmd.ExecuteReader())
        {
          // Check is the reader has any rows at all before starting to read.
          if (reader.HasRows)
          {
            // Read advances to the next row.
            while (reader.Read())
            {
              Console.WriteLine("Values:  {0}, {1}, {2}, {3}",
                  reader[0], reader[1], reader[2], reader[3]);
            }

          }
        }
      }
    }
  }
}
