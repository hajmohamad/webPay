using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webPay.Models;
using webPay.Models.PageAttribute;

namespace webPay.Controllers;

public class CustomersController : Controller
{
    private readonly WebPayDbContext _dbContext;

    public  CustomersController()
    {
        _dbContext = new WebPayDbContext();

    }
    public ActionResult CustomerForm()
    {
        var memberShipTypes = _dbContext.MemberShipType.ToList();
        CustomerFormViewModel customerFormViewModel = new CustomerFormViewModel()
        {
            MemberShipTypes = memberShipTypes
            
        };
        return View(customerFormViewModel);
    }
    public IActionResult Index()
    {

        
        return View();
    }

    public ActionResult CustomerViewPage(int id)
    {
        var customers = CustomersPageAttribute.CustomersPage.Customers.Find(x => x.Id == id);
        if(customers == null){
            return NotFound();
        }
        return View(customers);
    }
    
    [HttpPost]
    public ActionResult Save(Customer customer)
    {
        if (customer.Id == 0)
        {
            _dbContext.Customers.Add(customer);
        }
        else
        {
            var customerInDb = _dbContext.Customers.Find(customer.Id);
            if (customerInDb == null)
            {
                return NotFound();
            }
            customerInDb.Name = customer.Name;
            customerInDb.DateOfBirth = customer.DateOfBirth;
            customerInDb.IsSubscribed = customer.IsSubscribed;
            customerInDb.MemberShipTypeId = customer.MemberShipTypeId;
        }

        _dbContext.SaveChanges();
       return RedirectToAction("Index");
    }

    public IActionResult Edit(int? id)
    {
        var customer = _dbContext.Customers.Find(id);
        if(customer == null){
            return NotFound();
        }

        CustomerFormViewModel customerFormViewModel = new CustomerFormViewModel()
        {
            Customer = customer, 
            MemberShipTypes = _dbContext.MemberShipType.ToList()

        };
        return View("CustomerForm" , customerFormViewModel);
    }
} 