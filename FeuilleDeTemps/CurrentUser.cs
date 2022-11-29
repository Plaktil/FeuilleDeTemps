using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FeuilleDeTemps
{
	/// <summary>
	/// Static class that keeps track of the current user and its privilege level
	/// </summary>
	public static class CurrentUser
	{
		public static string id { get; set; }
		public static string fullName { get; set; }
		public static string role { get; set; }


		public static void Logout()
		{
			id = String.Empty;
			fullName = String.Empty;
			role = String.Empty;
		}

		public static bool IsAdmin()
		{
			return role == "Superviseur";
		}
	}
}
