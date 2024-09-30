using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderText : MonoBehaviour
{
    private TextMeshProUGUI text;
    private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("testtext").GetComponent<TextMeshProUGUI>();
        slider = GameObject.Find("testslider").GetComponent<Slider>();
        slider.onValueChanged.AddListener(UpdateText);
    }

    void UpdateText(float val){
        text.text = val.ToString("0.00");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
