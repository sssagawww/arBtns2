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

    // Start is called before the first frame update
    void Start()
    {
        sprite = Resources.Load<Sprite>(name);
        image.sprite = sprite;

        UIScript.num = 1;
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
        UIScript.ModelSwitch();
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
}
