public class Solution {
     // the   solution
    public void Rotate(int[] nums, int k) 
    {
        List<int> myList = new List<int>();
        int Length = nums.Length;
        k = k % Length; 

         for (int i = Length - k; i < Length; i++)
        {
            myList.Add(nums[i]);
        }

        for (int i = 0; i < Length - k; i++)
        {
            myList.Add(nums[i]);
        }

        for (int i = 0; i < Length; i++)
        {
            nums[i] = myList[i];
        }
    }
}