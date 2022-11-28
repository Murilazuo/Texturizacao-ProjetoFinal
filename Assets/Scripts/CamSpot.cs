using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSpot : MonoBehaviour
{
    [SerializeField] int id;
    CamAnim camAnim;
    private void Start()
    {
        camAnim = CamAnim.instance;
    }
    private void OnMouseDown()
    {
        camAnim.SetAnim(id);
    }
}
