﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using SawsAppTemplate.Application.Interfaces.Repositories;
using SawsAppTemplate.Domain.Entities.Misc;
using SawsAppTemplate.Shared.Constants.Application;
using SawsAppTemplate.Shared.Wrapper;
using LazyCache;
using MediatR;

namespace SawsAppTemplate.Application.Features.DocumentTypes.Queries.GetAll
{
    public class GetAllDocumentTypesQuery : IRequest<Result<List<GetAllDocumentTypesResponse>>>
    {
        public GetAllDocumentTypesQuery()
        {
        }
    }

    internal class GetAllDocumentTypesQueryHandler : IRequestHandler<GetAllDocumentTypesQuery, Result<List<GetAllDocumentTypesResponse>>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppCache _cache;

        public GetAllDocumentTypesQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IAppCache cache)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cache = cache;
        }

        public async Task<Result<List<GetAllDocumentTypesResponse>>> Handle(GetAllDocumentTypesQuery request, CancellationToken cancellationToken)
        {
            Func<Task<List<DocumentType>>> getAllDocumentTypes = () => _unitOfWork.Repository<DocumentType>().GetAllAsync();
            var documentTypeList = await _cache.GetOrAddAsync(ApplicationConstants.Cache.GetAllDocumentTypesCacheKey, getAllDocumentTypes);
            var mappedDocumentTypes = _mapper.Map<List<GetAllDocumentTypesResponse>>(documentTypeList);
            return await Result<List<GetAllDocumentTypesResponse>>.SuccessAsync(mappedDocumentTypes);
        }
    }
}