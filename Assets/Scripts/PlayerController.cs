using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    private Rigidbody2D rb;
    public GameObject effect;

    public int score;
    public Text scoreDisplay;

    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = score.ToString();
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(effect, transform.position, Quaternion.identity);
        gameOver.SetActive(true);
        Destroy(gameObject);
    }
}
