def get_integer_input(catch_phrase):
    while True:
        try:
            value = int(input(f"{catch_phrase}: ").lower())
            return value
        except ValueError:
            print("Please Input A Valid Integer!")

def decide_net_bonus():
    year_of_service = get_integer_input("Year Of Service: ")
    monthly_salary = get_integer_input("Monthly Salary: ")

    if year_of_service > 5:
        net_bonus = (monthly_salary * 12) * 5 / 100
    else:
        net_bonus = 0

    print(net_bonus)


def check_eligibility_to_vote():
    age = get_integer_input("Your Age:")
    if age > 17:
        print("You can vote!")
    else:
        print("You cannot vote!")    

def odd_or_even():
    number = get_integer_input("Enter A Number")
    if number % 2 == 0:
        print("Number is even!")
    else:
        print("Number is odd!")

def divisible_by_7():
    number = get_integer_input("Enter A Number")
    if number % 7 == 0:
        print("Number is divisible by 7!")
    else:
        print("Number is not divisible by 7!")

def hello_or_bye():
    number = get_integer_input("Enter A Number")
    if number % 5 == 0:
        print("Hello!")
    else:
        print("Bye!")

def last_digit():
    number = str(get_integer_input("Enter A Number"))
    last_digit = number[-1]
    print(last_digit)

def last_digit_divisible_by_3():
    number = str(get_integer_input("Enter A Number"))
    last_digit = int(number[-1])
    if last_digit % 3 == 0:
        print("Last digit is divisible by 3!")
    else:
        print("Last digit is not divisible by 3!")

def square_or_rectange():
    breadth = get_integer_input("Enter Shape's Breadth")
    length = get_integer_input("Enter Shape's Length")
    if breadth == length:
        print("Its a square!")
    else:
        print("Its a rectangle!")

def greater_value():
    number_a = get_integer_input("Enter Number A")
    number_b = get_integer_input("Enter Number B")
    if number_a == number_b:
        print(f"{number_a} is equal to {number_b}")
    elif number_a > number_b:
        print(f"{number_a} is greater than {number_b}")
    else:
        print(f"{number_b} is greater than {number_a}")

def discount():
    quantity = get_integer_input("Enter Item Quantity")
    if quantity > 1000:
        discount = quantity * 10
        print(discount)

def school_grading_system():
    marks = get_integer_input("Enter Your Marks")
    grading = {80: "A", 59: "B", 49: "C", 44: "D", 24: "E", 0: "F"}
    grade_values = grading.keys()
    for grade_value in grade_values:
        if marks > grade_value:
            grade = grading[grade_value]
            print(grade)
            break

def allowed_to_sit_in_exam():
    classes_held = get_integer_input("Classes Held")
    classes_attended = get_integer_input("Classes Attended")
    attendance_percentage = classes_attended / classes_held * 100
    print(attendance_percentage)
    any_medical_cause = input("Any Medical/Health Cause? ").lower()
    if attendance_percentage > 75 or "y" in any_medical_cause:
        print("Student Can Sit In Exam")
    else:
        print("Student Cannot Sit In Exam")

def leap_year():
    year = get_integer_input("Enter A Year")
    if year % 100 == 0:
        if year % 400 == 0:
            print("A Leap Year")
        else:
            print("Not A Leap Year")
    else:
        if year % 4 == 0:
            print("A Leap Year")
        else:
            print("Not A Leap Year")

def employee_work_areas():
    age = get_integer_input("Enter Your Age")
    gender = input("Enter Your Gender (Male Or Female)").lower()
    if "f" in gender:
        gender = "female"
    else:
        gender = "male"
    marital_status = input("Enter Your Marital Status (Yes Or No)").lower()
    if "y" in marital_status:
        marital_status = "Married"
    else:
        marital_status = "Not Married"
    
    if age < 20 or age > 60:
        print("Error")
    elif gender == "female":
        print("Work In Urban Areas")
    elif age > 20 and age < 40:
        print("Work Wherever")
    else:
        print("Work In Urban Areas")

def electric_bill():
    units = get_integer_input("Enter Electric Units Consumed")
    bill = 0
    if units > 100 and units < 301: 
        bill = (units - 100) * 5
    elif units > 300:
        units = units - 300
        bill = 200 * 5
        bill = units * 10 + bill
    print(bill)

def age_ranking():
    age_a = get_integer_input("Enter Age A")
    age_b = get_integer_input("Enter Age B")
    age_c = get_integer_input("Enter Age C")
    ages = [age_a, age_b, age_c].sort(reverse=True)
    print(f"Person Aged {ages[0]} Is Eldest; Person Aged {ages[1]} Is In Middle; Person Aged {ages[2]} Is Youngest")
