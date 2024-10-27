namespace Opgave_10_Entitity_Framework.Models
{
	public class Fly
	{
		public int FlyID { get; set; }
		public string Model {  get; set; }
		

		//Mange til mange relation
		public List<Personer> Ejere { get; set; }


		

	}
}
