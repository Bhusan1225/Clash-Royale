using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class DeckManager : MonoBehaviour
{
    public static DeckManager Instance;

    [SerializeField] private GameObject deckHolder;
    
    public List<Card> CARDS = new List<Card>(); // List to store cards
    private GameObject[] decksCard; // Array for deck slots

    public GameObject[] characterModel; 
   
    private int maxDeckSize; // Maximum number of cards allowed

    //Randon spawning 
    public Vector3 minSpawnPos;
    public Vector3 maxSpawnpos;


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
        decksCard = new GameObject[deckHolder.transform.childCount];

        // Set all the slots
        for (int i = 0; i < deckHolder.transform.childCount; i++)
        {
            decksCard[i] = deckHolder.transform.GetChild(i).gameObject; //sync with the deckHolder GameObject 
        }
        //RefreshUI();
    }

    public int getMaxDeckSize()
    {
        return maxDeckSize = deckHolder.transform.childCount;
    }

    public void RefreshUI()
    {
        for (int i = 0; i < decksCard.Length; i++)
        {
            Image cardImage = decksCard[i].transform.GetChild(0).GetComponent<Image>();
            TextMeshProUGUI cardText = decksCard[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>();
           


            if (i < CARDS.Count) // Ensure we don't access an index out of range
            {
                cardImage.enabled = true;
                cardText.enabled = true;
                cardImage.sprite = CARDS[i].cardIcon;
                cardText.text = CARDS[i].cardName;
            }
           
        }
    }

    public void Add(Card card)
    {
        if (CARDS.Count < maxDeckSize)
        {
            CARDS.Add(card);
            Debug.Log("Card added. Total cards in deck: " + CARDS.Count);
            RefreshUI();
        }
        
    }

    public void Remove(Card card)
    {
        if (CARDS.Contains(card)) // Ensure the exact reference exists
        {
            CARDS.Remove(card);
            RefreshUI();
        }
    }


    public void SpawnCharacter(GameObject cardCharacter)
    {
    
        Vector3 RandomPos = new Vector3(Random.Range(minSpawnPos.x, maxSpawnpos.x), -6, Random.Range(minSpawnPos.z, maxSpawnpos.z));
        Instantiate(cardCharacter, RandomPos, cardCharacter.transform.rotation);
    
     
    }
}