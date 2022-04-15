using LAb2.Services;
namespace LAb2.Models
{
    public class CalcModel
    {
        public int a { get; set; }
        public int b { get; set; }
        public string operation { get; set; }
        public string? GetValue()
        {
            return CalcService.Operation(a, b, operation);
        }
    }
}
