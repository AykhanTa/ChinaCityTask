
namespace ChinaCityTask
{
    internal class ChinaCity:City
    {
        public override int Population { 
            get => _population; 
            set  
            {
                if (value>0) _population = value;
            }
        }
    }
}
