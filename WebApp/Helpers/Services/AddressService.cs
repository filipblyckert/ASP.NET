using Azure.Core;
using Microsoft.Identity.Client;
using WebApp.Helpers.Repositories;
using WebApp.Models.Entities;
using WebApp.Models.Identity;

namespace WebApp.Helpers.Services
{
    public class AddressService
    {

        private readonly AddressRepository _addressRepo;
        private readonly UserAddressRepository _userAddressRepository;
        public AddressService(AddressRepository addressRepo, UserAddressRepository userAddressRepository)
        {
            _addressRepo = addressRepo;
            _userAddressRepository = userAddressRepository;
        }

        public async Task<AddressEntity> GetOrCreateAsync(AddressEntity addressEntity)
        {
            var entity = await _addressRepo.GetAsync( X =>
            X.StreetName == addressEntity.StreetName &&
            X.PostalCode == addressEntity.PostalCode &&
            X.City == addressEntity.City 
            
            );

            
                entity ??=  await _addressRepo.AddAsync(addressEntity);
                return entity!;
            
            
        }
        public async Task AddAddressAsync(AppUser user, AddressEntity addressEntity)
        {
            await _userAddressRepository.AddAsync(new UserAddressEntity
            {
                UserId = user.Id,
                AddressId = addressEntity.Id
            });
        }
    }
}
