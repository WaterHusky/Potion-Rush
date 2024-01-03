using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;

    public float movSpeed;

    public int points;
    public static int _points;
    public float startTime;
    public static float currentTime;

    public Text pointText;
    public Text timeText;

    public static bool dead;

    public GameObject popup;
    public static bool showingPopup;
    public float popupTimer;
    public static float currentPopupTimer;

    public void Start()
    {
        currentTime = startTime;
        dead = false;
        currentPopupTimer = popupTimer;
    }

    public void Update()
    {
        _points = points;
        animator.SetFloat("Speed", Mathf.Abs(0f));
        if (!dead)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Time.deltaTime * movSpeed);
                animator.SetFloat("Speed", Mathf.Abs(0.1f));
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Time.deltaTime * movSpeed);
                animator.SetFloat("Speed", Mathf.Abs(0.1f));
            }
                

            pointText.GetComponent<Text>().text = "Points: " + points;
            timeText.GetComponent<Text>().text = "Time Left: " + currentTime;
        }

        currentTime -= 1 * Time.deltaTime;
        if (currentTime <= 0)
            dead = true;

        TakeCareOfPopup();
    }

    public void TakeCareOfPopup()
    {
            if (showingPopup)
                popup.SetActive(true);
            else
                popup.SetActive(false);

        if (showingPopup)
            StartCoroutine("Timer");
        else
            StopCoroutine("Timer");
        
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(popupTimer);
        showingPopup = false;
    }
}
