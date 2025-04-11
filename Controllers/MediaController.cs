using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using TrainingForDatabase.Services.MediaServices;
using TrainingForDatabase.ViewModels.MediaVM;
using Microsoft.AspNetCore.Identity;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;


namespace TrainingForDatabase.Controllers
{
    public class MediaController : Controller
    {
        private readonly IMediaService _mediaService;
        private readonly UserManager<IdentityUser> _userManager;

        public MediaController(IMediaService mediaService, UserManager<IdentityUser> userManager)
        {
            _mediaService = mediaService;
            _userManager = userManager;
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
                    var user = await _userManager.GetUserAsync(User);

                    if (user != null)
                    {
                        // Handle file processing (e.g., saving to disk or database)
                        bool isUploaded = await _mediaService.Upload(model, user);

                        if (isUploaded)
                        {
                            return Ok(new { message = "File uploaded successfully!" });
                        }
                        else
                        {
                            return BadRequest(new { message = "File upload failed." });
                        }
                    }
                    else
                    {
                        return BadRequest(new { message = "you are not logged in" });
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
