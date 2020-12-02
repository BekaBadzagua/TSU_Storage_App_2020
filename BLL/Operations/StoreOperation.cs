using AutoMapper;
using BLL.DTOs.Store;
using BLL.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Operations
{

    public class StoreOperation : IStoreOperation
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public StoreOperation(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }


        public IEnumerable<StoreListDTO> GetAll()
        {
            var stores = _uow.Store.GetAll();

            return _mapper.Map<IEnumerable<StoreListDTO>>(stores);

        }
    }
}
