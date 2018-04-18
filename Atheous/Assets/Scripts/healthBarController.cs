using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBarController : MonoBehaviour
{
    private Image barImage;

    void Start()
    {
        barImage = GetComponent<Image>();
  
    }

    public void updateHealth(float health)
    {
        barImage.fillAmount = health;
    }
}