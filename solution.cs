public class Solution {
    public int MostFrequent(int[] nums, int key) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length - 1; i++){
            if(nums[i] == key){
                if(d.ContainsKey(nums[i + 1])){
                    d[nums[i + 1]] += 1;
                }
                else{
                    d[nums[i + 1]] = 1;
                }
            }
        }

        int max = 0;
        int ret = 0;
        foreach(int k in d.Keys){
            if(d[k] > max){
                max = d[k];
                ret = k;
            }
        }

        return(ret);
    }
}
