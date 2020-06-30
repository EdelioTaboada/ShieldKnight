using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    public static Transform PlayerTransform;
    public SpriteRenderer playerRenderer;
    // Start is called before the first frame update
    void Start()
    {
        PlayerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            PlayerTransform.position = new Vector3(PlayerTransform.position.x + 5 * Time.deltaTime, PlayerTransform.position.y, PlayerTransform.position.z);
            PlayerTransform.localScale = new Vector3(1, PlayerTransform.localScale.y, PlayerTransform.localScale.z);
        }
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            PlayerTransform.position = new Vector3(PlayerTransform.position.x - 5 * Time.deltaTime, PlayerTransform.position.y, PlayerTransform.position.z);
            PlayerTransform.localScale = new Vector3(-1, PlayerTransform.localScale.y, PlayerTransform.localScale.z);
        }
        if (Input.GetAxisRaw("Vertical") == 1) 
        {
            PlayerTransform.position = new Vector3(PlayerTransform.position.x, PlayerTransform.position.y + 1, PlayerTransform.position.z);
        }
    }
}
