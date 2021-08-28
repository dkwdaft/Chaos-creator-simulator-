using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class about : MonoBehaviour
{
    // Start is called before the first frame update
    public void Back()
    {


        SceneManager.LoadScene(0);


    }
    public void Manual()
    {


        SceneManager.LoadScene("manual");

    }
    public void Thanks()
    {
        SceneManager.LoadScene("thanks");



    }




}
