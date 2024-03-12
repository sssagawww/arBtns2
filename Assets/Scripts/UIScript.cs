using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    private string btn;
    private bool canRotate;
    public GameObject Object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canRotate)
        {
            if (btn.ToUpper().Equals("X")){
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
        if(Object.isStatic) { 
        Object.SetActive(true);}
    }
}
