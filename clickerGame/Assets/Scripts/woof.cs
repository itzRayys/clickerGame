using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class woof : MonoBehaviour
{
    public textUpdate textUpdate;

    public int moneyPerClick;

    private void Start()
    {
        moneyPerClick = 1;
    }


    public void woofClick()
    {
        textUpdate.woofCount += 1;
        textUpdate.updateWoofText();

        textUpdate.moneyCount = textUpdate.moneyCount + moneyPerClick;
        textUpdate.updateMoneyText();



    }




}
