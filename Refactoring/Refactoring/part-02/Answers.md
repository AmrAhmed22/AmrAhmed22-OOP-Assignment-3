# Part 02 — answers

---

## Reports

- What was the problem?

repeating the same implementation in each class, nothing connect them.

- What did you change?

making abstract class that combine the implementation in one place and everyclass inherit from it.
only Format is abstract Each exporter has only its own Format


- Why did you choose that approach?

The classes share real funcs implementation (Load, Validate, Save). in abstract class we implements that once.
With interface, each class will need to repeat the implementation again, which is the duplication we are removing.

---

## Enrollment

- What was the problem?
Main do too much work. Its create four different objects and know the exact order to call their methods.


- What did you change?
Make one class gathered all the flow in one place and inforce the order, the main should not know this internal info 

 
- Why did you choose that approach?
it hides the complexity , the order of the flow .
the Main func no longer needs to know about the internal services,or how they work, or the order of them.

