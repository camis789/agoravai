using SisProdutos.Config;
using SisProdutos.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SisProdutos.Service
{
    class CategoryService
    {
        DbContextProduct context = new DbContextProduct();

        public Category AddCategory(Category category)
        {
            category.DateCreate = DateTime.Now;

            context.Categorys.Add(category);

            context.SaveChanges();

            return category;
        }

     
        public bool CategoryTest(Category category)
        {
            var ress = context.Categorys.Where(x => x.Name == category.Name).FirstOrDefault();
            if (ress == null)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
            public List<Category> ListCategory()
            {
                var result = context.Categorys.ToList();

                return result;
            }

        }

            
    }

