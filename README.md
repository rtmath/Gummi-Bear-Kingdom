# Gummi Bear Kingdom

## by [Ryan Mathisen](https://github.com/rtmath) 2/10/2017

# Description

_This a mock-website for a fictional company named Gummi Bear Kingdom, featuring full database Create, Read, Update and Delete functionality for the user. There is a main products page listing out each product that Gummi Bear Kingdom offers, along with a details page for each product. The design of this project was based (loosely) on http://quincandy.com/ ._

## Requirements
  * Visual Studio
  * .Net Core
  * SQL Server Management Studio

## Installation
  * Clone this repo to your computer
  * In SSMS, connect to (localdb)\MSSQLLocalDB
  * Open this solution in Visual Studio and Build (Ctrl + Shift + B by default)
  * Navigate to where you cloned this repo with Powershell and run the following commands:
    * dotnet ef migrations add Initial
    * dotnet ef database update
  * In Visual Studio, hit F5 to launch the project
  * Enjoy!

## License
Copyright (c) 2017 [Ryan Mathisen](https://github.com/rtmath)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
