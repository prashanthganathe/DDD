﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace CZ.MVC.AutoMapper
{
    public class AutoMapperConfig
    {

        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
                {
                    x.AddProfile<DomainToVMMapping>();
                    x.AddProfile<VMToDomainMapping>();
                });

           
        }

    }
}