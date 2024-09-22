using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Cylinder : MonoBehaviour
{
    private float _noScope = 360f;
    private float _rotationAngle = 36f;
    
    void Start() 
    {
        StartCoroutine(Rotate());
    }

    void Update()
    {
        
    }

    IEnumerator Rotate()
    {
        while (_noScope > 0){
            var angle =  _rotationAngle * Time.deltaTime;
            transform.Rotate(0, 0, angle);
            _noScope -= angle;
            yield return null;
        }
    }
}