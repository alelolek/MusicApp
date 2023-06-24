using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCuting.DTO.Standar
{
	public class ResponseDto
	{
		public Dictionary<string, string> Errors { get; set; }

		public bool IsInValid { get => Errors.Any(); }

		public ResponseDto()
		{
			Errors = new Dictionary<string, string>();
		}
	}
}
