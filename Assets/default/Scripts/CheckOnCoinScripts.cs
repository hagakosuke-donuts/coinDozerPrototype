using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOnCoinScripts : MonoBehaviour
{

    [SerializeField] private GameObject coinStage; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            other.transform.SetParent(coinStage.transform,true);
            Debug.Log("当たった");
        }
    }
}
