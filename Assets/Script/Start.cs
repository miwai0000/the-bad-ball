using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{

    void Awake()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            begin();
        }
    }

    public void begin()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
