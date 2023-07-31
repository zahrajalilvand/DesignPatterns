namespace Composite_Menu.Model.Entities
{
    public class CategoryItem : CategoryComponent
    {
        public CategoryItem()
        {
            
        }
        public CategoryItem(string name, string link) 
        {
            Name = name;
            Link = link;
        }

        public string Link { get; set; }

        public override string Print()
        {
            return "";
        }
        public override void Add(CategoryComponent category)
        {
            throw new NotImplementedException();
        }

        public override void Remove(CategoryComponent category)
        {
            throw new NotImplementedException();
        }
    }
}
