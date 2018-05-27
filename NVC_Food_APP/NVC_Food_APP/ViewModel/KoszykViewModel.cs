using NVC_Food_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NVC_Food_APP.ViewModel
{
    public class KoszykViewModel
    {
        public List<PozycjaKoszyka> PozycjaKoszyka  { get; set; }
        public decimal CenaCalkowita { get; set; }
        
       
    }
}