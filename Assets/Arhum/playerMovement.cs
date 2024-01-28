using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the player movement

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Input for horizontal and vertical movement
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        // Calculate movement vector
        Vector2 movement = new Vector2(moveHorizontal, moveVertical).normalized * moveSpeed * Time.deltaTime;

        // Apply movement to the rigidbody
        rb.MovePosition(rb.position + movement);
    }
}
