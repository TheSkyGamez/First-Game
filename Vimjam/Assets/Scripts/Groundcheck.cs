using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundcheck : MonoBehaviour
{

     GameObject player;
  


    private void Start()
    {
        player = gameObject.transform.parent.gameObject;
    }
 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            player.GetComponent<PlayerMovement>().IsOnGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            player.GetComponent<PlayerMovement>().IsOnGround = false;
        }
    }
}
