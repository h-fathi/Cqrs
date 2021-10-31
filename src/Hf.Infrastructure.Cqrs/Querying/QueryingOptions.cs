namespace Hf.Cqrs.Infrastructure.Querying
{
    public class QueryingOptions
    {
        public int PageSize { get; set; } = 10;
        public int MaxPageSize { get; set; } = 100;
    }
}