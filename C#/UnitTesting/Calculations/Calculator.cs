namespace Calculations
{
    public class Calculator
    {
        private int num1, num2, ans;

        public Calculator(int num1, int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
        public int Ans { get => ans; set => ans = value; }

        /*public int getNum1() { return Num1; }
        public int getNum2() { return Num2; }*/

        public int Add()
        {
            Ans = Num1 + Num2;
            return Ans;
        }

        public int Subtract()
        {
            Ans = Num1 - Num2;
            return Ans;
        }
    }
}