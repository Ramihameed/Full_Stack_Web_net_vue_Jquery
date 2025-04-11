using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TrainingForDatabase.Data;
using TrainingForDatabase.Models;
using TrainingForDatabase.ViewModels.MediaVM;

namespace TrainingForDatabase.Services.MediaServices
{
    public class MediaService : IMediaService
    {
        private readonly IWebHostEnvironment _hostEnvironment;

        private readonly ApplicationDbContext _context;


        public MediaService(ApplicationDbContext context , IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        public async Task<List<MediaVM>> List()
        {
            var mediaList = await _context.Media
                                       .Include(m => m.Department)
                                       .ToListAsync();

            // Map Media to MediaVM
            var mediaVMList = mediaList.Select(media => new MediaVM
            {
                Id = media.Id,
                DepartmentId = media.DepartmentId,
                FilePath = media.FilePath,
                DepartmentName = media.Department.name,
                UploadedBy = media.UploadedBy


            }).ToList();

            return mediaVMList;
        }


        public async Task<bool> Upload(MediaVM model, IdentityUser user)
        {
            if (model.File != null && model.File.Length > 0)
            {
                // Create a unique file name
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(model.File.FileName);

                // Define the file path to save the file in a folder (e.g., wwwroot/images)
                var filePath = Path.Combine(_hostEnvironment.WebRootPath, "images", fileName);

                // Ensure the directory exists
                //Directory.CreateDirectory(Path.Combine(_hostEnvironment.WebRootPath, "images"));

                // Save the file to the server
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await model.File.CopyToAsync(stream);
                }

                // Create a new Media object and save the file path
                var media = new TrainingForDatabase.Models.Media
                {
                    DepartmentId = model.DepartmentId,
                    FilePath = Path.Combine("images", fileName),
                    UploadedBy = user?.UserName
                };

                _context.Media.Add(media);
                await _context.SaveChangesAsync();

                return true;
                // Or wherever you want to redirect
            }
            return false;
            
        }
    }
}
