using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.EntityLayer.Concrete;

namespace DesignPattern.BusinessLayer.Concrete
{
    public class ProcessManager : IProcessService
    {
        public void TDelete(Process t)
        {
            throw new NotImplementedException();
        }

        public Process TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Process> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Process t)
        {
            throw new NotImplementedException();
        }

        public void TMultiUpdate(List<Process> t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Process t)
        {
            throw new NotImplementedException();
        }
    }
}
