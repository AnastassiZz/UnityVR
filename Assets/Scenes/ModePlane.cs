using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModePlane : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Renderer>().material.color = new Color32(74, 135, 93, 1);
    }

}