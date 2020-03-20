using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float speed;
    private bool passed;

    // Start is called before the first frame update
    void Start()
    {
        passed = false;
        transform.position = new Vector2(transform.position.x, Random.Range(-3f, 3f));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= -10f)
        {
            Destroy(gameObject);
        }

        if(transform.position.x <= -4f && passed == false)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if(player)
            {
                player.GetComponent<PlayerController>().score++;
                passed = true;
            }
        }

        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
