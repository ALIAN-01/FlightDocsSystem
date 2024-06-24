﻿using System.ComponentModel.DataAnnotations;

namespace FlightDocsSystem.Models.DTO.User
{
	public class AddUserResquestDTO
	{
		[Required]
		public string Name { get; set; } = string.Empty;
		[Required]
		[EmailAddress]
		public string Email { get; set; } = string.Empty;
		[Required]
		public string Phone { get; set; } = string.Empty;
		[Required]
		public string RoleName { get; set; } = string.Empty;
		[Required]
		public string PassWord { get; set; } = string.Empty;

	}
}
