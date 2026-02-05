using CalcAppAPI.Models.Machine.Configurations.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CalcAppAPI.Data.Extensions.Connect.Palms
{
    public static class ModelBuilderManyToManyInfrastructure
    {
        public static void ConnectMachineOptionManyToMany<
            TMachine,
            TOption,
            TJoin>(
            this ModelBuilder modelBuilder,
            Expression<Func<TMachine, IEnumerable<TOption>>> machineNavigation,
            Expression<Func<TOption, IEnumerable<TMachine>>> optionNavigation,
            Expression<Func<TJoin, object?>> compositeKeyExpression,
            Expression<Func<TJoin, TMachine>> joinToMachine,
            Expression<Func<TJoin, TOption>> joinToOption,
            Expression<Func<TJoin, object?>> machineFk,
            Expression<Func<TJoin, object?>> optionFk,
            IEnumerable<TJoin>? seedData = null)
            where TMachine : class
            where TOption : MachineOption
            where TJoin : class
        {
            modelBuilder.Entity<TJoin>()
                .HasKey(compositeKeyExpression);

            modelBuilder.Entity<TJoin>()
                .HasOne(joinToMachine)
                .WithMany()
                .HasForeignKey(machineFk)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TJoin>()
                .HasOne(joinToOption)
                .WithMany()
                .HasForeignKey(optionFk)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TMachine>()
                .HasMany(machineNavigation)
                .WithMany(optionNavigation)
                .UsingEntity<TJoin>();

            if (seedData != null)
                modelBuilder.Entity<TJoin>().HasData(seedData);
        }
    }
}
