using App;

Console.WriteLine(Convert.ToBase64String(CryptographicHelpers.GenerateRandomKey(32)));
Console.WriteLine(CryptographicHelpers.GenerateRandomInteger(1, 100));
