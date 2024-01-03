using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPopup : MonoBehaviour
{
    public float timer;


    public void Start()
    {

        StartCoroutine("Timer");
    }


    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1);
        Disable();
    }

    public void Disable()
    {
        StopCoroutine("Timer");
        this.gameObject.SetActive(false);
    }

}
