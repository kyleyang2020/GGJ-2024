using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public float totalTime = 60f; // Set the total time for the timer in seconds
    private float currentTime;

    void Start()
    {
        currentTime = totalTime;
    }

    void Update()
    {
        // Update the timer
        if (currentTime > 0f)
        {
            currentTime -= Time.deltaTime;
            // You can add additional actions or update UI here during the countdown
        }
        else
        {
            // Timer reached zero, perform action
            TimerExpiredAction();
        }
    }

    void TimerExpiredAction()
    {
        Debug.Log("Timer expired!");
        // Add your custom action here, for example, load a new scene, restart the level, etc.
    }
}

