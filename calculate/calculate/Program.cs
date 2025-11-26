
int main()
{
    int x = 8;
    int y = 9;
    int z = x++ + ++y;

    printf("x = %d\n", x); // 9
    printf("y = %d\n", y); // 10
    printf("z = %d\n", z); // 18

    return 0;
}
