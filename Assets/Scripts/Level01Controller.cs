﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level01Controller : MonoBehaviour {

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitLevel();
        }
    }
    public void ExitLevel()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
