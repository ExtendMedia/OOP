using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShipyardManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI shipNameText;
    [SerializeField] private TextMeshProUGUI shipClassText;
    [SerializeField] private TextMeshProUGUI shipRankText;
    [SerializeField] private TextMeshProUGUI shipStatsText;
    [SerializeField] private GameObject shipInfoPanel;

    public void ShowShipInfo(string shipClass)
    {

        switch (shipClass)
        {
            case "Destroyer":
                Destroyer playerShip = new Destroyer();
                playerShip.GenerateShip();
                PrintShipName(playerShip);
                PrintShipClass(playerShip);
                PrintShipRank(playerShip);
                PrintShipMainStats(playerShip);
                PrintShipDestroyerStats(playerShip);
                shipInfoPanel.SetActive(true);
                break;
        }

    }

    private void PrintShipName(Ship playerShip)
    {
        shipNameText.text = playerShip.ShipName;
    }

       
    private void PrintShipClass(Ship playerShip)
    {
        shipClassText.text = "Class: " + playerShip.ShipClass;

    }
    private void PrintShipRank(Ship playerShip)
    {
        shipRankText.text = "Rank: " + playerShip.Rank;
    }

    private void PrintShipMainStats(Ship playerShip)
    {
        shipStatsText.text = "Armor: " + playerShip.Armor + "\n"
                            + "Artillery: " + playerShip.Artillery + "\n"
                            + "Speed: " + playerShip.Speed + "\n"
                            ;

    }

    private void PrintShipDestroyerStats(Destroyer playerShip)
    {
        shipStatsText.text += "Torpedoes: " + playerShip.Torpedoes + "\n"
                            + "AAGuns: " + playerShip.AAGuns + "\n"
                            ;

    }


}
