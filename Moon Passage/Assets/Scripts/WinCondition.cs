using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    [SerializeField] UIController uiController;

    private void OnCollisionEnter2D(Collision2D collision)
    {     
        if (collision.gameObject.CompareTag("Win"))
        {
            //Debug.Log("win!!!");            
            uiController.WinGameScreen();
        }
    }
}
