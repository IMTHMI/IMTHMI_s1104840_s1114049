using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonsScript : MonoBehaviour
{
    public GameObject objectToSpawn;

    public void Start()
    {
        objectToSpawn.SetActive(false);
    }

    public void NieuweMat()
    {
        objectToSpawn.SetActive(true);
        // Instantiate(objectToSpawn, GameObject.Find("Spawner").transform.position, GameObject.Find("Spawner").transform.rotation);
    }

    public void VerwijderMat()
    {
        objectToSpawn.SetActive(false);
        Debug.Log("Verwijder mat!");
    }
}
