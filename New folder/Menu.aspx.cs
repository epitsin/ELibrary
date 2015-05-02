using ELibraryServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Menu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable bookTypes;
        DataAccessLibrary library = new DataAccessLibrary();
        try
        {
            bookTypes = library.GetBookTypes();
            GridView1.DataSource = bookTypes.DefaultView;
            GridView1.DataBind();
        }
        catch (Exception ex) { LabelErr.Text = "No link to the Data Server!"; }
    }

    public void Get_Category(Object Src, CommandEventArgs Args)
    {
        Response.Redirect("Menu.aspx?Category=" + Args.CommandName);
    }
}