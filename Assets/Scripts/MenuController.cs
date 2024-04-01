using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject BtnPanel;
    public GameObject instructionPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Loader(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void LoadInstruction()
    {
        BtnPanel.SetActive(false);
        instructionPanel.SetActive(true);
    }

    public void OkBtnAction()
    {
        BtnPanel.SetActive(true);
        instructionPanel.SetActive(false);
    }
}
