﻿using EcommerceAPI.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EcommerceAPI.Domain.Entities
{
    public class Purchase
    {
        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public int PersonId { get; private set; }
        public DateTime Date { get; private set; }
        public Person Person { get; set; }
        public Product  Product { get; set; }

        public Purchase(int productId, int personId, DateTime? date) 
        {
            Validation(productId, personId, date);
        }

        public Purchase(int id, int productId, int personId, DateTime? date)
        {
            DomainValidationException.When(id < 0, "Id deve ser informado");

            Id = id;

            Validation(productId, personId, date);
        }

        private void Validation(int productId, int personId, DateTime? date)
        {
            DomainValidationException.When(productId < 0, "Id produto deve ser informado");
            DomainValidationException.When(personId < 0, "Id pessoa deve ser informado!");
            DomainValidationException.When(!date.HasValue, "Data da compra deve ser informado!");

            ProductId = productId;
            PersonId = personId;
            Date = date.Value;
        }
    }
}
