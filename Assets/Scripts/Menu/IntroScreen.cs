﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.Events;

public class IntroScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            
            SceneManager.LoadScene("Level01");
        }

    }
}
