namespace MindBoxLibrary
{
    public class Class1
    {
        bool IsCircle = false;
        double a, b, c;
        double gip,kat1,kat2;
        public Class1(double a, double b = 0, double c = 0)
        {
            this.a = a;
            if (b ==0 && c == 0) 
                IsCircle = true;
            else
            {
                this.b = b;
                this.c = c;
            }
            if (a > b && a > c)
                CalcGip(a, b, c);
            else if (b > a && b > c)
                CalcGip(b, a, c);
            else if (c > a && c > b)
                CalcGip(c, a, b);
        }
        private void CalcGip(double gip ,double kat1, double kat2)
        {
            this.gip = gip;
            this.kat1 = kat1;
            this.kat2 = kat2;
        }
        public double Calculate()
        {
            if (IsCircle == true)
                return Math.PI * Math.Pow(a,2);
            else
            {
                if (Math.Pow(kat1,2) + Math.Pow(kat2,2) == Math.Pow(gip,2))
                {
                    Console.WriteLine("Треугольник прямоугольный");
                }
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
    }
}