using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace cau3
{
    public class Account : IAccount
    {
        public int AccountId {get; set;}
        public string Fristname {get; set;}
        public string Lastname {get; set;}
        public string Gender{ get; set; }
        public float Balance { get;}

        public void ShowInfo()
        {
            Console.WriteLine( $"Account ID: {AccountId}, First Name: {Fristname}, Last Name: {Lastname}, Gender: {Gender}, Balance: {Balance}");
        }

        public float PayInto(float Amount)
        {
            return Amount + Balance;
        }
    }
}