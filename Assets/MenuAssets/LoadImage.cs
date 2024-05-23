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

    public void OpenExplorer()
    {
        NativeGallery.GetImageFromGallery((path) =>
        {
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
        imagePath = path;
        Debug.Log("path: " + path);
    }
}