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
    Console.WriteLine(" = " + options[intUserOption]);

if (options.ContainsKey(intUserOption))
{
    Console.WriteLine("Digite qual o valor em {0}: ", options[intUserOption]);
    string? userGivenValue = Console.ReadLine();
    Console.WriteLine("---------------------------------------------------------------");
    Console.WriteLine(userGivenValue + " " + options[intUserOption] + " é equivalente a:");

    float userGivenTemperature;
    float.TryParse(userGivenValue, out userGivenTemperature);

    TemperatureConverter converter = new TemperatureConverter();

    switch (options[intUserOption])
    {
        case "Kelvin":
            Console.Write("{0} °C (Celsius) \n{1} °F (Fahrenheit)",
                converter.KelvinToCelsius(userGivenTemperature),
                converter.KelvinToFahrenheit(userGivenTemperature));

            break;

        case "Celsius":
            Console.Write("{0} °F (Fahrenheit) \n{1} °K (Kelvin)",
               converter.CelsiusToFahrenheit(userGivenTemperature),
               converter.CelsiusToKelvin(userGivenTemperature));
            break;

        case "Fahrenheit":
            Console.Write("{0} °C (Celsius) \n{1} °K (Kelvin)",
                converter.FahrenheitToCelsius(userGivenTemperature),
                converter.FahrenheitToKelvin(userGivenTemperature));
            break;
    }

}
else
{
    Console.WriteLine("\n Opção inválida! ");
}

