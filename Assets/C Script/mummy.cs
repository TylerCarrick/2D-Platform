using Cinemachine.Utility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mummy : MonoBehaviour
{

    public GameObject player;
    SpriteRenderer sr;

    public Transform respawnPoint;


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }


    void Update()
    {
        Vector3 scale = transform.localScale;

        if (player.transform.position.x > transform.position.x)
        {
            sr.flipX = true;
            transform.position = new Vector2(transform.position.x + (1 * Time.deltaTime), transform.position.y);
        }

        if (player.transform.position.x < transform.position.x)
        {
            sr.flipX = false;
            transform.position = new Vector2(transform.position.x + (-1 * Time.deltaTime), transform.position.y);
        }



       






    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            //Destroy(other.gameObject);

            other.gameObject.GetComponent<Transform>().position = respawnPoint.transform.position;

        }
    }

}




































