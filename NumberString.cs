namespace StringCalculator
{
    public class NumberString
    {
        public string numbers { get; set; }
        public string delimeter { get; set; }
        public NumberString(string numbers)
        {
            this.numbers = numbers;
            this.numbers = numbers.Trim();
            if (numbers.StartsWith("//"))
            {
                delimeter = ""+numbers[2];
                this.numbers = numbers.Substring(4);
            }
            else
            {
                delimeter = ",";
            }
            this.numbers = numbers.Replace("\n", delimeter);
        }
    }
}
