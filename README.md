# Create Memory Leak in .NET
This repository is to show a simple way to create memory leak in .NET.
So, the steps are:
1. Declare a list of strings.
2. Create a perpetual while condition, and add GUID to the list.

Since the list will always be used, the garbage collector will find nothing to free.
