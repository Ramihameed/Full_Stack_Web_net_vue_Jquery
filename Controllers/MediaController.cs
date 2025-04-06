using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using TrainingForDatabase.Services.MediaServices;
using TrainingForDatabase.ViewModels.MediaVM;

namespace TrainingForDatabase.Controllers
{
    public class MediaController : Controller
    {
        private readonly IMediaService _mediaService;

        public MediaController(IMediaService mediaService)
        {
            _mediaService = mediaService;
        }

        // GET: Media
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult List()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Upload([FromForm] MediaVM model)
        {
            if (model.File != null && model.File.Length > 0)
            {
                try
                {
                    // Handle file processing (e.g., saving to disk or database)
                    bool isUploaded = await _mediaService.Upload(model);

                    if (isUploaded)
                    {
                        return Ok(new { message = "File uploaded successfully!" });
                    }
                    else
                    {
                        return BadRequest(new { message = "File upload failed." });
                    }
                }
                catch (Exception ex)
                {
                    // Log the error
                    Console.WriteLine(ex.Message);
                    return StatusCode(500, new { message = "An error occurred during the upload." });
                }
            }

            return BadRequest(new { message = "No file uploaded." });
        }


        [HttpGet]
        public async Task<IActionResult> GetMediaList()
        {
            var mediaVMList = await _mediaService.List();

            foreach (var media in mediaVMList)
            {
                media.FilePath = media.FilePath?.Replace("\\", "/");
            }

            return Ok(mediaVMList);  
        }

    }
}
