using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    Rigidbody2D rigidBody;
    public float speed;
    public bool canItMove;
    public GameObject manager;
    public static bool gameOver;
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
        rigidBody = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {   
        if(canItMove == false)
        {
            rigidBody.MovePosition(rigidBody.position + Vector2.up * speed * Time.deltaTime);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GreatCircle")
        {
            transform.SetParent(collision.transform);
            canItMove = true;
        }
        if(collision.gameObject.tag == "SmallCircle")
        {
            gameOver = true;
            manager.GetComponent<GameOver>().GameOverScene();
        }
    }
  
}
