using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Xpo;
using DevExpress.Web;

namespace XpoWebApplication {
    public partial class _Default : System.Web.UI.Page {

        protected void Page_Init(object sender, EventArgs e) {
            XpoDataSource1.Session = XpoHelper.GetNewSession();
        }
    }
}
