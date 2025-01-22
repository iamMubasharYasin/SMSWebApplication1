using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SMSWebApplication1.Data;
using SMSWebApplication1.Model;

namespace SMSWebApplication1.Pages;

public class Register_Student : PageModel
{
    private SMSDbContext db;
    public Register_Student(SMSDbContext _db)
    {
        db = _db;
    }
    
    [BindProperty]
    public Student student { get; set; }
    
    public IActionResult OnPost()
    {
        db.tbl_student.Add(student);
        db.SaveChanges();

        //ViewData["flag"] = "true";
        
        return RedirectToPage("Register_Student");
    }
}