﻿
double distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int i =0;
double time = 0;


while (distance > 10)
{
    if (friend == 1) {
        time = distance/(firstFriendSpeed+dogSpeed);
        friend = 2;
    } else {
        time = distance/(secondFriendSpeed+dogSpeed);
        friend = 1;
    }
distance = distance - (firstFriendSpeed + secondFriendSpeed)*time;
i++;
}

Console.WriteLine (i);