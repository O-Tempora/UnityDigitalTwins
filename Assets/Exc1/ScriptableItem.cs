using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

[CreateAssetMenu(menuName = "Assets/Exc1")]
public class Item : ScriptableObject
{
    public string Name;
    public string Description;
    // Start is called before the first frame update
    void Start()
    {
        Name = System.Guid.NewGuid().ToString();
        Description = "sendhelp";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
