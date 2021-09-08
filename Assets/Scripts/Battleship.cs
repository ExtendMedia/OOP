using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battleship : Ship //INHERITANCE
{

    private int torpedoes;
    public int Torpedoes //ENCAPSULATION
    {
        get { return torpedoes; }
        set { torpedoes = value; }
    }



    public override void GenerateShip() //POLYMORPHISM
    {
        base.GenerateShip();
        ShipClass = SetShipClass();
        Torpedoes = Random.Range(Rank, 21);
    }

    protected override string SetShipClass()
    {
        return "Battleship";
    }




}
