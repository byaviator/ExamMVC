using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Soft_Landing.BL.ModelViews;
using Soft_Landing.DAL.Contexts;
using Soft_Landing.DAL.Models;

namespace Soft_Landing.BL.Services
{
    class StaffModelServices
    {
        private readonly AppDbContext _context;
        public StaffModelServices()
        {
            _context = new AppDbContext();
        }
        public void Create(StaffModelCreateVM staffModelCreateVM)
        {
            StaffModel staffModel = new StaffModel();
            //mapping
            staffModel.Name = staffModelCreateVM.Name;
            staffModel.Profession = staffModelCreateVM.Profession;
            staffModel.Description = staffModelCreateVM.Description;

            //FileUpload
            string fileName = Path.GetFileNameWithoutExtension(staffModelCreateVM.Image.FileName);
            string extension = Path.GetExtension(staffModelCreateVM.Image.FileName);
            string fullName = fileName + Guid.NewGuid().ToString() + extension;
            staffModel.ImgPath = fullName;
            //
            string uploaPath = @"C:\Users\II Novbe\source\repos\Soft Landing\Soft Landing.MVC\wwwroot\Admin\assets\UploadedImages";
            string uploadPath = Path.Combine(uploadPath, fullName);
            using FileStream stream = 
            _context.Add(staffModel);
            _context.SaveChanges();

            


        }
    }
}
