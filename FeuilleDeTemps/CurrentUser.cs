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
		#region Static Members

		public static string id { get; set; }
		public static string fullName { get; set; }
		public static string role { get; set; }

		#endregion

		#region Static Methods

		/// <summary>
		/// Resets the class fields to their default value,
		/// effectively forgetting the last user
		/// </summary>
		public static void Logout()
		{
			id = String.Empty;
			fullName = String.Empty;
			role = String.Empty;
		}
		
		/// <summary>
		/// Verifies if the current user is of admin level
		/// </summary>
		/// <returns>True if admin level, false otherwise</returns>
		public static bool IsAdmin()
		{
			return role == "Superviseur";
		}

		#endregion
	}
}