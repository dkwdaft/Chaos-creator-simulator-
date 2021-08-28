using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevalManager : MonoBehaviour
{

    public List<intractableObject> brokenObjets;
    public List<intractableObject> AllObjets;
    public static int points;

    public Text Score;
    public Text TimeText;
    public float Time = 100;
    int players = 0;
    bool timeing = false;

    private void Start()
    {
        Time = 100;
        timeing = false;
    }

    public int joinPlayer()
    {
        players++;

        if (!timeing)
        {
            Debug.Log("stert colk");
            InvokeRepeating("count",1f,1f);
            timeing = true;
        }
        Debug.Log("jionplayer");

        return players;

    }


    void count()
    {
        Time--;

        TimeText.text = "Time :" + Time.ToString();

        if (Time == 0)
        {
            SceneManager.LoadScene("GameOver");


        }

    }

    public intractableObject FinedBroken()
    {
        UpdateScore();
        if(brokenObjets.Count != 0)
        {

            int t = Random.Range(0, brokenObjets.Count -1);


            brokenObjets.RemoveAt(t);

            return brokenObjets[t];
        }
        else
        {

            return null;
        }



        
    }

    public void UpdateScore()
    {
        int s = 0;


       
        foreach (var item in AllObjets)
        {

                if (item.objectState == state.Destroyed)
                {
                    s += item.PointValue;

                }
                
        }
         
       


        points = s;

        Score.text ="Score :" + points.ToString(); ;
    }


}
