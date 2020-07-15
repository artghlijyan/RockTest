using System.Collections.Generic;
using WarehouseTask.Model.Abstraction;

namespace WarehouseTask.Warehouse.Abstraction
{
    abstract class BaseWarehouse
    {
        public abstract IEnumerable<Material> Materials { get; }
        public abstract void Add(IEnumerable<Material> materials);
        public abstract void Remove(Material materials);
    }
}
