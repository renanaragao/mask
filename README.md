# Mask
Extension method for making string masks in CSharp.

### How to install with Nuget ?
```
dotnet add package Mask
```

### How do I use it? ###

```.cs
"11985644568".ToMasked("(AA) AAAAA-AAAA")
```
 
#### Examples of allowed masks

| mask            | example        |
| --------------  | -------------- |
| (AA) AAAAA-AAAA | (11 98564-4568 |
| 0000.00         | 2017.22        |
| 999.999.999-99  | 048.457.987-98 |
| SSSS            | 2014           |
