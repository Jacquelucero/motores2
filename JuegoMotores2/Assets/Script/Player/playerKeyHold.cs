using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerKeyHold : MonoBehaviour
{
    [SerializeField] private GameObject openDoor;
    public bool[] hasKey;

        private void Start()
    {
        hasKey = new bool[4];


    }
    private void Update()
    {
        if (hasKey[0] && hasKey[1] && hasKey[2] && hasKey[3] == true)
        {
            openDoor.SetActive(true);
        }
    }
}
