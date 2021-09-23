using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    [SerializeField]
    private int moveSpeed = 4;
    private Rigidbody rb;
    private GameObject player;
    bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!gameOver)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(this.transform.forward * moveSpeed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(-1 * this.transform.forward * moveSpeed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.Rotate(0, 2, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                this.transform.Rotate(0, -2, 0);
            }
        }
    }

    public void endGame()
    {
        gameOver = true;
    }
}
