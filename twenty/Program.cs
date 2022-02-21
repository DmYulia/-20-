using static System.Console;

namespace twenty
{
    class Program
    {
        delegate double DelegateGeom(double r);
        static void Main(string[] args)
        {
            DelegateGeom ciboll = LengthCircle;
            ciboll += AreaCircle;
            ciboll += VolumeBoll;
            double r;
    Stick:  Write("Input r = ");
            try
            {
            r = Convert.ToDouble(ReadLine());
                if (r <= 0) throw new Exception("Error!_\"r\" must be greater than \"0\"");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Stick;
            }
            ciboll(r);
            Console.ReadKey();
        }
        static double LengthCircle(double r)
        {
            double d = 2 * Math.PI * r;
            Console.WriteLine($"Circle length = {d}");
            return d;
        }
        static double AreaCircle(double r)
        {
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Circle area = {s}");
            return s;
        }
        static double VolumeBoll(double r)
        {
            double v = (4  * Math.PI * Math.Pow(r, 3))/ 3;
            Console.WriteLine($"Volume boll = {v}");
            return v;
        }
    }
}