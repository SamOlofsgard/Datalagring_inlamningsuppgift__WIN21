using Case_Management_System_WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Management_System_WPF.Handlers
{
    public class ErrandsList
    {
        public List<Errand> ErrandList { get; set; } = new List<Errand>();        
        public Errand Create(int id, int customerId, string title, string errandDescription, DateTime createdTime, DateTime changedTime, string errandStatus, string adminstrator)
        {
            return new Errand { Id = id, CustomerId = customerId, Title = title, ErrandDescription = errandDescription, CreatedTime = createdTime, ChangedTime = changedTime, ErrandStatus = errandStatus, Adminstrator = adminstrator };
        }
        public void AddToErrandsList(Errand item)
        {
            ErrandList.Add(item);
        }
        public void ClearErrandsList()
        {
            ErrandList.Clear();
        }
        public void RemoveErrandFromList(Errand item)
        {
            ErrandList.Remove(item);
        }
    }

    
}
