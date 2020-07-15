using System.Collections.Generic;
using WarehouseTask.Model.Abstraction;
using WarehouseTask.Model.Models;
using WarehouseTask.Warehouse.Impl;

namespace WarehouseTask
{
    class Program
    {
        // ToDo - need to be improved
        // will be glad for feedback, thanks

        static void Main(string[] args)
        {
            Material bolt = new Bolt();
            Material copper = new Copper();

            Warehouse1 warehouse = new Warehouse1();
            warehouse.Add(new List<Material>
            {
                bolt,
                copper
            });

            warehouse.Remove(copper);

            warehouse.ShowRest();
        }
    }
}
