Variance exercises
==================

Variance is a concept found in C# and a bunch of other programming languages - it's a bit of a niche concept, but
worth understanding so that it doesn't bite you completely out of the blue.

It's commonly encountered in the realm of generic types, like IEnumerable<T>, Func<T>, Action<T>, IList<T>. You 
may not have noticed, but these types often have the "in" and "out" modifiers applied to the type parameters.
(Don't confuse this use of "out" with "out" method parameters - the meaning here is related, but different)

IEnumerable<out T>           <-- where "out" indicates that IEnumerable is covariant for the type "T"
Action<in T>                 <-- where "in" indicates that Action is contravariant for "T"
IList<T>                     <-- neither "in" nor "out" modifier is present - so IList is invariant for "T"
Func<in T1, in T2, out T3>   <-- contravariant for T1 & T2 (input types), covariant for T3 (return type)

Probably none of this will make sense right now - but work through exercises 1 -> 4, and see if you can figure the rules out.

Note: the exercises are not intended to compile into useful code. They're purely to illustrate how the compiler applies
the rules of variance when deciding which method calls will compile, and which will fail to compile. The challenge for you
is to understand why - but once you get your head around that, the variance rules (mostly) make perfect sense!

Once you've looked at the exercises, try running the program code to see how the (occasionally arbitrary) rules of 
variance can bite you in the real world.