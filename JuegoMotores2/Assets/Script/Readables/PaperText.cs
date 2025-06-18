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

        clueText[0] = "¿Cuántas personas vivian en esta casa?\n ¿Cuántos monstruos rondan por aquí?\n ¿Cuántas puertas hay bloqueadas?";
        clueText[1] = "Cuatro palancas se ocultan lejos,\r\ntras objetos sin igual,\r\nsi quieres la llave conseguir,\r\ndeberás buscarlas ya.\r\n\r\nUna reposa en letras calladas,\r\ndonde un sabio duerme ya,\r\nsobre páginas gastadas,\r\nuna palanca encontrarás.\r\n\r\nOtra habita en lo impensado,\r\ndonde el agua suele estar,\r\nen un trono abandonado,\r\ndonde los desechos iban a parar.\r\n\r\nUna más tras tu llegada,\r\ndonde todo comenzó,\r\nvuelve al punto de la nada,\r\ny verás qué allí quedó.\r\n\r\nLa última espera en cuna olvidada,\r\ndonde el sueño fue eterno ayer,\r\nentre sábanas viejas y nana callada,\r\nun secreto podrás ver";
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
