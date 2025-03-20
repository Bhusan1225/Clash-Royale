using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckManager : MonoBehaviour
{
    public static DeckManager Instance;

    [SerializeField] private GameObject deckHolder;
    public List<Card2> cards2 = new List<Card2>(); // List to store cards
    private GameObject[] decksCard; // Array for deck slots
    private int maxDeckSize; // Maximum number of cards allowed

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        setMaxDeckSize();
        decksCard = new GameObject[deckHolder.transform.childCount];

        // Set all the slots
        for (int i = 0; i < deckHolder.transform.childCount; i++)
        {
            decksCard[i] = deckHolder.transform.GetChild(i).gameObject;
        }
        RefreshUI();
    }

    public int setMaxDeckSize()
    {
        return maxDeckSize = deckHolder.transform.childCount;
    }

    public void RefreshUI()
    {
        for (int i = 0; i < decksCard.Length; i++)
        {
            try
            {
                decksCard[i].transform.GetChild(0).GetComponent<Image>().enabled = true;
                decksCard[i].transform.GetChild(0).GetComponent<Image>().sprite = cards2[i].cardIcon;
            }
            catch
            {
                decksCard[i].transform.GetChild(0).GetComponent<Image>().sprite = null;
                decksCard[i].transform.GetChild(0).GetComponent<Image>().enabled = false;
            }
        }
    }

    public void Add(Card2 card)
    {
        if (cards2.Count < maxDeckSize) 
        {
            cards2.Add(card);
            Debug.Log("Card added. Total cards in deck: " + cards2.Count);
            RefreshUI();
        }
        else
        {
            Debug.LogError("Cannot add more cards. The deck is full!");
        }
    }

    public void Remove(Card2 card)
    {
        if (cards2.Contains(card))
        {
            cards2.Remove(card);
            Debug.Log("Card removed. Total cards in deck: " + cards2.Count);
            RefreshUI();
        }
        else
        {
            Debug.LogWarning("Card not found in deck!");
        }
    }
}