using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManger : MonoBehaviour
{
    public GameObject item;

    public void UnloadMiniGame(string sceneName)
    {
        SceneManager.UnloadSceneAsync(sceneName);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.tag == "FAX" && collision.tag == "Player2")
        {
            item.SetActive(false);
        }
        if (this.tag == "BOM" && collision.tag == "Player1" || collision.tag == "Player2")
        {
            item.SetActive(false);
        }
        if (this.tag == "MATH" && collision.tag == "Player1" || collision.tag == "Player2")
        {
            item.SetActive(false);
        }
    }
}

