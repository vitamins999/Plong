using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Script : MonoBehaviour
{
    public Rigidbody2D rb;
    public BallScript ball;
    public float moveSpeed;
    public float lerpSpeed = 1f;

    // Start is called before the first frame update
    void Awake()
    {
        moveSpeed = Options.difficulty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (ball.transform.position.y > transform.position.y)
        {
            if (rb.velocity.y < 0)
            {
                rb.velocity = Vector2.zero;
            }

            rb.velocity = Vector2.Lerp(rb.velocity, Vector2.up * moveSpeed, lerpSpeed * Time.deltaTime);
        
        } else if (ball.transform.position.y < transform.position.y)
        {
            if (rb.velocity.y > 0)
            {
                rb.velocity = Vector2.zero;
            }

            rb.velocity = Vector2.Lerp(rb.velocity, Vector2.down * moveSpeed, lerpSpeed * Time.deltaTime);
            
        } else
        {
            rb.velocity = Vector2.Lerp(rb.velocity, Vector2.zero * moveSpeed, lerpSpeed * Time.deltaTime);
        }
    }
}
