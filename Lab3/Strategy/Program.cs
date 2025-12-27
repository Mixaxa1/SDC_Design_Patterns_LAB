using Strategy;

var asc = new AscendingSortStrategy();
var desc = new DescendingSortStrategy();
var divine = new DivineSortStrategy();

var someNumbers = new List<int>
{
    1, 56, 3, 22, 11, 55, 55, 72, 95, 2
};

var sorter = new Sorter(asc);
sorter.Sort(someNumbers);

sorter.SetStrategy(desc);
sorter.Sort(someNumbers);

sorter.SetStrategy(divine);
sorter.Sort(someNumbers);