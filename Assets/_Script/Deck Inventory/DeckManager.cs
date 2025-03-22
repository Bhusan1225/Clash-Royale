using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DeckManager : MonoBehaviour
{
    public static DeckManager Instance;

    [SerializeField] private GameObject deckHolder;
    [SerializeField] private GameObject characterHolder;
    public List<Card> CARDS = new List<Card>(); // List to store cards
    private GameObject[] decksCard; // Array for deck slots
    //private GameObject[] charactersModel; // Array for characterHolder
    private int maxDeckSize; // Maximum number of cards allowed

    //private Button thisButton;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  
        }
        else
        {
            Destroy(gameObject);
        }

    }

    private void Start()
    {
       
        getMaxDeckSize();
        //charactersModel = new GameObject[characterHolder.transform.childCount];
        decksCard = new GameObject[deckHolder.transform.childCount];

        // Set all the slots
        for (int i = 0; i < deckHolder.transform.childCount; i++)
        {
            decksCard[i] = deckHolder.transform.GetChild(i).gameObject; //sync with the deckHolder GameObject 
        }

        //for (int i = 0; i< characterHolder.transform.childCount; i++)
        //{
        //    charactersModel[i] = characterHolder.transform.GetChild(i).gameObject; //sync with the characterHolder GameObject
        //}
        RefreshUI();
    }

    public int getMaxDeckSize()
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
                decksCard[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().enabled = true;
                decksCard[i].transform.GetChild(0).GetComponent<Image>().sprite = CARDS[i].cardIcon;
                decksCard[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = CARDS[i].cardName;


            }
            catch
            {

                decksCard[i].transform.GetChild(0).GetComponent<Image>().sprite = null;
                decksCard[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = null;
                decksCard[i].transform.GetChild(0).GetComponent<Image>().enabled = false;
                decksCard[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().enabled = false;
            }
        }

        //for (int i = 0; i < charactersModel.Length; i++)
        //{
        //    try
        //    {
        //        if (i < CARDS.Count) // Ensure 'i' is within range of CARDS
        //        {
        //            GameObject newCharacter = CARDS[i].characterModel; // Clone the model
        //            Transform parentTransform = charactersModel[i].transform.GetChild(0); // Get the parent

                    

        //            // Set the new model as a child
        //            newCharacter.transform.SetParent(parentTransform);
        //        }
        //        else
        //        {
        //            Debug.LogWarning($"Skipping index {i} because it exceeds CARDS list size.");
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {
        //        Debug.LogError($"Something went wrong at index {i}: {ex.Message}");
        //    }
        //}
    }

    public void Add(Card card)
    {
        if (CARDS.Count < maxDeckSize) 
        {
            CARDS.Add(card);
            Debug.Log("Card added. Total cards in deck: " + CARDS.Count);
            RefreshUI();
        }
        else
        {
            Debug.LogError("Cannot add more cards. The deck is full!");
        }
    }

    public void Remove(Card card)
    {
        if (CARDS.Contains(card))
        {
            CARDS.Remove(card);
            Debug.Log("Card removed. Total cards in deck: " + CARDS.Count);
            RefreshUI();
        }
        else
        {
            Debug.LogWarning("Card not found in deck!");
        }
    }
}