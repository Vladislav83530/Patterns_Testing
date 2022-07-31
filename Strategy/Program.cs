using Strategy;

var sort = new SelectionSort();
var context = new Context(sort);

context.Sort();
context.PrintArray();
