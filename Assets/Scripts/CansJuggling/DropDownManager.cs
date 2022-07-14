using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropDownManager : MonoBehaviour
{
    private TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        dropdown = gameObject.GetComponent<TMP_Dropdown>();
    }

    // Update is called once per frame
    void Update()
    {
        CansConstant.SetNumberOfCans(dropdown.value + 1);
    }
}
