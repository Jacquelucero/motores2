using Unity.VisualScripting;
using UnityEngine;

public class CerrarPanelUI : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.SetActive(false);
        }

    }
}
