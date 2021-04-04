#Have the function MaxSubarray(arr) take the array of numbers stored in arr and determine the largest sum that can be formed by any contiguous subarray in the array.
#For example, if arr is [-2, 5, -1, 7, -3] then your program should return 11 because the sum is formed by the subarray [5, -1, 7]. 
#Adding any element before or after this subarray would make the sum smaller.

def ArrayChallenge(arr):  maxsum = 0
  for i in range(len(arr)):
    for j in range(i, len(arr)):
      tempsum = sum(arr[i:j + 1])
      if tempsum > maxsum:
        maxsum = tempsum
  arr = maxsum
  return arr
  
print ArrayChallenge(raw_input())
