using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaRRier : MonoBehaviour
{
    player play;

    void Start()
    {
        play = GameObject.Find("bad ball").GetComponent<player>();;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "bad ball")
        {
            play.GameOver();
        }
    }
}
