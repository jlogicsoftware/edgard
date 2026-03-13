using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;

    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal") * speed;
        float moveVertical = Input.GetAxisRaw("Vertical") * speed;

        // Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        // rb.AddForce(movement * 10f);
        // rb.linearVelocity = new Vector2(moveHorizontal * 5f, moveVertical * 5f);
        rb.linearVelocity = new Vector2(moveHorizontal, rb.linearVelocityY);
    }
}
