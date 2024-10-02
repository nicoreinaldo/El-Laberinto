using UnityEngine;
using System.Collections.Generic;

public class CameraController : MonoBehaviour
{
    public List<Camera> cameraList;
    private int currentCameraIndex = 0;

    void Start()
    {
        // Disable all cameras and enable only the first one
        for (int i = 0; i < cameraList.Count; i++)
        {
            cameraList[i].enabled = false;
        }
        cameraList[currentCameraIndex].enabled = true;
    }

    public void SwitchToNextCamera()
    {
        // Disable the current camera
        cameraList[currentCameraIndex].enabled = false;
        // Increment the index and wrap around if necessary
        currentCameraIndex = (currentCameraIndex + 1) % cameraList.Count;
        // Enable the next camera
        cameraList[currentCameraIndex].enabled = true;
    }
}
