namespace SumOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfTwo([1, 1, 1, 2, 3, 4, 5, 2], 2));
            Console.ReadKey();
        }

        public static int SumOfTwo(int[] nums, int SumToFind)
        {
            int count = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i = 0; i< nums.Length; i++)
            {
                int complementary = SumToFind - nums[i];
                if( map.ContainsValue(complementary))
                {
                    count++;
                }
                else
                {
                    map.Add(i, nums[i]);
                }
            }
            return count;
        }
    }
}
