using UnityEngine;

public class shopManager : MonoBehaviour
{
    public countInt countInt;

    [Space(10)]
    public shopItemSO[] shopItemSO;
    public GameObject[] shopPanelGO;
    public shopTemplates[] shopPanels;



    private void Start()
    {
        for (int i = 0; i < shopItemSO.Length; i++)
        {
            loadPanels();
            shopPanelGO[i].SetActive(true);
        }
        affordCheck();
    }




    private void loadPanels()
    {
        for (int i = 0; i < shopItemSO.Length; i++)
        {
            shopPanels[i].itemName.text = shopItemSO[i].itemName;
            shopPanels[i].itemCost.text = shopItemSO[i].itemCost.ToString();
        }
    }


    public void affordCheck()
    {
        for (int i = 0; i < shopItemSO.Length; i++)
        {
            if (shopItemSO[i].itemCost <= countInt.moneyCount)
            {
                shopPanels[i].itemBuyButton.interactable = true;
            }
            else
            {
                shopPanels[i].itemBuyButton.interactable = false;
            }
        }
    }



}
