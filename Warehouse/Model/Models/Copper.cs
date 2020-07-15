using WarehouseTask.Model.Abstraction;

namespace WarehouseTask.Model.Models
{
    class Copper : Material
    {
        private readonly int maxCapacity;

        public Copper() : base("Copper", "Copper Descritpion", "Copper Icon")
        {
            maxCapacity = 110;
        }

        public override int MaxCapacity
        {
            get => this.maxCapacity;
        }

        public override string ToString()
        {
            return $"Name - {Name}, Description - {Description}, Icon - {Icon}, MaxCapacity - {MaxCapacity}";
        }
    }
}
