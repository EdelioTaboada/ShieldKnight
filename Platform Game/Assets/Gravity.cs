using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Transform playerTrans;
    public static bool isGrounded = false;
    public float GravSpeed;
    void Start()
    {
        playerTrans = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGrounded)
        {
            playerTrans.position = new Vector3(playerTrans.position.x, playerTrans.position.y - GravSpeed * Time.deltaTime, playerTrans.position.z);
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Ground")
        {

            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {

        if (col.gameObject.tag == "Ground")
        {

            isGrounded = false;
        }
    }
}
