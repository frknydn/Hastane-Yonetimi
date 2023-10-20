﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CreatePrescriptionsDTO
    {
        public int Id { get; set; }

        public string Medication { get; set; }
        public string Instructions { get; set; }
        public int UserID { get; set; }
    }
}
