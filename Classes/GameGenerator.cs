using System;
using System.Collections.Generic;

public class GameGenerator : IGameGenerator
{
    private int quantityOfNumbers;
    private int initialNumber;
    private int finalNumber;
    List<int> game = new List<int>();

    public GameGenerator(int quantityOfNumbers, int initialNumber, int finalNumber)
    {
        this.quantityOfNumbers = quantityOfNumbers;
        this.initialNumber = initialNumber;
        this.finalNumber = finalNumber;
    }

    public List<int> GenerateGame()
    {          
        for(int i = 0; i < this.quantityOfNumbers; i++)
        {
            var newNumber = GenerateNumber();               
            game.Add(newNumber);
        }      
        game.Sort();
        return game;
    }

    private int GenerateNumber()
    {
        Random random = new Random();
        var newNumber = 0;
        var numberExists = false;        

        do
        {
            newNumber = random.Next(this.initialNumber, this.finalNumber + 1);
            numberExists = CheckIfNumberAlreadyExists(newNumber);
        }while(numberExists == true);          

        return newNumber;
    }

    private bool CheckIfNumberAlreadyExists(int newNumber)
    {
        var numberExists = false;

        foreach (var number in this.game)
        {
            if(newNumber == number)
            {
                numberExists = true;
                break;
            }
        }
        return numberExists;
    }
}