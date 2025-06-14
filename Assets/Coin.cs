using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private int totalCoins;
    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.gameObject.CompareTag("Player"))
        {
            totalCoins++;
            Destroy(gameObject);
        }
    }
}
