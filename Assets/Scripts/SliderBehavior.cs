using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class SliderBehavior : MonoBehaviour
{
    public GameObject slider;
    public GameObject Cube;

    public AudioSource sine;
    public AudioSource saw;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float size = (slider.GetComponent<PinchSlider>().SliderValue / 2.0f) + 0.5f;
        Cube.transform.localScale = new Vector3(size, size, size);

        sine.volume = 1.0f - slider.GetComponent<PinchSlider>().SliderValue;
        saw.volume = slider.GetComponent<PinchSlider>().SliderValue;
    }
}
