﻿using Domain.RequestTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASIST_REPORT_REST_API.Models
{
    public class PINRequest : IPINRequest
    {
        public string PIN { get; set; }
    }
}