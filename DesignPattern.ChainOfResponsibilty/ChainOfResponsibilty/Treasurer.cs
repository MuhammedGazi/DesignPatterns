using DesignPattern.ChainOfResponsibilty.DAL;
using DesignPattern.ChainOfResponsibilty.Models;

namespace DesignPattern.ChainOfResponsibilty.ChainOfResponsibilty
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount=req.Amount.ToString();
                customerProcess.Name=req.Name;
                customerProcess.EmployeeName="Veznedar - Mehmet Turan";
                customerProcess.Description="Para Çekme İşlemi Onaylandı,Müşteriye Talep Edilen Tutar Ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if(NextApprover !=null)
            {
                CustomerProcess customerProcess= new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name=req.Name;
                customerProcess.EmployeeName = "Veznedar - Mehmet Turan";
                customerProcess.Description = "Para Çekme İşlemi Onaylanmadı,Talep Edilen Tutar Limiti Aştığı İçin Şube Müdür Yardımcısına Yönlendirildi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
