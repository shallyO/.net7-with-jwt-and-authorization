using System;
namespace dotnet_jwt_auth.Models
{
	public class UserDto
	{
        public required string Username { get; set; }

        public required string Password { get; set; }
    }
}

