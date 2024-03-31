using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NightController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Disable the renderer for the object
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.enabled = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
