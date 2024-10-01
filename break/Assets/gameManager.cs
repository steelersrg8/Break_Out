using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public static int Life = 3;
    public static int score = 0;
    public GUISkin myGUISkin;
    public static GameObject theBall;
    public Transform Level1;
    public Transform Level2;
    public Transform Level3;
    public Transform Level4;

    bool islevel2beingplayed = false;
    bool islevel3beingplayed = false;
    bool islevel4beingplayed = false;


    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("theBall");
        Instantiate(Level1, Vector3.zero, Quaternion.identity);
    }


    void OnGUI()
    {

        GUI.skin = myGUISkin;
        GUI.Label(new Rect(40, 10, 120, 40), "Score :" + score);
        GUI.Label(new Rect(40, 30, 120, 40), "Lives:" + Life);
        if (Life == 0)
        {
            //stop the ball, repostion to center
            theBall.SendMessage("hasWon");
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 5, 240, 40), "You Have Lost");
            if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2, 60, 40), "Replay:"))
            {
                Life = 3;
                score = 0;
                SceneManager.LoadScene(1);

            }

        }
        //score should equal # of bricks in level 1
        if (score == 11)
        {
            if (islevel2beingplayed == false)
            {
                Instantiate(Level2, new Vector3(0, 0, 0), Quaternion.identity);
                theBall.SendMessage("resetBall");
                Life = Life + 1;
                islevel2beingplayed = true;
            }

        }
        //score should equal level 1 + level 2 bricks; now move on to level 3
        if (score == 33)
        {
            if (islevel3beingplayed == false)
            {
                Instantiate(Level3, new Vector3(0, 0, 0), Quaternion.identity);
                theBall.SendMessage("resetBall");
                Life = Life + 1;
                islevel3beingplayed = true;
            }

        }
        //now moving on to level 4
        if (score == 66)
        {
            if (islevel4beingplayed == false)
            {
                Instantiate(Level4, new Vector3(0, 0, 0), Quaternion.identity);
                theBall.SendMessage("resetBall");
                Life = Life + 1;
                islevel4beingplayed = true;
            }

        }
        //you beat level 4, now you win
        if (score == 110)
        {
            //stop the ball, repostion to center
            theBall.SendMessage("hasWon");
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 5, 240, 40), "You Have Won");
            if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2, 60, 40), "Replay:"))
            {
                Life = 3;
                score = 0;
                SceneManager.LoadScene(1);

            }

        }
    }
}