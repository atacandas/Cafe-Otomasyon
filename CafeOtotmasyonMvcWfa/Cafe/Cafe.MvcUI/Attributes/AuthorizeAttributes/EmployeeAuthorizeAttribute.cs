using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cafe.MvcUI.Attributes.AuthorizeAttributes
{
    public class EmployeeAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["myLogin"] != null)
            {
                return true;
            }
            else
            {
                httpContext.Response.Redirect("/Account/AdminLogin");
                return false;
            }
        }
    }
}