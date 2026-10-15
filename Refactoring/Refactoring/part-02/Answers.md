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
- What did you change?
- Why did you choose that approach?
