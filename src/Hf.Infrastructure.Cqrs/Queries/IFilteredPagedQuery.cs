

using Hf.Cqrs.Infrastructure.Querying;

namespace Hf.Cqrs.Infrastructure.Queries
{
    public interface IFilteredPagedQuery<out TReadModel> : IQuery<IPagedResult<TReadModel>>, IFilteredPagedRequest
    {
    }

    public abstract class FilteredPagedQuery<TReadModel> : FilteredPagedRequest, IFilteredPagedQuery<TReadModel>
    {
    }
}