using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class USBDriveDetector : MonoBehaviour
{
    public string[] usbDriveNames; // Names of the USB drives you want to detect
    public Sprite[] backgroundImages; // Background images corresponding to each USB drive
    public SpriteRenderer spriteRenderer;

    private Image backgroundImage;

    private void Start()
    {
    }

    private void OnUSBDriveInserted(string driveName)
    {
        // Find the index of the inserted USB drive
        int index = Array.IndexOf(usbDriveNames, driveName);

        // If the inserted USB drive is found, load the corresponding background image
        if (index != -1 && index < backgroundImages.Length)
        {
            spriteRenderer.sprite = backgroundImages[index];
        }
    }

    private void Update()
    {
        // Detect USB drive insertion   
        foreach (DriveInfo drive in DriveInfo.GetDrives())
        {
            // Print the name of the drive
            Debug.Log("Detected drive: " + drive.Name);

            if (drive.DriveType == DriveType.Removable && drive.IsReady)
            {
                foreach (string usbDriveName in usbDriveNames)
                {
                    if (drive.Name == usbDriveName)
                    {
                        OnUSBDriveInserted(drive.Name);
                        break;
                    }
                }
            }
        }
    }
}