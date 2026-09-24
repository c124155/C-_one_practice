# C# Windows Forms Practice

## Overview

This practice demonstrates how to:

- Create initial string variables from form inputs
- Concatenate multiple string values
- Display the combined output in a Label control
- Clear form inputs and output fields
- Close the application form

---

## 1. Creating Initial Variables

In this step, four string variables are created to store student information retrieved from TextBox controls.

- `std_name` stores the student name.
- `std_id` stores the student ID.
- `std_dept` stores the department name.
- `std_semester` stores the semester information.

The following screenshot shows how the variables are declared and initialized in C#.

![Creating Variables](Screenshots/Creating_Variables.png)

## 2. Concatenating Variables

In this step, the student variables are combined into a single string using the `+` operator.

The combined result is stored in the `student` variable.

The following screenshot shows the string concatenation process.

![String Concatenation](Screenshots/String_Concatenation.png)

## 3. Displaying the Output

After combining the student details, the value stored in the `student` variable is assigned to the `.Text` property of a Label control (`lbloutput`).

The following screenshot shows how the output is displayed on the form.

![Display Output](Screenshots/Display_Output.png)

## 4. Clearing Inputs and Output

To reset the form, the `Clear()` method is called on each TextBox, and the Label control's `.Text` property is set to an empty string `""`.

The following screenshot shows how the form controls are cleared.

![Clearing Inputs and Output](Screenshots/Clearing_Inputs.png)

## 5. Closing the Form

To close the application or current window, the `this.Close()` method is executed.

The following screenshot shows the code used to close the form.

![Closing Form](Screenshots/Closing_Form.png)