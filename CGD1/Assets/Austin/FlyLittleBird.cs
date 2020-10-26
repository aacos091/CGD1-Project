using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FlyLittleBird : MonoBehaviour
{
    public float upVelocity = 1;
    public float directionalVelocity = 1;
    public int score = 0;
    public Text scoreText;
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            // Jump
            rb.velocity = (Vector2.up * upVelocity) + (Vector2.right * directionalVelocity);

            score += 5;
        }

        scoreText.text = score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "RightWall")
        {
            directionalVelocity = -directionalVelocity;
            sr.flipX = true;
        }
        else if (collision.gameObject.tag == "LeftWall")
        {
            directionalVelocity = -directionalVelocity;
            sr.flipX = false;
        }
        else if (collision.gameObject.tag == "GlueTrap") 
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Game Over Screen");
        }
    }
}
