using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manual : MonoBehaviour
{
    public void BackToAbout()
    {
        SceneManager.LoadScene("About");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }
}
