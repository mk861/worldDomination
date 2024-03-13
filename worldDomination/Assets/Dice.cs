using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    int diceRollNumber;
    readonly System.Random diceRandom = new();

    public int RollDice() {
        diceRollNumber = diceRandom.Next(1,7);
        return diceRollNumber;
    }
}
