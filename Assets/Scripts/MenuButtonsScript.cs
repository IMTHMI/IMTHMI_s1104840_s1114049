using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuButtonsScript : MonoBehaviour
{
    public GameObject objectToSpawn;
    [SerializeField] TextMeshPro sizesText;

    public void Start()
    {
        objectToSpawn.SetActive(false);
    }

    public void NieuweMat()
    {
        objectToSpawn.SetActive(true);
        sizesText.text = "1500mm" + "x" + "1500mm";
        // Instantiate(objectToSpawn, GameObject.Find("Spawner").transform.position, GameObject.Find("Spawner").transform.rotation);
    }

    public void VerwijderMat()
    {
        objectToSpawn.SetActive(false);
        Debug.Log("Verwijder mat!");
    }
}
