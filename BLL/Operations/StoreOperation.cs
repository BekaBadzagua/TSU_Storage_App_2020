using AutoMapper;
using BLL.DTOs.Store;
using BLL.Interfaces;
using DAL.Entities;
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

        public void Add(StoreDTO store)
        {
            _uow.Store.Create(_mapper.Map<Store>(store));
        }

        public void Edit(StoreDTO store)
        {
            _uow.Store.Update(_mapper.Map<Store>(store));
        }

        public void Delete(int id)
        {
            _uow.Store.Delete(id);
        }


        public StoreListDTO Get(int id)
        {
            var store = _uow.Store.Get(id);

            return _mapper.Map<StoreListDTO>(store);
        }

        public IEnumerable<StoreListDTO> GetAll()
        {
            var stores = _uow.Store.FindAll();

            return _mapper.Map<IEnumerable<StoreListDTO>>(stores);

        }
    }
}
