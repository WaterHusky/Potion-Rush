using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_Loader : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Potion Rush");
    }
}
