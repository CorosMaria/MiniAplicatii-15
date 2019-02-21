// Zile.cpp : main project file.

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{	int n;
	string zile[7]={"luni", "marti", "miercuri", "joi", "vineri", "sambata", "duminica"};
	cout<<"Programul cere numarul zilei din saptamana (0-7) si afiseaza numele acesteia:";
	cin>>n;
	if(n>0 && n<8)
	{
		cout<<"Ati ales:"<<zile[n-1];//Tabloul numara de la 0
	}
	cin.ignore();
	cin.get();
    return 0;
}
