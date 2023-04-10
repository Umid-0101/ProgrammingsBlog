using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Data.Concrete.EntityFramework.Contexts;
using ProgrammersBlog.Data.Concrete.EntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProgrammersBlogContext _context;
        private EfArticleRepository _articleRepository;
        private EfCategoryRepository _categoryRepository;
        private EfCommentRepository _commentRepository;
        private EfRoleRepository _roleRepository;
        private EfUserRepository _userRepository;

        public UnitOfWork(ProgrammersBlogContext context) 
        { 
            _context = context;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public IArticleRepository Articles => _articleRepository ?? new EfArticleRepository(_context);

        public ICatrgoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);

        public ICommentRepository Comments => _commentRepository ?? new EfCommentRepository(_context);

        public IRoleRepository Roles => _roleRepository ?? new EfRoleRepository(_context);

        public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);

        ICommentRepository IUnitOfWork.Roles => throw new NotImplementedException();

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
