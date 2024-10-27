namespace Opgave_10_Entitity_Framework.Models
{
    public class Ejer
    {
        public int EjerID { get; set; }
        public string Navn { get; set; }

        public List<Bil> BilList { get; set; }
    }
}
