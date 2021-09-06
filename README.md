# Turn Letters Into Numbers

Here is one of the many forms to convert a letter to the number of the position that corresponds to the alphabet

## Table of Contents

- [Project](#project)
- [Overview](#overview)
- [Unit Testing](#unit_testing)

## Project <a name = "project"></a>

- It consists of a Program class with the main method that will take the input, and in the Utils folder, there is a StringToInt class that will convert the letters and creates the output string.
- The variable with the name "numGap" is a reference to the gap between A to Z in the ASCII code and with that is possible to search the position of a letter.

## Overview <a name = "overview"></a>

- After the input string is sent, the code will loop with a 'for loop' till the end of the length of the input string.
- An If statement inside the loop will determine if the content in the position of the string is a letter and add its position to the string builder.
- In case that the value in the position it's not a letter, it will only add it to the string builder.

## Test <a name = "unit_testing"></a>

- A NUnit Test project was created, to evaluate possible outcomes.
- Three tests were created to compare the result of the method with the expected output.

## **Test Status:**
<div align="center">

[![Status](https://img.shields.io/badge/status-active-success.svg)]()
  
</div>
