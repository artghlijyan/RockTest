namespace WarehouseTask.Model.Abstraction
{
    abstract class Material
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Icon { get; private set; }
        public abstract int MaxCapacity { get; }

        public Material(string name, string desc, string icon)
        {
            this.Name = name;
            this.Description = desc;
            this.Icon = icon;
        }
    }
}
