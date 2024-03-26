using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CreateIT : MonoBehaviour
{
    private string path;
    public string targetName;
    public GameObject gameObject;
    void Start()
    {
        gameObject.SetActive(false);
        path = LoadImage.imagePath;
        VuforiaApplication.Instance.OnVuforiaStarted += CreateImageTargetFromSideloadedTexture;
    }
    void CreateImageTargetFromSideloadedTexture()
    {
        gameObject.SetActive(true);
        WWW www = new WWW("file:///" + path);
        var mTarget = VuforiaBehaviour.Instance.ObserverFactory.CreateImageTarget(www.texture, 1f, targetName);
        mTarget.gameObject.AddComponent<DefaultObserverEventHandler>();
        Debug.Log("Instant Image Target created " + mTarget.TargetName);
    }
}
