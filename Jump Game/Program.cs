using System;

namespace Jump_Game
{
  class Program
  {
    static void Main(string[] args)
    {
      var nums = new int[] { 2, 3, 1, 1, 4 };
      Solution s = new Solution();
      var result = s.CanJump(nums);
      Console.WriteLine(result);
    }
  }

  public class Solution
  {
    public bool CanJump(int[] nums)
    {
      // will start from the end, will check if we can reach last index from previous index
      // if yes, previous index would be our new destination
      // will check now new desc can be reach from previous index
      // and will loop throw till the first index
      if (nums.Length == 1) return true;
      int dest = nums.Length - 1;
      int i = nums.Length - 2;
      while (i >= 0)
      {
        int maxJump = i + nums[i];
        if (maxJump >= dest) dest = i;
        i--;
      }

      return dest == 0;
    }
  }
}
