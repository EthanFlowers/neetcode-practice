class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        for i in range(len(nums)):
            for k in range(i+1,len(nums)):
                #print(f"i: {i} k: {k} sum:{nums[i] + nums[k]}")
                if nums[i] + nums[k] == target:
                    return [i,k]



# i: 0 k: 1
# i: 1 k: err

# i: 0 k: 1
# i: 1 k: 2