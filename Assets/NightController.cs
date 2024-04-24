using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class NightController : MonoBehaviour
{

    Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        // // Disable the renderer for the object
        // this.renderer = GetComponent<Renderer>();
        // if (renderer != null)
        // {
        //     renderer.enabled = false;
        // }
        this.renderer.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nightTime()
    {
        Debug.Log("nighttime");
        this.renderer.enabled = true;
    }

    public void dayTime()
    {
        Debug.Log("daytime");
        this.renderer.enabled = false;
    }
}
