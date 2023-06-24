

using CrossCuting.DTO;
using Infraestructure.Entities;
using Infraestructure.Interface;

namespace Infraestructure.Mapper
{
	public class AccountMapper : IMapper<Account, AccountDto>
	{
		public Account MapDtoToEntity(AccountDto dto)
		{
			return new Account
			{
				id = dto.id,
				username = dto.username,
				email = dto.email,
				password = dto.password,
				rol = dto.rol
			};
		}

		public AccountDto MapEntityToDto(Account account)
		{
			return new AccountDto
			{
				id = account.id,
				username = account.username,
				email = account.email,
				password = account.password,
				rol = account.rol
			};
		}
	}
}
