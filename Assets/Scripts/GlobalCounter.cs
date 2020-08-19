using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCounter : MonoBehaviour
{
    public static int health = 100;
    public GameObject HealthDis;
    public int InternalHealth;
    void Update()
    {
        //health
        InternalHealth = health;
        HealthDis.GetComponent<Text>().text = "HP: " + InternalHealth;


    }
}
