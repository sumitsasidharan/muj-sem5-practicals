# 01 Write a program to take input from user and perform their addition.

num1 = float(input("Enter the first number: "))
num2 = float(input("Enter the second number: "))
result = num1 + num2
print("Sum:", result)


# 02 Write a program to create a function to calculate factorial of a number.

def factorial(n):
    if n == 0 or n == 1:
        return 1
    else:
        return n * factorial(n-1)

num = int(input("Enter a number: "))
print("Factorial:", factorial(num))


# 03 Write a python program to find largest number among three numbers.

# Python program to find the largest number among the three input numbers

# change the values of num1, num2 and num3 for a different result
num1 = int(input("Enter first number"))
num2 = int(input("Enter second number"))
num3 = int(input("Enter third number"))

if (num1 >= num2) and (num1 >= num3):
   largest = num1
elif (num2 >= num1) and (num2 >= num3):
   largest = num2
else:
   largest = num3

print("The largest number is", largest)



# 04 Write a program to double a given number and add two numbers using lambda() function.
double = lambda x:2*x

print(double(5))

add = lambda x,y:x+y

print(add(5,4)) 