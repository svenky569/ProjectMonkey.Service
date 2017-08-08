using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nunet.RBSK.BusinessObjects;
using Nunet.RBSK.DataObjects;
using System.Web.Configuration;
namespace WebUnitTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Nunet.RBSK.DataObjects.SqlServer.UserDao user = new Nunet.RBSK.DataObjects.SqlServer.UserDao();
            user.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RBSK_Con"].ConnectionString; 
            user.DeleteUser(6);

        }
    }
}