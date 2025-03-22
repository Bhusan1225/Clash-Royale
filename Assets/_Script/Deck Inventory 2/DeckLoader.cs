using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class DeckLoader : MonoBehaviour
{
    public static DeckLoader Instance;
    
    [SerializeField] private GameObject deckHolder;
    [SerializeField] private GameObject characterHolder;
    internal GameObject cardCharacter;



    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
           
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {


        if (DeckManager.Instance != null)
        {
            LoadDeck();
        }
        else
        {
            Debug.LogError("DeckManager not found!");
        }
    }

    private void LoadDeck()
    {
        List<Card2> selectedDeck = DeckManager.Instance.cards2; // Get saved deck

        for (int i = 0; i < selectedDeck.Count; i++)
        {
            GameObject deckSlot = deckHolder.transform.GetChild(i).gameObject;
            GameObject characterHolders = characterHolder.transform.GetChild(i).gameObject;
            
            //load image
            Image cardImage = deckSlot.transform.GetChild(0).GetComponent<Image>();
            cardImage.enabled = true;
            cardImage.sprite = selectedDeck[i].cardIcon; // set the card image

            //load text
            TextMeshProUGUI cardText = deckSlot.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
            cardText.enabled = true;
            cardText.text = selectedDeck[i].cardName; //set the card text

            //load model
            cardCharacter = characterHolders.transform.GetChild(1).GetChild(0).gameObject; //get the character model
            cardCharacter.SetActive(false); //Initially it will be false 
            cardCharacter = selectedDeck[i].characterModel; //set the character

            //set character speed and Attack range
            NavMeshAgent agent = cardCharacter.GetComponent<NavMeshAgent>();
            agent.speed = selectedDeck[i].characterSpeed;
            agent.stoppingDistance = selectedDeck[i].characterRange;

        }
    }
}
