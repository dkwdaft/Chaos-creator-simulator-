using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class About : MonoBehaviour
{
    public void manual()
    {
        SceneManager.LoadScene("manual");
    }

    public void credits()
    {
        SceneManager.LoadScene("Thanks");
    }


    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
