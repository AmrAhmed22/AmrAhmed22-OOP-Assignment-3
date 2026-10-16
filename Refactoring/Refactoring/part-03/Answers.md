# Part 03 — answers

---

## BlockedUsers

- Time complexity before: O(NxM)
- Time (ms) before: 22 ms 

- What did you change?
 change list to Hashset, because .contains() in list takes O(N) linear search for every element but hashset take only O(1) searching.

- Time complexity after: O(N) // the requestids only
- Time (ms) after: 0 ms 

---

## Students

- What was the problem?
2 problems 
creating list of 1_000_000 elements in memory , and everytime the list resized when its full , it better to assign 1_000_000 as size of it while initialize
but this is not the main problem

the main problem it loops a million times even if you want 3 objects only! every object else is uneseful


- What did you change?

use yield return that return it one by one when you want it, so no million objects create unless you really want them!