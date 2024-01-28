using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculateP1 : MonoBehaviour
{
    // list of 3 math things, +, -, x
    List<char> opList = new List<char> { '+', '-', 'x' };

    // first and second number to math
    int firstNum, secondNum, ansNum;

    // TMPro text object
    public TMPro.TextMeshProUGUI mathProblem;

    // list of buttons/answers
    public List<Button> buttonList;
    public List<TMPro.TextMeshProUGUI> buttonTextList;

    // int of the correct answer
    int randomButtonText;

    // keeps track on answer
    int buttonCounter = 0;

    // mini game manager and the scene name
    MiniGameManger manager;
    public string sceneName;

    private void Start()
    {
        // randomly chooses a op and nums
        int opIndex = Random.Range(0, opList.Count);
        firstNum = Random.Range(0, 100);
        secondNum = Random.Range(0, 100);

        // string for/to display math problem
        string problem = firstNum.ToString() + " " + opList[opIndex] + " " + secondNum.ToString();

        // displaying problem on screen
        mathProblem.text = problem;

        // doing math
        DoMath(firstNum, opIndex, secondNum);

        // random button and its text from 0-4
        randomButtonText = UnityEngine.Random.Range(0, buttonTextList.Count);
        buttonTextList[randomButtonText].text = ansNum.ToString();

        // random numbers 0 - 2000
        for (int i = 0; i < buttonTextList.Count; i++)
        {
            // skips over the actual answer
            // randomly chooses a number between 
            // DID NOT IMPLEMENT EDGE CASES where correct answers can come up
            if (!(i == randomButtonText))
                buttonTextList[i].text = Random.Range(0, 2000).ToString();
        }

        Debug.Log(problem);
        Debug.Log(ansNum);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && buttonCounter == randomButtonText)
        {
            manager.UnloadMiniGame(sceneName);
            Debug.Log("is correct");
        }
        if (Input.GetKeyDown(KeyCode.A) && buttonCounter > 0)
            buttonCounter--;
        else if (Input.GetKeyDown(KeyCode.D) && buttonCounter < 4)
            buttonCounter++;
    }

    int DoMath(int first, int opIndex, int second)
    {
        // +
        if (opIndex == 0)
            ansNum = first + second;
        // -
        else if (opIndex == 1)
            ansNum = first - second;
        // *
        else if (opIndex == 2)
            ansNum = first * second;

        return ansNum;
    }
}
