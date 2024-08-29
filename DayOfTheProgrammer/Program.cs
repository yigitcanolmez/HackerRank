using System.Globalization;

var monthsDayCountWithLeap = 244;
var monthsDayCountWithOutLeap = 243;
var year = 2100;

string response = string.Empty;
int dayOfTheSeptember = 0;

if (year > 1918)
{

    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
    {
        dayOfTheSeptember = 256 - monthsDayCountWithLeap;
        response = SetDateResponse(dayOfTheSeptember);
    }
    else
    {
        dayOfTheSeptember = 256 - monthsDayCountWithOutLeap;
        response = SetDateResponse(dayOfTheSeptember);
    }

}
else if (year > 0 && year < 1918)
{
    if (year % 4 == 0)
    {
        dayOfTheSeptember = 256 - monthsDayCountWithLeap;
        response = SetDateResponse(dayOfTheSeptember);
    }
    else
    {
        dayOfTheSeptember = 256 - monthsDayCountWithOutLeap;
        response = SetDateResponse(dayOfTheSeptember);
    }
}
else if (year == 1918)
{
    dayOfTheSeptember = 256 - monthsDayCountWithOutLeap;
    response = SetDateResponse(dayOfTheSeptember, true);
}

string SetDateResponse(int dayOfTheSeptember, bool _1918 = false)
{
    if (_1918)
        response = new DateTime(year, 9, dayOfTheSeptember, new JulianCalendar()).ToString("dd.MM.yyyy");
    else
        response = new DateTime(year, 9, dayOfTheSeptember).ToString("dd.MM.yyyy");

    return response;
}