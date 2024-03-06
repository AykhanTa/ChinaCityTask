namespace ChinaCityTask
{
     class City
     {
        string _name;
        public string Name {
            get 
            {
                return _name;
            }
            set
            {
                bool isLetter = true;
                if (!(value.Length > 3 && value.Length < 20))
                {
                    Console.WriteLine("serte uygun deyil");
                    return;
                }
               
                foreach (var item in value)
                {
                    
                    if (!(char.IsLetter(item)))
                    {
                        isLetter= false;
                        break;
                    }
                }
                if (isLetter)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Serte uygun deyilllll");
                    return;
                }
                
                
            }
        }
        int _population;
        public int Population {
            get
            {
                return _population;
            }
            set 
            {
                if (value<0)
                {
                    Console.WriteLine("Deyer 0-dan asagi ola bilmez.");
                    return;
                }
                _population= value;
            } 
        }

        
    }
}
