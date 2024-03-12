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
    public SceneAsset scene;

    public void OpenExplorer()
    {
        path = EditorUtility.OpenFilePanel("Overwrite with png", "", "png");
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
        mRenderer = (MeshRenderer)FindFirstObjectByType(typeof(MeshRenderer));
        WWW www = new WWW("file:///" + path);
        mRenderer.material.mainTexture = www.texture;
    }
}