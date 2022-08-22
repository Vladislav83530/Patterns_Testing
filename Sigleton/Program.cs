using Sigleton;

//Computer comp = new Computer();
//comp.Launch("Windows 8.1");
//Console.WriteLine(comp.OS.Name);

//comp.OS = OS.GetInstance("Windows 11");
//Console.WriteLine(comp.OS.Name);

(new Thread(() =>
{
    Computer comp2 = new Computer();
    comp2.OS = OS.GetInstance("Windows 11");
    Console.WriteLine(comp2.OS.Name);
})).Start();

Computer comp = new Computer();
comp.Launch("Windows 8.1");
Console.WriteLine(comp.OS.Name);
