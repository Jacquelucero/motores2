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
        
        clueText = new string[6];

        clueText[0] = "�Cu�ntas personas vivian en esta casa?\n �Cu�ntos monstruos rondan por aqu�?\n �Cu�ntas puertas hay bloqueadas?";
        clueText[1] = "Cuatro palancas se ocultan lejos,\r\ntras objetos sin igual,\r\nsi quieres la llave conseguir,\r\ndeber�s buscarlas ya.\r\n\r\nUna reposa en letras calladas,\r\ndonde un sabio duerme ya,\r\nsobre p�ginas gastadas,\r\nuna palanca encontrar�s.\r\n\r\nOtra habita en lo impensado,\r\ndonde el agua suele estar,\r\nen un trono abandonado,\r\ndonde los desechos iban a parar.\r\n\r\nUna m�s tras tu llegada,\r\ndonde todo comenz�,\r\nvuelve al punto de la nada,\r\ny ver�s qu� all� qued�.\r\n\r\nLa �ltima espera en cuna olvidada,\r\ndonde el sue�o fue eterno ayer,\r\nentre s�banas viejas y nana callada,\r\nun secreto podr�s ver";
        clueText[2] = "4 llaves es lo que buscas.";
        clueText[3] = "Texto pista diciendo que la palanca correcta es la esquina izquierda arriba";
        clueText[4] = "Text pista diciendo que la palanca correct es la esquina derecha abajo";
        clueText[5] = "Capo el que lee";
        
    }
    public void SetText(int clueNumber)
    {
        if (clueNumber == 1)
        {
            m_text.fontSize = 3.4f;
        }
        else { m_text.fontSize = 5; }

        Debug.Log(clueNumber);
        m_text.text = clueText[clueNumber];
        
    }
}
