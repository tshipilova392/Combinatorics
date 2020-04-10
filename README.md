# Combinatorics
# Subsets
Algorithm for enumerating all subsets and using it for search all subsets with equal weights sum

MakeSubsets method creates array of bool with given length:

000
001
010
011
100
101
110
111

Evaluate method uses MakeSubset, calculates weights according to bool array, and finds subsets with equal sum of weights.

weights = { 2, 5, 6, 2, 4, 7 }

000000
000001
000010
000011
000100
000101
000110
000111 OK
001000
001001 OK
001010
001011
001100
001101
001110
001111
010000
010001
010010
010011
010100
010101
010110
010111
011000
011001
011010
011011
011100 OK
011101
011110
011111
100000
100001
100010
100011 OK
100100
100101
100110
100111
101000
101001
101010
101011
101100
101101
101110
101111
110000
110001
110010
110011
110100
110101
110110 OK
110111
111000 OK
111001
111010
111011
111100
111101
111110
111111


# Permutations
Algorithm for enumerating all permutations and using it for Travelling salesman problem

MakePermutations method creates array of int with given length:  
0 1 2 3  
0 1 3 2  
0 2 1 3  
0 2 3 1  
0 3 1 2  
0 3 2 1  
1 0 2 3  
1 0 3 2  
1 2 0 3  
1 2 3 0  
1 3 0 2  
1 3 2 0  
2 0 1 3  
2 0 3 1  
2 1 0 3  
2 1 3 0  
2 3 0 1  
2 3 1 0  
3 0 1 2  
3 0 2 1  
3 1 0 2  
3 1 2 0  
3 2 0 1  
3 2 1 0  
  
Prices array is array of the distances between each pair of given cities.
Evaluate method uses MakePermutations and calculates price of given route.
evaluate method cab be used for finding the shortest possible route that visits each city and returns to the origin city.  
0 1 2 3  - 9  
0 1 3 2  - 9  
0 2 1 3  - 10  
0 2 3 1  - 12  
0 3 1 2  - 19  
0 3 2 1  - 13  
1 0 2 3  - 12  
1 0 3 2  - 13  
1 2 0 3  - 19  
1 2 3 0  - 9  
1 3 0 2  - 10  
1 3 2 0  - 9  
2 0 1 3  - 9  
2 0 3 1  - 19  
2 1 0 3  - 13  
2 1 3 0  - 10  
2 3 0 1  - 9  
2 3 1 0  - 12  
3 0 1 2  - 9  
3 0 2 1  - 10  
3 1 0 2  - 12  
3 1 2 0  - 19  
3 2 0 1  - 9  
3 2 1 0  - 13  
  
# Combinations
Algorithm for enumerating all combinations.  

MakeCombinations method creates array of bool with given length of array and given amount of 1:  
11100  
11010  
11001  
10110  
10101  
10011  
01110  
01101  
01011  
00111  
