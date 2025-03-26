using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class DeckLoader : MonoBehaviour
{
    public static DeckLoader Instance;

    [SerializeField] internal GameObject deckHolder;
    
    public List<GameObject> deckChar;
   

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
        List<Card> selectedDeck = DeckManager.Instance.CARDS;

        for (int i = 0; i < selectedDeck.Count; i++)
        {
            var deckCardUse = deckHolder.transform.GetChild(i).gameObject.GetComponent<DeckCardUse>();
            deckCardUse.LoadCard(selectedDeck[i]);

        }
    }


    



}
