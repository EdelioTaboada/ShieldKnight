using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform cameraTrans;
    public Transform PlayerTransform;
    // Start is called before the first frame update
    void Start()
    {
        cameraTrans = GameObject.FindGameObjectWithTag("MainCamera").transform;
        PlayerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        cameraTrans.position = new Vector3(PlayerMovement.PlayerTransform.position.x, 0,-10);
    }
}
