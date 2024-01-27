using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using TMPro;
using UnityEditor;
using UnityEditor.Tilemaps;
using UnityEngine;

public class WordsAbominationP2 : MonoBehaviour
{
    // list of 5 letter words in play
    List<string> list = new List<string> { "obama", "chaos", "tears", "ducks", "queen" };

    // word with missing letter and it's letter
    char[] wordMissOne;
    char letter;

    // TMPro text object
    public TMPro.TextMeshProUGUI guessWord;

    private void Start()
    {
        guessWord.text = string.Join("  ", GetRandomWordLetters(list));
    }

    char[] GetRandomWordLetters(List<string> words)
    {
        // gets random word and set it
        int randomWordIndex = Random.Range(0, words.Count);

        // puts random word into a array of characters
        char[] chars = words[randomWordIndex].ToCharArray();

        // replace the missing letter with '_'
        int missingLetter = Random.Range(0, chars.Length);
        letter = chars[missingLetter]; // set missing letter char

        // changing said letter to '_'
        chars[missingLetter] = '_';
        wordMissOne = words[randomWordIndex].ToCharArray(); // set word missing letter char[]

        return chars;
    }
}
