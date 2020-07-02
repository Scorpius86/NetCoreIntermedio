﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galaxy.MVC.DI.ApplicationService.Transient
{
    public class GuidTransientApplicationService:IGuidTransientApplicationService
    {
        private Guid _guidService { get; }

        public GuidTransientApplicationService()
        {
            _guidService = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return _guidService.ToString();
        }
    }
}
