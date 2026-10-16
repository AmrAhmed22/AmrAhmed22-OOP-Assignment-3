Step 2 :
what is the same between the two stores, and what is different?

the methods and logic are the same , the different is just the type and the attributes of the type.


step 3 :

CS1061: 'T' does not contain a definition for 'ID' and no accessible extension method 'ID' accepting a first argument of type 'T' could be found (are you missing a using directive or an assembly reference?)

we use a T type, so i can't access attributes in it like ID because it's anonymous,it have no fields.

step 7 :
 Leave new Store<string>() as a commented-out line marked “must NOT compile”, and explain why ?

 it will not compile because the Store<T> has constraint (where T:IHasID) and string not implemented that.


 Last question:
what is the common name for the kind of class you built in Steps 4 and 5?

Generic Repository, repository that works for any entity type with an Id, using a generic type constraint.


