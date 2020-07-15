using System.Collections.Generic;
using WarehouseTask.Model.Abstraction;
using WarehouseTask.Warehouse.Abstraction;

namespace WarehouseTask.Warehouse.Impl
{
    class Warehouse1 : BaseWarehouse
    {
        private List<Material> materials;

        public override IEnumerable<Material> Materials 
        {
            get => this.materials;
        }

        public Warehouse1()
        {
            this.materials = new List<Material>();
        }

        public override void Add(IEnumerable<Material> materials)
        {
            this.materials.AddRange(materials);
        }

        public override void Remove(Material material)
        {
            this.materials.Remove(material);
        }

        public void ShowRest()
        {
            foreach (var item in materials)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
