using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    GameObject endUI;
    GameObject LostUI;
    player play;

    void Awake()
    {
        endUI = GameObject.Find("EndUI");
        LostUI = GameObject.Find("loseUI");
        play = GameObject.Find("bad ball").GetComponent<player>();
        

    }

    void Start()
    {
        endUI.SetActive(false);
        LostUI.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.name == "bad ball")
        {
            play.Win();
        }
    }
}
