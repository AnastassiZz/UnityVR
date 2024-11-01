using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRtest : MonoBehaviour
{
    public GameObject Test;
    public int x = 0;
    public Text Mytxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        x++;
        if (x >= 101)
        {
            Test.SetActive(false);
        }
        Mytxt.text = x.ToString();
    }
}
