using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class UIScript : MonoBehaviour
{
    public Vector3 dir;
    private bool canRotate;
    private bool canPaint = false;
    private bool canSize;
    private float size = 0.2f;
    public GameObject Object;
    public Content content;
    public FlexibleColorPicker picker;
    private Color defaultColor;
    public ImageTargetBehaviour imageTarget;
    public Texture2D myImage;

    void Start()
    {
        GameObject _o = content.items[content.getNum()];
        for (int i = 0; i < _o.GetComponent<MeshRenderer>().materials.Length; i++)
        {
            if (_o.GetComponent<MeshRenderer>().materials[i].name.Equals(_o.name + " (Instance)"))
            {
                picker.color = _o.GetComponent<Renderer>().materials[i].color;
            }
        }
        defaultColor = picker.color;
    }

    void Update()
    {
        if (canPaint)
        {
            GameObject _o = content.items[content.getNum()];
            for (int i = 0; i < _o.GetComponent<MeshRenderer>().materials.Length; i++)
            {
                if(_o.GetComponent<MeshRenderer>().materials[i].name.Equals(_o.name + " (Instance)"))
                {
                    _o.GetComponent<MeshRenderer>().materials[i].color = picker.color;
                }
                Debug.Log("material of model: " + _o.GetComponent<MeshRenderer>().materials[i].name + " " + _o.name);
            }
        }
            
        if (canRotate)
        {
            content.items[content.getNum()].transform.Rotate(dir * 10);
        }

        if (canSize)
        {
            content.items[content.getNum()].transform.localScale += new Vector3(size, size, size);
        }
    }

    public void RotateModel()
    {
        canRotate = true;
    }

    public void resetColor()
    {
        GameObject _o = content.items[content.getNum()];
        for (int i = 0; i < _o.GetComponent<MeshRenderer>().materials.Length; i++)
        {
            if (_o.GetComponent<MeshRenderer>().materials[i].name.Equals(_o.name + " (Instance)"))
            {
               _o.GetComponent<MeshRenderer>().materials[i].color = defaultColor;
            }
        }
        picker.color = defaultColor;
//        changeColor();
    }

    public void SizeUpModel()
    {
        canSize = true;
        size = 0.2f;
    }
    public void SizeDownModel()
    {
        canSize = true;
        size = -0.2f;
    }

    public void stopSize()
    {
        canSize = false;
    }

    public void StopRotate()
    {
        canRotate = false;
    }

    public void changeColor()
    {
        setup();
        picker.gameObject.SetActive(!picker.gameObject.activeSelf);
    }

    public void SceneLoader(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void Hide()
    {
        content.items[content.getNum()].SetActive(!content.items[content.getNum()].activeSelf);
    }

    public void setup()
    {
        canPaint = !canPaint;
        GameObject _o = content.items[content.getNum()];
        for (int i = 0; i < _o.GetComponent<MeshRenderer>().materials.Length; i++)
        {
            if (_o.GetComponent<MeshRenderer>().materials[i].name.Equals(_o.name + " (Instance)"))
            {
                picker.color = _o.GetComponent<Renderer>().materials[i].color;
            }
        }
        defaultColor = picker.color;
    }
}