using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1Movement : MonoBehaviour
{
    // for the speed of the character
    [SerializeField] private float speed;

    // for the player walk anim
    //private Animator animator;
    private Rigidbody2D rb;

    private void Start()
    {
        //animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // PLAYER MOVEMENT with wasd
        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal2"), Input.GetAxisRaw("Vertical2"), 0);

        // animation for player
        /*
        if (playerInput.sqrMagnitude > 0)
            animator.Play("player1Walk");
        else
            animator.Play("player1Stand");
        */

        // moves player, normalized to fix speed when moving diagonally
        // Time.deltaTime to make movement framerate dependent
        rb.velocity = playerInput.normalized * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BOM")
        {
            speed -= 2;
        }
        if (collision.tag == "MATH")
        {
            speed += 2;
        }
    }

}
