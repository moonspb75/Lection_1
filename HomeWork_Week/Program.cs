// По введенному номеру дня недели вывести его название
System.Console.WriteLine();
string[] Days = {"Mon", "Tues", "Wed", "Thar", "Frid", "Sat", "Sun"};
System.Console.Write("Введите номер дня недели: ");
string writeDay = Console.ReadLine();
bool result = int.TryParse(writeDay, out int dayNanber);
System.Console.WriteLine();
if (result == false) System.Console.WriteLine("Число введено неверно");
else if (0 < dayNanber && dayNanber < 8) System.Console.WriteLine($"{dayNamber}-й день недели - {Days[dayNanber - 1]}");
else System.Console.WriteLine("Дня недели с таким номером не существует");
System.Console.WriteLine();