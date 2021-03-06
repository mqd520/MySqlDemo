﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using Common;

namespace MySqlDemo.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            log4net.ILog logger = log4net.LogManager.GetLogger("myDebugAppender");
            CommonLogger.WriteLog(ELogCategory.Info, "MySqlDemo.Web MvcApplication Startup ...");

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_PreSendRequestHeaders(object sender, EventArgs e)
        {
            HttpApplication app = sender as HttpApplication;
            if (app != null && app.Context != null)
            {
                app.Context.Response.Headers.Remove("Server");
                app.Context.Response.Headers.Remove("X-AspNet-Version");
                app.Context.Response.Headers.Remove("X-AspNetMvc-Version");
            }
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            HttpApplication http = sender as HttpApplication;
            Exception exception = Server.GetLastError();
            CommonLogger.WriteLog(
                ELogCategory.Fatal,
                string.Format("MvcApplication.Application_Error Exception: {0}", exception.Message),
                e: exception
            );

            Server.ClearError();
            http.Response.StatusCode = 500;
            http.Response.Write("500");
            http.Response.End();
        }
    }
}
