using Microsoft.AspNetCore.Identity;
using TrainingForDatabase.Migrations;
using TrainingForDatabase.ViewModels.MediaVM;

namespace TrainingForDatabase.Services.MediaServices
{
    public interface IMediaService
    {
        Task<bool> Upload(MediaVM model , IdentityUser user);
        Task<List<MediaVM>> List();

    }
}
