using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class InventoryManager2 : MonoBehaviour
{
    public static InventoryManager2 Instance;

    [SerializeField] private GameObject cardHolder;
    public List<Card> CARDS = new List<Card>(); // Card list
    private List<GameObject> cards = new List<GameObject>(); // Converted array to list


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        

        // Initialize the card slots list
        for (int i = 0; i < cardHolder.transform.childCount; i++)
        {
            cards.Add(cardHolder.transform.GetChild(i).gameObject);
        }
        
        RefreshUI();
    }

    public void RefreshUI()
    {
        for (int i = 0; i < cards.Count; i++)
        {
            Image cardImage = cards[i].transform.GetChild(0).GetComponent<Image>();
            TextMeshProUGUI cardText = cards[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>();

            if (i < cards.Count)
            {
                cardImage.enabled = true;
                cardText.enabled = true;
                cardImage.sprite = CARDS[i].cardIcon;
                cardText.text = CARDS[i].cardName;

                Debug.Log(cardImage.sprite);
                Debug.Log(cardText.text);   
                
            }
            else
            {
                cardImage.enabled = false;
                cardText.enabled = false;
                cardImage.sprite = null;
                cardText.text = "";
            }
        }
    }

    public void Add(Card card)
    {
        CARDS.Add(card);
        RefreshUI();
    }

    public void Remove(Card card)
    {
        if (CARDS.Contains(card)) // Ensure the exact reference exists
        {
            CARDS.Remove(card);
            //RefreshUI();
        }
    }
}