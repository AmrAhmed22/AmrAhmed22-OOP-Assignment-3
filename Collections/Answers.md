Task 2.1 

IReadOnlyDictionary :
IReadOnlyDictionary<TKey, TValue>, it is interface that provides a read only access to a dictionary. you can't do methods like add or remove exactly like IReadOnlyList. we can use it as public attribute that return from a class to protect the internal data of the main private object.

SortedDictionary :
SortedDictionary automatically sorted its elements by the key, it's implemented as a binary search tree.
the standard Dictionary uses a hash table and does not have any specific order for keys. 

Because of this structure, SortedDictionary has a slower lookup, insertion, and deletion time complexity of O(log N) (log N duo to the binary search), compared to the Dictionary O(1) time complexity.

we can use SortedDictionary when we need to retrieve or print the items in a specific sorted order.



Task 2.2

S1 => Dictionary
the key is nationalid,and search is O(1) complexity.

S2 => HashSet
Saved one value and it's unique.


S3 => List
keep the order as entered and accept duplicates


S4 => IReadOnlyDictionary
can Read only no add or change on it

S5 => SortedDictionary
the key is start time and it want always to be sorted

S6 => IEnumerable
may return early ,using yield here 