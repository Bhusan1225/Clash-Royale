using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckManager : MonoBehaviour
{
    [SerializeField] private GameObject deckHolder;
    public static DeckManager Instance;
    public List<Card2> cards2 = new List<Card2>(); //list


    private GameObject[] decksCard; // Array
    private void Awake()
    {

        Instance = this;
    }

    private void Start()
    {
        decksCard = new GameObject[deckHolder.transform.childCount];
        //set all the slots
        for (int i = 0; i < deckHolder.transform.childCount; i++)
        {
            decksCard[i] = deckHolder.transform.GetChild(i).gameObject;
        }
        RefreshUI();

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
        cards2.Add(card);
        RefreshUI();
    }

    public void Remove(Card2 card)
    {
        cards2.Remove(card);
        RefreshUI();
    }

}
