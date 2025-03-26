using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class CardSpawner: MonoBehaviour
{
    
    private Button cardButton;
    [SerializeField]private Image cardImage;
    [SerializeField] private TextMeshProUGUI cardText;

    Card myCardData;

    private void Start()
    {
        cardButton = GetComponent<Button>();
        
    }
    void SpawnCharacter()
    {

       DeckManager.Instance.SpawnCharacter(myCardData.characterModel);
   
    }


    public void OnButtonClick()
    {
            SpawnCharacter();
            Debug.Log("You picked a card");
  
    }

    public void LoadCard(Card thisCard)
    { 

            //load image
            cardImage.enabled = true;
            cardImage.sprite = thisCard.cardIcon; // set the card image

            //load text
            cardText.enabled = true;
            cardText.text = thisCard.cardName; //set the card text

            myCardData = thisCard;


    }
}
