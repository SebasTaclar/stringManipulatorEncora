# stringManipulatorEncora
Code challenge

First of all, I started looking at the requeriment, where I started to see that the first thing is create a collection of strings provided manually or by unitTesting, then according to the demands described on the requeriment 
I need to idenfied the frequency of each letter inside in each word, for this purpose I used linq as the approach, grouping by any letter in the word, which I consider was a good approach in order to apply good practices of coding, 
then base on this IEnumerable<Anonymus> variable I started to iterate this previous variable in order to fill each new string (output) repeting the current letter the number of times identified in the previous approach. 
I performed this with a foreach loop on the IEnumerble variable and dicreasing the frequency of each letter until the count reachs zero, then the loop iterates to the next letter, for the alphabetical order 
I previously order the letter in the word by alphabetical order.

Respect to the architecture I use an independient class to generate the input list of string, process the string interating this previous list and finally building the output list of string, 
I used the disposable interface in order to be able to use the using statement in the main program, respect to the framework I used .NET Core 5 due I fell confortable with this framework .

Respect to the unit test I used the MSTest Project which is compatible with .NET Core 5. and then I created each test case generating the input and the expected output, and using CollectionAssert 
I was be able to compare each collection. 

Additional Notes; I had to make sure that the word has at least 1 letter, and also make sure to delete the spaces (this because if there was any space the test was going to fail).