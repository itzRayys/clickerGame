using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textUpdate : MonoBehaviour
{
    [Space(10)]
    public int woofCount = 0;
    public int moneyCount = 24;

    [Space(10)]
    public TextMeshProUGUI woofText;
    public TextMeshProUGUI moneyText;

    private void Start()
    {
        woofText.text = "woofs: " + woofCount.ToString();
        moneyText.text = "money: " + moneyCount.ToString();
    }

    public void updateWoofText()
    {
        woofText.text = "woofs: " + woofCount.ToString();
    }

    public void updateMoneyText()
    {
        moneyText.text = "money: " + moneyCount.ToString();

    }

}
