# RepeatedString

Lilah has a string (s), of lowercase English letters that she repeated infinitely many times.
Given an integer (n), find and print the number of letter a's in the first (n) letters of Lilah's infinite string.

For example, if the string (s)= 'aba' and (n)=10, the substring we consider is 'abaabaabaa', the first 10 characters of her infinite string.
There are 7 occurrences of a in the substring.

Function Description

Complete the repeatedString function in the editor below. It should return an integer representing the number of occurrences of a in the prefix of length (n) in the infinitely repeating string.

RepeatedString has the following parameter(s):

s: a string to repeat
n: the number of characters to consider

Input Format

The first line contains a single string s .
The second line contains an integer n .

Output Format

Print a single integer denoting the number of letter a's in the first (n) letters of the infinite string created by repeating (s) infinitely many times.

Sample Input

aba
10

Sample Output

7

Explanation 
The first n=10 letters of the infinite string are abaabaabaa. Because there are 7 a's, we print 7 on a new line.
