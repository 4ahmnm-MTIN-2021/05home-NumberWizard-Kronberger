using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{

    int max;
    int min;
    int guess;

    public Text guessText;

    void Start()
    {
        max = 100;
        min = 1;
        guess = 50;

        Debug.Log("Hello I am the Number Wizard Pick a number between 1 and 100 Tell me if your number is higher or lower than ... Push Arrow Up if your number is higher, Arrow Down if it is lower, and Enter if it is correct");
        max = max + 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Correct, as always");
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
    }
}