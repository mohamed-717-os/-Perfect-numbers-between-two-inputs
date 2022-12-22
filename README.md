# Perfect-numbers-between-two-inputs
The program asks the user for the 'first number' and the 'second number' and prints all perfect numbers between them.
there is a function called prime1() to ensure that input is prime by dividing the input by all odd numbers that are less than the square root of the input a theory in the number theory (x is prime when x hasn't a prime divisor <= √x).

The program calculates the perfect numbers using Euclid's formula --> (2^p - 1).2^(p-1) is perfect when (2^p - 1) is prime.
and (2^p - 1) is prime when p is prime.
So the program will use the prime numbers to calculate perfect numbers,
and if the perfect number is between the two inputs, the program prints it.
To make it faster we will examine only odd numbers and begin the loop with 3,
and for '2' the program will print 6 before the loop if the 'first number' is less than 6
because '6' is the output of '2' in the equation.
