using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMenuBehavior : MonoBehaviour
{
    public GameObject blip_prefab;
    public bool SmashMode = false;

    public void addBlip()
    {
        Instantiate(blip_prefab, new Vector3(0, -0.1f, 0.5f), Quaternion.identity);
    }

    public void toggleSmashMode()
    {
        // Still need to implement code to ensure that the blips can interpret this
        // Also need to implement smash mode... do that first actually
        if (!SmashMode)
        {
            SmashMode = true;
        }
        else
        {
            SmashMode = false;
        }
    }

    public void exitApp()
    {
        Application.Quit();
    }
}
