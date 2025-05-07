using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnim1 : MonoBehaviour
{
    public Animator anim1;
    void OnMouseDown()
    {
        anim1.SetTrigger("StartAnim1");
    }
}
