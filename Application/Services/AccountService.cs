using CrossCuting.DTO;
using CrossCuting.DTO.Standar;
using Infraestructure.Entities;
using Infraestructure.Interface;
using Infraestructure.Mapper;
using Infraestructure.Repositories;

namespace Business.Services
{
    public class AccountService
    {
        private readonly IRepository<AccountDto> accountRepository;
        public AccountService()
        {
            accountRepository = new AccountRepository();
        }

        public ResponseDto CreateAccount(AccountDto accountDto)
        {
            var response = new ResponseDto();
            try
            {
                response = accountRepository.Save(accountDto);
            }
            catch (Exception ex)
            {

                response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
            }
            return response;
        }

        public ResponseDto EditAccount(AccountDto accountDto)
        {
            var response = new ResponseDto();
            try
            {
                response = accountRepository.Update(accountDto);
            }
            catch (Exception ex)
            {
                response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
            }
            return response;
        }

        public ResponseDto DeleteAccount(AccountDto accountDto)
        {
            var response = new ResponseDto();
            try
            {
                response = accountRepository.Delete(accountDto.id);
            }
            catch (Exception ex)
            {
                response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
            }
            return response;
        }

    }
}
