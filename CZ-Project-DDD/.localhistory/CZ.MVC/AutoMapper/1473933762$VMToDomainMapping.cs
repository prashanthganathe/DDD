using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CZ.MVC.ViewModels;
using CZ.Domain.Entities;

namespace CZ.MVC.AutoMapper
{
    public class VMToDomainMapping:Profile
    {
        public override string ProfileName
        {
            get { return "VMToDomainMapping"; }
        }


        protected static void Configure()
        {
            var config = new MapperConfiguration(cfg => {

                cfg.CreateMap<Client,ClientVM>();
                cfg.CreateMap<Product,ProductVM>();

            });

        }
    }
}