using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class AudioToggle : MonoBehaviour
{
    public AudioSource sine;
    public AudioSource saw;

    public GameObject sphere;
    public GameObject lh;
    public GameObject rh;
    public GameObject handmenu;
    public GameObject slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Consider adding a multiplier to the height var to make pitch changes more dramatic
        float height = sphere.transform.position.y;
        sine.pitch = height + 1.1f;
        saw.pitch = height + 1.1f;

        // This may need to be edited to get all blip objects and set them to smash mode
        // ie: GameObject.FindObjectsOfType(typeof(Blip)); // returns Object[]
        if (handmenu.GetComponent<HandMenuBehavior>().SmashMode)
        {
            // if lh or rh <= 0.3m from blip: blip.volume = (0.3 - (dist)) * 10
            float rdist = Mathf.Abs(Vector3.Distance(rh.transform.position, sphere.transform.position));
            float ldist = Mathf.Abs(Vector3.Distance(lh.transform.position, sphere.transform.position));
            float closest_dist = Mathf.Min(rdist, ldist);

            float slider_value = slider.GetComponent<PinchSlider>().SliderValue;

            // These values need to be adjusted because right now it is quite finicky (0.1 -> 0.2 seemed to help a lot)
            if (closest_dist <= 0.15f)
            {
                // Adjust this so that it changes volumes based on slider value for each wave type (just multiply each volume by slider.value or (1-slider.value))
                // DESIGN CHOICE: Add smash mode to each sphere, or universal smash mode (currently it is universal)
                sine.volume = ((0.15f - closest_dist) * 10f) * (1.0f - slider_value);
                saw.volume = ((0.15f - closest_dist) * 10f) * slider_value;
            }
            else
            {
                sine.volume = 0f;
                saw.volume = 0f;
            }
        }
    }

    public void toggle()
    {
        if (sine.isPlaying)
        {
            sine.Pause();
            saw.Pause();
        }
        else
        {
            sine.Play();
            saw.Play();
        }
    }
}
