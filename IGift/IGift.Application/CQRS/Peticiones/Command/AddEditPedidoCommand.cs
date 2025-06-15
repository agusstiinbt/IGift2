﻿using AutoMapper;
using IGift.Application.Interfaces.Repositories.Generic.Auditable;
using IGift.Domain.Entities.SQLServer;
using IGift.Shared.Constants;
using IGift.Shared.Wrapper;
using MediatR;

namespace IGift.Application.CQRS.Peticiones.Command
{
    public class AddEditPeticionesCommand : IRequest<IResult>
    {
        /// <summary>
        /// Si se envía igual a 0(cero) significa que estamos editando un registro
        /// </summary>
        public int Id { get; set; } = 0;
        public string IdUser { get; set; }
        public string Descripcion { get; set; }
        public int Monto { get; set; }
        public string Moneda { get; set; }
    }
    internal class AddPedidoCommandHandler : IRequestHandler<AddEditPeticionesCommand, IResult>
    {
        private readonly IAuditableUnitOfWork<int> _unitOfWork;
        private readonly IMapper _mapper;

        public AddPedidoCommandHandler(IAuditableUnitOfWork<int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> Handle(AddEditPeticionesCommand request, CancellationToken cancellationToken)
        {
            var pedido = new Petitions//TODO fijarse si se puede mapear
            {
                IdUser = request.IdUser,
                Descripcion = request.Descripcion,
                Moneda = request.Moneda,
                Monto = request.Monto,
                CreatedBy = "Agustin Esposito",
                CreatedOn = DateTime.Now,
                LastModifiedOn = DateTime.Now,
                LastModifiedBy = AppConstants.Server.AdminEmail,
                Categoria = "Por ahora vacio"
            };
            if (request.Id == 0)
            {
                var result = await _unitOfWork.Repository<Petitions>().AddAsync(pedido);
                return await _unitOfWork.Commit("Pedido agregado con éxito", cancellationToken);
            }
            else
            {
                var peticion = await _unitOfWork.Repository<Petitions>().GetByIdAsync(request.Id);
                if (peticion != null)
                {
                    await _unitOfWork.Repository<Petitions>().UpdateAsync(pedido);
                    return await Result.SuccessAsync("Pedido modificado con éxito");
                }
                return await Result.FailAsync("pedido no encontrado");
            }
        }
    }
}
