class TemperatureConverter
{
    Dictionary<int, string> options = new Dictionary<int, string>(){
    {1, "Kelvin"},
    {2, "Celsius"},
    {3, "Fahrenheit"}
};


    public float CelsiusToFahrenheit(float TemperatureCelsius)
    {
        float TemperatureFahrenheit = ((TemperatureCelsius * 1.8F) + 32);
        return TemperatureFahrenheit;
    }
    public float CelsiusToKelvin(float TemperatureCelsius)
    {
        float TemperatureKelvin = TemperatureCelsius + 273.15F;
        return TemperatureKelvin;
    }

    public float FahrenheitToCelsius(float TemperatureFahrenheit)
    {
        float TemperatureCelsius = ((TemperatureFahrenheit - 32) / 1.8F);
        return TemperatureCelsius;
    }
    public float FahrenheitToKelvin(float TemperatureFahrenheit)
    {
        float TemperatureKelvin = FahrenheitToCelsius(TemperatureFahrenheit) + 273.15F;
        return TemperatureKelvin;
    }

    public float KelvinToCelsius(float TemperatureKelvin)
    {
        float TemperatureCelsius = TemperatureKelvin - 273.15F;
        return TemperatureCelsius;
    }
    public float KelvinToFahrenheit(float TemperatureKelvin)
    {
        float TemperatureFahrenheit = (TemperatureKelvin - 273.15F) * 1.8F + 32;
        return TemperatureFahrenheit;
    }

}
