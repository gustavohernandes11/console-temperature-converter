Console.WriteLine("Conversor de unidades de temperatura. ");

Dictionary<int, string> options = new Dictionary<int, string>(){
    {1, "Kelvin"},
    {2, "Celsius"},
    {3, "Fahrenheit"}
};

foreach (var option in options)
{
    Console.WriteLine("[{0}] {1}", option.Key, option.Value);
}

Console.WriteLine("Escolha qual a unidade você tem o valor que quer converter?: ");
ConsoleKeyInfo userOption = Console.ReadKey();

int intUserOption;
if (int.TryParse(userOption.KeyChar.ToString(), out intUserOption))
    Console.WriteLine("\n " + intUserOption);

if (options.ContainsKey(intUserOption))
{
    Console.WriteLine("\n Digite qual o valor: ");
    string? userGivenValue = Console.ReadLine();

    float userGivenTemperature;
    float.TryParse(userGivenValue, out userGivenTemperature);

    Temperature temperature = new Temperature(userGivenTemperature, intUserOption);


}
else
{
    Console.WriteLine("\n Opção inválida! ");
}


