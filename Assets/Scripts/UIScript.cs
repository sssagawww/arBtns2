using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class UIScript : MonoBehaviour
{
    public Vector3 dir;
    private bool canRotate;
    private bool canSize;
    private float size = 0.2f;
    public GameObject Object;
    string path;
    public Content content;
    public FlexibleColorPicker picker;
    //private MeshRenderer mRenderer;
    //private ImageTargetBehaviour imageTarget;
    //private DefaultObserverEventHandler eventHandler;

    void Start()
    {
        picker.color = content.items[content.getNum()].GetComponent<Renderer>().material.color;
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
        content.items[content.getNum()].GetComponent<Renderer>().material.color = picker.color;
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