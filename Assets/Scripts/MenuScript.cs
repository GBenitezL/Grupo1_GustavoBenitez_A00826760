using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
