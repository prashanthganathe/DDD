using AutoMapper;
using CZ.Domain.Entities;
using CZ.MVC.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZ.MVC.AutoMapper
{
    public class DomainToVMMapping : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToVMMapping"; }
        }

        protected override void Configure()
        {
            var config = new MapperConfiguration(cfg => {

                cfg.CreateMap<ClientVM, Client>();
                cfg.CreateMap<ProductVM, Product>();

            });

        }
    }
}