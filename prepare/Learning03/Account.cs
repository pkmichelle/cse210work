using System;

// public class Account
// {
//     public int _balance = 0;
//     public void Deposit(int amount)
//     {
//         _balance = _balance + amount;
//     }
// }

// If we change it to a list instead
public class Account
{
    private List<int> _transactions = new List<int>();
    public void Deposit(int amount)
    {
        _transactions.Add(amount);
    }

    public void GetBalance()
    {}
}