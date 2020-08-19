using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    public static int Cash = 100;
    public GameObject CashDis;
    public int InternalCash;
    void Update()
    {
        InternalCash = Cash;
      CashDis.GetComponent<Text>().text = "$: " + InternalCash;  
    }
}
