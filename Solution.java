class Solution {
    public int mostFrequent(int[] nums, int key) {
        HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();
        for(int i = 0; i < nums.length - 1; i++){
            if(nums[i] == key){
                map.put(nums[i + 1], map.getOrDefault(nums[i + 1], 0) + 1);
            }
        }

        int max = 0;
        int ret = 0;
        for(int k : map.keySet()){
            if(map.get(k) > max){
                max = map.get(k);
                ret = k;
            }
        }

        return(ret);
    }
}
