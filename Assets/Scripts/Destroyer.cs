using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Destroyer : Ship //INHERITANCE
{

    private int torpedoes;
    public int Torpedoes //ENCAPSULATION
    {
        get { return torpedoes; }
        set { torpedoes = value; }
    }
    private int aaGuns;
    public int AAGuns //ENCAPSULATION
    {
        get { return aaGuns; }
        set { aaGuns = value; }
    }


    public override void GenerateShip() //POLYMORPHISM
    {
        base.GenerateShip();
        ShipClass = SetShipClass();
        Torpedoes = Random.Range(Rank, 21);
        AAGuns = Random.Range(Rank, 21);
    }

    protected override string SetShipClass()
    {
        return "Destroyer";
    }




}
