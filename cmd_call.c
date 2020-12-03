#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(int argc, char*argv[])
{
    if(argc != 3)
    {
        printf("Format is not correct!\n");
    }
    char str[] = "certutil -hashfile ";
    char shift[] = " ";
    char* arg = strcat(argv[1], shift);
    char* Arg = strcat(arg, argv[2]);
    system(strcat(str, Arg));
    return 0;
}