using System;
using EXERCISE_01___HERITAGE.Entities;
namespace EXERCISE_01___HERITAGE {
    //-----> START
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
            Console.WriteLine(account.Balance);
            //account.Balance = 1500; ---- > Não permite pq esta protejido, por protected.
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}
