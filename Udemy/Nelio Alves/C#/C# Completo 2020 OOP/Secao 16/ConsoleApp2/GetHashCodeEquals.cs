/*
 * Esta classe implementa os métodos sobrecarregados de GetHashCode e de Equals num objeto qualquer.
 */

namespace ConsoleApp2
{
    class GetHashCodeEquals
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public GetHashCodeEquals(string name , double price)
        {
            Name = name;
            Price = price;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is GetHashCodeEquals))
            {
                return false;
            }
            GetHashCodeEquals other = obj as GetHashCodeEquals;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
