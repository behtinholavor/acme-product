using System;

namespace Enterprise.Product
{
    public class Product
    {
        public string Id { get; private set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }

        public Product WithId(string id)
        {
            Id = id;
            return this;
        }
    }
}