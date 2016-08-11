#A collection of functions from completing the exercises at http://www.practicepython.org/
#Not all exercises are done here, and the number doesn't always corrospond to the exercise.

import random

#1: Tell somone the year they will turn 100.
def turnOneHundred(age):
    #get difference in age and 100 and add that to current year
    #this will give the year they turn 100
    current_year = 2016
    to_100 = 100 - age
    age_100 = current_year + to_100

    return age_100


#2: Tell if number is even or odd, and if two numbers divide evenly.
def isEven(num):
    if (num % 2 == 0):
        return True
    else:
        return False

def isOdd(num):
    if (num % 2 == 0):
        return False
    else:
        return True

def isDivisible(numerator, denominator):
    if (numerator % denominator == 0):
        return True
    else:
        return False

#3. Print all elements in a given list less than a given value.
def printLessThan(ls, value):
    for number in ls:
        if (number < value):
            print(number, end=" ")

#4. Get divisors of a value.
def divisors(num):
    #make a range to the value, and an empty list to add divisors too
    checkRange = range(1, num + 1)
    divisors = []
    
    #check for remainders for the range and add divisors to the list
    for value in checkRange:
        if (num % value == 0):
            divisors.append(value)

    return divisors

#5. Give the shared values of two lists without duplicates.
def shared(ls1, ls2):
    #list for shared value
    inBoth = []

    #check all values in first list, if they are in list 2
    #and not in the shared list already, add it to the shared list
    for value in ls1:
        if (value in ls2):
            if (value in inBoth):
                continue
            else:
                inBoth.append(value)
                
    return inBoth

#6. Test if a string is a palindrome or not.
def isPalindrome(string):
    #test string against the reverse of it
    return (string == string[::-1])

#7. Takes in a list and returns only the even values of it.
def even(ls):
    #check values in input, if they are ints and even, add to evenValue list
    evenValues = [value for value in ls if ((type(value) == int) and (value % 2 == 0))]

    return evenValues

#8. Rock, paper, scissors game.
def rockPaperScissors():
    #into message
    print("Enter 'end' to stop")
    print("Rock, paper, or scissors?")

    #get user inputs
    player1 = input("Player 1: ")
    player2 = input("Player 2: ")

    #main loop
    while (player1.lower() != "end"):
        
        #conditions to decide who wins
        if player1.lower() == player2.lower():
            print("It's a tie")
        elif player1.lower() == "rock" and player2.lower() == "paper":
            print("Player 2 wins!")
        elif player1.lower() == "rock" and player2.lower() == "scissors":
            print("Player 1 wins!")
        elif player1.lower() == "paper" and player2.lower() == "rock":
            print("Player 1 wins!")
        elif player1.lower() == "paper" and player2.lower() == "scissors":
            print("Player 2 wins!")
        elif player1.lower() == "scissors" and player2.lower() == "paper":
            print("Player 1 wins!")
        elif player1.lower() == "scissors" and player2.lower() == "rock":
            print("Player 2 wins!")
        elif player2.lower() == "end":
            break
        else:
            print("Try again")

        print()
        player1 = input("Player 1: ")
        player2 = input("Player 2: ")

    #end message
    print()        
    print("Thanks for playing!")

#9. Guess the random number game, chooses a random number from 1 to limit.
def randomGuess(limit):
    #generate the random number to be guessed
    #if a valid value was not given, stop the game
    try:
        num = random.randint(1,limit + 1)
    except:
        print("Input must be a positive integer.")
        return

    #introduciton and create guess variable
    print("I'm thinking of a number between 1 and", limit)
    guess = 0

    #guess attempts counter
    attempt = 1

    #main loop
    while guess != num:
        try:
            print("I'm thinking of a number between 1 and", limit)
            guess = int(input("Guess the number: "))
            if guess > num:
                print("Too high")
            elif guess < num:
                print("Too low")
            elif guess == num:
                break
            else:
                print("Try again")
                
            #update attempt counter, only counting valid guesses
            attempt = attempt + 1
            print()
        except:
            print()
            print("Input must be a positive integer.")

    #ending infomation
    print()
    print("You got it! The number was", num)
    print("Number of valid attempts:", attempt)
    print("Thanks for playing")

#10. Testing if a number is prime.
def primeTest(num):
    #make a list for the range of the user input
    #make sure to not include 1 and the number!
    testList = range(2, num)

    #list of any divisors of the number
    divisors = [value for value in testList if (num % value == 0)]
            
    #print if the number is prime or not
    if divisors == []:
        print(num, "is prime")
    else:
        print(num, "is not prime")

#11. Gives first 'number' values of the Fibonacci sequence
def fib(number):
    #conditions for if negatives, 1, or 2 are passed in
    if number <= 0:
        print("Number must be greater than zero.")
        return
    elif number == 1:
        return [1]
    elif number == 2:
        return [1,1]
    else:
        #make array that numbers will be held in
        fibs = [1,1]
        
        #make range for how long loop will run
        #end at number-1 to account for two values already in fibs[]
        run = range(1,number-1)
        
        #add the current list number and the previous together
        #append the list with that value
        for x in run:
            fibs.append(fibs[x] + fibs[x-1])
        return fibs

#12. Function to remove duplicates using loops
def removeDuplicates(input_list):
    #make new list for unique values
    output_list = []

    #loop to add unique values only to output
    for value in input_list:
        if value not in output_list:
            output_list.append(value)
            
    return output_list

#13. Reverses the word order in a sentence.
def reverseWordOrder(sentence):
    #split string into a list
    sentenceList = sentence.split()

    #make new list of test list values backwards
    reverseSentenceList = sentenceList[ : :-1]

    #join reverse list into a new string
    reverseSentence = " ".join(reverseSentenceList)

    return reverseSentence

#14. Password generator. Length can be 4 to 16 characters
def password():
    #make lists for numbers, special characters, and the alphabet
    #changing things to work with strings would be easier, maybe
    intList = [0,1,2,3,4,5,6,7,8,9]
    letterList = ['a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z']
    specialList = ['!','?','_','#','@','+','-']

    #new list for password
    password = []

    #add a random number of values from each list, and uppercase letters, to the password
    for x in range(0,random.choice(range(1,5))):
        password.append(random.choice(intList))
        x += 1

    for x in range(0,random.choice(range(1,5))):
        password.append(random.choice(letterList))
        x += 1

    for x in range(0,random.choice(range(1,5))):
        password.append(random.choice(letterList).upper())
        x += 1
        
    for x in range(0,random.choice(range(1,5))):
        password.append(random.choice(specialList))
        x += 1

    #shuffle list
    random.shuffle(password)

    #print list
    print("Your password is: ", end = "")
    for value in password:
        print(value, end = "")

#15. Cows and bulls game.
def cowsAndBulls():
    #this will generate a random 4 digit number as a string 
    randomNum = ""
    for x in range(0,4):
        randomNum += str(random.choice(range(1,10)))
        x += 1

    #get user number
    userNum = input("Enter a 4 digit number: ")

    #keep track of guesses
    guess = 0

    #loop until they guess the correct value
    while userNum != randomNum:
        try:
            #keep track of cows and bulls
            cow = 0
            bull = 0
            
            #loop through user input and update cows or bulls
            for value in userNum:
                if value == randomNum[userNum.index(value)]:
                    cow += 1
                if value in randomNum and value != randomNum[userNum.index(value)]:
                    bull += 1
                    
            #output bulls and cows count and get new input
            print("Bulls:", bull, "  Cows:", cow)
            print()
            userNum = input("Enter a 4 digit number: ")
        except:
            print()
            userNum = input("Enter a 4 digit number: ")

    #print ending message
    print("You got it!")

#16. Count how many times names appear in a text file.
def nameCount(filename):
    #make a blank dictionary to hold names and count them
    counter = {}

    #open file and loop through each line
    #add the name as a key and how many times it appears as a value

    with open(filename) as file:
        line = file.readline()
        while line:
            line = line.strip()
            if line in counter:
                counter[line] += 1
            else:
                counter[line] = 1
            
            line = file.readline()

        return counter

#17. Prints an n by n square board for n = 'size'
#make function to print top desired times
def top(tops):
    for x in range(0,tops):
        print(" ---", end = "")
        
#make function to print sides desired times + 1
def sides(sides):
    for x in range(0,sides+1):
        print("|   ", end = "")

#funciton for printing full board       
def board(size):
    try:
        for x in range(0,size):
            top(size)
            print("")
            sides(size)
            print("")
        #add the bottom
        top(size)

    except:
        print("Input size must be a positive integer.")

#18. Maximum value of 3 numbers.
def Max(a,b,c):
    if (a == b == c):
        return a
    elif (a > b) and (a > c):
        return a
    elif (b > a) and (b > c):
        return b
    elif (c > a) and (c > b):
        return c
