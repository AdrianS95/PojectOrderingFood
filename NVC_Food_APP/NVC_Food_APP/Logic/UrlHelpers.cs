using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NVC_Food_APP.Logic
{
    public static class UrlHelpers
    {
        public static string IkonyKategoriiSciezka(this UrlHelper helper, string nazwaIkonyKategorii)
        {
            return helper.Content(Path.Combine(AppConfig.IkonyKategoriFolderWzgledny, nazwaIkonyKategorii));
        }

        public static string ObrazkiSciezka(this UrlHelper helper, string nazwaObrazka)
        {
            return helper.Content(Path.Combine(AppConfig.ObrazkiFolderWzgledny, nazwaObrazka));
        }
    }
}