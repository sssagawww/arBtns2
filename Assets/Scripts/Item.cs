using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IPointerClickHandler
{
    public string name;
    private Sprite sprite;
    public Image image;
    private Mesh combinedMesh;

    public GameObject model1;
    public GameObject model2;

    private int modelNumber;
    // Start is called before the first frame update
    void Start()
    {
        sprite = Resources.Load<Sprite>(name);
        image.sprite = sprite;

        modelNumber = 1;
        model1.SetActive(true);
        model2.SetActive(false);
        
        /*currentModel = Instantiate(model1, transform.position, transform.rotation) as GameObject;
        currentModel.transform.parent = transform;*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData data)
    {
        Debug.Log("click");
        //ChangeModel();
        ModelSwitch();
        //ScrollController.curObj = name;
        //spawnableObject = newObject;
    }

    private GameObject currentModel;

    /*public void ChangeModel()
    {
        if (currentModel == model1)
        {
            GameObject thisModel = Instantiate(model2, transform.position, transform.rotation) as GameObject;
            Destroy(currentModel);
            thisModel.transform.parent = transform;
            currentModel = thisModel;
        }
        else 
        {
            GameObject thisModel = Instantiate(model1, transform.position, transform.rotation) as GameObject;
            Destroy(currentModel);
            thisModel.transform.parent = transform;
            currentModel = thisModel;
        }
    }*/

    void ModelSwitch()
    {
        if (modelNumber == 1)
        {
            model1.SetActive(false);
            model2.SetActive(true);
            modelNumber = 2;
        }
        else if (modelNumber == 2)
        {
            model2.SetActive(false);
            model1.SetActive(true);
            modelNumber = 1;
        }
    }
}
