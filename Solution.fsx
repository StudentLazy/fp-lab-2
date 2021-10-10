// Solution

// In this sample, the goal was to compute the length of the list

// Method 1: Library Function
let len1 = List.length 

// Method 2: Recursion
let rec len2 = function
  | []   -> 0
  | h::t -> len(t)+1

// Method 3: Tail Rec
let len3 =
  let rec len3' acc = function
  | [] -> acc
  | _::t -> len3' (acc+1) t
  len3' 0
