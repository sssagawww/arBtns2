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

    public GameObject spawnableObject;
    // Start is called before the first frame update
    void Start()
    {
        sprite = Resources.Load<Sprite>(name);
        image.sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData data)
    {
        ScrollController.curObj = name;
    }
}
