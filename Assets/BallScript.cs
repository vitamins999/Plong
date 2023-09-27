using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyBall()
    {
        Destroy(gameObject);
    }

    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rb.velocity = new Vector2(x, y) * speed;
    }

    public void ResetPosition()
    {
        rb.position = Vector2.zero;
        Launch();
    }
}
