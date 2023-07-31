﻿namespace Composite_Menu.Model.Entities
{
    public abstract class CategoryComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual string Print()
        {
            throw new NotSupportedException();
        }

        public abstract void Add(CategoryComponent category);

        public abstract void Remove(CategoryComponent category);
    }
}
