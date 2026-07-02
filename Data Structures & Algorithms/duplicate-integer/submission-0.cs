public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> secondArr = new List<int>();
        for (int i = 0; i < nums.Length; i ++) {
           if(secondArr.Contains(nums[i])) {
            return true; 
            }
            else {
                secondArr.Add(nums[i]);
            } 
        };
        return false;
    }
}