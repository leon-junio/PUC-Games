using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{

    public void startScreen(string sceneName)
    {
        //carrega cena para visualização
        SceneManager.LoadScene(sceneName);
    }

}
