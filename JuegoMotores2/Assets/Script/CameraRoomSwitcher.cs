using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRoomSwitcher : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            mainCamera.transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                mainCamera.transform.position.z
            );
        }
    }
}
