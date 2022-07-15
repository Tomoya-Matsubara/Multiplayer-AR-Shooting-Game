using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CansExistenceManager : MonoBehaviour
{
    [SerializeField] private int ID;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"{CansConstant.nCans} > {ID}?");

        if (ID > CansConstant.nCans)
        {
            gameObject.SetActive(false);
            // Debug.Log("hoge");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
