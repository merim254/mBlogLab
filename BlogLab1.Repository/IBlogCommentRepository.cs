﻿

using BlogLab1.Models.BlogComment;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlogLab1.Repository
{
    public interface IBlogCommentRepository
    { 
          Task<BlogComment> UpsertAsync(BlogCommentCreate blogCommentCreate,int applicationUserId);

         Task<List<BlogComment>> GetAllAsync(int blogId);
        Task<BlogComment> GetAsync(int blogCommentId);

       

        Task<int> DeleteAsync(int blogCommentId);

    }
}
