﻿using Ardalis.Specification;
using FixedsApp.Application.Common.Marker;
using FixedsApp.Application.Common.Wrapper;
using FixedsApp.Domain.Entities.Common;

namespace FixedsApp.Application.Common
{
    public interface IRepositoryAsync : ITransientService
    {
        Task<IEnumerable<T>> GetListAsync<T, TId>(ISpecification<T>? specification = null, CancellationToken cancellationToken = default)
        where T : BaseEntity<TId>;

        Task<IEnumerable<TDto>> GetListAsync<T, TDto, TId>(ISpecification<T>? specification = null, CancellationToken cancellationToken = default)
        where T : BaseEntity<TId>
        where TDto : IDto;

        Task<T> GetByIdAsync<T, TId>(TId id, ISpecification<T>? specification = null, CancellationToken cancellationToken = default)
        where T : BaseEntity<TId>;

        Task<TDto> GetByIdAsync<T, TDto, TId>(TId id, ISpecification<T>? specification = null, CancellationToken cancellationToken = default)
        where T : BaseEntity<TId>
        where TDto : IDto;

        Task<bool> ExistsAsync<T, TId>(ISpecification<T>? specification = null, CancellationToken cancellationToken = default)
        where T : BaseEntity<TId>;

        Task<T> CreateAsync<T, TId>(T entity)
        where T : BaseEntity<TId>;

        Task<IList<TId>> CreateRangeAsync<T, TId>(IEnumerable<T> entityList)
        where T : BaseEntity<TId>;

        Task<T> UpdateAsync<T, TId>(T entity)
        where T : BaseEntity<TId>;

        Task RemoveAsync<T, TId>(T entity)
        where T : BaseEntity<TId>;

        Task<T> RemoveByIdAsync<T, TId>(TId entityId)
        where T : BaseEntity<TId>;
        Task<PaginatedResponse<TDto>> GetPaginatedResultsAsync<T, TDto, TId>(int pageNumber, int pageSize, ISpecification<T>? specification = null, CancellationToken cancellationToken = default) // used by Tanstack Table (React, Vue)
        where T : BaseEntity<TId>
        where TDto : IDto;
        Task<int> SaveChangesAsync();
    }
}
