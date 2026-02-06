using CalcAppAPI.Domain.Entities.Exceptions;

namespace CalcAppAPI.Domain.Entities.Errors
{
    public class Errors
    {
        public static class Trailer
        {
            public static NotFoundException NotFound(int id) =>
                new("TRAILER_NOT_FOUND",
                    $"Trailer with id {id} was not found.");
        }

        public static class Crane
        {
            public static NotFoundException NotFound(int id) =>
                new("CRANE_NOT_FOUND",
                    $"Crane with id {id} was not found.");
        }

        public static class Infrastructure
        {
            public static InfrastructureException DatabaseUnavailable =>
                new("DATABASE_UNAVAILABLE",
                    "Database is not reachable.");
        }
    }
}
