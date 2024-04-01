using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NightController : MonoBehaviour
{

    Renderer renderer;
    [SerializeField] private UnityEvent _nightTime;
    [SerializeField] private UnityEvent _dayTime;
    
    // Start is called before the first frame update
    void Start()
    {
        // Disable the renderer for the object
        this.renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.enabled = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void nightTime()
    {
        this.renderer.enabled = true;
    }

    void dayTime()
    {
        this.renderer.enabled = false;
    }
}
