class Solution:
    def mostFrequent(self, nums: List[int], key: int) -> int:
        d = {}
        for i in range(len(nums) - 1):
            if nums[i] == key:
                if nums[i + 1] in d:
                    d[nums[i + 1]] = d[nums[i + 1]] + 1
                else:
                    d[nums[i + 1]] = 1
        
        m = 0
        ret = 0
        for k in d:
            if d[k] > m:
                m = d[k]
                ret = k
        
        return ret
