using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryDesignPattern.EntityLayer.Concrete;

namespace RepositoryDesignPattern.DataAccessLayer.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        List<Product> ProductListWithCategory();
    }
}
