using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.EntityLayer.Concrete;

namespace DesignPattern.DataAccessLayer.Abstract
{
    public interface ICustomerDal:IGenericDal<Customer>
    {
    }
}
