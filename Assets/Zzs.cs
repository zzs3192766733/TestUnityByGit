using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zzs : MonoBehaviour
{
    public static int wcnm;
    public void FindSbWy()
    {
        this.transform.position = this.transform.position + new Vector3(1, 1, 1);
    }
    public void Zzsssb(string str)
    {
        Debug.Log("wcnm");
    }
    public static void Wcnm(int wcnm)
    {
        Zzs.wcnm = wcnm;
    }
}
