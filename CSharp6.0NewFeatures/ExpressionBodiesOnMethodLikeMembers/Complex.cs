namespace ExpressionBodiesOnMethodLikeMembers
{
    class Complex
    {
        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public int Real { get; set; }
        public int Imaginary { get; set; }
        public Complex Add(Complex numberToAdd)
        {
            return new Complex(Real + numberToAdd.Real, Imaginary + numberToAdd.Imaginary);
        }

        //returns new Complex object
        public static Complex operator +(Complex firstNumber, Complex secondNumber) => firstNumber.Add(secondNumber);

        //returns new string
        public static implicit operator string(Complex complexNumber)
            => $"({complexNumber.Real}, {complexNumber.Imaginary})";
    }
}
