using TrainingForDatabase.ViewModels.MediaVM;

namespace TrainingForDatabase.Services.MediaServices
{
    public interface IMediaService
    {
        Task<bool> Upload(MediaVM model);

    }
}
