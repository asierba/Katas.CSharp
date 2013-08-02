Code Katas in C#
------------------

This is a collection of Code Katas. Done in C# through a TDD approach.

* FizzBuzz
* Fibonacci
* Checkout
* String Calculator


Fizzbuzz
---------

Fizzbuzz is a drinking game where players take turns to count incrementally, replacing any number divisible by three with the word "fizz", and any number divisible by five with the word "buzz".

E.g: 

* 1 -> 1
* 2 -> 2
* 3 -> fizz
* 4 -> 4
* 5-> buzz 
* 6 -> fizz
* 7 -> 7
* 8 -> 8
* 9 -> fizz
* 10 -> buzz
* 11 -> 11
* 12 -> fizz
* 13 -> 13
* 14 -> 14
* 15 -> fizzbuzz
* ...

+info: http://en.wikipedia.org/wiki/Bizz_buzz

Kata obtained from http://codingkata.net/Katas/Beginner/FizzBuzz


Fibonacci
----------
Fibonnaci is a sequence of numbers where the first number is 0, the second 1 and the subsquent the sum of the previous two.
0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 114 ..

+info: http://en.wikipedia.org/wiki/Fibonacci_number

Checkout
---------
Supermarket checkout that calculates the total price of a number of items. 
In a normal supermarket, things are identified using Stock Keeping Units, or SKUs. In our store, we’ll use individual letters of the alphabet (A, B, C, and so on). Our goods are priced individually. In addition, some items are multipriced: buy n of them, and they’ll cost you y cents. For example, item ‘A’ might cost 50 cents individually, but this week we have a special offer: buy three ‘A’s and they’ll cost you $1.30. In fact this week’s prices are:

  Item	Unit  Price	 Special Price            
  --------------------------
    A     50       3 for 130
    B     30       2 for 45
    C     20
    D     15
Our checkout accepts items in any order, so that if we scan a B, an A, and another B, we’ll recognize the two B’s and price them at 45 (for a total price so far of 95). Because the pricing changes frequently, we need to be able to pass in a set of pricing rules each time we start handling a checkout transaction.

Kata obtained from http://codekata.pragprog.com/2007/01/kata_nine_back_.html

String Calculator
------------------
Calculates the sum of integers in a string separated by a comma.

Kata obtained from http://osherove.com/tdd-kata-1/

Bowling game
------------
"The game consists of 10 frames as shown above.  In each frame the player has
two opportunities to knock down 10 pins.  The score for the frame is the total
number of pins knocked down, plus bonuses for strikes and spares.

A spare is when the player knocks down all 10 pins in two tries.  The bonus for
that frame is the number of pins knocked down by the next roll.  So in frame 3
above, the score is 10 (the total number knocked down) plus a bonus of 5 (the
number of pins knocked down on the next roll.)

A strike is when the player knocks down all 10 pins on his first try.  The bonus
for that frame is the value of the next two balls rolled.

In the tenth frame a player who rolls a spare or strike is allowed to roll the extra
balls to complete the frame.  However no more than three balls can be rolled in
tenth frame."

Kata obtained from http://butunclebob.com/ArticleS.UncleBob.TheBowlingGameKata
From the book Agile Principles, Patterns, and Practices by Rorbert C. Martin
