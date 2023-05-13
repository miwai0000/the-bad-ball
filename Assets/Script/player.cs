using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float speed;
    public float turnspeed;
    float tspeed;
    float tturnspeed;
    float x;
    bool fallMove = false;
    GameObject LoseUI;
    GameObject WinUI;
    bool stop = false;

    void Awake()
    {
        LoseUI = GameObject.Find("loseUI");
        WinUI = GameObject.Find("EndUI");
    }
    
    void Update()
    {

        tspeed = speed;
        tturnspeed = turnspeed;
        x = 0;

        //����
        if (Input.GetKey(KeyCode.A))
        {
            leftmove();
        }
        if (Input.GetKey(KeyCode.D))
        {
            rightmove();
        }
        if (Input.GetKey(KeyCode.J))
        {
            addspeed();
        }
        if (Input.GetKey(KeyCode.K))
        {
            unaddspeed();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exit();
        }


        //λ��
        if(!fallMove)
        {
            transform.Translate( x * tturnspeed * Time.deltaTime, 0, tspeed * Time.deltaTime );
        }
        

        //׹��
        if(transform.position.x <-4.5 || transform.position.x >4.5)
        {
            transform.Translate(0, -10 * Time.deltaTime, 0);
            fallMove = true;
        }

        if(transform.position.y<-20)
        {
            GameOver();
        }

        //����
        if(stop)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Restart();
                return;
            }
        }

    }

    public void leftmove()
    {
        x -= 1;
    }

    public void rightmove()
    {
        x += 1;
    }

    public void addspeed()
    {
        tspeed *= 2;
    }

    public void unaddspeed()
    {
        tturnspeed /= 2f;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void exit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        LoseUI.SetActive(true);
        stop = true;
    }

    public void Win()
    {
        Time.timeScale = 0;
        WinUI.SetActive(true);
        stop = true;
    }
}
