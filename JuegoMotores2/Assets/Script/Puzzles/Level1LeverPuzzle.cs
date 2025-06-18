using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1LeverPuzzle : PuzzleLeverSystem
{
    [SerializeField] private GameObject keyItem;
    public override void ResolvePuzzle()
    {
        Debug.Log("Resuelto");
       keyItem.SetActive(true);
        for (int i = 0; i < leverState.Length; i++)
        {
            leverState[i] = false;
        }
    }
}
