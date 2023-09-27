using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Script : MonoBehaviour
{
    public Rigidbody2D rb;
    public BallScript ball;
    public float moveSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (ball.transform.position.y > transform.position.y)
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        } else if (ball.transform.position.y < transform.position.y)
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }
    }
}
