namespace LAb2.Services
{
    public class CalcService
    {
        public static string Add(int a, int b)
        {
            return (a + b).ToString();
        }
        public static string Sub(int a, int b)
        {
            return (a - b).ToString();
        }
        public static string Mult(int a, int b)
        {
            return (a * b).ToString();
        }
        public static string Div(int a, int b)
        {
            if (b == 0)
                return "Infinity";
            else
                return (a / b).ToString();
        }
        public static string? Operation(int a, int b, string op)
        {
            if (op == "+")
                return Add(a, b);
            if (op == "-")
                return Sub(a, b);
            if (op == "*")
                return Mult(a, b);
            if (op == "/")
                return Div(a, b);
            return null;
        }
    }
    public static class ServiceProviderExtansions
    {
        public static void AddCalcService(this IServiceCollection services)
        {
            services.AddTransient<CalcService>();
        }
    }
}
