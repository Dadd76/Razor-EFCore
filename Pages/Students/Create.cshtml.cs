using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContosoUniversity.Data;
using ContosoUniversity.Models;
using ContosoUniversity.ViewModels;

namespace ContosoUniversity.PagesStudents
{
    public class CreateVMModel : PageModel
    {
        private readonly ContosoUniversity.Data.SchoolContext _context;

        public CreateVMModel(ContosoUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        // [BindProperty]
        // public Student Student { get; set; } = default!;

        // // For more information, see https://aka.ms/RazorPagesCRUD.
        // public async Task<IActionResult> OnPostAsync()
        // {
        //     var emptyStudent = new Student();

        //     if (await TryUpdateModelAsync<Student>(
        //         emptyStudent,
        //         "student",   // Prefix for form value.
        //         s => s.FirstMidName, s => s.LastName, s => s.EnrollmentDate))
        //         {
        //         _context.Students.Add(emptyStudent);
        //         await _context.SaveChangesAsync();
        //         return RedirectToPage("./Index");
        //         }

        //     return Page();
        // }
        [BindProperty]
        public StudentVM StudentVM { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var emptyStudent = new Student();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            // var entry = _context.Add(new Student());
            // entry.CurrentValues.SetValues(StudentVM);
            // await _context.SaveChangesAsync();
            // return RedirectToPage("./Index");

            if (await TryUpdateModelAsync<Student>(emptyStudent,"student",s => s.FirstMidName, s => s.LastName, s => s.EnrollmentDate))
            {
                var entry = _context.Students.Add(emptyStudent);
                entry.CurrentValues.SetValues(StudentVM);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }


            return Page();

        }

    }
}
