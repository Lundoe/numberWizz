using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberWizz : MonoBehaviour

{

int maximumNumber;
int minimumNumber;
int wizzGuess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        maximumNumber = 1000;
        minimumNumber = 1;
        wizzGuess = 500;
       
        Debug.Log("Hi, welcome to numberWizz!");
        Debug.Log("To play this game, you have to think of a number.");
        Debug.Log($"Therefore, please proceed to think of a number between {minimumNumber} and {maximumNumber}.");
        Debug.Log($"Now, tell me if the number you chose is higher or lower, than {wizzGuess}.");
        Debug.Log("If the number is higher, then press the 'Arrow Up' key. If the number is lower, then press the 'Arrow Down' key. If the progam quesses the correct number, then press 'Enter'.");
        maximumNumber = maximumNumber + 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minimumNumber = wizzGuess;
            NextGuess();
        }
        
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maximumNumber = wizzGuess;
            NextGuess();
        }
 
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Great! numberWizz guessed the correct number. The game will now restart.");
            StartGame();
        }
    }

    void NextGuess()
    {
        wizzGuess = (maximumNumber + minimumNumber) / 2;
        Debug.Log($"Is this the correct number? Or is it higher or lower than {wizzGuess}?.");
    }

}
