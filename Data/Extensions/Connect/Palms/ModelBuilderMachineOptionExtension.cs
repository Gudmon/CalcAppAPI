using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CalcAppAPI.Data.Extensions.Connect.Palms
{
    public static class ModelBuilderMachineOptionExtension
    {
        public static void ConfigureMachineOptionLink<TJoin>(
        this ModelBuilder modelBuilder,
        Expression<Func<TJoin, object?>> compositeKeyExpression)
        where TJoin : class
        {
            modelBuilder.Entity<TJoin>()
                .HasKey(compositeKeyExpression);
        }
    }
}
