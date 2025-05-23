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
        public void Create(StaffModelCreateVM collectionModelVM)
        {
            StaffModel staffModel = new StaffModel();
            //mapping
            staffModel.Name = collectionModelVM.Name;
            staffModel.Profession = collectionModelVM.Profession;
            staffModel.Description = collectionModelVM.Description;
            //File upload 
            string fileName = Path.GetFileNameWithoutExtension(collectionModelVM.Image.FileName);
            string extension = Path.GetExtension(collectionModelVM.Image.FileName);
            string fullName = fileName + Guid.NewGuid().ToString() + extension;
            staffModel.ImgPath = fullName;
            //File Upload Olacaqi Yer
            string uploadPath = @"C:\Users\II Novbe\source\repos\Soft Landing\Soft Landing.MVC\wwwroot\Admin\assets\UploadedImages";
            uploadPath = Path.Combine(uploadPath, fullName);
            using FileStream stream = new FileStream(uploadPath, FileMode.Create);
            collectionModelVM.Image.CopyTo(stream);
            _context.Add(staffModel);
            _context.SaveChanges();
        }
        #region Read
        public StaffModel GetCollectionById(int? Id)
        {
            if (Id is null)
            {
                throw new Exception();
            }
            StaffModel collection = _context.StaffModels.Find(Id);
            return collection;

        }
        #endregion 
        public List<StaffModel> GetAllCollections()
        {
            List<StaffModel> list = _context.StaffModels.ToList();
            return list;
        }
        public void Update(int Id, StaffModelUpdateVM staffModelUpdateVM)
        {
            StaffModel  collection = GetCollectionById(Id);
            collection.Name = staffModelUpdateVM.Name;
            collection.Profession = staffModelUpdateVM.Profession;
            collection.Description = staffModelUpdateVM.Description;

            if (staffModelUpdateVM.Image is not null)
            {
                string fileName = Path.GetFileNameWithoutExtension(staffModelUpdateVM.Image.FileName);
                string extension = Path.GetExtension(staffModelUpdateVM.Image.FileName);
                string fullName = fileName + Guid.NewGuid().ToString() + extension;
                collection.ImgPath = fullName;
                //File Upload Olacaqi Yer
                string uploadPath = @"C:\Users\II Novbe\Desktop\Simulation-NFT-main\Simulation.MVC\wwwroot\assets\UploadedImages";
                uploadPath = Path.Combine(uploadPath, fullName);
                using FileStream stream = new FileStream(uploadPath, FileMode.Create);
                staffModelUpdateVM.Image.CopyTo(stream);
                _context.Add(collection);
                _context.SaveChanges();
            }

        }

        public void Delete(int Id)
        {
            StaffModel staffModel = GetCollectionById(Id);
            _context.Remove(staffModel);
            _context.SaveChanges();
        }
    }
}
