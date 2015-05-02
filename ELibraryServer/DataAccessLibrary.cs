using ELibraryServer.BiblioDataSetTableAdapters;
using System.Data;
using System.Data.SqlClient;

namespace ELibraryServer
{
    public class DataAccessLibrary
    {
        public DataSet GetELibraryDataSet()
        {
            BiblioDataSet ds = new BiblioDataSet();
            BooksTableAdapter booksTA = new BooksTableAdapter();
            booksTA.Fill(ds.Books);
            BookTypesTableAdapter bookTypesTA = new BookTypesTableAdapter();
            bookTypesTA.Fill(ds.BookTypes);

            return ds;
        }

        public DataTable GetBooksByCategory(string category)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            connection.ConnectionString = ELibraryServer.Properties.Settings.Default.libraryConnectionString;
            try
            {
                using(connection)
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "Select Authors, Title, ISBN from Titles where BookTypeID = '" + category + "'";
                    table.Load(command.ExecuteReader());
                }
            }
            catch(SqlException ex)
            {
                connection.Close();
            }

            return table;
        }

        public DataTable GetBookTypes()
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            connection.ConnectionString = ELibraryServer.Properties.Settings.Default.libraryConnectionString;
            try
            {
                using (connection)
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "Select * from BookTypes";
                    table.Load(command.ExecuteReader());
                }
            }
            catch (SqlException ex)
            {
                connection.Close();
            }

            return table;
        }
    }
}
