namespace Calculator_ASP_core.Models
{
    public class CalData
    {
        /// <summary>
        /// عملیات های ریاضی ماشین حساب
        /// </summary>
        public enum Operations
        {
            Sumproduct,Subtraction,Crossproduct,Divition,Factorial,Power,Root,Mode
        }

        public Operations Operation { get; set; }
        public int Value1 { get; set; }
        public int Value2 { get; set; }

    }
}
