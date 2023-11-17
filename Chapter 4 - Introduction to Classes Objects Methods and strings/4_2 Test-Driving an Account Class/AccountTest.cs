using System;

class AccountTest{
    static void Main(){
        Account account1 = new Account();
        Console.WriteLine($"Initial name is: {myAccount.GetName()}");
        
        Console.Write("Enter the name: ");
        string theName = Console.ReadLine(); 
        myAccount.SetName(theName);
        
        Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");
    }
}