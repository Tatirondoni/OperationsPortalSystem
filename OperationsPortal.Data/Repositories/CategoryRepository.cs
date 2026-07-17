using System.Collections.Generic;
using System.Linq;
using OperationsPortal.Domain.Interfaces;

namespace OperationsPortal.Data.Repositories 
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly OperationsPortalDbEntities1 _context;

        public CategoryRepository()
        {
            _context = new OperationsPortalDbEntities1();
        }

        public IEnumerable<OperationsPortal.Domain.Entities.Category> GetAll()
        {
            
            return _context.Categories
                .Select(c => new OperationsPortal.Domain.Entities.Category
                {
                    CategoryId = c.CategoryId,
                    Name = c.Name,
                    Description = c.Description,
                    IsActive = c.IsActive
                })
                .ToList();
        }

        public OperationsPortal.Domain.Entities.Category GetById(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryId == id);

            if (category == null)
                return null;

            return new OperationsPortal.Domain.Entities.Category
            {
                CategoryId = category.CategoryId,
                Name = category.Name,
                Description = category.Description,
                IsActive = category.IsActive
            };
        }

        public void Add(OperationsPortal.Domain.Entities.Category category)
        {
            var entity = new Category
            {
                Name = category.Name,
                Description = category.Description,
                IsActive = category.IsActive
            };

            _context.Categories.Add(entity);
            _context.SaveChanges();
        }

        public void Update(OperationsPortal.Domain.Entities.Category category)
        {
            var entity = _context.Categories.FirstOrDefault(c => c.CategoryId == category.CategoryId);

            if (entity == null)
                return;

            entity.Name = category.Name;
            entity.Description = category.Description;
            entity.IsActive = category.IsActive;

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Categories.FirstOrDefault(c => c.CategoryId == id);

            if (entity == null)
                return;

            _context.Categories.Remove(entity);
            _context.SaveChanges();
        }
    }
}