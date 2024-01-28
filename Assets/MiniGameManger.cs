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

    public void UnloadMiniGame(string sceneName)
    {
        SceneManager.UnloadSceneAsync(sceneName);
    }

    public void StartDDR()
    {
        
    }

    public void StartFAX()
    {

    }

    public void StartBOM()
    {

    }

    public void StartMATH()
    {

    }
}
