using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        List<LibraryLoan> libraryLoans = new List<LibraryLoan>();

        public void addToStock(Article item) {
            this.libraryLoans.Add(item);
        }

        public void addToStock(Book item) {
            this.libraryLoans.Add(item);
        }

        public void addToStock(Newspaper item) {
            this.libraryLoans.Add(item);
        }

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string checkInLoan(string title) {

            List<LibraryLoan> filtered = (List<LibraryLoan>)this.libraryLoans.Where(article => article.getTitle().Equals(title));

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutLoan(string title) {
            List<LibraryLoan> filtered = (List<LibraryLoan>)this.libraryLoans.Where(article => article.getTitle().Equals(title));

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
    }
}
