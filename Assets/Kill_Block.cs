using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_Block : MonoBehaviour
{
    public Transform respawnPoint;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            //Destroy(other.gameObject);

            other.gameObject.GetComponent<Transform>().position = respawnPoint.transform.position;

        }
    }

}
