namespace DebugWithTimCorey
{
    public class Person
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string FunkyNameBuilder()
        {
            string output = "";
            for (int i = 0; i < FristName.Length; i++)
            {
                if (i%2 == 0)
                {
                    //Substring tu 0-1 chi lay 1 character khong character thu 1
                    output += FristName.Substring(i, 1);
                }
                else
                {
                    output += FristName.Substring(i, 1).ToUpper();
                }
            }
            return output;
        }
    }
}
