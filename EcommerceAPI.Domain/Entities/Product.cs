using EcommerceAPI.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Domain.Entities
{
    public sealed class Product
    {
        public int Id { get; private set; }
        public string  Name { get; private set; }
        public string CodErp { get; private set; }
        public decimal Price { get; private set; }
        public ICollection<Purchase> Purchases { get; set; }


        // Constructor para adicionar
        public Product(string name, string codErp, decimal price) 
        { 
            Validation(name, codErp, price);
            Purchases = new List<Purchase>();
        }

        // Constructor para editar
        public Product(int id, string name, string codErp, decimal price)
        {
            DomainValidationException.When(id < 0, "Id deve ser maior que 0");
            Id = id;
            Validation(name, codErp, price);
            Purchases = new List<Purchase>();
        }

        private void Validation(string name, string codErp, decimal price)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado!");
            DomainValidationException.When(string.IsNullOrEmpty(codErp), "Código Erp deve ser informado!");
            DomainValidationException.When(price < 0, "Preço deve ser informado!");

            Name = name;
            CodErp = codErp;
            Price = price;
        }
    }
}
