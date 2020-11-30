using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Oxygen : MonoBehaviour
{
    
    public Slider oxygenBar;
    public float oxygenAmount;   
    private float currentOxygen;

    [SerializeField] UIController uiController;  


    void Start()
    {
        currentOxygen = oxygenAmount;        
    }

    void Update()
    {
        currentOxygen -= Time.deltaTime;
        //Debug.Log(currentOxygen);
        oxygenBar.value = currentOxygen / oxygenAmount;

        if(currentOxygen <= 0)
        {            
            uiController.ShowGameOverScreen();
        }
    }

    



}
