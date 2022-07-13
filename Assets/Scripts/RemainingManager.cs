using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RemainingManager : MonoBehaviour
{
    public int remaining = 3;
    private TextMeshProUGUI remainingText;

    // Start is called before the first frame update
    void Start()
    {
        remainingText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        remainingText.text = $"Remaining: {remaining}";
    }

    public void DecreaseCount()
    {
        remaining -= 1;
    }
}
