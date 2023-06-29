using System.Data.SqlClient;
using CrossCuting.DTO;
using CrossCuting.DTO.Standar;
using Infraestructure.DataBase;
using Infraestructure.Entities;
using Infraestructure.Interface;
using Infraestructure.Mapper;

namespace Infraestructure.Repositories
{
	public class AccountRepository : IRepository<AccountDto>
	{
		private readonly SqlConnection connection;
        private readonly IMapper<Account, AccountDto> mapper; 

        public AccountRepository()
        {
            connection = DatabaseConnection.GetInstance().GetConnection();
            mapper = new AccountMapper();
        }

        private void ReadAccount(SqlCommand command, List<AccountDto> accountsDto)
        {
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Account account = new Account();
                    account.id = reader.GetInt32(0);
                    account.username = reader.GetString(1);
                    account.email = reader.GetString(2);
                    account.password = reader.GetString(3);
                    account.rol = reader.GetString(4);
					var accountDto = mapper.MapEntityToDto(account);
					accountsDto.Add(accountDto);
                }
            }
            connection.Close();
        }


        public List<AccountDto> Get(Func<AccountDto, bool>? filter = null)
        {
            List<AccountDto> accountsDto = new List<AccountDto>();

            try
            {
                var query = "SELECT * FROM Account";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    ReadAccount(command, accountsDto);
                }
            }
            catch (Exception)
            {
                throw;
            }
			if (filter != null)
				accountsDto = accountsDto.Where(filter).ToList();
			
            return accountsDto;
        }

        public ResponseDto Save(AccountDto accountDto)
        {
            var response = new ResponseDto();
			var account = mapper.MapDtoToEntity(accountDto);
			try
            {
                var query = "INSERT INTO Account(username,email,password,rol) VALUES(@username,@email,@password,@rol)";
                using(SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@username", account.username);
                    command.Parameters.AddWithValue("@email",account.email);
                    command.Parameters.AddWithValue("@password", account.password);
                    command.Parameters.AddWithValue("@rol", account.rol);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
            }
            return response;
        }


        public ResponseDto Delete(int accountId)
        {
            var response = new ResponseDto();   

            try
            {
                var query = "DELETE FROM Account WHERE id = @id";
                using(SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@id", accountId);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
            }
            return response;
        }


        public ResponseDto Update(AccountDto accountDto)
        {
            var response = new ResponseDto();
			var account = mapper.MapDtoToEntity(accountDto);
			try
            {
                var query = "UPDATE Account SET username = @username,email = @email, rol = @rol WHERE id = @id";
                using(SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@id", account.id);
                    command.Parameters.AddWithValue("@username", account.username);
					command.Parameters.AddWithValue("@email", account.email);
                    command.Parameters.AddWithValue("@rol", account.rol);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                response.Errors.Add(string.Empty, ex.Message.Substring(0,Math.Min(ex.Message.Length, 250)));
            }
            return response;
        }

		
	}
}
