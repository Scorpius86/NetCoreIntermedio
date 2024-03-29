﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace RealTimeApplication.API.Infrastructure.Data.Entities
{
    public partial class Order
    {
        public Order()
        {
            Trackings = new HashSet<Tracking>();
        }

        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public string Description { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<Tracking> Trackings { get; set; }
    }
}