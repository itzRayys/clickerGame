using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devCheats : MonoBehaviour
{
    public countInt countInt;
    public textUpdate textUpdate;

    public void set100()
    {
        countInt.moneyCount = 100;
        textUpdate.updateMoneyText();
    }

    public void add100()
    {
        countInt.moneyCount += 100;
        textUpdate.updateMoneyText();
    }

    public void add1000()
    {
        countInt.moneyCount += 1000;
        textUpdate.updateMoneyText();
    }

    public void add10000()
    {
        countInt.moneyCount += 10000;
        textUpdate.updateMoneyText();
    }

    public void add100000000()
    {
        countInt.moneyCount += 100000000;
        textUpdate.updateMoneyText();
    }
}
