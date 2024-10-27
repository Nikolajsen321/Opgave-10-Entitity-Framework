using System.ComponentModel.DataAnnotations;

namespace Opgave_10_Entitity_Framework.Models
{
	public class Personer
	{
		[Key]  // Angiver at PersonID er primærnøgle
		public int PersonID { get; set; }
		public string Name { get; set; }

		// Navigation property til Fly
		public List<Fly> FlyEjet { get; set; } = new();

	}
}
