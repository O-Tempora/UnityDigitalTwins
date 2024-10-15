using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        var rend = other.GetComponent<Renderer>();
        rend.material.color = Random.ColorHSV();
    }
}
