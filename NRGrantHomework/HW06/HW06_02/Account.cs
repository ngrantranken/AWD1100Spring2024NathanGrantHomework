using System;
using System.Data;

namespace HW06_02
{
    public class Account
    {
        // Declare and initialize constant
        public decimal MINIMUMBALANCE = 25.00m;

        // Instance variables
        private readonly string _title;
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _accountNumber;
        private readonly string _pinNumber;
        private decimal _balance;

        //Full-Arg Constructor
        public Account(string title, string firstName, string lastName, string accountNumber, string pinNumber, decimal balance)
        {
            _title = title;
            _firstName = firstName;
            _lastName = lastName;    
            _accountNumber = accountNumber;
            _pinNumber = pinNumber;
            _balance = balance;
        }

        // Getters
        public string GetTitle() => _title;
        public string GetFirstName() => _firstName;
        public string GetLastName() => _lastName;
        public string GetAccountNumber() => _accountNumber;
        public string GetPinNumber() => _pinNumber;
        public decimal GetBalance() => _balance;

         public void MakeDeposit(decimal deposit)
        {
            decimal theDeposit = deposit;
            try
            {
                if (theDeposit <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _balance += deposit;
            }
            catch(ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show("System Message:\t" + aoore.Message + "Illegal Deposit. Must be greater than 0.", "ILLEGAL DEPOSIT ATTEMPTED");
                return;
            }
        }

        public void MakeWithdrawal(decimal withdrawal)
        {
            decimal theWithdrawal = withdrawal;
            decimal tempValue = -1;
            try
            {
                if (theWithdrawal <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                tempValue = _balance - theWithdrawal;
                if (tempValue >= MINIMUMBALANCE)
                {
                    _balance -= withdrawal;
                }
                else
                {
                    throw new DataException();
                }
            }
            catch(DataException de)
            {
                MessageBox.Show("System Message:\t" + de.Message + "Insufficient Funds For Withdrawal", "INSUFFICIENT FUNDS");
                return;
            }
            catch(ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show("System Message:\t" + aoore.Message + "Illegal Withdrawal. Must be greater than 0.", "ILLEGAL WITHDRAWAL ATTEMPTED");
                return;
            }
        }
    }
}
