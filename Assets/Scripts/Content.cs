using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Content : MonoBehaviour
{
    public GameObject[] items;
    private int num;
    // Start is called before the first frame update
    void Start()
    {
        num = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void switchModel()
    {
        for (int i = 0; i < items.Length; i++)
        {
            items[i].SetActive(false);
        }
        items[num].SetActive(true);
        Debug.Log("clicked model: " + num);
    }

    public void setNum(int newNum)
    {
        num = newNum;
    }

    public int getNum() { 
        return num;
    }
}
