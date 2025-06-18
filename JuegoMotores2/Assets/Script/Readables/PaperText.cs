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

        clueText[0] = "¿Cuántas personas vivian en esta casa?";
        clueText[1] = "¿Cuántos monstruos rondan por aquí?";
        clueText[2] = "¿Cuéntas puertas hay bloqueadas?";
        
    }
    public void SetText(int clueNumber)
    {
        Debug.Log(clueNumber);
        m_text.text = clueText[clueNumber];
    }
}
