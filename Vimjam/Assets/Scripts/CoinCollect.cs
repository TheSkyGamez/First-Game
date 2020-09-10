using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollect : MonoBehaviour
{
    public GameObject Wall;
    public int Coins = 0;
   
   

    // Update is called once per frame
    void Update()
    {
        if (Coins == 3)
        {
            Destroy(Wall);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Coins")
        {
            Coins = Coins + 1;
        }

        if (collision.collider.tag == "Flag")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (collision.collider.name == "DeathArea")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
