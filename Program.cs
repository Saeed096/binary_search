using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace binary_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //int[] temp = { 1 };
            //int[] result = SearchRange(temp , 1);

            //Console.WriteLine(result[0] + result[1]);

            //int [] nums = { 1, 3,4,5,6,7 };
            //int result = SearchInsert(nums, 2);
            //Console.Write(result);


            //int result2 = Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0);


            //int result = getMaximumAmount( new[] {1 ,2 , 4 } , 4);

            //long result = PickGifts(new[] { 25, 64, 9, 4, 100 }, 4);

            //int result = sum(new []{1,2,3 });

            //int result = count(new int?[] { 1, 2, 3 });

            //Console.WriteLine(result);


            //PeakIndexInMountainArray(new int []{ 18, 29, 38, 59, 98, 100, 99, 98, 90 });

            Merge(new int[] {1,2,3,0,0,0} , 3 , new int[] { 2, 5, 6}, 3);

            int[] result = SortArray2(new int[] {5,2,3,1 });

            foreach(int num in result)
            {
                Console.WriteLine(num);
            }
        }

        // no 1

        //public int binarySearch(int[] nums, int target)
        //{
        //    int max = nums.Length - 1;
        //    int min = 0;

        //    while( max >= min)
        //    {
        //        int mid = (max + min) / 2;

        //        if (target == nums[mid])
        //        {
        //            return mid;
        //        }
        //        else if (target > nums[mid])
        //        {
        //            min = mid + 1;
        //        }
        //        else
        //        {
        //            max = mid - 1;
        //        }
        //    }
        //    return -1;
        //}




        // no 34 
        //public int[] SearchRange(int[] nums, int target)
        //{
        //    int[] result = new int[2];

        //    int max = nums.Length - 1;
        //    int min = 0;
        //    int count = nums.Where(n => n==target).Count();

        //    while (max >= min)
        //    {
        //        int mid = (max + min) / 2;

        //        if (target == nums[mid] && ((mid != 0 && target > nums[mid - 1]) || mid == 0))
        //        {
        //            result[0] = mid;
        //            result[1] = mid + count - 1;
        //            return result;
        //        }
        //        else if (target < nums[mid] || (target == nums[mid] && mid != 0 && target == nums[mid - 1]))
        //        {
        //            max = mid -1;
        //        }
        //        else
        //        {
        //            min = mid + 1;
        //        }
        //    }
        //    return [-1,-1];
        //}








        // no 34 
        //public int[] SearchRange2(int[] nums, int target)
        //{
        //    int[] result = { -1 , -1};

        //    int count = nums.Where(n => n == target).Count();


        //    result[0] = findFirstOccurence(nums , target);
        //    if (result[0] != -1)
        //    {
        //        result[1] = findLastOccurence(nums , target);
        //    }
        //    return result;
        //}

        //private int findFirstOccurence(int[] nums , int target)
        //{
        //    int max = nums.Length - 1;
        //    int min = 0;
        //    int first = -1;

        //    while(min <= max)
        //    {
        //        int mid = (max + min) / 2;
        //        if (target == nums[mid])
        //        {
        //            first = mid;
        //            max = mid -  1;
        //        }
        //        else if(target < nums[mid])
        //        {
        //            max = mid - 1;
        //        }
        //        else
        //        {
        //            min = mid + 1;
        //        }
        //    }
        //    return first;
        //}


        //private int findLastOccurence(int[] nums, int target)
        //{
        //    int max = nums.Length - 1;
        //    int min = 0;
        //    int last = max;

        //    while (min <= max)
        //    {
        //        int mid = (max + min) / 2;
        //        if (target == nums[mid])
        //        {
        //            last = mid;
        //            min = mid + 1;
        //        }
        //        else if (target < nums[mid])
        //        {
        //            max = mid - 1;
        //        }
        //        else
        //        {
        //            min = mid + 1;
        //        }
        //    }
        //    return last;
        //}


        // no 35
        //    public static int SearchInsert(int[] nums, int target)
        //    {
        //        int min = 0;
        //        int max = nums.Length - 1;
        //        int middle = (min + max) / 2;
        //        int? result = 0;

        //    while (min <= max)
        //    {
        //        middle = (min + max) / 2;
        //        if (nums[middle] == target)
        //        {
        //            return middle;
        //        }
        //        else if (nums[middle] > target)
        //        {
        //            result = isTargetNearToCurrentLocation(nums, middle, target, true);
        //            if ( result == null)
        //            {
        //                max = middle - 1;
        //            }
        //            else
        //            {
        //                //  return result;
        //                break;
        //            }
        //        }
        //        else
        //        {
        //            result = isTargetNearToCurrentLocation(nums, middle, target, false);
        //            if(result == null)
        //            {
        //                min = middle + 1;
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
        //    }
        //    return (int)result;  

        //    }

        //private static int? isTargetNearToCurrentLocation(int[] nums , int middle , int target, bool isTargetSmaller)
        //{
        //    switch(isTargetSmaller)
        //    {
        //        case true:
        //            {
        //                if ((middle != 0 && nums[middle - 1] < target) || middle == 0)
        //                {
        //                    return middle;
        //                }
        //                return null;
        //            }
        //          case false:
        //         {
        //                if ( (middle < nums.Length - 1 && nums[middle + 1] > target) || middle == nums.Length - 1)
        //                {
        //                    return middle + 1;
        //                }
        //                return null;               
        //            }
        //          }
        //}




        // no 35
        //public static int SearchInsert(int[] nums, int target)
        //{
        //    int left = 0, right = nums.Length - 1;

        //    while (left <= right)
        //    {
        //        int mid = (left + right) / 2;

        //        if (nums[mid] == target)
        //        {
        //            return mid; // Target found
        //        }
        //        else if (nums[mid] < target)
        //        {
        //            left = mid + 1; // Search in the right half
        //        }
        //        else
        //        {
        //            right = mid - 1; // Search in the left half
        //        }
        //    }

        //    return left; // take the last index dealed as min , all other guesses were larger than target , but the guess that make left updated was smaller than target so min was updated , due to all other guesses were larger and target was not found so the expected position for target should be first mid which was smaller than the target + 1 which represents the latest value for left
        //    // can return right + 1;  >> right also
        //}




        // no 441
        //public int ArrangeCoins(int n)
        //{
        //BigInteger min = 0;
        //BigInteger max = n;
        //BigInteger mid = min + (max - min) / 2;

        //int result = 0;
        //while (min <= max)
        //{
        //    mid = min + (max - min) / 2;
        //    if (mid * (mid + 1) / 2 <= n)
        //    {
        //        result = (int)mid;
        //        min = mid + 1;
        //    }
        //    else
        //    {
        //        max = mid - 1;
        //    }
        //}

        //return result;
        //}


        // no 69
        //public int MySqrt(int x)
        //{
        //    if(x == 0)
        //    {
        //        return 0;
        //    }

        //BigInteger min = 1;
        //BigInteger max = x;
        //BigInteger mid = min + (max - min) / 2;
        //int result = 0;

        //while(min <= max)
        //{
        //    mid = min + (max - min) / 2;
        //    if (mid * mid == x)
        //    {
        //        result = (int)mid;
        //        break;
        //    }
        //    else if(mid * mid < x)
        //    {
        //        result = (int)mid;
        //        min = mid + 1;
        //    }
        //    else
        //    {
        //        max = mid - 1;
        //    }
        //}
        //return result;

        //}



        // 33
        //public static int Search(int[] nums, int target)
        //{
        //    if(nums.Contains(target))
        //    {
        //        int min = 0;
        //        int max = nums.Length;
        //        int mid = min + (max - min) / 2;
        //        int[] rotatedIndexes = new int[2];
        //        if (isRotationHappened(nums.Max() , nums[nums.Length - 1]))
        //        {
        //            // check rotation happened at which index
        //            rotatedIndexes = getRotatedIndexs(nums);
        //            //int[] arrangedArray = rearrangeArray(nums, rotatedIndexes);
        //            //nums = arrangedArray;
        //        }

        //        if(rotatedIndexes is not null)
        //        {
        //            // we may search in 2 separated arrays using binary search
        //            max = rotatedIndexes[1] - 1;
        //        }

        //        // first search
        //            while(min <= max)
        //            {
        //                mid = min + (max - min) / 2;
        //                if (nums[mid] == target)
        //                {
        //                    return mid;
        //                }
        //                else if (nums[mid] < target)
        //                {
        //                    min = mid + 1;
        //                }
        //                else
        //                {
        //                    max = mid - 1;
        //                }
        //            }


        //            // second search
        //        min = rotatedIndexes[1];
        //        max = nums.Length - 1;

        //        while (min <= max)
        //        {
        //            mid = min + (max - min) / 2;
        //            if (nums[mid] == target)
        //            {
        //                return mid;
        //            }
        //            else if (nums[mid] < target)
        //            {
        //                min = mid + 1;
        //            }
        //            else
        //            {
        //                max = mid - 1;
        //            }
        //        }

        //        return mid;


        //    }


        //    else
        //    {
        //        return -1;
        //    }
        //}

        //private static bool isRotationHappened(int biggestNum ,int lastNum)
        //{
        //    if (lastNum < biggestNum)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //private static int[] getRotatedIndexs(int[] nums)
        //{
        //    int[] swappedIndexes = new int[2];

        //    int min = 0;
        //    int max = nums.Length - 1;
        //    int mid = min + (max - min) / 2;
        //    int lastNum = nums[nums.Length - 1];
        //    int firstSwappedIndex = 0;
        //    int secondSwappedIndex = nums.Length - 1;

        //    while(min <= max)
        //    {
        //        mid = min + (max - min) / 2;

        //        if (nums[mid] > lastNum)
        //        {
        //            firstSwappedIndex = mid;
        //            max = mid - 1;
        //        }
        //        else
        //        {
        //            min = mid + 1;
        //        }
        //    }
        //    swappedIndexes[0] = firstSwappedIndex;
        //    // find 2nd swapped index

        //    min = firstSwappedIndex;
        //    max = nums.Length - 1;
        //    mid = min + (max - min) / 2;

        //    while(min <= max)
        //    {
        //        mid = min + (max - min) / 2;

        //        if(nums[mid] < nums[firstSwappedIndex])
        //        {
        //            secondSwappedIndex = mid;
        //            max = mid - 1;
        //        }
        //        else
        //        {
        //            min = mid + 1;
        //        }
        //    }
        //    swappedIndexes[1] = secondSwappedIndex;

        //    return swappedIndexes;

        //}

        //private static int[] rearrangeArray(int[] nums, int[] rotatedIndexes)
        //{
        //    int[] preRotataionPart = nums.Skip(0).Take(rotatedIndexes[0]).ToArray();
        //    int[] intermediateRotationPart = nums.Skip(rotatedIndexes[1])
        //            .Take(nums[nums.Length - rotatedIndexes[1]])
        //            .ToArray();

        //    int[] postRotationPart = nums.Skip(rotatedIndexes[0])
        //            .Take(rotatedIndexes[1] - rotatedIndexes[0])
        //            .ToArray();

        //    int[] rearrangedArray = preRotataionPart.Concat(intermediateRotationPart)
        //                            .Concat(postRotationPart).ToArray();

        //    return rearrangedArray;
        //}





        // ibm preparation 



        public static int getMaximumAmount(int[] typesQuantity, int customersNum)
    {
        // Priority queue (max-heap) to track items with their prices
        var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));

        // Add all items to the priority queue
        foreach (var quantity in typesQuantity)
        {
            if (quantity > 0)
            {
                maxHeap.Enqueue(quantity, quantity);
            }
        }

        int totalMoney = 0;

        // Serve customers
        for (int i = 0; i < customersNum && maxHeap.Count > 0; i++)
        {
            // Get the highest-priced item
            int highestPrice = maxHeap.Dequeue();
            totalMoney += highestPrice;

            // Decrement the quantity and re-add to the queue if still available
            if (highestPrice - 1 > 0)
            {
                maxHeap.Enqueue(highestPrice - 1, highestPrice - 1);
            }
        }

        return totalMoney;
    }


        // 2558
        public static long PickGifts(int[] gifts, int k)
        {
            var priorityQueque = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));

            if(gifts.Count() == 0)
            {
                return 0;
            }

            foreach (var gift in gifts)
            {
                if(gift > 0)
                {
                    priorityQueque.Enqueue(gift, gift);
                }
            }

            long result = 0;

            for(int i = 0; i < k; i++)
            {
                long highestPileWithGifts = priorityQueque.Dequeue();
                int num = (int) Math.Floor(Math.Sqrt(highestPileWithGifts));

                if(num != 0)
                {
                    priorityQueque.Enqueue(num, num);
                }


            }

            int counter = 0;
            int quequeSize = priorityQueque.Count;
            while(counter < quequeSize)
            {
                result += priorityQueque.Dequeue();
                counter++;
            }

            return result;
        }


        // example for using recursion instead of loop
        public static int sum(int[] arr)
        {
            if(arr.Count() == 0)
            {
                return 0;
            }

            int result = 0;
            int arrHeader = arr[0];

                result = arrHeader + sum(arr.Skip(1).ToArray());

            return result;

        }


        public static int count(int?[] arr)
        {
            if(arr == null || arr.Length <= 0)
            {
                return 0;
            }

            int result = 1 + count(arr.Skip(1).ToArray());

            return result;
        }




        public char NextGreatestLetter(char[] letters, char target)
        {
            int min = 0;
            int max = letters.Length - 1;

            int mid = min + (max - min) / 2;   // this for int overflow safety

            char result = letters[0];  // initial value

            while(min <= max)
            {
                mid = min + (max - min) / 2;

               
                if (letters[mid] > target) 
                {
                    result = letters[mid];
                    max = mid - 1;
                }
                else 
                {
                    min = mid + 1;
                }
            }

            return result;
            
        }



        public static int PeakIndexInMountainArray(int[] arr)
        {
            int min = 0;
            int max = arr.Length - 1;

            int mid = min + (max - min) / 2;   // this for int overflow safety
            int result = arr[mid];

            while (min < max)  // loop will be broken once min = max , there is no way for min to exceed max value
            {
                mid = min + (max - min) / 2;  //if min & max are 2 following nums >> mid will be always = min >> so there is a way to check mid + 1 as it = min + 1 which is max and no out of range exception , no way for min & max to be the same here as if that happened loop will be broken

                if (arr[mid] < arr[mid + 1])    // peak may be mid + 1 or larger so min should be updated
                {
                    min = mid + 1;  
                }

                else  // peak may be = mid or smaller so max should be updated.
                {
                    max = mid;  
                }
            }

            return min;  // min & max point to peak here
        }



        public static void Merge(int[] nums1, int m, int[] nums2, int n)  // need refactor
        {


            int firstZeroIndex = m;
            int movingNumber = 0; // initial value
            int lastPushedIndex = 0;

            for (int secondArrayOuterIndex = 0; secondArrayOuterIndex < n; secondArrayOuterIndex++) // iterate over 2nd array
            {
                bool isLarger = true;

                for (int firstArrayInnerIndex = lastPushedIndex; firstArrayInnerIndex < firstZeroIndex && isLarger;   // no need to iterate to reach updated first zero index , enough to iterate to reach the original first zero index which is m , after that all values should be appended at last of array
                    firstArrayInnerIndex++) // start iteration from last pushed index >> the newly pushed one is greater so it is a must to be pushed after it
                {
                    if (nums2[secondArrayOuterIndex] < nums1[firstArrayInnerIndex])
                    {
                        movingNumber = nums2[secondArrayOuterIndex];
                        lastPushedIndex = firstArrayInnerIndex;

                        for(int i = firstArrayInnerIndex; i <= firstZeroIndex; i++)  // iterate on reaching the 1st zero index to put latest movingNumber on it
                        {
                            int temp = nums1[i];
                            nums1[i] = movingNumber;
                            movingNumber = temp;
                        }

                        isLarger = false;
                    }
                }

                if(isLarger)  // if larger than all nums in first array
                {
                    nums1[firstZeroIndex] = nums2[secondArrayOuterIndex];
                    lastPushedIndex = firstZeroIndex;
                }

                firstZeroIndex++;
            }

        }





        public int SingleNumber(int[] nums)
        {
            if(nums.Length == 1)
            {
                return nums[0];
            }

            List<int> ints = new List<int>();

            foreach(int num in nums)  // O(N) >> count of nums
            {
                if(ints.Contains(num)) // O(M) >> count of ints >> at beginning ints will be very small >> by the time it may be equal N >> so its average is 1/2 N
                {
                    ints = ints.Where(i => i != num).ToList();  // O(M) >> count of ints >> its average is 1/2 N too >> so foreach operation O(1/2 N + 1/2 N) = O(N) >> for all iterations O(N²)
                }
                else
                {
                    ints.Add(num);  // O(1)  // constatnts like that are ignored in time compleexity 
                }
            }
            return ints[0];
        }



        public int SingleNumber2(int[] nums)  // better >> linear time complexity
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            HashSet<int> set = new HashSet<int>();
            
            foreach(int num in nums)  // O(N)
            {
                if(!set.Add(num))  // O(1) as it is a hashset
                {
                    set.Remove(num);  // O(1) as it is a hashset
                }
            }
            return set.First();
        }


        public int MissingNumber(int[] nums) // O(2N) constatns are ignored >> O(N)
        {
            int result = 0;
            if(nums.Length == 0)
            {
                return result;
            }
            
            HashSet<int> numsSet = new HashSet<int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                numsSet.Add(nums[i]);
            }

            for (int i = 0; i <= nums.Length; i++)
            {
                if(numsSet.Add(i))
                {
                    result = i;
                }
            }

            return result;

        }



        public int MissingNumber2(int[] nums)
        {
            int result = 0;
            if (nums.Length == 0)
            {
                return result;
            }

            int n = nums.Length;
            int expected = n * (n + 1) / 2;
            int real = nums.Sum();

            result = expected - real;
            return result;

        }


        //public static int[] SortArray(int[] nums)  // to be revised // quick sort algorithm, check O(????) >> should be O(n(log n)) >> on quick sort all items will be checked for number of log(n) if the whole array is 8 elements >> will check the 8 to divide to 4 and 4 as example , then check the 4 to divde into 2 and 2 and the other 4 also so the whole 8 were checked again , finaly each 2 will be checked to detect swapping will happen or not so the whole 8 elements were checked again, that means we touched the whole array 3 times which is log(8) so O(n(log n)) 
        //{
        //    if (nums.Length == 0)
        //    {
        //        return new int[0];
        //    }

        //    else if (nums.Length == 1)
        //    {
        //        return nums;
        //    }

        //    else if (nums.Length == 2)
        //    {
        //        if (nums[0] <= nums[1])
        //        {
        //            return nums;
        //        }
        //        swap(nums);
        //    }

        //    else
        //    {
        //        int pivot = nums[0];

        //        List<int> smallerThanPivot = new List<int>();
        //        List<int> largerThanPivot = new List<int>();

        //        for (int i = 1; i < nums.Length; i++)
        //        {
        //            if (nums[i] <= pivot)
        //            {
        //                smallerThanPivot.Add(nums[i]);
        //            }
        //            else
        //            {
        //                largerThanPivot.Add(nums[i]);
        //            }
        //        }

        //        List<int> wholeList = new List<int>();
        //        List<int> smallerNumsArr = SortArray(smallerThanPivot.ToArray()).ToList();
        //        List<int> largerNumsArr = SortArray(largerThanPivot.ToArray()).ToList();
        //        // here concat parts of arr together
        //        wholeList.AddRange(smallerNumsArr);   // not allowed to use built in methods
        //        wholeList.Add(pivot);
        //        wholeList.AddRange(largerNumsArr);

        //        nums = wholeList.ToArray();



        //    }

        //    return nums;
        //}


        public static int[] SortArray2(int[] nums)  // to be revised // quick sort algorithm, check O(????) >> should be O(n(log n)) >> on quick sort all items will be checked for number of log(n) if the whole array is 8 elements >> will check the 8 to divide to 4 and 4 as example , then check the 4 to divde into 2 and 2 and the other 4 also so the whole 8 were checked again , finaly each 2 will be checked to detect swapping will happen or not so the whole 8 elements were checked again, that means we touched the whole array 3 times which is log(8) so O(n(log n)) 
        {
            if (nums.Length == 0)
            {
                return new int[0];
            }

            else if (nums.Length == 1)
            {
                return nums;
            }

            else if (nums.Length == 2)
            {
                if (nums[0] <= nums[1])
                {
                    return nums;
                }
                swap(nums, 0 , 1);
                return nums;
            }

            else
            {
                int pivot = nums[0];
                int pivotIndex = 0;
                //List<int> smallerThanPivot = new List<int>();
                //List<int> largerThanPivot = new List<int>();

                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] < pivot)
                    {
                        for(int y = i; y > pivotIndex; y--)  // to be tested , if num < pivot , swap pivot with this num and update pivot index with i without the nested loop , start iterating from the end to start
                        {
                            swap(nums, y, y - 1);
                        }
                        pivotIndex++;
                    }
                }
                SortArray2(nums[..pivotIndex]);
                SortArray2(nums[(pivotIndex+1)..]);
                 // here concat parts of arr together
            

                //int[] sortedArray = new int[nums.Length];
                //for(int i = 0; i<smallerThanPivotArray.Length; i++)
                //{
                //    sortedArray[i] = smallerThanPivotArray[i];
                //}

                //sortedArray[smallerThanPivotArray.Length] = pivot;

                //for (int i = 0; i < largerThanPivotArray.Length; i++)
                //{
                //    sortedArray[i + smallerThanPivotArray.Length + 1] = largerThanPivotArray[i];
                //}

                return nums;

            }

        }


        public static void swap(int[] nums , int firstIndex , int secondIndex)
        {
            int temp = nums[firstIndex];
            nums[firstIndex] = nums[secondIndex];
            nums[secondIndex] = temp;
        }



    }
}
