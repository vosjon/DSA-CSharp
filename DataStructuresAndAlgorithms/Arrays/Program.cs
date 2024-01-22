using static System.Console;

// Arrays
// Array Insertions and Deletions

// Inserting at the END of an Array

int[] intArray = new int[10];

// Make a variable to keep the length because .Length is based off capacity
// and does not track the actual index
int length = 0;

// This adds data for us
for (int i = 0; i < 8; i++)
{
    intArray[i] = i + 1;
    length++;
}

/*intArray[length] = 8;
length++;*/

// Inserting at the START of an Array

//for (int i = 3; i >= 0; i--)
//{
//    // This is moving over all the values:
//    intArray[i + 1] = intArray[i];
//}

//intArray[0] = 8;

// Inserting ANYWHERE in the Array

for (int i = 4; i >= 2; i--)
{
    // Shift each element one position to the right
    intArray[i + 1] = intArray[i];
}

intArray[2] = 8;

//foreach (int i in intArray)
//{
//    Write($"{i} ");
//}

// Array Deletions - Part 2 of the Array Lessons
int[] intArray2 = new int[9];

int length2 = 0;

for (int i = 0; i < 6; i++)
{
    intArray2[length2] = i;
    length2++;
}

for (int i = 2; i < length2; i++)
{
    intArray2[i - 1] = intArray2[i];
}

length2--;

// Deleting from the start
//for (int i = 1; i < length2; i++)
//{
//    intArray2[i - 1] = intArray2[i];
//}

// Deleting from the end
for (int i = 0; i < length2; i++)
{
    Write($"{intArray2[i]} ");
}