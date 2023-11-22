using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        private int categoryId;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal; 
        }
        public List<Category> GetAll()
        {
            //iş kodları
            return _categoryDal.GetAll();
        }

        public Category GetBy(int categoryid)
        {
            throw new NotImplementedException();
        }

        //Select *from Categories where CategoryId = 3
        public Category GetById(int categoryid)
        {
         return _categoryDal.Get(c => c.CategoryId == categoryId); 
        }
    }
}
