# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?
Calculate func used switch case on a magic string, it violates Open Closed principle.
if you want to add another carieer you must open and change it which is bad design.


- What did you change?

(Applied Strategy pattern)

make interface that has calculate func inside it 
each carieer has its class implements the interface 
calculator receives reference of interface in the constructor


made a New carrier in new file.
No existing class was edited.

---

## OrderProcessor

- What was the problem?
create 2 objects with new inside an object! tightly coupled



- What did you change?

DIP

use interfaces and inject the real values at runtime, loose coupling

---

## Notifications

- What was the problem?
so many inheritance (is a) in the file, it makes inheritance for every possible combination this also violates Open/Closed

- What did you change?
use composition over inheritance (has a) as interface , and make the class take the interface and a variable isUrgent & SendAt




---

## Proof

- New carrier file(s): BostaCarrier & Interface
- New notification channel file(s):: WhatsAppChannel & Interface
- Existing classes left unchanged? (yes/no): yes 
