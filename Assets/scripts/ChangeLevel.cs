﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{

    public void level1()
    {
        SceneManager.LoadScene("Level1");
    }
}
