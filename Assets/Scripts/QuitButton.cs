﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour {
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(Quit);
    }

    void Quit()
    {
        Application.Quit();
    }
}
