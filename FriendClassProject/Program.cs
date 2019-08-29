using System;

namespace FriendClassProject {
    class Program {
        static void Main(string[] args) {

            Friend Susan = new Friend("Susan", "111-1111","sm@gmail.com", 30);
            Friend Jono = new Friend("Jono", "222-2929", "jl@gmail.com", 25);
            Friend Leslie = new Friend("Leslie", "334-9090", "lg@gmail.com", 9);
            Friend FJ = new Friend("FJ", "999-9898", "FJ@gmail.com", 40);
            Friend Bill = new Friend("Bill", "878-8787", "bw@gmail.com", 31);

            Susan.BFF = true;

            var buddies = new Friend[] { Susan, Jono, Leslie, FJ, Bill };
            foreach (var bud in buddies) {
                bud.YearsKnown = bud.BFF ? 10 : 0; 
                Console.WriteLine(bud);   // nicer display.  Calls ToString() method
                //Console.WriteLine($"{bud.Name} {bud.Phone} {bud.Email} {bud.BFF} {bud.YearsKnown}");  // long version
            }



        }
    }
}
