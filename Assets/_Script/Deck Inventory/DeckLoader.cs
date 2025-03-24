using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class DeckLoader : MonoBehaviour
{
    public static DeckLoader Instance;

    [SerializeField] internal GameObject deckHolder;
    

    //public GameObject charModel;
    public List<GameObject> deckChar;
    public Button[] buttons;

    //Randon spawning 
    public Vector3 minSpawnPos;
    public Vector3 maxSpawnpos;
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
        buttons = new Button[deckHolder.transform.childCount]; //get the array size 6

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

            //buttons[i] = deckHolder.transform.GetChild(i).GetComponent<Button>(); //sync with the cards button in the deckslot
            //buttons[i].onClick.AddListener(getCharacterSpawn);



            ////load image
            //Image cardImage = deckSlot.transform.GetChild(0).GetComponent<Image>();
            //cardImage.enabled = true;
            //cardImage.sprite = selectedDeck[i].cardIcon; // set the card image

            ////load text
            //TextMeshProUGUI cardText = deckSlot.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
            //cardText.enabled = true;
            //cardText.text = selectedDeck[i].cardName; //set the card text

            

        }
    }


    //public void getCharacterSpawn()
    //{


    //    for (int i = 0; i < buttons.Length; i++)
    //    {
    //        int index = i;  // Capture index for lambda
    //        DeckManager.Instance.SpawnCharacter(index);
    //        Debug.Log("You get a charater in the game" + index);
    //    }

    //}
    public void getCharacterSpawn()
    {

        List<Card> selectedDeck = DeckManager.Instance.CARDS;

        //load character
        for (int i = 0; i < buttons.Length; i++)
        {
            if (selectedDeck[i].characterModel != null)
            {
                deckChar[i] = selectedDeck[i].characterModel;
            }
            else
            {
                Debug.Log("There is no character Model");
            }


            Vector3 RandomPos = new Vector3(Random.Range(minSpawnPos.x, maxSpawnpos.x), 0, Random.Range(minSpawnPos.z, maxSpawnpos.z));
            Instantiate(deckChar[i], RandomPos, deckChar[i].transform.rotation);


        }

        //Vector3 RandomPos = new Vector3(Random.Range(minSpawnPos.x, maxSpawnpos.x), 0, Random.Range(minSpawnPos.z, maxSpawnpos.z));
        //Instantiate(charModel, RandomPos, charModel.transform.rotation);
    }



}
