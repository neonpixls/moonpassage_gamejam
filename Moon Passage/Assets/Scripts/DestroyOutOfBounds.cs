using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] UIController uiController;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("collision name" + collision.gameObject.name);



        if(collision.gameObject.CompareTag("Platform"))
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.CompareTag("DeathBox"))
        {          
            uiController.ShowGameOverScreen();            
        }
    }
}
