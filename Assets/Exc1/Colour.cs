using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private new Renderer renderer;
    private Color defaultColor = Color.blue;
    private Color onHoverColor = Color.black;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.color = defaultColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter() {
	    renderer.material.color = onHoverColor;
	}
 
    void OnMouseExit() {
        renderer.material.color = defaultColor;
	}
}
