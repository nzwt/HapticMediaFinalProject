using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeChildren : MonoBehaviour
{
    public float resizeAmount = 0.1f; // Amount by which to resize the children
    public float maxScale = 2f; // Maximum scale allowed
    public float minScale = 0.5f; // Minimum scale allowed

    void Update()
    {
        // Check for input to resize larger
        if (Input.GetKeyDown(KeyCode.F9))
        {
            ResizeChildrenByAmount(resizeAmount);
        }

        // Check for input to resize smaller
        if (Input.GetKeyDown(KeyCode.F8))
        {
            ResizeChildrenByAmount(-resizeAmount);
        }
    }

    void ResizeChildrenByAmount(float amount)
    {
        foreach (Transform child in transform)
        {
            Vector3 newScale = child.localScale + new Vector3(0, amount, 0);

            // Clamp the scale to the defined range
            //newScale.x = Mathf.Clamp(newScale.x, minScale, maxScale);
            newScale.y = Mathf.Clamp(newScale.y, minScale, maxScale);
            //newScale.z = Mathf.Clamp(newScale.z, minScale, maxScale);

            // Apply the new scale to the child
            child.localScale = newScale;
        }
    }
}