namespace BMICalculator
{
    public class BMICalculator
    {
        public double Calculate(double weight, byte height)
        {
            double h = height / 100.0;
            return weight / (h*h);

        }

    }
}
