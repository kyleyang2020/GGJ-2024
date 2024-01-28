using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite defaultImg;
    public Sprite pressedImg;

    public KeyCode pressedKey;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(pressedKey))
            spriteRenderer.sprite = pressedImg;
        else if(Input.GetKeyUp(pressedKey))
            spriteRenderer.sprite = defaultImg;
    }
}
