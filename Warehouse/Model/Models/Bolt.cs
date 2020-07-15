using WarehouseTask.Model.Abstraction;

namespace WarehouseTask.Model.Models
{
    class Bolt : Material
    {
        private readonly int maxCapacity;

        public Bolt() : base("Bolt", "Bolt Desritpion", "Bolt Icon")
        {
            maxCapacity = 100;
        }

        public override int MaxCapacity
        {
            get => this.maxCapacity;
        }

        public override string ToString()
        {
            return $"Name - {Name}, Description - {Description}, Icon - {Icon}, MaxCapacity - {MaxCapacity} ";
        }
    }
}
