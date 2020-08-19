using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class MainButtonClick : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton() {
        GlobalCounter.health -= 1;

        int randomNumber = UnityEngine.Random.Range(1, 6);

        GlobalCash.Cash += randomNumber;
        HealthBar.CurrentHealth -=1;
    }
}
