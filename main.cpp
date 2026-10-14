/*task1:
#include <iostream>
using namespace std;
int main() {
    for (int i = 1; i <= 30; i++) {

        if (i % 7 == 0) {
            cout << i << " -> Lucky" << endl;
        }
        else if (i % 3 == 0 && i % 5 == 0) {
            cout << i << " -> FizzBuzz" << endl;
        }
        else if (i % 3 == 0) {
            cout << i << " -> Fizz" << endl;
        }
        else if (i % 5 == 0) {
            cout << i << " -> Buzz" << endl;
        }
        else {
            cout << i << " -> " << i << endl;
        }

    }

    return 0;
}
*/
//task2
/*
#include <iostream>
using namespace std;
int main() {
    string sentence = "   The Quick Brown Fox Jumps Over The Lazy Dog   ";

    string s = sentence;
    s = s.substr(s.find_first_not_of(' '), s.find_last_not_of(' ') - s.find_first_not_of(' ') + 1);
    cout << "Trimmed: " << s << endl;
    
    cout << "Character count: " << s.length() << endl;
    string lower = s;
    for (int i = 0; i < lower.length(); i++) {
        lower[i] = tolower(lower[i]);
    }
    cout << "Lowercase: " << lower << endl;

    int count = 0;
    for (int i = 0; i < s.length(); i++) {
        if (tolower(s[i]) == 'o') {
            count++;
        }
         
    }
    cout << "Count of o: " << count << endl;

   
    string replaced = s;
    for (int i = 0; i < replaced.length(); i++) {
        if (replaced[i] == ' ') {
            replaced[i] = '_';
        }
    }
    cout << "Replaced: " << replaced << endl;

    return 0;
}

*/
/*task3
#include<iostream>
using namespace std;
int main(){
    int scores[5];
     int sum = 0;
   for (int i = 0; i < 5; i++) {
        cout << "Enter score " << i + 1 << ": ";
        cin >> scores[i];

        while (scores[i] < 0 || scores[i] > 100) {
            cout << "Invalid score! Enter again: ";
            cin >> scores[i];
        }

        sum += scores[i];
    }
    int highest, lowest;
    highest = scores[0];
    lowest = scores[0];
    
    for (int i = 0; i < 5; i++) {
        if (scores[i] > highest)
            highest = scores[i];

        if (scores[i] < lowest)
            lowest = scores[i];
    }

    double average = sum / 5.0;
    cout << "\nScores: "<<endl;
    cout << "Average: " << average<<endl;
    cout << "Highest: " << highest<<endl;
    cout << "Lowest: " << lowest<<endl;
   char grade;
    if (average >= 90)
        grade = 'A';
    else if (average >= 80)
        grade = 'B';
    else if (average >= 70)
        grade = 'C';
    else if (average >= 60)
        grade = 'D';
    else
        grade = 'F';

    cout << "\nGrade: " << grade;

    if (average >= 90)
        cout << " Excellent";
    else if (average >= 80)
        cout << " Very Good";
    else if (average >= 70)
        cout << " Above Average";
    else if (average >= 60)
        cout << " Pass"<<endl;
    else
        cout << " Fail"<<endl;

    if (average >= 60)
        cout << "Status: PASS"<<endl;
    else
        cout << "Status: FAIL"<<endl;

    return 0;

}
*/
/*task4
#include <iostream>
using namespace std;
int main() {
    int n;
    cout << "Enter an integer: ";
    cin >> n;
    if (n > 0)
        cout << "Positive: Yes" << endl;
    else if (n < 0)
        cout << "Negative: Yes" << endl;
    else
        cout << "Zero: Yes" << endl;
    if (n % 2 == 0)
        cout << "Even/Odd: Even" << endl;
    else
        cout << "Even/Odd: Odd" << endl;
    bool prime = true;

    if (n <= 1)
        prime = false;

    for (int i = 2; i < n; i++) {
        if (n % i == 0) {
            prime = false;;
            break;
        }
    }

    if (prime)
        cout << "Prime? Yes" << endl;
    else
        cout << "Prime? No" << endl;    
    bool square = false;
      int x = n;
    if (x < 0)
        x = -x;  
    for (int i = 0; i <= x; i++) {
        if (i * i == x) {
            square = true;
            break;
        }
    }

    if (square)
        cout << "Perfect Square? Yes" << endl;
    else
        cout << "Perfect Square? No" << endl;
    int temp = x;
    int sum = 0;

    while (temp > 0) {
        sum = sum + temp % 10;
        temp = temp / 10;
    }

    cout << "Digit Sum: " << sum << endl;
    int reversed = 0;
    int temp2 = x;
    while (temp2 > 0) {
        int digit = temp2 % 10;
        reversed = reversed * 10 + digit;
        temp2 = temp2 / 10;
    }

    if (n < 0)
        reversed = -reversed;

    cout << "Reversed: " << reversed << endl;

    return 0;
}
*/

/*task5
#include <iostream>
#include <iomanip>
using namespace std;

int main() {
    string products[5] = {
        "Keyboard", "Mouse", "Monitor", "USB Hub", "Webcam"
    };

    double prices[5] = {350, 180, 2200, 120, 650};
    int quantity[5] = {0, 0, 0, 0, 0};

    int id, q;
    double subtotal = 0, discount = 0, total;

    cout << "===== Product Catalog =====" << endl;

    for (int i = 0; i < 5; i++) {
        cout << i + 1 << ". " << products[i]
             << " - " << prices[i] << endl;
    }

    cout << "Enter 0 to finish shopping." << endl;

    while (true) {
        cout << "Enter product ID: ";
        cin >> id;

        if (id == 0)
            break;

        if (id < 1 || id > 5) {
            cout << "Invalid ID!" << endl;
            continue;
        }

        cout << "Enter quantity: ";
        cin >> q;

        if (q <= 0) {
            cout << "Invalid quantity!" << endl;
            continue;
        }

        quantity[id - 1] += q;
    }

    for (int i = 0; i < 5; i++) {
        subtotal += quantity[i] * prices[i];
    }

    if (subtotal >= 3000)
        discount = subtotal * 0.15;
    else if (subtotal >= 1000)
        discount = subtotal * 0.10;
    else if (subtotal >= 500)
        discount = subtotal * 0.05;

    total = subtotal - discount;

    cout << fixed << setprecision(2);
    cout << "\n======= RECEIPT =======" << endl;

    for (int i = 0; i < 5; i++) {
        if (quantity[i] > 0) {
            cout << products[i]
                 << " x" << quantity[i]
                 << " = " << quantity[i] * prices[i]
                 << endl;
        }
    }

    cout << "------------------------" << endl;
    cout << "Subtotal: " << subtotal << endl;
    cout << "Discount: -" << discount << endl;
    cout << "Total: " << total << endl;

    return 0;
}

*/

