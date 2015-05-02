using ELibraryServer.BiblioDataSetTableAdapters;
using System.Data;

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
    }
}
