using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.5f;
    private Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        Movement();
    }

    void Movement() 
    {
        float forwardDir = Input.GetAxis("Vertical");
        float rightDir = Input.GetAxis("Horizontal");

        Vector3 dir = new (-1 * forwardDir * speed, -1 * rightDir * speed, 0);
        transform.Translate(dir);
    }
}
