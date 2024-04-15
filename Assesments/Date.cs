using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    class Date
    {
        private string day, month;
        private double year;

        public Date()
        {
            day = "Monday";
            month = "April";
            year = 2024;
        }

        public Date(string day, string month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public string Display()
        {
            return $"Day = {day}, Month = {month}, Year = {year}";
        }
    }
}
