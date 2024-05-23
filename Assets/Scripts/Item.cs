using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IPointerClickHandler
{
    public int itemNum;
    public Content content;

    
    void Start()
    {        
        
    }

    
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData data)
    {
        Debug.Log("click");
        content.setNum(itemNum);
        content.switchModel();
    }

    private GameObject currentModel;
}
