﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Centric_Consulting_Project.Models
{
    public class Recognize
    {
        public int RecognizeID { get; set; }
        public int EmployeeID { get; set; }
        public enum CoreValue { Stewardship, Culture, Innovation, [Description("Delivery Excellence")] DeliveryExcellence, [Description("Greater Good")] GreaterGood, [Description("Integrity and Openness")] IntegrityandOpenness, Balance}
        public CoreValue CoreValueIndicator { get; set; }
        public string Message { get; set; }
        public enum TxtorEmail { Text, Email}
        public TxtorEmail MessageOption { get; set; }


    }
}