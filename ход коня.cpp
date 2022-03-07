

#include <iostream>
#include <stdio.h>

#define DS 8
using namespace std;
int desk[DS][DS];
int step[8][2] = { {1,-2}, {2,-1}, {2,1}, {1,2}, {-1,2}, {-2,1}, {-2,-1}, {-1,-2} };
int n;

bool set_horse(int x, int y)
{
	if ((x < 0) || (x >= DS) || (y < 0) || (y >= DS))
		return false;

	if (desk[x][y] != 0)
		return false;

	n++;
	desk[x][y] = n;

	if (n == DS * DS)
		return true;

	for (int i = 0; i < 8; i++)
		if (set_horse(x + step[i][0], y + step[i][1]))
			return true;
	n--;
	desk[x][y] = 0;

	return false;
}

int main()
{
	n = 0;
	for (int i = 0; i < DS; i++)
		for (int j = 0; j < DS; j++)
			desk[i][j] = 0;
	set_horse(0, 0);
	for (int i = 0; i < DS; i++)
	{
		for (int j = 0; j < DS; j++)
			printf(" %2d", desk[i][j]);
		printf("\n");
	}
	system("pause");
} 