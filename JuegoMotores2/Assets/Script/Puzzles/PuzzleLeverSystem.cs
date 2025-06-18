using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PuzzleLeverSystem : MonoBehaviour
{


    public float leverTimeCooldown;
    private bool puzzleResolved = false;

    [Header("Combinacion correcta")]

    [SerializeField] private bool Lever1;
    [SerializeField] private bool Lever2;
    [SerializeField] private bool Lever3;
    [SerializeField] private bool Lever4;

    

   

    public bool[] leverState = new bool[4];

    private void Update()
    {
        if (!puzzleResolved &&
            leverState[0] == Lever1 &&
            leverState[1] == Lever2 &&
            leverState[2] == Lever3 &&
            leverState[3] == Lever4)
        {
            ResolvePuzzle();
        }
    }


   public virtual void ResolvePuzzle()
    {
        puzzleResolved = true;
        Debug.Log("Resolviste el puzzle");

        
    }

}
