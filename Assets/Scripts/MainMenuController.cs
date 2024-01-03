using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{



    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    void Update()
    {

    }

    public void doExitGame()
    {
        Application.Quit();
    }
}
