using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public int x;
    public int y;
    public int z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        x = Random.Range(0, 255);
        y = Random.Range(0, 255);
        z = Random.Range(0, 255);
        this.GetComponent<Renderer>().material.color = new Color32((byte)x, (byte)y, (byte)z, 1);
    }
}
