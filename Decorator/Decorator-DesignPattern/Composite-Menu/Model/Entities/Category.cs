namespace Composite_Menu.Model.Entities
{
    public class Category:CategoryComponent
    {
        readonly List<CategoryComponent> _menuComponent = new List<CategoryComponent>();
        public ICollection<CategoryComponent> menuItem => _menuComponent;

        public Category() 
        { 
        }

        public Category(string name)
        {
            Name = name;
        }

        public override void Add(CategoryComponent menuComponent)
        {
            _menuComponent.Add(menuComponent);
        }

        public override void Remove(CategoryComponent menuComponent)
        {
            _menuComponent.Remove(menuComponent);
        }

        public override string Print()
        {
            return "";
        }
    }
}
