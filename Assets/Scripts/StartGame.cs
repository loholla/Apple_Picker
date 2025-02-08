using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void startGame(){
        Scene activeScene = SceneManager.GetActiveScene();
        switch(activeScene.name){
            case "Game":
                SceneManager.LoadScene("MainMenu");
                break;
            case "MainMenu":
                SceneManager.LoadScene("Game");
                break;
        }
    }
}
