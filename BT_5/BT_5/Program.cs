using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_5
{
     class Program
    {
        static void Main(string[] args)
        {
            //xuất thông tin 3 tài khoản ra màn hình
            Account act1 = new Account(72354,"Ted Murphy", 102.56);
            Account act2 = new Account(69713,"Jane Smith", 40.00);
            Account act3 = new Account(93757,"Edward Demsey", 102.56);
            act1.toString();
            act2.toString();
            act3.toString();

            //Deposit 25.85 cho tài khoản 1
            act1.deposit(25.85);
            act1.toString();

            //Deposit 500 cho tài khoản 2
            act2.deposit(500);
            act2.toString();

            //Tài khoản 2 withdraw 430.75 vs phí là 1.50
            act2.withdraw(430.75, 1.50);
            act2.ToString();

            //Tính phí của tài khoản 3
            act3.addInterest();
            
            //Tài khoản 2 chuyển TK 1 100 và tin thông tin 2 tk sau khi chuyển
            act2.transfer(ref act1, 100.00);
            act1.toString();
            act2.toString();
        }
    }
}
