namespace ObjectClassLibrary
{
    public class BodyMassIndex
    {
        private double _weight;
        private double _height;
        public string Name { get; private set; }
        public double Weight
        {
            get
            {
                // return _height;
                // Problem Description: returned incorrect field (_height), changed to correct field (_weight).
                return _weight;
            }
            set
            {
                if (value <= 0)
                {
                    // throw new ArgumentNullException("Weight must be a positive non-zero value");
                    // corrected to out of range exception and message

                    throw new ArgumentOutOfRangeException("Weight must be a positive non-zero number", new ArgumentException());
                }
                // Height = value;
                // Problem Description: assigned value to Height property, corrected to _weight field.
                _weight = value;
            }
        }
        public double Height
        {
            get
            {
                // return Height;
                // Problem Description: returned Height property, corrected to _height field.
                return _height;
            }
            set
            {
                if (value <= 0)
                {
                    // throw new ArgumentException("Height must be a positive non-zero value");
                    // corrected to out of range exception and message

                    throw new ArgumentOutOfRangeException("Height must be a positive non-zero number", new ArgumentException());
                }
                _height = value;
            }
        }
        public BodyMassIndex(string name, double weight, double height)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                // name = name;
                // Problem Description: assigned value to itself (stack overflow)
                // Corrected to throw exception if string is null or empty or whitespace
                // also, corrected to assign name argument to Name property
                // also, changed to argument null exception
                throw new ArgumentNullException("Name cannot be blank", new ArgumentException());
            }

            Name = name;
            //else
            //{
            //throw new ArgumentException("Name cannot be blank");
            //}

            this.Weight = weight;
            // height = this.Height;
            // Problem Description: was assigning null height to the height argument
            // Corrected to assign height argument to Height property
            Height = height;
        }
        /// <summary>
        /// Calculate the body mass index (BMI) using the weight and height of the person.
        ///
        /// The BMI of a person is calculated using the formula: BMI = 700 * weight / (height * height)
        /// where weight is in pounds and height is in inches.
        /// </summary>
        /// <returns>the body mass index (BMI) value of the person</returns>
        public double Bmi()
        {
            // double bmiValue = 703 * Weight / Math.Pow(2, Height);
            // Problem Description: summary comments are incorrect. Coefficient is 703, not 700.
            // incorrect Math.Pow usage (should be Math.Pow(Height, 2))
            double bmiValue = 703 * _weight / Math.Pow(_height, 2);
            bmiValue = Math.Round(bmiValue, 1);
            return bmiValue;
        }
        /// <summary>
        /// Determines the BMI Category of the person using their BMI value.
        /// </summary>
        /// <returns>one of following: underweight, normal, overweight, obese.</returns>
        public string BmiCategory()
        {
            string category = "Unknown";
            double bmiValue = Bmi();
            // Problem Description: consecutive if statements overwrite lesser categories due to overlapping ranges
            // i.e. every underweight and normal value will be overwritten as overweight due to non-branching logic
            // solution: 
            if (bmiValue < 18.5)
            {
                category = "underweight";
            }
            //if (bmiValue < 24.9)
            else if (bmiValue < 24.9)
            {
                category = "normal";
            }
            //if (bmiValue < 29.9)
            else if (bmiValue < 29.9)
            {
                category = "overweight";
            }
            //if (bmiValue >= 30)
            else if (bmiValue >= 30)
            {
                category = "obese";
            }
            return category;
        }
    }
}