#Number guessing game

import random
import time

playAgain = 1
while (playAgain):
    #initial list for holding values from 1 to 100
    possibleChoices = [value for value in range(1,101)]
      
    #variable to keep track of number of guesses
    guess = 0

    #variable for if the game fails from the list becoming empty
    fail = 0

    #introduction to the game
    print("Think of an integer from 1 to 100, I will try to guess it.")
    print("Say \"higher\" if the guess is too low.")
    print("Say \"lower\" if the guess is too high.")
    print("Say \"end\" to end the game early.")
    print("Say \"yes\" if the guess is correct.")
    print()
    time.sleep(10)

    #initial guess
    choice = random.choice(possibleChoices)

    #loop for game
    while (1):
        print("Is your number %s? " %(choice), end = "")
        userInput = input()
        print()
        if (userInput.lower().strip() == "yes"):
            guess += 1
            break
        elif (userInput.lower().strip() == "higher"):
            #make sure to slice the list using INDEX values, not the actual value!
            if (choice == 100):
                print("No more choices left")
                fail = 1
                break
            else:
                possibleChoices = possibleChoices[possibleChoices.index(choice+1) : ]
                guess += 1
                choice = random.choice(possibleChoices)
        elif (userInput.lower().strip() == "lower"):
            possibleChoices = possibleChoices[ : possibleChoices.index(choice)]
            if (possibleChoices == []):
                print("No more choices left")
                fail = 1
                break
            guess += 1
            choice = random.choice(possibleChoices)
        elif (userInput.lower().strip() == "end"):
            fail = 1
            break
        else:
              print("Say \"yes\" or \"higher\" or \"lower\" or \"end\"")

    #ending messages
    if (fail):
        print("Game over")
    else:
        print("I did it!")
        if (guess == 1):
            print("And I got it on the first try!")
        else:
            print("And it only took %d guesses!" %(guess))

    #see if the user wants to play again
    while (1):
        playAgainChoice = input("Play again? Yes or no: ")
        if (playAgainChoice.lower().strip() == "no"):
            playAgain = 0
            break
        elif (playAgainChoice.lower().strip() == "yes"):
            print()
            break
        else:
            continue

print()
print("Thanks for playing.")
