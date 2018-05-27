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
            var ret = helper.Content(Path.Combine(AppConfig.IkonyKategoriFolderWzgledny, nazwaIkonyKategorii));
            if (ret == null)
            {
                return helper.Content(Path.Combine(AppConfig.IkonyKategoriFolderWzgledny, "Domyslny.png"));
            }
            else
            {
                return ret;
            }
        }

        public static string ObrazkiSciezka(this UrlHelper helper, string nazwaObrazka)
        {
            var ret = helper.Content(Path.Combine(AppConfig.ObrazkiFolderWzgledny, nazwaObrazka));
            if (ret == null)
            {
                return helper.Content(Path.Combine(AppConfig.IkonyKategoriFolderWzgledny, "Domyslny.png"));
            }
            else
            {
                return ret;
            }
        }
    }
}