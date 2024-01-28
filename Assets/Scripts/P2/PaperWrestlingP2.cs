using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperWrestlingP2 : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Return))
        {
            count += 1;
            textScore.text = count.ToString();
        }

        // when win limit is reached close that mini game scene
        if (count > winLimit)
        {
            manager.UnloadMiniGame("PaperWrestlingP1");
            manager.UnloadMiniGame("PaperWrestlingP2");
        }
            
    }
}
