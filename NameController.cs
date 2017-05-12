﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Demo
{
	public static class WebApiConfig
	{
        public static void Register(HttpConfiguration config)
        {
            //Web API Configuration and services

            //Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}"

                )
                

        }
	}
}
