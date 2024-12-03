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
            Dictionary<int, bool> map = new Dictionary<int, bool>();
            for(int i = 0; i< nums.Length; i++)
            {
                int complementary = SumToFind - nums[i];
                if( map.ContainsKey(complementary))
                {
                    if(!map[complementary])
                    {
                        map[complementary] = true;
                        count++;
                    }
                }
                else
                {
                    if (!map.ContainsKey(nums[i]))
                    {
                        map.Add(nums[i], false);
                    }
                }
            }
            return count;
        }
    }
}
