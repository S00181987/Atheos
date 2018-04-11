using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

//Credit to Philip D' Arcy Y3 Games
public class HealthBarController : MonoBehaviour
{
    private Image barImage;

    void Start()
    {
        barImage = GetComponent<Image>();
    }

    public void UpdateHealth(float health)
    {
        barImage.fillAmount = health;
    }
}
