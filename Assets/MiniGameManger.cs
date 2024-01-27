using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManger : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(2, LoadSceneMode.Additive);
        }
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            SceneManager.UnloadSceneAsync(2);
        }
    }
}
