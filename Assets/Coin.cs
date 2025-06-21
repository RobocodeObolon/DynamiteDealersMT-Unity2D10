using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void Start;
    private int totalCoins;
    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.gameObject.CompareTag("Player"))
        {
            gameObject.Find("Player").GetComponent<PlayerMovement>().totalCoins++;
            Destroy(gameObject);
        }
        if(totalCoins == 4)
        {
            
        }
    }
}
