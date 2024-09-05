using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CommunityInvolvement : MonoBehaviour
{
    private static CommunityInvolvement communityInvolvementObject;

    public static CommunityInvolvement CommunityInvolvementObject
    {
        get
        {
            return communityInvolvementObject;
        }
    }
    [Header("GameObject")]
    [SerializeField] GameObject communityInvolvement;

    [Header("Cubes")]
    [SerializeField] GameObject moveProtest;
    [SerializeField] GameObject movePetition;
    [SerializeField] GameObject moveDonation;

    [Header("Buttons")]
    [SerializeField] Button moveProtestBtn;
    [SerializeField] Button movePetitionBtn;
    [SerializeField] Button moveDontaionBtn;

    [Header("Your Resources")]
    [SerializeField] TextMeshProUGUI rTimeText;
    [SerializeField] TextMeshProUGUI rNetworkText;
    [SerializeField] TextMeshProUGUI rMoneyText;

    [Header("Long-Term Effect Resources")]
    [SerializeField] TextMeshProUGUI lTimeText;
    [SerializeField] TextMeshProUGUI lNetworkText;
    [SerializeField] TextMeshProUGUI lMoneyText;

    [Header("GameObjects")]
    [SerializeField] public GameObject communityInvolvementBackground;

    public static int protestMoveCounter = 0;
    public static int petitionMoveCounter = 0;
    public static int donationMoveCounter = 0;

    RealityCheck realityCheckObject;
    Level1 level1Object;
    CommunityWellbeing communityWellbeingObject;

    private void Awake()
    {
        communityInvolvementBackground.SetActive(false);
        if (communityInvolvementObject != null && communityInvolvementObject != this)
        {
            Destroy(this);
        }
        else
        {
            communityInvolvementObject = this;
        }
    }

    private void Start()
    {
        protestMoveCounter= 0;
        petitionMoveCounter= 0;
        donationMoveCounter= 0;
        realityCheckObject = RealityCheck.RealityCheckObject;
        level1Object = Level1.Level1Object;
        communityWellbeingObject = CommunityWellbeing.CommunityWellbeingObject;
    }


    public void OnCommunityInvolvementClick()
    {
        communityInvolvement.GetComponent<Animator>().SetBool("CommunityInvolvementClickExit", false);
        communityInvolvement.GetComponent<Animator>().SetBool("CommunityInvolvementClick", true);
    }
    public void OnCommunityInvolvementExitClick()
    {
        communityInvolvement.GetComponent<Animator>().SetBool("CommunityInvolvementClick", false);
        communityInvolvement.GetComponent<Animator>().SetBool("CommunityInvolvementClickExit", true);
    }
    public void MoveProtest()
    {
        if (Level1.cardSandraSpecial)
        {
            Level1.cardSandraSpecial = false;
            protestMoveCounter++;
            ProtestMoveCounter(protestMoveCounter);
            realityCheckObject.RealityCheckInvolvementGrowth();
        }
        else if (Level1.cardSandraOngoing && Convert.ToInt16(rTimeText.text) >= 2)
        {
            Level1.cardSandraOngoing = false;
            protestMoveCounter++;
            ProtestMoveCounter(protestMoveCounter);
            realityCheckObject.RealityCheckInvolvementGrowth();
            rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - 2);
        }
        else if ((Level1.cardStefanOngoing && Level1.cardLizStefanOngoing) && Convert.ToInt16(rTimeText.text) >= 1)
        {
            Level1.cardLizStefanOngoing = false;
            protestMoveCounter++;
            ProtestMoveCounter(protestMoveCounter);
            realityCheckObject.RealityCheckInvolvementGrowth();
            rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - 1);
        }
        else if (Level1.cardStefanOngoing && Convert.ToInt16(rTimeText.text) >= 2)
        {
            protestMoveCounter++;
            ProtestMoveCounter(protestMoveCounter);
            realityCheckObject.RealityCheckInvolvementGrowth();
            rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - 2);
        }
        else if (Convert.ToInt16(rTimeText.text) >= 3)
        {
            protestMoveCounter++;
            ProtestMoveCounter(protestMoveCounter);
            realityCheckObject.RealityCheckInvolvementGrowth();
            rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - 3);
        }
        else
        {
            level1Object.NotEnoughResourcesPopup();
        }
    }
    void ProtestMoveCounter(int counter)
    {
        switch (counter)
        {
            case 1:
                lNetworkText.text = Convert.ToString(Convert.ToInt16(lNetworkText.text) + 1);
                moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -530);
                break;
            case 2:
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) + 1);
                moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -485);
                break;
            case 3:
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) + 1);
                moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -443);
                break;
            case 4:
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) + 1);
                moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -398);
                break;
            case 5:
                moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -355);
                break;
            case 6:
                communityWellbeingObject.WellbeingIncrease();
                moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -302);
                break;
            case 7:
                moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -255);
                break;
            case 8:
                communityWellbeingObject.WellbeingIncrease();
                moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -205);
                break;
            case 9:
                moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -160);
                break;
            case 10:
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -114);
                break;
            default:
                break;
        }
    }
    
    public void MovePetition()
    {
        if (Level1.cardSandraSpecial)
        {
            Level1.cardSandraSpecial = false;
            petitionMoveCounter++;
            PetitionMoveCounter(petitionMoveCounter);
            realityCheckObject.RealityCheckInvolvementGrowth();
        }
        else if (Level1.cardSandraOngoing && Convert.ToInt16(rNetworkText.text) >= 2)
        {
            Level1.cardSandraOngoing = false;
            petitionMoveCounter++;
            PetitionMoveCounter(petitionMoveCounter);
            realityCheckObject.RealityCheckInvolvementGrowth();
            rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - 2);
        }
        else if ((Level1.cardMariaOngoing && Level1.cardLizMariaOngoing) && Convert.ToInt16(rNetworkText.text) >= 1)
        {
            Level1.cardLizMariaOngoing = false;
            petitionMoveCounter++;
            PetitionMoveCounter(petitionMoveCounter);
            realityCheckObject.RealityCheckInvolvementGrowth();
            rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - 1);
        }
        else if (Level1.cardMariaOngoing && Convert.ToInt16(rNetworkText.text) >= 2)
        {
            petitionMoveCounter++;
            PetitionMoveCounter(petitionMoveCounter);
            realityCheckObject.RealityCheckInvolvementGrowth();
            rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - 2);
        }
        else if (Convert.ToInt16(rNetworkText.text) >= 3)
        {
            petitionMoveCounter++;
            PetitionMoveCounter(petitionMoveCounter);
            realityCheckObject.RealityCheckInvolvementGrowth();
            rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - 3);
        }
        else
        {
            level1Object.NotEnoughResourcesPopup();
        }
    }

    void PetitionMoveCounter(int counter)
    {
        switch (counter)
        {
            case 1:
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) + 1);
                movePetition.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -530);
                break;
            case 2:
                lNetworkText.text = Convert.ToString(Convert.ToInt16(lNetworkText.text) + 1);
                movePetition.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -485);
                break;
            case 3:
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) + 1);
                movePetition.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -443);
                break;
            case 4:
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) + 1);
                movePetition.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -398);
                break;
            case 5:
                movePetition.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -355);
                break;
            case 6:
                communityWellbeingObject.WellbeingIncrease();
                movePetition.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -302);
                break;
            case 7:
                movePetition.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -255);
                break;
            case 8:
                communityWellbeingObject.WellbeingIncrease();
                movePetition.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -205);
                break;
            case 9:
                movePetition.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -160);
                break;
            case 10:
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                movePetition.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -114);
                break;
            default:
                break;
        }
    }
    public void MoveDonation()
    {
        if (Level1.cardSandraSpecial)
        {
            Level1.cardSandraSpecial = false;
            donationMoveCounter++;
            DonationMoveCounter(donationMoveCounter);
            realityCheckObject.RealityCheckInvolvementGrowth();
        }
        else if (Level1.cardSandraOngoing && Convert.ToInt16(rMoneyText.text) >= 2)
        {
            Level1.cardSandraOngoing = false;
            donationMoveCounter++;
            DonationMoveCounter(donationMoveCounter);
            realityCheckObject.RealityCheckInvolvementGrowth();
            rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - 2);
        }
        else if ((Level1.cardCharlieOngoing && Level1.cardLizCharlieOngoing) && Convert.ToInt16(rMoneyText.text) >= 1)
        {
            Level1.cardLizCharlieOngoing = false;
            donationMoveCounter++;
            DonationMoveCounter(donationMoveCounter);
            realityCheckObject.RealityCheckInvolvementGrowth();
            rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - 1);
        }
        else if (Level1.cardCharlieOngoing && Convert.ToInt16(rMoneyText.text) >= 2)
        {
            donationMoveCounter++;
            DonationMoveCounter(donationMoveCounter);
            realityCheckObject.RealityCheckInvolvementGrowth();
            rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - 2);
        }
        else if (Convert.ToInt16(rMoneyText.text) >= 3)
        {
            donationMoveCounter++;
            DonationMoveCounter(donationMoveCounter);
            realityCheckObject.RealityCheckInvolvementGrowth();
            rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - 3);
        }
        else
        {
            level1Object.NotEnoughResourcesPopup();
        }
    }
    void DonationMoveCounter(int counter)
    {
        switch (counter)
        {
            case 1:
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) + 1);
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -530);
                break;
            case 2:
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) + 1);
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -485);
                break;
            case 3:
                lNetworkText.text = Convert.ToString(Convert.ToInt16(lNetworkText.text) + 1);
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -443);
                break;
            case 4:
                lNetworkText.text = Convert.ToString(Convert.ToInt16(lNetworkText.text) + 1);
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -398);
                break;
            case 5:
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -355);
                break;
            case 6:
                communityWellbeingObject.WellbeingIncrease();
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -302);
                break;
            case 7:
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -255);
                break;
            case 8:
                communityWellbeingObject.WellbeingIncrease();
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -205);
                break;
            case 9:
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -160);
                break;
            case 10:
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -114);
                break;
            default:
                break;
        }
    }
    
    public void MoveDonationUpWithoutMoney()
    {
        donationMoveCounter++;
        switch (donationMoveCounter)
        {
            case 1:
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) + 1);
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -530);
                break;
            case 2:
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) + 1);
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -485);
                break;
            case 3:
                lNetworkText.text = Convert.ToString(Convert.ToInt16(lNetworkText.text) + 1);
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -443);
                break;
            case 4:
                lNetworkText.text = Convert.ToString(Convert.ToInt16(lNetworkText.text) + 1);
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -398);
                break;
            case 5:
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -355);
                break;
            case 6:
                communityWellbeingObject.WellbeingIncrease();
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -302);
                break;
            case 7:
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -255);
                break;
            case 8:
                communityWellbeingObject.WellbeingIncrease();
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -205);
                break;
            case 9:
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -160);
                break;
            case 10:
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                moveDonation.GetComponent<RectTransform>().anchoredPosition = new Vector2(230, -114);
                break;
            default:
                break;
        }

    }

    public void MoveProtestUpWithoutMoney()
    {
            protestMoveCounter++;        
            switch (protestMoveCounter)
            {
                case 1:
                    lNetworkText.text = Convert.ToString(Convert.ToInt16(lNetworkText.text) + 1);
                    moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -530);
                    break;
                case 2:
                    lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) + 1);
                    moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -485);
                    break;
                case 3:
                    lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) + 1);
                    moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -443);
                    break;
                case 4:
                    lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) + 1);
                    moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -398);
                    break;
                case 5:
                    moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -355);
                    break;
                case 6:
                    communityWellbeingObject.WellbeingIncrease();
                    moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -302);
                    break;
                case 7:
                    moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -255);
                    break;
                case 8:
                    communityWellbeingObject.WellbeingIncrease();
                    moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -205);
                    break;
                case 9:
                    moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -160);
                    break;
                case 10:
                    communityWellbeingObject.WellbeingIncrease();
                    communityWellbeingObject.WellbeingIncrease();
                    moveProtest.GetComponent<RectTransform>().anchoredPosition = new Vector2(-230, -114);
                    break;
                default:
                    break;
            }
    }

}
