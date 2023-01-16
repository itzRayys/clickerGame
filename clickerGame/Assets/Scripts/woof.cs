using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class woof : MonoBehaviour
{
    public countInt countInt;
    public textUpdate textUpdate;

    public int moneyPerClick;

    private void Start()
    {
        moneyPerClick = 1;
    }


    public void woofClick()
    {
        countInt.woofCount += 1;
        textUpdate.updateWoofText();

        countInt.moneyCount = countInt.moneyCount + moneyPerClick;
        textUpdate.updateMoneyText();



    }




}
