using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuButtonsScript : MonoBehaviour
{
    public GameObject objectToSpawn;
    [SerializeField] TextMeshPro sizesText;
    public string sizeOne = "1500";
    public string sizeTwo = "1500";

    public void Start()
    {
        objectToSpawn.SetActive(false);
    }

    public void NieuweMat()
    {
        objectToSpawn.SetActive(true);
        sizesText.text = sizeOne + "mm x " + sizeTwo + "mm";
        // Instantiate(objectToSpawn, GameObject.Find("Spawner").transform.position, GameObject.Find("Spawner").transform.rotation);
    }

    public void VerwijderMat()
    {
        objectToSpawn.SetActive(false);
        Debug.Log("Verwijder mat!");
    }
}
