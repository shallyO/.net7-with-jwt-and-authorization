using System;
namespace dotnet_jwt_auth.Models
{
	public class User
	{
		public string Username { get; set; } = string.Empty;

		public string PasswordHash { get; set; } = string.Empty;
	}
}

