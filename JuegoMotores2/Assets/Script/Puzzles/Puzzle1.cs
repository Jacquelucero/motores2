using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{


    public float leverTimeCooldown;
    [Header("Combinacion correcta")]

    [SerializeField] private bool Lever1;
    [SerializeField] private bool Lever2;
    [SerializeField] private bool Lever3;
    [SerializeField] private bool Lever4;

    

   

    public bool[] leverState = new bool[4];

    private void Update()
    {
        if (leverState[0] == Lever1 && leverState[1] == Lever2 && leverState[2] == Lever3 && leverState[3] == Lever4)
        {
            ResolvePuzzle();
        }
    }

    void ResolvePuzzle()
    {
        Debug.Log("Resolviste el puzzle");
    }
}
