namespace ChinaCityTask
{
     class City
     {
         string _name;
        public string Name {
            get=> _name;            
            set
            {
                if (CheckName(value)) _name = value;
            }
        }
        protected int _population;
        public virtual int Population {
            get=> _population;
            set 
            {
                if (value>0) _population = value;
            }
        }

        private bool CheckName(string value)
        {
            if (string.IsNullOrEmpty(value)) return false;
            if (!(value.Length > 3 && value.Length < 20)) return false;
            foreach (char c in value)
                if(!char.IsLetter(c)) return false;
                return true;
        }

    }
}
