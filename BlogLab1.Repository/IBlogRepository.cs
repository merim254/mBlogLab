
using BlogLab1.Models.Blog;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlogLab1.Repository
{
    public interface IBlogRepository
    {
          Task<Blog> UpsertAsync(BlogCreate blogCreate,int applicationUserId);

         Task<PagedResults<Blog>> GetAllAsync(BlogPaging blogPaging);
        Task<Blog> GetAsync(int blogId);

        Task<List<Blog>> GetAllByUserIdAsync(int applicationUserId);
        Task<List<Blog>> GetAllFamousAsync();

        Task<int> DeleteAsync(int blogId);

    }
}
