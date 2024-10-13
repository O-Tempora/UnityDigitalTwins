using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float defaultSpeed = 1.0f/100_000_000.0f;
    public float sprintSpeed = 1.0f/1_000.0f;
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis, yAxis;
        if (Input.GetKey(KeyCode.LeftShift)){
            xAxis = Input.GetAxis("HorizontalFast") * sprintSpeed;
            yAxis = Input.GetAxis("VerticalFast") * sprintSpeed;
        } else {
            xAxis = Input.GetAxis("Horizontal") * defaultSpeed;
            yAxis = Input.GetAxis("Vertical") * defaultSpeed;
        }

        var movementVec = new Vector3(xAxis, yAxis, 0);
        transform.Translate(movementVec);
    }
}
