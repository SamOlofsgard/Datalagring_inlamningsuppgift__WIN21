using Case_Management_System_WPF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Management_System_WPF.Services
{
    internal class SqlService
    {
        private SqlContext _context = new SqlContext();

        #region Create

        public int CreateAddress(Address address)
        {   
            var _address = _context.Addresses.Where(x => x.StreetName == address.StreetName && x.PostalCode == address.PostalCode && x.City == address.City && x.Country == address.Country).FirstOrDefault();
            if (_address == null)
            {

                _context.Addresses.Add(address);
                _context.SaveChanges();
                return address.Id;
            }
            return _address.Id;
        }

        public int CreateErrand(Errand errand)
        {
            var _errand = _context.Errands.Where(x => x.Title == errand.Title && x.ErrandDescription == errand.ErrandDescription).FirstOrDefault();
            if (_errand == null)
            {
                _context.Errands.Add(errand);
                _context.SaveChanges();
                return errand.Id;
            }
            return _errand.Id;
        }


        public int CreateCustomer(CreateCustomer customer)
        {
            var _customer = new Customer();
            var item = _context.Customers.Where(x => x.Email == customer.Email).FirstOrDefault();

            if (item == null)
            {
                _customer.FirstName = customer.FirstName;
                _customer.LastName = customer.LastName;
                _customer.Email = customer.Email;
                _customer.PhoneNumber = customer.PhoneNumber;
                _customer.MobileNumber = customer.MobileNumber;
                _customer.AddressId = CreateAddress(customer.Address);
                _context.Customers.Add(_customer);
                _context.SaveChanges();
            }
            return _customer.Id;
        }
        #endregion

        #region Read
        public Address GetAddress(int id)
        {
            return _context.Addresses.SingleOrDefault(x => x.Id == id);
        }
        public Customer GetCustomer(int id)
        {
            return _context.Customers.SingleOrDefault(x => x.Id == id);
        }
        public Errand GetErrand(int id)
        {
            return _context.Errands.SingleOrDefault(x => x.Id == id);        
        }       

        public IEnumerable<Address> GetAddresses()
        {
            return _context.Addresses;
        }
        public IEnumerable<Customer> GetCustomers()
        {            
            return _context.Customers;
        }
        public IEnumerable<Errand> GetErrands()
        {
            return _context.Errands;
        }

        #endregion

        #region Update
        
        public void UpdateErrand(int id, Errand _errand)
        {
            var item = _context.Errands.Find(id);
            if (item != null && item.Id == id)
            {
                item.Title = _errand.Title;
                item.ErrandDescription = _errand.ErrandDescription;
                item.ErrandStatus = _errand.ErrandStatus;
                item.Adminstrator = _errand.Adminstrator;
                item.ChangedTime = _errand.ChangedTime;
                

                _context.Update(item);
                _context.SaveChanges();
            }
        }
        #endregion

        #region Delete                
        public void DeleteErrand(int id)
        {
            var item = _context.Errands.Find(id);

            if (item != null && item.Id == id)
            {
                _context.Errands.Remove(item);
                _context.SaveChanges();
            }
        }
        #endregion

    }
}
