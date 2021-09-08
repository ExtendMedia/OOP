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
    [SerializeField] private TextMeshProUGUI title;


    public void Start()
    {
        title.text = GameManager.Instance.playerName + "'s Shipyard";
    }

    public void ShowShipInfo(string shipClass)
    {

        switch (shipClass)
        {
            case "Destroyer":
                Destroyer destroyerShip = new Destroyer();
                destroyerShip.GenerateShip();
                PrintShipName(destroyerShip);
                PrintShipClass(destroyerShip);
                PrintShipRank(destroyerShip);
                PrintShipMainStats(destroyerShip);
                PrintShipDestroyerStats(destroyerShip);
                shipInfoPanel.SetActive(true);
                break;

            case "Carrier":
                Carrier carrierShip = new Carrier();
                carrierShip.GenerateShip();
                PrintShipName(carrierShip);
                PrintShipClass(carrierShip);
                PrintShipRank(carrierShip);
                PrintShipMainStats(carrierShip);
                PrintShipCarrierStats(carrierShip);
                shipInfoPanel.SetActive(true);
                break;
            
            case "Battleship":
                Battleship battleShip = new Battleship();
                battleShip.GenerateShip();
                PrintShipName(battleShip);
                PrintShipClass(battleShip);
                PrintShipRank(battleShip);
                PrintShipMainStats(battleShip);
                PrintShipBattleshipStats(battleShip);
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

    private void PrintShipCarrierStats(Carrier playerShip)
    {
        shipStatsText.text += "Aviation: " + playerShip.Aviation + "\n"
                            + "AAGuns: " + playerShip.AAGuns + "\n"
                            ;

    }
    private void PrintShipBattleshipStats(Battleship playerShip)
    {
        shipStatsText.text += "Torpedoes: " + playerShip.Torpedoes + "\n"
                            ;

    }
}
