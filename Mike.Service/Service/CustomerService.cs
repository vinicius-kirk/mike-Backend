using AutoMapper;
using Mike.Domain.Entities;
using Mike.Domain.Repositories;
using Mike.Interface.DTO;
using Mike.Interface.Services;
using System;

namespace Mike.Service.Service
{
    public class CustomerService : ICustomerService
    {
        protected readonly ICustomerRepository _customerRepository;
        protected readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository,
                               IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public CustomerDTO Edit(CustomerDTO customerDTO)
        {
            var customer = _mapper.Map<Customer>(customerDTO);

            if (customer.Valid)
            {
                customer.AddNotifications(customer);
                return null;
            }

            _customerRepository.Put(customer);

            return customerDTO;
        }

        public CustomerDTO GetCustomerByID(string ID)
        {
            var guid = int.Parse(ID);

            var customer = _customerRepository.GetByID(guid);

            return _mapper.Map<CustomerDTO>(customer);
        }

        public CustomerDTO Save(CustomerDTO customerDTO)
        {
            var customer = _mapper.Map<Customer>(customerDTO);

            if (customer.Valid)
            {
                customer.AddNotifications(customer);

                return null;
            }

            _customerRepository.Add(customer);

            return customerDTO;
        }
    }
}
