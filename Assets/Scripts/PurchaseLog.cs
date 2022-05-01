using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoCookie;
    public GameObject AutoSell;

    public void StartAutoCookie()
    {
        AutoCookie.SetActive(true);
        GlobalCash.CashCount -= GlobalBaker.bakerValue;
        GlobalBaker.bakerValue *= 2;
        GlobalBaker.turnOffButton = true;
        GlobalBaker.bakePerSec += 1;
        GlobalBaker.numberOfBakers += 1;
    }
    public void StartAutoSell()
    {
        AutoSell.SetActive(true);
        GlobalCash.CashCount -= GlobalCashier.CashierValue;
        GlobalCashier.CashierValue *= 2;
        GlobalCashier.turnOffButton = true;
        GlobalCashier.SellPerSec += 1;
        GlobalCashier.numberOfCashiers += 1;
    }
}
