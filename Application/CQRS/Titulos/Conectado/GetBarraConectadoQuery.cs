using Application.Interfaces.Repositories.Generic.NonAuditable;
using Application.Responses.Titulos.Categoria;
using Application.Responses.Titulos.Conectado;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Shared.Wrappers;

namespace Application.CQRS.Titulos.Conectado
{
    public record GetBarraConectadoQuery : IRequest<IResult<BarraHerramientasConectadoResponse>>;

    internal class GetBarraDesconectadoQueryHandler : IRequestHandler<GetBarraConectadoQuery, IResult<BarraHerramientasConectadoResponse>>
    {
        private readonly INonAuditableUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public GetBarraDesconectadoQueryHandler(INonAuditableUnitOfWork<int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult<BarraHerramientasConectadoResponse>> Handle(GetBarraConectadoQuery request, CancellationToken cancellationToken)
        {
            var titulos = await _unitOfWork.Repository<Models.Titulos.TitulosConectado>().GetAllMapAsyncQuery<TitulosConectadoResponse>(_mapper);

            var categorias = await _unitOfWork.Repository<Models.Titulos.Categoria>().GetAllMapAsyncQuery<CategoriaResponse>(_mapper);

            var response = new BarraHerramientasConectadoResponse()
            {
                Titulos = await titulos.ToListAsync(),
                Categorias = await categorias.ToListAsync(),
            };
            return await Result<BarraHerramientasConectadoResponse>.SuccessAsync(response);
        }
    }
}
