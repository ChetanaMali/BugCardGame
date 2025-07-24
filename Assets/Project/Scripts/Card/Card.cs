// --------------------------------------------------------------------------------------
// Class Name:      Card
// Author:          Chetana Mali
// Created Date:    3-9-2024
// Last Modified:   29-10-2024 by [Chetana Mali]
// Description:     Represents a card in a Battle Bug card game, with properties
//                  such as name, rarity, cost, stats, and a picture. This ScriptableObject
//                  enables creating and managing cards as assets in Unity.
// --------------------------------------------------------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;
    public string latinName;
    public string biography;
    public Sprite pictureOfBug;
    public string rarity;
    public int foodCost;
    public int healthPoint;
    public int attackPower;
    public Color cardColor;
    
}
