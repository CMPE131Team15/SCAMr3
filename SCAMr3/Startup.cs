﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SCAMr3.Startup))]
namespace SCAMr3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
