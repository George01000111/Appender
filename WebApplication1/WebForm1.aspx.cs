using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(WebForm1));


        protected void Page_Load(object sender, EventArgs e)
        {
            throw new Exception("este un error al iniciar la pagina");

        }
        void Page_Error(object sender,EventArgs e)
        {
            Exception exc = Server.GetLastError();
            log.Error(exc.Message,exc);
            Server.ClearError();
        }


    }
}