using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Hospital
{
    internal class Connection
    {
        private string connectionString;
        private SqlConnection conexion;

        public Connection()
        {
            connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True";
        }

        public void Start()
        {
            try
            {
                // Creamos la conexión con el connection string
                this.conexion = new SqlConnection(this.connectionString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        public void HacerQuery(string queryString)
        {
            try
            {
                // Creamos el objeto con el comando SQL
                SqlCommand query = new SqlCommand(queryString, this.conexion);

                // Abrimos la conexion
                this.conexion.Open();

                // Ejecutamos el comando y guardamos el resultado en un DataReader
                SqlDataReader resultado = query.ExecuteReader();

                while (resultado.Read())
                {
                    // Mostramos el resultado con los nombres de los campos
                    Console.WriteLine(resultado["nombre"] + ",  " + resultado["ubicacion"] + ",  " + resultado["camas_disponibles"]);
                }

                resultado.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            finally
            {
                this.conexion.Close();
            }
        }

        public void HacerNonQuery(string queryString)
        {
            try
            {
                // Abrimos la conexion
                this.conexion.Open();

                // Creamos el objecto con el comando SQL
                SqlCommand query = new SqlCommand(queryString, this.conexion);

                int rowsAffected = query.ExecuteNonQuery();
                Console.WriteLine("Filas = " + rowsAffected);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error \n" + e);
            }
            finally
            {
                this.conexion.Close();
            }
        }

        public void UsarDataTable(string queryString)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(queryString, this.conexion);

                //Using Data Table
                DataTable dt = new DataTable();
                da.Fill(dt);

                Console.WriteLine("Using Data Table");
                //Active and Open connection is not required

                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine(row["nombre"] + ",  " + row["ubicacion"] + ",  " + row["camas_disponibles"]);
                }

                Console.WriteLine("---------------");

                //Using DataSet
                DataSet ds = new DataSet();
                da.Fill(ds, "hospital");

                Console.WriteLine("Using Data Set");

                foreach (DataRow row in ds.Tables["hospital"].Rows)
                {
                    Console.WriteLine(row["nombre"] + ",  " + row["ubicacion"] + ",  " + row["camas_disponibles"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error\n" + e);
            }
        }

        public void MasDataTable()
        {
            try
            {
                //Creating data table instance
                DataTable dataTable = new DataTable("hospital");

                DataColumn id = new DataColumn
                {
                    ColumnName = "id",
                    DataType = Type.GetType("System.Int32"),
                    AutoIncrement = true,
                    AutoIncrementSeed = 1000,
                    AutoIncrementStep = 10
                };
                dataTable.Columns.Add(id);

                //Add the DataColumn few properties
                DataColumn name = new DataColumn("nombre");
                name.MaxLength = 50;
                name.AllowDBNull = false;
                dataTable.Columns.Add(name);

                //Add the DataColumn using defaults
                DataColumn direccion = new DataColumn("direccion");
                dataTable.Columns.Add(direccion);

                //Add New DataRow by creating the DataRow object
                DataRow row1 = dataTable.NewRow();

                row1["nombre"] = "Dana";
                row1["direccion"] = "Hola";
                dataTable.Rows.Add(row1);

                //Supply null for auto increment column
                dataTable.Rows.Add(null, "Maria", "Adios");

                foreach (DataRow row in dataTable.Rows)
                {
                    Console.WriteLine(row["id"] + ",  " + row["nombre"] + ",  " + row["direccion"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error\n" + e);
            }
        }

        public void MasDataSet()
        {
            try
            {
                // Creating Customer Data Table
                DataTable Customer = new DataTable("Customer");

                // Adding Data Columns to the Customer Data Table
                DataColumn CustomerId = new DataColumn("ID", typeof(Int32));
                Customer.Columns.Add(CustomerId);
                DataColumn CustomerName = new DataColumn("Name", typeof(string));
                Customer.Columns.Add(CustomerName);
                DataColumn CustomerMobile = new DataColumn("Mobile", typeof(string));
                Customer.Columns.Add(CustomerMobile);

                //Adding Data Rows into Customer Data Table
                Customer.Rows.Add(101, "Anurag", "2233445566");
                Customer.Rows.Add(202, "Manoj", "1234567890");

                // Creating Orders Data Table
                DataTable Orders = new DataTable("Orders");

                // Adding Data Columns to the Orders Data Table
                DataColumn OrderId = new DataColumn("ID", typeof(System.Int32));
                Orders.Columns.Add(OrderId);
                DataColumn CustId = new DataColumn("CustomerId", typeof(Int32));
                Orders.Columns.Add(CustId);
                DataColumn OrderAmount = new DataColumn("Amount", typeof(int));
                Orders.Columns.Add(OrderAmount);

                //Adding Data Rows into Orders Data Table
                Orders.Rows.Add(10001, 101, 20000);
                Orders.Rows.Add(10002, 102, 30000);

                //Creating DataSet Object
                DataSet dataSet = new DataSet();

                //Adding DataTables into DataSet
                dataSet.Tables.Add(Customer);
                dataSet.Tables.Add(Orders);

                //Fetching Customer Data Table Data
                Console.WriteLine("Customer Table Data: ");

                //Fetching DataTable from Dataset using the Index position
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    //Accessing the data using string column name
                    Console.WriteLine(row["ID"] + ",  " + row["Name"] + ",  " + row["Mobile"]);
                    //Accessing the data using integer index position
                    //Console.WriteLine(row[0] + ",  " + row[1] + ",  " + row[2]);
                }
                Console.WriteLine();

                //Fetching Orders Data Table Data
                Console.WriteLine("Orders Table Data: ");
                //Fetching DataTable from the DataSet using the table name

                foreach (DataRow row in dataSet.Tables["Orders"].Rows)
                {
                    //Accessing the data using string column name
                    Console.WriteLine(row["ID"] + ",  " + row["CustomerId"] + ",  " + row["Amount"]);
                    //Accessing the data using integer index position
                    //Console.WriteLine(row[0] + ",  " + row[1] + ",  " + row[2]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Occurred: {ex.Message}");
            }
        }
    }
}
