using System.Collections;
using System.Collections.Generic;
using Mono.Cecil.Cil;
using UnityEngine.UI;
using UnityEngine;

public class LightswitchScript : MonoBehaviour
{
    private Light biglight;
    public Button lightswitch;
    // Start is called before the first frame update
    void Start()
    {
        biglight = GameObject.Find("biglight").GetComponent<Light>();
        
        lightswitch = GameObject.Find("lightswitch").GetComponent<Button>();
		lightswitch.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnClick(){
        biglight.enabled = !biglight.enabled;
    }
}
