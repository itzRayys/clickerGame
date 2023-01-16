using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textUpdate : MonoBehaviour
{

    [Space(10)]
    public TextMeshProUGUI woofText;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI moneyText2;

    public countInt countInt;

    private void Start()
    {
        woofText.text = "woofs: " + countInt.woofCount.ToString();
        moneyText.text = "money: " + countInt.moneyCount.ToString();
        moneyText2.text = countInt.moneyCount.ToString();
    }

    public void updateWoofText()
    {
        woofText.text = "woofs: " + countInt.woofCount.ToString();
    }

    public void updateMoneyText()
    {
        moneyText.text = "money: " + countInt.moneyCount.ToString();
        moneyText2.text = countInt.moneyCount.ToString();

    }

}
