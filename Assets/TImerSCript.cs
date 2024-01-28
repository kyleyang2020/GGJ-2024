using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public float totalTime = 60; // Set the total time for the timer in seconds
    private float currentTime;

    // TMPro text object
    public TMPro.TextMeshProUGUI timer;

    void Start()
    {
        currentTime = totalTime;
    }

    void Update()
    {
        timer.text = currentTime.ToString();
        // Update the timer
        if (currentTime > 0f)
        {
            currentTime = currentTime - Time.deltaTime;
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
        SceneManager.LoadScene("ENDP2");
    }
}

