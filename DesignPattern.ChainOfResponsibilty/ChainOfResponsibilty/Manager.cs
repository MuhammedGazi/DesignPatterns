using DesignPattern.ChainOfResponsibilty.DAL;
using DesignPattern.ChainOfResponsibilty.Models;

namespace DesignPattern.ChainOfResponsibilty.ChainOfResponsibilty
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdürü - Feriha Saymaz";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı,Müşteriye Talep Edilen Tutar Ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdürü - Feriha Saymaz";
                customerProcess.Description = "Para Çekme İşlemi Onaylanmadı,Talep Edilen Tutar Limiti Aştığı İçin Bölge Müdürüne Yönlendirildi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
