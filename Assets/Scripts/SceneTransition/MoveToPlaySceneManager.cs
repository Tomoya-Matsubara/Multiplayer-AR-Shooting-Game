using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToPlaySceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToShootingScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void MoveToJugglingScene()
    {
        SceneManager.LoadScene("CanShootScene");
    }
}
