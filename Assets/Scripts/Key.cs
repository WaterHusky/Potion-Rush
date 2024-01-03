using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Key : MonoBehaviour
{
    GameObject player;


    public bool rotten;

    public int points;
    public float movSpeed;

    public GameObject Spawnermanager;
    public Transform playerPointText;


    public void Start()
    {
        player = GameObject.FindWithTag("Player");
        Spawnermanager = GameObject.Find("Spawners");
        playerPointText = player.transform.GetChild(0);

    }


    public void Update()
    {
        if(!playerPointText)
            playerPointText = player.transform.GetChild(0);

        transform.Translate(Vector3.down * Time.deltaTime * movSpeed);
        if (player)
            Debug.Log("Player cannot be found: Make sure to tag the player as 'Player'");
        //increase diffculuty
        if(Player._points >= 50 && Player._points < 100)
        {
            movSpeed = 6;
        }
        if (Player._points >= 100 && Player._points < 150)
        {
            movSpeed = 7;
        }
        if (Player._points >= 150 && Player._points < 250)
        {
            movSpeed = 8;
            points = 25;
            Spawnermanager.GetComponent<Spawnermanager>().waitTimer = 1.2f;
        }
        if (Player._points >= 250 && Player._points < 400)
        {
            movSpeed = 10;
            player.GetComponent<Player>().movSpeed = 10;
            Spawnermanager.GetComponent<Spawnermanager>().waitTimer = 1.1f;
            Spawnermanager.GetComponent<Spawnermanager>().rottenIngredientPercent = 0.2f;
        }
        if (Player._points >= 400 && Player._points < 600)
        {
            movSpeed = 12;
            player.GetComponent<Player>().movSpeed = 11;
            points = 50;
            Spawnermanager.GetComponent<Spawnermanager>().waitTimer = 0.9f;
        }
        if (Player._points >= 600 && Player._points < 1000)
        {
            movSpeed = 15;
            player.GetComponent<Player>().movSpeed = 12;
            Spawnermanager.GetComponent<Spawnermanager>().waitTimer = 0.8f;
            Spawnermanager.GetComponent<Spawnermanager>().rottenIngredientPercent = 0.4f;
        }
        if (Player._points >= 1000)
        {
            movSpeed = 20;
            player.GetComponent<Player>().movSpeed = 20;
            Spawnermanager.GetComponent<Spawnermanager>().waitTimer = 0.7f;
            Spawnermanager.GetComponent<Spawnermanager>().rottenIngredientPercent = 0.5f;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.GetComponent<Player>().points += points;
            if (!playerPointText)
                playerPointText = player.transform.GetChild(0);
            if (!rotten)
            {
                playerPointText.GetComponent<TextMeshPro>().text = "+" + points;
                Player.currentTime += 1.5f;
            }
            else
            {
                playerPointText.GetComponent<TextMeshPro>().text = "-" + points;
                Player.currentTime += 0.5f;
            }

            Player.showingPopup = true;
            Destroy(this.gameObject);
        }
    }
}
