using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class HealthBar : MonoBehaviour
{
    private RectTransform bar;
    private UnityEngine.UI.Image barImage;

    void Start()
    {
        bar = GetComponent<RectTransform>();
        barImage = GetComponent<UnityEngine.UI.Image>();
        if (Health.totalHealth < 0.3f)
        {
            barImage.color = Color.red;
        }
        SetSize(Health.totalHealth);
    }

    public void Damage(float damage)
    {
        if ((Health.totalHealth -= damage) >= 0f)
        {
            Health.totalHealth -= damage;
        }
        else
        {
            Health.totalHealth = 0f;
        }
        if (Health.totalHealth < 0.3f)
        {
            barImage.color = Color.red;
        }

        SetSize(Health.totalHealth);
    }

    public void SetSize(float size)
    {
        bar.localScale = new Vector3(size, 1f);
    }
}
