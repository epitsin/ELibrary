using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SearchInDb
/// </summary>
public class SearchInDb
{
	public SearchInDb()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static String GetURL(String pStrISBN)
    {
        String strReturn = "";
        System.Data.DataTable dt = new System.Data.DataTable();
        if (pStrISBN == "")
        {
            return strReturn;
        }
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\ Client_Server_2\\Services\\App_Data\\findURLSQL.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        using (conn)
        {
            SqlCommand cmd = new SqlCommand("Select URL, ISBN from tISBN where ISBN= '" + pStrISBN + "'", conn);
            try
            {
                conn.Open();
                dt.Load(cmd.ExecuteReader());
                if (dt.Rows.Count == 0)
                {
                    return strReturn;
                }
                strReturn = dt.Rows[0]["URL"].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                strReturn = "";
            }
            return strReturn;
        }
    }
}