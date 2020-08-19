using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
   private Image hpBar;
   public static float CurrentHealth;
   private float MaxHealth = GlobalCounter.health;

   private void Start() {
       
       hpBar = GetComponent<Image>();

       CurrentHealth = MaxHealth;

   }
   private void Update() {
       hpBar.fillAmount = CurrentHealth / MaxHealth;
   }
}
