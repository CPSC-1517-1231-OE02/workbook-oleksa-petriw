namespace TrainSystem
{
    /// <summary>
    /// 
    /// </summary>
    public class Engine
    {
        // Fields
        private int _horsePower;
        private int _weight;
        //? _model, _serialNumber, _inService?

        // Properties
        public int HorsePower //can only be altered when engine not in service. Allow direct upgrades.
        {
            get
            {
                return _horsePower;
            }

            set
            {

            }
        }

        public bool InService //engine is defaulted to InService on creation (greedy constructor)
        {
            get
            {

            }

            set
            {

            }
        }

        public string Model //store as read-only. Why have a set? Private mutator?
        {
            get
            {

            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model must not be null, empty, or whitespace.");
                }
                //_model = value.Trim();
            }
        }

        public string SerialNumber //store as read-only. Why have a set? Private mutator?
        {
            get
            {

            }

            set
            {

            }
        }

        public int Weight //can only be altered when engine not in service. Allow direct upgrades.
        {
            get
            {
                return _weight;
            }

            set
            {
                if (Utilities.IsPostiveNonZero(value) == false)
                {
                    throw new ArgumentOutOfRangeException("Weights must be positive non-zero numbers.");
                }
                else if (Utilities.InHundreds(value) == false)
                {
                    throw new ArgumentException("Weights must be in 100 pound increments");
                }

                _weight = value;
            }
        }

        //Methods

        //Greedy Constructor
        public Engine(string model, string serialNumber, int weight, int horsepower)
        {
            Model = model;
            SerialNumber = serialNumber;
            Weight = weight;
            HorsePower = horsepower;
            //?? default the InService to true on creation
        }

        public string ToString() //must be overloaded and return instance values in CSV string: Model,SerialNumber,Weight,HorsePower,InService
        {

        }
    }
}