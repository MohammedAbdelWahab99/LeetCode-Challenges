public class Solution {
    public int MajorityElement(int[] nums) {
    var myDictio = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++) {
        if (myDictio.ContainsKey(nums[i])) 
        {
            myDictio[nums[i]]++;
        } 
        else 
        {
            myDictio.Add(nums[i], 1);
        }

        if (myDictio[nums[i]] > nums.Length / 2) {
            return nums[i];
        }
    }
    return -1;
    }
}