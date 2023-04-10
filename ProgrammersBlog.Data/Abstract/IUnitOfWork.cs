using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        IArticleRepository Articles { get; }  //UnitOfWork.Articles
        ICatrgoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        ICommentRepository Roles { get; }
        IUserRepository Users { get; } // _unitOfWork.Categories.AddAsync()
        Task<int> SaveAsync();
    }
}
