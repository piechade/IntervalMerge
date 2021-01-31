# Interval Merge

The Program implementing a function MERGE which receives a list of intervals and returns a list of intervals as a result. In the result all overlapping intervals should be remembered. All non-overlapping intervals remain untouched.

## Build instructions
1. Create a central folder like ```C:\Repos```
3. Clone IntervalMerge into  ```<central folder>\IntervalMerge```
5. Open ```<central folder>\IntervalMerge\IntervalMerge.sln```
5. Restore Nuget packages

### Alternatively in PowerShell
```powershell
git clone https://github.com/piechade/IntervalMerge IntervalMerge
dotnet build .\IntervalMerge\IntervalMerge.sln
``` 

## Algorithm

1. Sort the intervals based on increasing order of 
    starting time.
2. Push the first interval on to a stack.
3. For each interval do the following
   a. If the current interval does not overlap with the stack 
       top, push it.
   b. If the current interval overlaps with stack top and ending
       time of current interval is more than that of stack top, 
       update stack top with the ending  time of current interval.
4. At the end stack contains the merged intervals. 

## Time complexity 

The Time complexity of the method is O(nLogn) which is for sorting.

## Robustness 

The program checks each interval if the end time is greater than the start time. When sorting, all intervals are checked for the correct type. The length of the array is also checked to avoid side effects.

## Memory consumption

The Program need storage in the length of the different intervals arrays plus the length off the result.

## Statistics

Code time: 30min  
Test time: 5min  
Writing doc: 30min  
