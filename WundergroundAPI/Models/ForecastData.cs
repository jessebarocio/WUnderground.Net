﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGurus.Weather.WundergroundAPI.Models
{
    public class ForecastData
    {
        public Forecast Forecast { get; set; }
        public Response Response { get; set; }
    }
}
