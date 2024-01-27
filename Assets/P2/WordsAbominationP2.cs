using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordsAbominationP2 : MonoBehaviour
{
    // list of 5 letter words in play
    List<string> list = new List<string> { "obama", "chaos", "tears", "ducks", "missippi" };

    // word with missing letter and it's letter
    char[] wordMissOne;
    char letter;

    // TMPro text object
    public TMPro.TextMeshProUGUI guessWord;

    // list of buttons/answers
    public List<Button> buttonList;
    public List<TMPro.TextMeshProUGUI> buttonTextList;

    // int of the correct answer
    int randomButtonText;

    private void Start()
    {
        // show the word with missing letter
        guessWord.text = string.Join("  ", GetRandomWordLetters(list));

        // random button and its text from 0-4
        randomButtonText = UnityEngine.Random.Range(0, buttonTextList.Count);
        buttonTextList[randomButtonText].text = letter.ToString();

        // 97-122, a-z
        for(int i = 0; i < buttonTextList.Count; i++)
        {
            // skips over the actual answer
            if (i == randomButtonText)
                i++;
            // randomly chooses a lower case letter to fill in for wrong answers
            // DID NOT IMPLEMENT EDGE CASES where correct answers can come up
            else
                buttonTextList[i].text = Convert.ToChar(UnityEngine.Random.Range(97, 122)).ToString();
        }
    }

    private void Update()
    {
        // NEED TO IMPLEMENT BUTTON CLICK ACTIONS
        Button correctAnswer = buttonList[randomButtonText];
    }

    char[] GetRandomWordLetters(List<string> words)
    {
        // gets random word and set it
        int randomWordIndex = UnityEngine.Random.Range(0, words.Count);

        // puts random word into a array of characters
        char[] chars = words[randomWordIndex].ToCharArray();

        // replace the missing letter with '_'
        int missingLetter = UnityEngine.Random.Range(0, chars.Length);
        letter = chars[missingLetter]; // set missing letter char

        // changing said letter to '_'
        chars[missingLetter] = '_';
        wordMissOne = words[randomWordIndex].ToCharArray(); // set word missing letter char[]

        return chars;
    }
}
