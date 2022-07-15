using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CansResultManagaer : MonoBehaviour
{
    private TextMeshProUGUI resultText;

    // Start is called before the first frame update
    void Start()
    {
        resultText = gameObject.GetComponent<TextMeshProUGUI>();

        
        resultText.text = CansConstant.clear ? "Cleared " : "Failed ";
        resultText.text += $"{CansConstant.nCans} Can";

        if (CansConstant.nCans > 1)
            resultText.text += "s";

        resultText.text += CansConstant.clear ? "!" : "...";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
