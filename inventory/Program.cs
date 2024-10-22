Character myChar = new();

myChar.Backpack.Items.Add(new Consumable() {Name = "Smörgås"});
myChar.Backpack.Items.Add(new Consumable() {Name = "Ägg"});

myChar.Backpack.Display();


Console.ReadLine();