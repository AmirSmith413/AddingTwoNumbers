//Mini Challenge #2
//Finished on:8/9/22
//Peer Reviewed by:Valerie Aguilar





 int num1,num2,sum;
string Num1;
string Num2;
string decision;
bool playAgain = true;
while(playAgain == true)
{
Console.WriteLine("Please enter two numbers.");

//enter any numbers here
Num1 = Console.ReadLine();
Num2 = Console.ReadLine();

//numbers will be converted here
num1 = Convert.ToInt32(Num1);
num2 = Convert.ToInt32(Num2);
sum = num1 + num2;
Console.WriteLine($"The answer is {sum}.");
//the sum of the 2 number will be displayed here
sum = Convert.ToInt32(num1 + num2);    
Console.WriteLine("Would you like to try again?Type Y to try again or N to end.");
 decision = Console.ReadLine().ToUpper();
    //if the user wanted to try again, pressing "Y" will send them to the beginning
 if(decision == "Y")
    {
      playAgain = true;
    }
    else if(decision == "N")
    {
      //if the user wanted to stop pressing "N" will end the program
      playAgain = false;
    }
    else
    {
        Console.WriteLine("Please pick a valid option.");
    } 
}