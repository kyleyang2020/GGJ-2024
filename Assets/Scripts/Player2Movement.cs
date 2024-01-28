using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2Movement : MonoBehaviour
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
        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);

        // animation for player
        /*
        if (playerInput.sqrMagnitude > 0)
            animator.Play("player2Walk");
        else
            animator.Play("player2Stand");
        */

        // moves player, normalized to fix speed when moving diagonally
        // Time.deltaTime to make movement framerate dependent
        rb.velocity = playerInput.normalized * speed;
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player1")
        {
            Debug.Log("tp");
            transform.position = new Vector3(45, -45, -5);
        }
        if (collision.tag == "FAX")
        {
            Debug.Log("hit");
            SceneManager.LoadScene(1, LoadSceneMode.Additive);
            SceneManager.LoadScene(2, LoadSceneMode.Additive);
        }
        if (collision.tag == "BOM")
        {
            speed -= 2;
        }
        if (collision.tag == "MATH")
        {
            speed += 2;
        }
    }
    

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
}
