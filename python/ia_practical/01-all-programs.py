

# 01 Write a python program to create custom exception and check the eligibility of user to vote according to input age, if not eligible then throw custom exception.

class NotEligibleToVoteException(Exception):
    # Custom exception for ineligible voters.
    def __init__(self, age):
        self.age = age
        self.message = "Not eligible"
        super().__init__(self.message)

def check_voting_eligibility(age):
    # Check if the user is eligible to vote.
    if age < 18:
        raise NotEligibleToVoteException(age)
    else:
        print("eligible")
        
try:
    # Taking age as input from the user
    age = int(input(""))
    check_voting_eligibility(age)
except ValueError:
    print("Invalid input. Please enter a valid number for age.")
except NotEligibleToVoteException as e:
    print(e)
    

# 02 Program to print the list of duplicates from a list of integers
def find_duplicates(input_list):
    # Find and return duplicates in the given list
    duplicates = []
    seen = set()
    for item in input_list:
        if item in seen and item not in duplicates:
            duplicates.append(item)
        seen.add(item)
    return duplicates

# Input list
input_list = [10, 20, 30, 20, 20, 30, 40, 50, -20, 60, 60, -20, -20]
# Finding duplicates
duplicates = find_duplicates(input_list)
# Printing the duplicates
print(duplicates)
    


# 03 Write a Program to check input number is prime or not prime.

def is_prime(number):
    # Checking if a number is prime.
    if number <= 1:
        return False
    for i in range(2, number):
        if number % i == 0:
            return False
    return True

# Checking if a number is prime
try:
    # Text removed from input("") to pass test cases
    number = int(input(""))
    if is_prime(number):
        print("prime")
    else:
        print("not prime")
except ValueError:
    print("Invalid input. Please enter an integer.")
    



# 04 Write a Python Program to Find the Sum of Digits of a Number Using Recursion.

def sum_of_digits(n):
  # sum of digits using recursion
  if n == 0:
    return 0
  else:
    return n % 10 + sum_of_digits(n // 10)

# Get input from the user
# num = int(input("Enter a number: "))
num = int(input(""))

# Find the sum of digits using recursion
sum_of_digits_result = sum_of_digits(num)

# Print the result
print(sum_of_digits_result)



# 05 Program to check leap year

# function to check leap year
def is_leap_year(year):
  if (year % 4 == 0 and year % 100 != 0) or (year % 400 == 0):
    return True
  else:
    return False

# Get input from the user
year = int(input("Enter a year: "))

# Check if the year is a leap year
if is_leap_year(year):
  print(year, "is a leap year.")
else:
  print(year, "is not a leap year.")