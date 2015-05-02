using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryServer
{
    public class DataAccessLibrary
    {
        public DataSet GetELibraryDataSet()
        {
            BiblioDataSet ds = new BiblioDataSet();
            BooksTableAdapter booksTA = new BooksTableAdapter();
            booksTA.Fill(ds.Books);
            BooksTableAdapter bookTypesTA = new BooksTableAdapter();
            bookTypesTA.Fill(ds.BookTypes);

            return ds;
        }
    }
}
