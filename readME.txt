This is to compare weather from ndtv and openweatherapi

1)config.json file resides in TVWeatherApp\bin\Debug\netcoreapp3.1 contains urls/apikey/thresholdvalue/city which is input to the program
2)Chromebrowser class contains driver instance return object whenever getdriver is called
3)Ndtvweather class searches and return temperature in long from UI
4)openweather returns temperature aslong from api.Key and location is read in json file as mentioned in step1
5)All the identifiers used in browser operation resides in ndtv.xml in location TVWeatherApp\bin\Debug\netcoreapp3.1 
6)config class has methods to read values and has comparator method which calculates and return bool value within range or out of range
7) Program class is the entry point and execution starts from this class.
8) To run goto C:\Users\Amith.v.nayak\source\repos\TVWeatherApp\TVWeatherApp\bin\Debug\netcoreapp3.1 and run TVWeatherApp.exe as admin, output is printed on console
 