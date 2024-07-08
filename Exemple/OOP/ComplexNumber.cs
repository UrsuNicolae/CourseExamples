namespace Exemple.OOP
{
    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real * b.Real - a.Imaginary * b.Imaginary,
                a.Real * b.Imaginary + a.Imaginary * b.Real);
        }

        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            var denominator = b.Real * b.Real + b.Imaginary * b.Imaginary;
            return new ComplexNumber((a.Real * b.Real + a.Imaginary * b.Imaginary) / denominator,
                (a.Imaginary * b.Real - a.Real * b.Imaginary) / denominator);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
