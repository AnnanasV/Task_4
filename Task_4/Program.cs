Console.WriteLine(MathHelper.MathHelper.Factorial(4));
Console.WriteLine(MathHelper.MathHelper.GCD(4, 10));
Console.WriteLine(MathHelper.MathHelper.LCM(4, 10));

﻿var appSettings = new ApplicationSettings.ApplicationSettings("Program Name");
Console.WriteLine(appSettings.ShowInfo());


﻿var storage1 = new Storage.Storage<int>();
storage1.SetItem(17);
Console.WriteLine(storage1.GetItem());

var storage2 = new Storage.Storage<string>();
storage2.SetItem("str");
Console.WriteLine(storage2.GetItem());
