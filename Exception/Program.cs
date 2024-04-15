namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Test test = new Test();
            test[0] = 1;
            test[1] = 2;
            test[11] = 3;
            //for (int i = 0;i <test.Length;i++)
            //{
            //    Console.WriteLine(test[i]);
            //}
            foreach (var item in typeof(Test).GetProperties())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
    class Test
    {

        public int[] arr { get; set; }
        public int Length => arr.Length;
        public Test()
        {
            arr = new int[10];
        }
        public int this[int i]
        {
            get { return arr[i]; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("0 dan kicikdir");
                }
                if (i >= arr.Length)
                {
                    throw new IndexOutOfRangeException("uzunluqu coxdur");
                }
                arr[i] = value;
            }
        }

    }

}
