﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jthacker2747ex2d1.Startup))]
namespace jthacker2747ex2d1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
