using Microsoft.Owin;
using Owin;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System;


namespace NVC_Food_APP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}