#define EXPORT_API _declspec(dllexport)

#include <iostream>

extern "C"
{


    //The functions we will call from Unity.
    int EXPORT_API PrintANumber() {
        return 5;
    }

    int EXPORT_API AddTwoIntegers(int a, int b) {
        return a + b;
    }

    float EXPORT_API AddTwoFloats(float a, float b) {
        return a + b;
    }
}


int main()
{
    std::cout << AddTwoFloats(2.5, 5.5);

   
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
