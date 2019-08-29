using System;
using System.Collections.Generic;
using System.Text;

namespace FriendClassProject {
    class Friend {

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get;  set; }
        public bool BFF { get; set; } = false;
        public int YearsKnown { get; set; }

        // default constructor
        public Friend () {
        }

        // constructors are only called when a new instance is created, with "new" keyword
        // Constructors never return values, they're not allowed to
        public Friend(string name, string phone, string email, int years) {
            this.Name = name;   // this.Name is a "property".  name is a temporary parameter.
            this.Phone = phone;
            this.Email = email;
            this.YearsKnown = years;
        }
        public override string ToString() {
            return $"{Name,-15} {Phone,-12} {Email,-25} {(BFF ? "BFF" : ""),3} {YearsKnown}";  /*system figures out datatype of the 2 args in the ternary stmt*/
        }

        // Eexists a ToString class.  And we can override it
        //interpolated strings:  The negative integers define the width you' like it to tak eup.  The negative:  Left-justified. Name gets 15 spaces allotted.   It is L.-justified
        // ternary operator:  bool-cond ? x : y
        // ternary:    var a = (b > 0) ? c : d;     Remember, = is an ASSIGNMENT operator . R.H. side is to be evaluated
        // ternary.   Note, since var is interpolated, c and d could ACTUALLY by diff. datatypes! (side-bar, wouldn't be used that often)
        // NEED TO PRACTICE THIS SYNTAX
        // ternary is great for when you want to set a PROPERTY to one of two values, depending on something


        // --side-bar--  Console.WriteLine ALWAYS calls ToString method before it prints.  To print int 5, it calls 5.ToString(), or something like that


        public void SetName(string name) {
            Name = name;
        }
        public void SetPhone(string phone) {
            Phone = phone;
        }
        public void SetEmail(string email) {
            Email = email;
        }
        public void SetBFF(bool bff) {
            BFF = bff;
        }
        public void SetYearsKnown(int years) {
            YearsKnown = years;
        }





    }
}
