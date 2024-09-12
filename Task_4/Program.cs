var storage1 = new Storage.Storage<int>();
storage1.SetItem(17);
Console.WriteLine(storage1.GetItem());

var storage2 = new Storage.Storage<string>();
storage2.SetItem("str");
Console.WriteLine(storage2.GetItem());