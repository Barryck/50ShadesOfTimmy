﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJam.SceneManagement;
using GameJam.Setup;

namespace GameJam
{
    /// <summary>
    /// Initializer called from initializer scene. Just sends the game to main menu with managers loaded in 
    /// memory
    /// </summary>
    public class GJ_Initializer : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
            GJ_SceneLoader.Instance.LoadSceneAsync(GJ_SceneSetup.SCENES.MAIN_MENU);
        }

    }

}