using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.UI;
public class InventoryManager2 : MonoBehaviour
{
    public static InventoryManager2 Instance;

    [SerializeField] private GameObject cardHolder;
    public List<Card2> cards2 = new List<Card2>(); //list


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
                cards[i].transform.GetChild(0).GetComponent<Image>().sprite = cards2[i].cardIcon;
            }
            catch
            {

                cards[i].transform.GetChild(0).GetComponent<Image>().sprite = null;
                cards[i].transform.GetChild(0).GetComponent<Image>().enabled = false;
            }

        }
    }


    public void Add(Card2 card)
    {

        cards2.Add(card);
        //RefreshUI();
    }

    public void Remove(Card2 card)
    {
        
        cards2.Remove(card);
        //RefreshUI();
    }


}