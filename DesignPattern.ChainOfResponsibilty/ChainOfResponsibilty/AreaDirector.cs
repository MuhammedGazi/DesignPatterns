using DesignPattern.ChainOfResponsibilty.DAL;
using DesignPattern.ChainOfResponsibilty.Models;

namespace DesignPattern.ChainOfResponsibilty.ChainOfResponsibilty
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Müdürü - Ramazan Yılmaz";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı,Müşteriye Talep Edilen Tutar Ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Müdürü - Ramazan Yılmaz";
                customerProcess.Description = "Para Çekme İşlemi Onaylanmadı,Talep Edilen Tutar Limiti Aştığı İçin İşlem Gerçekleştirilemedi, Max Günlük Tutar 400.000 tl Farklı Günlerde Gelmesi Gerekmektedir";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
