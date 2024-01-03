using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrogUI : MonoBehaviour
{
    GameObject player;
    public Image FrogUI1, FrogUI2, FrogUI3, FrogUI4, FrogUI5, FrogUI6, FrogUI7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player._points >= 50 && Player._points < 100)
        {
            FrogUI1.enabled = true;
            FrogUI2.enabled = false;
            FrogUI3.enabled = false;
            FrogUI4.enabled = false;
            FrogUI5.enabled = false;
            FrogUI6.enabled = false;
            FrogUI7.enabled = false;
        }
        if (Player._points >= 100 && Player._points < 150)
        {
            FrogUI1.enabled = true;
            FrogUI2.enabled = true;
            FrogUI3.enabled = false;
            FrogUI4.enabled = false;
            FrogUI5.enabled = false;
            FrogUI6.enabled = false;
            FrogUI7.enabled = false;
        }
        if (Player._points >= 150 && Player._points < 250)
        {
            FrogUI1.enabled = true;
            FrogUI2.enabled = true;
            FrogUI3.enabled = true;
            FrogUI4.enabled = false;
            FrogUI5.enabled = false;
            FrogUI6.enabled = false;
            FrogUI7.enabled = false;
        }
        if (Player._points >= 250 && Player._points < 400)
        {
            FrogUI1.enabled = true;
            FrogUI2.enabled = true;
            FrogUI3.enabled = true;
            FrogUI4.enabled = true;
            FrogUI5.enabled = false;
            FrogUI6.enabled = false;
            FrogUI7.enabled = false;
        }
        if (Player._points >= 400 && Player._points < 600)
        {
            FrogUI1.enabled = true;
            FrogUI2.enabled = true;
            FrogUI3.enabled = true;
            FrogUI4.enabled = true;
            FrogUI5.enabled = true;
            FrogUI6.enabled = false;
            FrogUI7.enabled = false;
        }
        if (Player._points >= 600 && Player._points < 1000)
        {
            FrogUI1.enabled = true;
            FrogUI2.enabled = true;
            FrogUI3.enabled = true;
            FrogUI4.enabled = true;
            FrogUI5.enabled = true;
            FrogUI6.enabled = true;
            FrogUI7.enabled = false;
        }
        if (Player._points >= 1000)
        {
            FrogUI1.enabled = true;
            FrogUI2.enabled = true;
            FrogUI3.enabled = true;
            FrogUI4.enabled = true;
            FrogUI5.enabled = true;
            FrogUI6.enabled = true;
            FrogUI7.enabled = true;
        }
    }
}
