using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperWrestlingP1 : MonoBehaviour
{
    // mini game manager for closing scene
    private MiniGameManger manager;

    // score text and counters
    public TMPro.TextMeshProUGUI textScore;
    public int count;
    public int winLimit;

    private void Update()
    {
        // player 2 spam clicks enter and display click amount
        if (Input.GetKeyDown(KeyCode.Space))
        {
            count += 1;
            textScore.text = count.ToString();
        }
    }
}
