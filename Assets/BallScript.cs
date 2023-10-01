using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public AudioSource batSFX;
    public AudioSource wallSFX;
    public AudioSource goalSFX;

    // Start is called before the first frame update
    void Start()
    {
        Launch();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(speed * Time.deltaTime * rb.velocity);
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
        goalSFX.Play();
        rb.position = Vector2.zero;
        Launch();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            batSFX.Play();
            
        }
        
        if (collision.gameObject.CompareTag("Wall"))
        {
            wallSFX.Play();
        }
    }
}
