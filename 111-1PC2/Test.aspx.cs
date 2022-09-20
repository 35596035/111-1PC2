using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC2
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i_In = 66377;
            double d_Ou = -1;
            double d_Sum = (double)i_In;
            d_Ou = d_Sum * (9.0 / 5.0) + 32.0;
            Response.Write(d_Ou);
        }
    }
}