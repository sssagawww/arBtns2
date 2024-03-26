using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class UIScript : MonoBehaviour
{
    private string btn;
    private bool canRotate;
    public GameObject Object;
    string path;
    public MeshRenderer mRenderer;
    public ImageTargetBehaviour imageTarget;
    private DefaultObserverEventHandler eventHandler;

    void Start()
    {
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
        if (canRotate)
        {
            if (btn.ToUpper().Equals("X"))
            {
                transform.Rotate(Vector3.right * 10);
            }
            if (btn.ToUpper().Equals("Y"))
            {
                transform.Rotate(Vector3.up * 10);
            }
        }
    }

    public void RotateModel(string btn)
    {
        this.btn = btn;
        canRotate = true;
    }

    public void StopRotate()
    {
        canRotate = false;
    }

    public void SceneLoader(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void Hide()
    {
        if (Object.isStatic)
        {
            Object.SetActive(true);
        }
    }
}