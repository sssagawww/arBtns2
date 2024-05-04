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
    string path;
    public Content content;
    public FlexibleColorPicker picker;
    private Color defaultColor;
    //private MeshRenderer mRenderer;
    //private ImageTargetBehaviour imageTarget;
    //private DefaultObserverEventHandler eventHandler;

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
        path = LoadImage.imagePath;
        //imageTarget = GameObject.FindWithTag("imageTag");
        //mRenderer = imageTarget.GetComponent<MeshRenderer>();
        WWW www = new WWW("file:///" + path);
        //imageTarget = VuforiaBehaviour.Instance.ObserverFactory.CreateImageTarget(www.texture, 1f, "loadedImg");
        //imageTarget.gameObject.AddComponent<DefaultObserverEventHandler>();
        //imageTarget = www.texture;
        //eventHandler = imageTarget.GetComponent<DefaultObserverEventHandler>();
        //imageTarget.Image = www.texture;

        //mRenderer.material.mainTexture = www.texture;
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
            /* if (btn.ToUpper().Equals("X"))
             {
                 content.items[content.getNum()].transform.Rotate(Vector3.right * 10);
             }*/
            //if (btn.ToUpper().Equals("Y"))
            //{
            content.items[content.getNum()].transform.Rotate(dir * 10);
            //}
            //Debug.Log("clicked model: " + content.items[content.getNum()]);
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
        changeColor();
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
        canPaint = !canPaint;
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

    /*public static void ModelSwitch()
    {
        if (num == 1)
        {
            objects[num-1].SetActive(false);
            objects[num].SetActive(true);
            num = 2;
        }
        else if (num == 2)
        {
            objects[num].SetActive(false);
            objects[num-1].SetActive(true);
            num = 1;
        }
    }*/
}