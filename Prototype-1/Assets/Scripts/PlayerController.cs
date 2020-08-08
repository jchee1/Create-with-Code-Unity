using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 22.0f;
    private float turnSpeed = 45.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    private float horizontalInput;
    private float forwardInput;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //turn vehicle
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
    }
}
