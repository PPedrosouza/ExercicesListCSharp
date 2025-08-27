# 📚 C# Exercises List

This repository contains a collection of practical exercises in C# (.NET 8) focused on learning fundamental language concepts.

## 🎯 Implemented Exercises

### **1. Welcome Program** 
Create a program where the user needs to type a name and a personalized welcome message with their name is displayed: **`Hello, Welisson! You are very welcome!`**

*Note: notice that the method to read data that a user types was not covered in class.* How about starting with your first search? 🔍

💡 **The method to read data that a user types is** **`Console.ReadLine();`**

**📁 File:** `Exercice1.cs`
- ✅ User input reading
- ✅ Input validation
- ✅ String interpolation

---

### **2. Full Name Concatenation**
Create a program that concatenates a first name and last name entered by the user and displays the full name at the end.

**📁 File:** `Exercice2.cs`
- ✅ Multiple data input
- ✅ String concatenation
- ✅ Type validation

---

### **3. Mathematical Calculator** 
Create a program with 2 **`double`** type values already declared that returns:
- The sum between these two numbers;
- The subtraction between the two numbers;
- The multiplication between the two numbers;
- The division between the two numbers (worth checking if the second number is 0!);
- The average between the two numbers.

💡 **You can go beyond and allow the user to enter two random numbers!**

**📁 File:** `Execise3.cs`
- ✅ Basic mathematical operations
- ✅ Division by zero validation
- ✅ Static methods
- ✅ Type conversion

---

### **4. Character Counter**
Create a program where the user types one or more words and the number of characters that the entered word has is displayed.

**💡 Tip:** You can do a check and increment the counter only **if** it's a character, ignoring spaces if the user types more than one word.

**📁 File:** `Exercice4.cs`
- ✅ String manipulation
- ✅ Character counting
- ✅ Space handling

---

### **5. Vehicle License Plate Validator**
Create a program where the user needs to type a vehicle's license plate and the program verifies if the plate is valid, following the Brazilian standard valid until 2018:
- The plate must have 7 alphanumeric characters;
- The first three characters are letters (uppercase or lowercase);
- The last four characters are numbers;

At the end, the program should display ***True*** if the plate is valid and ***False*** otherwise.

**📁 File:** `Exercice5.cs`
- ✅ Pattern validation
- ✅ Character manipulation
- ✅ Conditional structures
- ✅ Use of lists and loops

---

### **6. Date Formatting**
Create a program that requests the user to display the current date in different formats:
- Complete format (day of the week, day of the month, month, year, hour, minutes, seconds);
- Only the date in "01/03/2024" format;
- Only the time in 24-hour format;
- The date with the month written out.

**📁 File:** `Exercice6.cs`
- ✅ Date formatting
- ✅ Use of `CultureInfo`
- ✅ Different output formats
- ✅ Working with `DateTime`

---

## 🚀 How to Run

1. **Clone the repository:**
```sh
git clone https://github.com/your-username/ExercicesListCSharp.git
```

2. **Open in Visual Studio 2022:**
   - File → Open → Project/Solution
   - Select the `.sln` file or project folder

3. **Run an exercise:**
   - Uncomment the `Main()` method of the desired exercise
   - Comment out other `Main()` methods to avoid conflicts
   - Press `F5` or `Ctrl+F5` to execute

## 🛠️ Technologies Used

- **C# 12.0**
- **.NET 8**
- **Visual Studio 2022**

## 📋 Concepts Covered

- ✅ Input and output (`Console.ReadLine()`, `Console.WriteLine()`)
- ✅ Data types (`string`, `double`, `char`, `bool`)
- ✅ Conditional structures (`if`, `else`)
- ✅ Loops (`while`, `for`)
- ✅ Data validation
- ✅ String manipulation
- ✅ Date formatting
- ✅ Static methods
- ✅ Collections (`List<T>`)
- ✅ Basic exception handling

## 🎓 Learning

This set of exercises is ideal for:
- 🔰 C# beginners
- 📚 Programming students
- 💡 Reviewing fundamental concepts
- 🎯 Programming logic practice

---

*Developed as part of C# and .NET studies* 💻✨
