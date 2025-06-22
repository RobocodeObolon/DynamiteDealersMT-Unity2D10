using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int totalCoins;
    private Rigidbody2D rb;
    public GameObject scene;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scene = GameObject.Find("WinScene");
        scene.SetActive(false);
    }

    private void Update(){
        if(totalCoins == 4)
        {
            scene.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontalInput,  verticalInput) * moveSpeed;

        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
    }
}
