using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using Vuforia;


public class LoadImage : MonoBehaviour
{
    string path;
    public MeshRenderer mRenderer;
    public GameObject Object;
    public static string imagePath;
    //public AssetReference scene;

    public void OpenExplorer()
    {
        //path = EditorUtility.OpenFilePanel("Overwrite with png", "", "png");
        NativeGallery.GetImageFromGallery((path) =>
        {
            //UploadNewProfileImage(path);
            this.path = path;
        });
        GetImage();
    }

    void GetImage()
    {
        if (path != null)
        {
            UpdateImage();
        }
    }

    void UpdateImage()
    {
        //mRenderer = (MeshRenderer)FindFirstObjectByType(typeof(MeshRenderer));
        /*Object = GameObject.FindWithTag("imageTag");
        mRenderer = Object.GetComponent<MeshRenderer>();
        WWW www = new WWW("file:///" + path);
        mRenderer.material.mainTexture = www.texture;*/
        imagePath = path;
        Debug.Log("path: " + path);
    }
}