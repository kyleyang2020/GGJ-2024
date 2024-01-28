using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScroller : MonoBehaviour
{
    public float fallSpeed;

    public bool gameStart;

    private void Update()
    {
        if(gameStart)
        {
            transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);    
        }
    }
}
