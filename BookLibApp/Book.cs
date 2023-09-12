using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibApp
{
    public class Book
    {
        const int _minYear = 1100;
        const int _maxYear = 2015;
        const int _minTitleLength = 2;

        //Instance fields
        string _title;
        int _year;

        //Properties
        public static int MinYear => _minYear;
        public static int MaxYear => _maxYear;
        public static int MinTitleLength => _minTitleLength;
        public string Title
        {
            get { return _title; }
            set
            {
                if (value.Length >= MinTitleLength) 
                {
                    _title = value;
                }
                else
                {
                    throw new Exception();
                }
                
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if (value >= MinYear && value <= MaxYear)
                {
                    _year = value;
                }
                else
                {
                    
                }
            }
        }

        //Constuctors
        public Book()
        {
            Title = "<no title>";
            Year = MinYear;
        }

        public Book(string title, int year)
        {
            Title = title;
            Year = year;
        }

    }
}
