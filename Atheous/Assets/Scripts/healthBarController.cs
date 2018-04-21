using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBarController : MonoBehaviour
{
    private Image barImage;
    float healthPercent = PlayerController.health;

    void Start()
    {
        barImage = GetComponent<Image>();

  
    }

    public void updateHealth(float healthPercent)
    {
        barImage.fillAmount = healthPercent;
    }
}