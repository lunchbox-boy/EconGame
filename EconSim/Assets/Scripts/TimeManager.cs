using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager 
{

    Date date = new Date(1,1,1);
}

public enum Month
{
    January, Febuary, March, April, May, June, July, Augest, September, October, November, December
}

public struct Date
{
    int year;
    int month;
    int day;

    public Date(int year, int month, int day)
    {
        this.year = year;
        this.month = month;
        this.day = day;
    }
}


