namespace Circle
{
    public class Program
    {
        const float PI= 3.14f;
        public static void Calculate(float radius)
        {
            float area = (PI * (radius * radius));
            float circumference = 2 * PI * radius;

            Console.WriteLine($"For radius {radius} the circumference is {circumference:N1} and area is {area:N1}");

        }
        static void Main(string[] args)
        {
            Program p=new Program();
            Console.WriteLine("Enter the radius");
            float radius=float.Parse(Console.ReadLine());

            Calculate(radius);
            

        }
    }
}