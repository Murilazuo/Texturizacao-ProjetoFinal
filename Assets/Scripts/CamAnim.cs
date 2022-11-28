using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamAnim : MonoBehaviour
{
    Animator anim;
    public static CamAnim instance;
    private void Awake()
    {
        instance = this;
        anim = GetComponent<Animator>();
    }
    public void SetAnim(int i)
    {
        anim.SetInteger("CamID", i);
        anim.SetTrigger("Trigger");
    }
    public void Clear()
    {
        anim.SetTrigger("Clear");
    }
}
