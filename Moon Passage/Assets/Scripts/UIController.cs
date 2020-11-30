using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] Text distanceTraveled;
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] Player player;
       

    //[SerializeField] GameObject gameMusic;

    public void ShowGameOverScreen()
    {
        player.playerIsAlive = false;
        gameOverScreen.SetActive(true);
        //gameMusic.SetActive(false);
        float roundedDistance = Mathf.Ceil(player.distanceTraveled);
        distanceTraveled.text = roundedDistance.ToString();             
    }

    public void GameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
