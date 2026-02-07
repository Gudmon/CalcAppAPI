using CalcAppAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CalcAppAPI.Application.Dtos.Palms
{
    public class MachineConfigurationLoader
    {
        private readonly DataContext _context;

        public MachineConfigurationLoader(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TDto>> LoadCollectionAsync<TEntity, TDto>(
        Expression<Func<TEntity, bool>> filter,
        Expression<Func<TEntity, TDto>> selector)
        where TEntity : class
        {
            return await _context.Set<TEntity>()
                .Where(filter)
                .Select(selector)
                .ToListAsync();
        }

        public async Task<TDto?> LoadSingleAsync<TEntity, TDto>(
        Expression<Func<TEntity, bool>> filter,
        Expression<Func<TEntity, TDto>> selector)
        where TEntity : class
        {
            return await _context.Set<TEntity>()
                .Where(filter)
                .Select(selector)
                .FirstOrDefaultAsync();
        }
    }
}
