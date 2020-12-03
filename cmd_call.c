#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(int argc, char*argv[])
{
    if(argc != 2)
    {
        printf("Format is not correct!\n");
    }
    char str[] = "certutil -hashfile ";
    system(strncat(str, argv[1], 256));
    return 0;
}