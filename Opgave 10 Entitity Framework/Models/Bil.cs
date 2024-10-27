namespace Opgave_10_Entitity_Framework.Models
{
    public class Bil
    {
        public int BILID {  get; set; } //primære nøgle
        public string Name {  get; set; }
        public int Weight {  get; set; }
    
        public int NummerPlade { get; set; }

        public int EjerID { get; set; }
        public Ejer Ejer { get; set; }
     

    }
}
