int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

string value = "102";
int result = 0;

if(int.TryParse(value, out result)){
    Console.WriteLine($"Measurement: {result}");
}
else{
    Console.WriteLine("Unaple to report the measurement.");
}
Console.WriteLine($"Measurement wit offset: fweh {50 + result}");