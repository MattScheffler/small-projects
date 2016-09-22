#converts a base 10 number to binary
def Binary(x):
    #initial conditions for small values
    if (x < 0):
        return
    if (x == 0):
        return 0
    if (x == 1):
        return 1

    #counts the highest power of 2 in the input
    n = 0
    while ((2**n) < x):
        n += 1

    #for exact powers of 2  
    if (((2**n) % x) == 0):
        return (10**n)

    else:
        binary = "1"
        n -= 2
        #keep track of the difference in the last value and the next lowest power of 2
        #if there is no difference then "switch on" a binary value, else it is 0
        difference = x - (2**(n+1))
        while (n >= 0):
            if (difference == 0):
                binary += "0"
            elif (difference >= (2**n)):
                binary += "1"
                difference -= (2**n)
            else:
                binary += "0"
            n -= 1
        return int(binary)
