using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class InventoryManager2 : MonoBehaviour
{
    public static InventoryManager2 Instance;

    [SerializeField] private GameObject cardHolder;
    public List<Card> CARDS = new List<Card>(); //list
    private GameObject[] cards; // Array


    private void Awake()
    {

        Instance = this;
    }

    private void Start()
    {
        cards = new GameObject[cardHolder.transform.childCount];
        //set all the slots
        for (int i = 0; i < cardHolder.transform.childCount; i++)
        {
            cards[i] = cardHolder.transform.GetChild(i).gameObject;
        }
        RefreshUI();

    }

    public void RefreshUI()
    {
        for (int i = 0; i < cards.Length; i++)
        {
            try
            {

                cards[i].transform.GetChild(0).GetComponent<Image>().enabled = true;
                cards[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().enabled = true;
                cards[i].transform.GetChild(0).GetComponent<Image>().sprite = CARDS[i].cardIcon;
                cards[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = CARDS[i].cardName;


            }
            catch
            {

                cards[i].transform.GetChild(0).GetComponent<Image>().sprite = null;
                cards[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = null;
                cards[i].transform.GetChild(0).GetComponent<Image>().enabled = false;
                cards[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().enabled = false;
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
        
        CARDS.Remove(card);
        RefreshUI();
    }


}