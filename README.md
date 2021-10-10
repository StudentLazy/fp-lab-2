# Lab 2: Simple List Operations

## Part 1: List Calculations

Implement a given function using three different methods:

 - using built-in library function in the most concise way
 - using recursion, without library functions
 - using tail recursion

Number of function to implement is calculated as (N mod 7) + 1, where N is your personal number in the group list.

Implement a function that computes:
 
 1. Scalar product of two vectors represented as lists 
 2. Pairwise product of two vectors (`times [1;2;3] [3;2;1]` should be `[3;6;3]`)
 3. Sum of all elements of a list that are divisible by 13
 4. Sum of every second element in a list (eg. for a list `[l1;l2;l3]` computes `l1+l3`)
 5. Sum of squares of all numbers in the list
 6. Difference beteen maximal and minimal element of a list
 7. Rectified list, i.e. all negative elements in a list should be replaced by 0

Place your soultion into `Solution.fsx` file.

## Part 2: Database Queries

Consider that you need to implement a database of students and their exam grades. Students can belong to different groups 
(in our case, from 101 to 104), and they have a number of exam grades (numbers from 2 to 5) on different subjects.

Sample data has been provided to you in this repository. Files `one.fsx`, `two.fsx`, `three.fsx` and `four.fsx` contain different possible
represenations of the same data. Please select **one file** accoding to your number using (N mod 4) + 1 formula and work with this representation.

You need to implement **one task** from the table below (using (N mod 3)+1 formula). Each tasks contains three functions to implement:

 1. Task 1
    - Print the table of groups and average grade for that group
    - For each subject, print the list of students who failed the exam (grade=2)
    - Find the number of failing students in each group
 2. Task 2
    - Print the average grade for each subject
    - For each group, print the number of students who failed the exam 
    - Find the number of failing students for each subject
 3. Task 3
    - For each student, print his average grade, and whether he passed or not (did not pass = has at least one 2)
    - For each subject, print the number of failed students
    - For each group, print the student with maximum total grade (any such student, if there are many)

Place your solution into `Data.fsx` file.

Good luck with the exercise!
