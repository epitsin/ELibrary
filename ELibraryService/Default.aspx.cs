using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String strURL = "", strISBN;
        strISBN = TextBox1.Text.ToString();
        strISBN = strISBN.Trim();
        // strURL = "http://yahoo.com";
        if (strISBN != "")
        {
            try
            {
                strURL = SearchInDb.GetURL(strISBN);
            }
            catch (Exception) { strURL = "No connection to Database"; }
        }
        else
        {
            HyperLink1.Text = "";
            HyperLink1.NavigateUrl = "";
        }
        if (strURL != "")
        {
            HyperLink1.Text = strURL;
            HyperLink1.NavigateUrl = strURL;
        }
        else
        {
            HyperLink1.Text = "Sorry, we have not found an e-book version!";
            HyperLink1.NavigateUrl = "";
        }
    }

}