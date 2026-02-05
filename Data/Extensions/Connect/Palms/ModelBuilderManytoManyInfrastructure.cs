using CalcAppAPI.Models.Machine.Configurations.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CalcAppAPI.Data.Extensions.Connect.Palms
{
    public static class ModelBuilderManyToManyInfrastructure
    {
        public static void ConnectMachineOptionManyToMany<
            TMachine,
            TOption>(
            this ModelBuilder modelBuilder,
            string tableName,
            Expression<Func<TMachine, IEnumerable<TOption>>> machineNavigation,
            Expression<Func<TOption, IEnumerable<TMachine>>> optionNavigation,
            IEnumerable<object>? seedData = null)
            where TMachine : class
            where TOption : MachineOption
        {
            modelBuilder.Entity<TMachine>()
                .HasMany(machineNavigation)
                .WithMany(optionNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    tableName,
                    j => j.HasOne<TOption>()
                          .WithMany()
                          .HasForeignKey("OptionId")
                          .OnDelete(DeleteBehavior.Cascade),
                    j => j.HasOne<TMachine>()
                          .WithMany()
                          .HasForeignKey("MachineId")
                          .OnDelete(DeleteBehavior.Cascade),
                    j =>
                    {
                        j.HasKey("MachineId", "OptionId");

                        if (seedData != null)
                            j.HasData(seedData);
                    });
        }
    }

}
