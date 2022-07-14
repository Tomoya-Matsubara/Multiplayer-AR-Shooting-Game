using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnHomeManager : MonoBehaviour
{
    [SerializeField] private GameObject confirmPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        confirmPanel.SetActive(true);
    }

    public void YesButonTapped()
    {
        SceneManager.LoadScene("BulletSelectScene");
    }

    public void NoButtonTapped()
    {
        confirmPanel.SetActive(false);
    }
}
