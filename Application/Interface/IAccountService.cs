
using CrossCuting.DTO.Standar;
using CrossCuting.DTO;

namespace Business.Interface
{
	public interface IAccountService
	{
		public ResponseDto CreateAccount(AccountDto accountDto);

		public ResponseDto DeleteAccount(int accountId);

		public ResponseDto EditAccount(AccountDto accountDto);
		public List<AccountDto> GetAllAccount();
	}
}
