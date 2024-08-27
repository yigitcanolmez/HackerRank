
List<int> arr = new();


var distinctArr = arr.Distinct().Order();

Dictionary<int, int> dic = new();

foreach (var item in distinctArr)
{
    var countArr = arr.Where(x => x == item).Count();

    dic.Add(item, countArr);
}

int maxType = dic.First().Key;
int maxTypeNumber = dic.First().Value;

foreach (var item in dic)
{
    if (item.Value > maxTypeNumber)
    {
        maxType = item.Key;
        maxTypeNumber = item.Value;
    }
}

return maxType;
        
