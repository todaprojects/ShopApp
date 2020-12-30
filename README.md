# Shop App
A .NET console application, written in C#.

### Task v1.0 (lesson2)

#### Create shop that sells Candies, Books, Cups.

  - Items have names, quantities;
  - App must keep running, while `exit` is not typed in;
  - Create User class, that holds money balance; 
  - Use OOP, with min 2 classes.

### Task v1.1 (lesson5)

Update 'The shop' application done in lesson2 with the concepts explained in:
  - Apply Services principle and separate console printing and shop operations into separate services.
  - In Services constructor there should be no 'new' word, interfaces of services should be used,
   and they should be create(injected) in main method.

Extra: Add extra service which reads input from a file (like 'list', 'buy', etc) and prints output into separate.
This should be exchangeable with ConsolePrinter (use the same interface).
    
### Usage

#### Configuration

A `Congfig.cs` file contains:

  - value of field `bool IsDefaultConsole` defines the way of the input and output:
    - if value is `true` - all input/output is on Console;
    - if value is `false` - all input/output is from/to files.
   
  - `InputFilePath` and `OutputFilePath` default values can be changed to match a relative path to files.

#### Available commands in the console / text file:

  - `List` - display all available items;
  - `Buy Candy 20` - buy wanted quantity of the item;
  - `Add Cup 30` - increase quantity of sellable item;
  - `Show Balance` - display your current balance;
  - `Topup 30` - add money to your balance.
