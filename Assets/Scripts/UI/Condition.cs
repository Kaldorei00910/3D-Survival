using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{
    public float curValue;
    public float startValue;
    public float maxvalue;
    public float passiveValue;
    public Image uiBar;

    void Start()
    {
        curValue = startValue;
    }

    void Update()
    {
        //ui업데이트
        uiBar.fillAmount = GetPercentage();

    }

    float GetPercentage()
    {
        return curValue/ maxvalue;
    }

    public void Add(float value)
    {
        curValue = Mathf.Min(curValue + value, maxvalue);
    }

    public void Subtract(float value)
    {
        curValue = Mathf.Max(curValue - value, 0);
    }
}
