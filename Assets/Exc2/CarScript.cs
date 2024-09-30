using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Car;
    void Start()
    {
        for(int i = 0; i < 3; i++){
             Instantiate(Car, new Vector3(10 * i, 10 * i, 10 * i), new Quaternion());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
