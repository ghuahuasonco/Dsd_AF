﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AFRESTServices
{
    public class TPConexion
    {
        public static string CadenaCone 
        {
            get 
            {
                return "Data Source = ghuahuasonco; Initial Catalog = BD_AF; Integrated Security = True";
            }
        }
    }
}