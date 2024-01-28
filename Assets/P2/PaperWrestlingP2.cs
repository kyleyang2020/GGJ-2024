using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperWrestlingP2 : MonoBehaviour
{
    // mini game manager for closing scene
    private MiniGameManger manager;

    // player 2 scene name
    private string PaperWrestling2;

    // score text and counters
    public TMPro.TextMeshProUGUI textScore;
    public int count;
    public int winLimit;

    private void Update()
    {
        // player 2 spam clicks k and display click amount
        if (Input.GetKeyDown(KeyCode.K))
        {
            count += 1;
            textScore.text = count.ToString();
        }

        // when win limit is reached close that mini game scene
        if (count > winLimit)
            manager.UnloadMiniGame(PaperWrestling2);
    }
}
