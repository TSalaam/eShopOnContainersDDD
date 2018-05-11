﻿using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.ServiceStack;
using ServiceStack;

namespace eShop.Catalog.Product.Services
{
    [Api("Catalog")]
    [Route("/catalog/products/{ProductId}/unmark", "POST")]
    public class UnMarkReordered : DomainCommand
    {
        public Guid ProductId { get; set; }
    }
}
