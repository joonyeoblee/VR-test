using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] float lifeTIme = 5f;
    void Start()
    {
        Destroy(gameObject, lifeTIme);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
