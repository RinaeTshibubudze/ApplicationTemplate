﻿using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using SawsAppTemplate.Application.Interfaces.Repositories;
using SawsAppTemplate.Domain.Entities.Misc;
using SawsAppTemplate.Shared.Wrapper;
using MediatR;

namespace SawsAppTemplate.Application.Features.Documents.Queries.GetById
{
    public class GetDocumentByIdQuery : IRequest<Result<GetDocumentByIdResponse>>
    {
        public int Id { get; set; }
    }

    internal class GetDocumentByIdQueryHandler : IRequestHandler<GetDocumentByIdQuery, Result<GetDocumentByIdResponse>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public GetDocumentByIdQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<GetDocumentByIdResponse>> Handle(GetDocumentByIdQuery query, CancellationToken cancellationToken)
        {
            var document = await _unitOfWork.Repository<Document>().GetByIdAsync(query.Id);
            var mappedDocument = _mapper.Map<GetDocumentByIdResponse>(document);
            return await Result<GetDocumentByIdResponse>.SuccessAsync(mappedDocument);
        }
    }
}