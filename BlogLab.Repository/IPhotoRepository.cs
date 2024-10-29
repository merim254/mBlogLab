using BlogLab.Models.Photo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Repository
{
    public  interface IPhotoRepository
    {
         Task<Photo> InsertAsync(PhotoCreate photoCreate, int applicationUserId);
        Task<Photo> GetAsync(int PhotoId);
        Task<List<Photo>> GetAllByUserIdAsync(int applicationUserId);
        Task<int> DeleteAsync( int PhotoId);

    }
}
