using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeDeskmatSize : MonoBehaviour
{
    bool hasChanged;
    GameObject primitive;
    [SerializeField] TextMeshPro sizesText;
    public Material deskmatMaterial;
    public List<List<int>> sizingList;
    int pastSize;
    int currentSize;

    private void Swap()
    {
        primitive.transform.localScale = new Vector3(sizingList[currentSize][0]/(float)1000, 0.001f, sizingList[currentSize][1]/(float)1000);
        sizesText.text = sizingList[currentSize][0] + "mm x " + sizingList[currentSize][1] + "mm";
    }

    public void IncreaseSize()
    {
        if (currentSize < 25)
        {
            pastSize = currentSize++;
            Swap();
        }
    }

    public void DecreaseSize()
    {
        if (currentSize > 0)
        {
            pastSize = currentSize--;
            Swap();
        }

    }

    public void Reset()
    {
        currentSize = 1;
        Swap();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Fill list with all available sizes
        sizingList = new List<List<int>> {
            new List<int> { 300, 300 },
            new List<int> { 400, 300 },
            new List<int> { 600, 300 },
            new List<int> { 600, 400 },
            new List<int> { 900, 300 },
            new List<int> { 900, 400 },
            new List<int> { 900, 500 },
            new List<int> { 900, 600 },
            new List<int> { 900, 700 },
            new List<int> { 1000, 300 },
            new List<int> { 1000, 400 },
            new List<int> { 1000, 500 },
            new List<int> { 1000, 600 },
            new List<int> { 1000, 700 },
            new List<int> { 1200, 300 },
            new List<int> { 1200, 400 },
            new List<int> { 1200, 500 },
            new List<int> { 1200, 600 },
            new List<int> { 1200, 700 },
            new List<int> { 1200, 800 },
            new List<int> { 1200, 900 },
            new List<int> { 1500, 600 },
            new List<int> { 1500, 700 },
            new List<int> { 1500, 800 },
            new List<int> { 1500, 900 },
        };

        // Create deskmat cube object
        primitive = GameObject.CreatePrimitive(PrimitiveType.Cube);
        primitive.transform.parent = gameObject.transform;
        primitive.transform.localPosition = new Vector3(0, 0, 0);
        primitive.transform.localRotation = Quaternion.Euler(0, 0, 0);
        primitive.GetComponent<Renderer>().material = deskmatMaterial;

        // Set sizing based on first item in the list
        Swap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
