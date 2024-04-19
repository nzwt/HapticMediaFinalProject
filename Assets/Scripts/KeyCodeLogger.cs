using UnityEngine;

public class KeyCodeLogger : MonoBehaviour
{
    void Update()
    {
        foreach (KeyCode keyCode in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(keyCode))
            {
                Debug.Log("KeyCode: " + keyCode);
            }
        }
    }
}