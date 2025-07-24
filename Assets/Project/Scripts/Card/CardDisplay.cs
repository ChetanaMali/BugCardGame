// --------------------------------------------------------------------------------------
// Class Name:       CardDisplay
// Author:           Chetana Mali
// Created Date:     3-9-2024
// Last Modified:    29-10-2024 by[Chetana Mali]
// Description:      Displays data from a Card ScriptableObject on UI elements in a bug-themed
//                   card game. Assigns values to name, image, rarity, cost, stats, and biography
//                   fields on the card UI. This script initializes the card display at the
//                   start of the game.
// --------------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class CardDisplay : MonoBehaviour
{
    [SerializeField] private Card card;
    [SerializeField] private Image cardImage;
    [SerializeField] private TextMeshProUGUI cardName;
    [SerializeField] private TextMeshProUGUI cardLatinName;
    [SerializeField] private TextMeshProUGUI cardRarity;
    [SerializeField] private TextMeshProUGUI cardFoodCost;
    [SerializeField] private TextMeshProUGUI cardBiography;
    [SerializeField] private TextMeshProUGUI cardAttackPower;
    [SerializeField] private TextMeshProUGUI cardHealthPoint;

    // Start is called before the first frame update
    void Start()
    {
        cardImage.GetComponent<Image>().sprite = card.pictureOfBug;

        cardName.text = card.name;
        cardLatinName.text = card.latinName;
        cardRarity.text = card.rarity;
        cardFoodCost.text = card.foodCost.ToString();
        cardBiography.text = card.biography;
        cardAttackPower.text = card.attackPower.ToString();
        cardHealthPoint.text = card.healthPoint.ToString();
    }

    
}
