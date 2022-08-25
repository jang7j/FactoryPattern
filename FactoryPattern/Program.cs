using FactoryPattern;

Console.WriteLine("How much do you have in your pocket? ");
var userInput = decimal.Parse(Console.ReadLine());

var happyLunch = CostcoFactory.GetLunch(userInput); //4. Return type is INTERFACE. Store it in a variable = factoryName.methodName(para)
happyLunch.Order(); //5. Call stubbed out method from the interface.
                    

//6. Output depends on userInput based on the class that conforms to this Interface