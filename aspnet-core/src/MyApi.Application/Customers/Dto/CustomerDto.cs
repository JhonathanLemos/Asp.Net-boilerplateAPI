﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyApi.Products;
using MyApi.Products.Dto;
using System.Collections.Generic;

namespace MyApi.Customers.Dto
{
    [AutoMapFrom(typeof(Customer))]
    public class CustomerDto : FullAuditedEntityDto<long>
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Cnpj { get; set; }
    }
}
