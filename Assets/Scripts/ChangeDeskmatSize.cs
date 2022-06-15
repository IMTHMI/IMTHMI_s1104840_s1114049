using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDeskmatSize : MonoBehaviour
{
    bool hasChanged;
    GameObject primitive;
    public GameObject yourObject;
    public GameObject assemblyObj;
    int pastSize;
    int currentSize;

    private void Swap()
    {
        if (pastSize==0)
        {
            primitive = GameObject.CreatePrimitive(PrimitiveType.Cube);
            primitive.transform.parent = assemblyObj.transform;
            primitive.transform.localPosition = new Vector3(0, 0, 0);
            primitive.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        


        switch (currentSize)
        {
            case 0:
                Destroy(primitive);
                yourObject.SetActive(true);
                return;
            case 1:
                primitive.transform.localScale = new Vector3(0.3f, 0.001f, 0.3f);

                break;
            case 2:
                primitive.transform.localScale = new Vector3(0.4f, 0.001f, 0.3f);

                break;
            case 3:
                primitive.transform.localScale = new Vector3(0.6f, 0.001f, 0.3f);

                break;
            case 4:
                primitive.transform.localScale = new Vector3(0.6f, 0.001f, 0.4f);

                break;

            case 5:
                primitive.transform.localScale = new Vector3(0.9f, 0.001f, 0.3f);

                break;

            case 6:
                primitive.transform.localScale = new Vector3(0.9f, 0.001f, 0.4f);

                break;

            case 7:
                primitive.transform.localScale = new Vector3(0.9f, 0.001f, 0.5f);

                break;

            default:
                break;
        }

        yourObject.SetActive(false);
    }

    public void IncreaseSize()
    {
        pastSize = currentSize++;
        Swap();
    }

    public void DecreaseSize()
    {
        pastSize = currentSize--;
        Swap();
    }

    public void Reset()
    {
        currentSize = 0;
        Swap();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
