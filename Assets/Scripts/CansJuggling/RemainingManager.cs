using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class RemainingManager : MonoBehaviour
{
    public int remaining = 3;
    private TextMeshProUGUI remainingText;

    // Start is called before the first frame update
    void Start()
    {
        remainingText = gameObject.GetComponent<TextMeshProUGUI>();
        remaining = CansConstant.nCans;
    }

    // Update is called once per frame
    void Update()
    {
        remainingText.text = $"Remaining: {remaining}";

        if (remaining == 0)
            ChangeScene();
    }

    public void DecreaseCount()
    {
        remaining -= 1;
    }

    void ChangeScene()
    {
        CansConstant.GameOver();
        SceneManager.LoadScene("CansResultScene");
    }
}
