using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnermanager : MonoBehaviour
{
    public int spawns;
    public Transform[] spawn;
    public Transform chosenSpawnObj;

    public float waitTimer;
    public static float _waitTimer;
    public float rottenIngredientPercent;


    public static bool spawnRottenIngredient;
    public static int chosenSpawn;

    public GameObject Ingredient;
    public GameObject Ingredient2;
    public GameObject Ingredient3;
    public GameObject Ingredient4;
    public GameObject Ingredient5;
    public GameObject rottenIngredient;

    public void Start()
    {
        spawn = new Transform[14];
        spawns = this.transform.childCount;
        for (int i = 0; i < spawns; i++)
            spawn[i] = this.transform.GetChild(i);

        _waitTimer = waitTimer;
    }


    public void Update()
    {
        if (Player.currentTime > 0)
        {
            if (_waitTimer > 0)
                _waitTimer -= 1 * Time.deltaTime;
            else
                Spawn();
        }
    }

    public void Spawn()
    {
        /// Randomly chooses spot
        chosenSpawn = Random.Range(0, spawns);
        chosenSpawnObj = spawn[chosenSpawn];

        /// Randomly generates a item
        if (Random.value < rottenIngredientPercent)
            spawnRottenIngredient = true;

        //spawn key
        Vector3 pos = new Vector3(chosenSpawnObj.position.x, chosenSpawnObj.position.y - 1.5f, chosenSpawnObj.position.z);
        if (spawnRottenIngredient)
            Instantiate(rottenIngredient, pos, Quaternion.identity);
        else if (Random.value > 0.2f && Random.value < 0.3f)
            Instantiate(Ingredient, pos, Quaternion.identity);
        else if (Random.value > 0.3f && Random.value < 0.4f)
            Instantiate(Ingredient2, pos, Quaternion.identity);
        else if (Random.value > 0.4f && Random.value < 0.5f)
            Instantiate(Ingredient3, pos, Quaternion.identity);
        else if (Random.value > 0.5f && Random.value < 0.6f)
            Instantiate(Ingredient4, pos, Quaternion.identity);
        else if (Random.value > 0.6f && Random.value < 0.7f)
            Instantiate(Ingredient4, pos, Quaternion.identity);

        spawnRottenIngredient = false;
        _waitTimer = waitTimer;
    }
}
