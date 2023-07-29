using UnityEngine;
using TMPro;

public class saveManager : MonoBehaviour
{
    public mapManager map;
    public countInt count;
    public itemManager item;

    public TextMeshProUGUI loadedDataText;

    public void savePlayer()
    {
        saveSystem.savePlayer(map, count, item);
    }

    public void loadPlayer()
    {
        savePlayerData data = saveSystem.loadPlayer();

        loadedDataText.text = "Current location: " + data.currentLocation.ToString() + " \n"
            + "Woof count: " + data.woofCount.ToString() + " \n"
            + "Money count: " + data.moneyCount.ToString() + " \n"
            + "Items equipped: " + " \n"
            + "      " + data.itemsEquipped[0] + " \n"
            + "      " + data.itemsEquipped[1] + " \n"
            + "      " + data.itemsEquipped[2] + " \n"
            + "      " + data.itemsEquipped[3] + " \n"
            + "      " + data.itemsEquipped[4] + " \n"
            + "      " + data.itemsEquipped[5];
    }
}
