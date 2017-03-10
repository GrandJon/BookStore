using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NIIT.BookStore.Web.Handlers
{
    /// <summary>
    /// MyHandler 的摘要说明
    /// </summary>
    public class MyHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            context.Response.Write("<html>");
            context.Response.Write("<head>");
            context.Response.Write("<Title>Hello");
            context.Response.Write("</Title>");
            context.Response.Write("</head>");
            context.Response.Write("<body>");
            context.Response.Write("Hello World");
            context.Response.Write("</body>");
            context.Response.Write("</html>");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}