using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour
{
    public Image img1;
    public Image img2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("workingngngngng");
        if (collision.CompareTag("Player1"))
            img1.enabled = true;
        else if (collision.CompareTag("Player2"))
            img2.enabled = true;
    }
}
