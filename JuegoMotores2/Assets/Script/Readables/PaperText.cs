using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PaperText : MonoBehaviour
{
    [SerializeField] private TMP_Text m_text;
    public int clueNumber;
    private string[] clueText;

    private void Start()
    {
        
        clueText = new string[3];

        clueText[0] = "�Cu�ntas personas vivian en esta casa?";
        clueText[1] = "�Cu�ntos monstruos rondan por aqu�?";
        clueText[2] = "�Cu�ntas puertas hay bloqueadas?";
        
    }
    public void SetText(int clueNumber)
    {
        Debug.Log(clueNumber);
        m_text.text = clueText[clueNumber];
    }
}
