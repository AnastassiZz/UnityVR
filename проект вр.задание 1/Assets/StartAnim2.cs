using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnim2 : MonoBehaviour
{
    public Animator anim2;
    void OnMouseDown()
    {
        anim2.SetTrigger("StartAnim2");
    }
}
