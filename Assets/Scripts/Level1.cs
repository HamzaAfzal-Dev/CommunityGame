using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking.Types;
using UnityEngine.UI;
using static UnityEngine.ParticleSystem;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;

public class Level1 : MonoBehaviour
{
    private static Level1 level1Object;

    public static Level1 Level1Object
    {
        get
        {
            return level1Object;
        }
    }

    [Header("Game Objects")]
    [SerializeField] GameObject cardsContainer;
    [SerializeField] public GameObject situationCardContainer;
    [SerializeField] GameObject resourceContainer;
    [SerializeField] GameObject longTermEffectContainer;
    [SerializeField] GameObject communityInvolvment;
    [SerializeField] GameObject communityInvolvmentBackground;
    [SerializeField] GameObject communityWellbeing;
    [SerializeField] public GameObject realityCheckContainer;
    [SerializeField] public GameObject situation1Container;
    [SerializeField] public GameObject situation2Container;
    [SerializeField] GameObject moveProtest;
    [SerializeField] GameObject movePetition;
    [SerializeField] GameObject moveDonation;
    [SerializeField] GameObject situationActionContainer;
    [SerializeField] GameObject communityWellbeingCube;
    [SerializeField] GameObject cardBackground;
    public GameObject resourceGainerContainer;


    [Header("Buttons")]
    [SerializeField] Button readyPlayBtn;
    [SerializeField] public Button situationOneBtn;
    [SerializeField] public Button situationOneActionOneBtn;
    [SerializeField] public Button situationOneActionTwoBtn;
    [SerializeField] public Button situationOneActionThreeBtn;
    [SerializeField] public Button situationOneIgnoreBtn;
    [SerializeField] public Button situationTwoBtn;
    [SerializeField] public Button situationTwoActionOneBtn;
    [SerializeField] public Button situationTwoActionTwoBtn;
    [SerializeField] public Button situationTwoActionThreeBtn;
    [SerializeField] public Button situationTwoIgnoreBtn;
    [SerializeField] public Button moveProtestBtn;
    [SerializeField] Button movePetitionBtn;
    [SerializeField] Button moveDontaionBtn;
    [SerializeField] Button payNowBtn;
    [SerializeField] Button goToAnotherSituationAfterCompletingOneBtn;
    [SerializeField] Button goBackToSituationBtn;
    [SerializeField] Button burnoutBtn;
    [SerializeField] Button rConversionToTimeBtn;
    [SerializeField] Button rConversionToNetworkBtn;
    [SerializeField] Button rConversionToMoneyBtn;
    public Button rcBurnoutCard1Btn;
    public Button rcBurnoutCard2Btn;
    public Button rcBurnoutCard3Btn;
    public Button rcBurnoutResourceBtn;
    public Button rcTeamBuildingCard1Btn;
    public Button rcTeamBuildingCard2Btn;
    public Button rcTeamBuildingCard3Btn;
    public Button rcTeamBuildingResourceBtn;
    public Button communityWellbeingReadyCard1Btn;
    public Button communityWellbeingReadyCard2Btn;
    public Button communityWellbeingReadyCard3Btn;
    [SerializeField] Button rgGetNowBtn;
    [SerializeField] Button communityInvolvementGoToNextRoundBtn;
    [SerializeField] Button finishGameBtn;

    [Header("Texts")]
    [SerializeField] TextMeshProUGUI headingText;
    [SerializeField] TextMeshProUGUI instructionText;
    [SerializeField] TextMeshProUGUI homelessAct1MoneyText;
    [SerializeField] TextMeshProUGUI homelessAct2MoneyText;
    [SerializeField] TextMeshProUGUI homelessAct3MoneyText;
    [SerializeField] TextMeshProUGUI refugeeAct1MoneyText;
    [SerializeField] TextMeshProUGUI refugeeAct2MoneyText;
    [SerializeField] TextMeshProUGUI refugeeAct3MoneyText;
    [SerializeField] TextMeshProUGUI rgHeadingText;
    [SerializeField] TextMeshProUGUI roundCounterText;
    [SerializeField] TextMeshProUGUI finalScoreText;
    [SerializeField] TextMeshProUGUI finalMessageText;

    [Header("Your Resources")]
    [SerializeField] public TextMeshProUGUI rTimeText;
    [SerializeField] public TextMeshProUGUI rNetworkText;
    [SerializeField] public TextMeshProUGUI rMoneyText;

    [Header("Long-Term Effect Resources")]
    [SerializeField] public TextMeshProUGUI lTimeText;
    [SerializeField] public TextMeshProUGUI lNetworkText;
    [SerializeField] public TextMeshProUGUI lMoneyText;

    [Header("Card Animation")]
    [SerializeField] Animator cardAnimator;
    [SerializeField] Animator situationAnimator;
    [SerializeField] Animator communityInvolvementAnimator;

    [Header("Input Fields")]
    [SerializeField] TMP_InputField iTimeFieldFrom;
    [SerializeField] TMP_InputField iNetworkFieldFrom;
    [SerializeField] TMP_InputField iMoneyFieldFrom;
    [SerializeField] TMP_InputField rgTimeInput;
    [SerializeField] TMP_InputField rgNetworkInput;
    [SerializeField] TMP_InputField rgMoneyInput;



    [Header("Cards")]
    [SerializeField] GameObject cardAndrew;
    [SerializeField] GameObject cardAndrewEx;
    [SerializeField] GameObject cardCharlie;
    [SerializeField] GameObject cardCharlieEx;
    [SerializeField] GameObject cardJoey;
    [SerializeField] GameObject cardJoeyEx;
    [SerializeField] GameObject cardLiz;
    [SerializeField] GameObject cardLizEx;
    [SerializeField] GameObject cardMaria;
    [SerializeField] GameObject cardMariaEx;
    [SerializeField] GameObject cardMario;
    [SerializeField] GameObject cardMarioEx;
    [SerializeField] GameObject cardMary;
    [SerializeField] GameObject cardMaryEx;
    [SerializeField] GameObject cardPeter;
    [SerializeField] GameObject cardPeterEx;
    [SerializeField] GameObject cardRick;
    [SerializeField] GameObject cardRickEx;
    [SerializeField] GameObject cardSandra;
    [SerializeField] GameObject cardSandraEx;
    [SerializeField] GameObject cardStefan;
    [SerializeField] GameObject cardStefanEx;
    [SerializeField] GameObject cardTilda;
    [SerializeField] GameObject cardTildaEx;

    [Header("Buttons")]
    public Button andrewMoneyOngoingButton;
    public Button andrewTimeOngoingButton;
    public Button andrewNetworkOngoingButton;
    public Button specialAndrewBtn;
/*    public Button ongoingCharlieBtn;
*/    public Button specialCharlieBtn;
    public Button ongoingJoeyBtn;
    public Button specialJoeyBtn;
    public Button ongoingLiz1Btn;
    public Button ongoingLiz2Btn;
    public Button specialLiz1Btn;
    public Button specialLiz2Btn;
/*    public Button ongoingMariaBtn;
*/    public Button specialMariaBtn;
    public Button ongoingMoneyMario1Btn;
    public Button ongoingTimeMario2Btn;
    public Button ongoingNetworkMario3Btn;
    public Button specialMarioBtn;
    public Button ongoingMaryBtn;
    public Button specialMaryBtn;
    public Button ongoingPeterBtn;
    public Button specialPeterBtn;
    public Button ongoingRickBtn;
    public Button specialRickBtn;
    public Button ongoingSandraBtn;
    public Button specialSandraBtn;
/*    public Button ongoingStefanBtn;
*/    public Button specialStefanBtn;
    public Button ongoingTildaBtn;
    public Button specialTildaBtn;

    Sprite spAndrew;
    Sprite spAndrewEx;
    Sprite spCharlie;
    Sprite spCharlieEx;
    Sprite spJoey;
    Sprite spJoeyEx;
    Sprite spLiz;
    Sprite spLizEx;
    Sprite spMaria;
    Sprite spMariaEx;
    Sprite spMario;
    Sprite spMarioEx;
    Sprite spMary;
    Sprite spMaryEx;
    Sprite spPeter;
    Sprite spPeterEx;
    Sprite spRick;
    Sprite spRickEx;
    Sprite spSandra;
    Sprite spSandraEx;
    Sprite spStefan;
    Sprite spStefanEx;
    Sprite spTilda;
    Sprite spTildaEx;

    [Header("Popup")]
    [SerializeField] GameObject popupContainer;
    [SerializeField] TextMeshProUGUI popupText;

    [Header("Exchange Menu")]
    public GameObject exchangeMenuButton;
    public GameObject exchangeMenuContainer;
    [SerializeField] TMP_InputField emTimeFieldFrom;
    [SerializeField] TMP_InputField emNetworkFieldFrom;
    [SerializeField] TMP_InputField emMoneyFieldFrom;
    [SerializeField] Button emConversionToTimeBtn;
    [SerializeField] Button emConversionToNetworkBtn;
    [SerializeField] Button emConversionToMoneyBtn;


    [HideInInspector] public GameObject card1;
    [HideInInspector] public GameObject card2;
    [HideInInspector] public GameObject card3;
    public List<GameObject> cards;

    static public bool cardAndrewSpecial = false;
    static public bool cardAndrewOngoing = false;
    static public bool cardCharlieOngoing = false;
    static public bool cardCharlieSpecial = false;
    static public bool cardJoeyOngoing = false;
    static public bool cardJoeySpecial = false;
    static public bool cardLizOngoing = false;
    static public bool cardLizCharlieOngoing = false;
    static public bool cardLizMariaOngoing = false;
    static public bool cardLizStefanOngoing = false;
    static public bool cardLizSpecial = false;
    static public bool cardMariaOngoing = false;
    static public bool cardMariaSpecial = false;
    static public bool cardMarioOngoing = false;
    static public bool cardMarioSpecial = false;
    static public bool cardMaryOngoing = false;
    static public bool cardMarySpecial = false;
    static public bool cardPeterOngoing = false;
    static public bool cardPeterSpecial = false;
    static public bool cardRickOngoing = false;
    static public bool cardRickSpecial = false;
    static public bool cardSandraOngoing = false;
    static public bool cardSandraSpecial = false;
    static public bool cardStefanOngoing = false;
    static public bool cardStefanSpecial = false;
    static public bool cardTildaOngoing = false;
    static public bool cardTildaSpecial = false;

    static public string cardOneName;
    static public string cardTwoName;
    static public string cardThreeName;

    static public int cardOneIndex;
    static public int cardTwoIndex;
    static public int cardThreeIndex;

    static public string moneyText;
    static public string networkText;
    static public string timeText;

    static public bool isNewRound = false;


    // local classes objects
    CommunityWellbeing communityWellbeingObject;
    Situation situationObject;
    RealityCheck realityCheckObject;

    int round = 1;
    private void Awake()
    {
        if (level1Object != null && level1Object != this)
        {
            Destroy(this);
        }
        else
        {
            level1Object = this;
        }

        cards = new List<GameObject>{ cardPeter, cardPeterEx, cardRick, cardRickEx, cardTilda, cardTildaEx, cardCharlie, cardCharlieEx, cardMaria, cardMariaEx,
                                      cardStefan, cardStefanEx, cardAndrew, cardAndrewEx, cardJoey, cardJoeyEx, cardLiz, cardLizEx, cardMario, cardMarioEx,
                                      /*cardMary, cardMaryEx,*/ cardSandra, cardSandraEx};
        CardAllotment();
        AllotName();
        SetInitialText();

        spAndrew    =   cardAndrew.GetComponent<Image>().sprite;
        spAndrewEx  =   cardAndrewEx.GetComponent<Image>().sprite;
        spCharlie   =   cardCharlie.GetComponent<Image>().sprite;
        spCharlieEx =   cardCharlieEx.GetComponent<Image>().sprite;
        spJoey      =   cardJoey.GetComponent<Image>().sprite;
        spJoeyEx    =   cardJoeyEx.GetComponent<Image>().sprite;
        spLiz       =   cardLiz.GetComponent<Image>().sprite;
        spLizEx     =   cardLizEx.GetComponent<Image>().sprite;
        spMaria     =   cardMaria.GetComponent<Image>().sprite;
        spMariaEx   =   cardMariaEx.GetComponent<Image>().sprite;
        spMario     =   cardMario.GetComponent<Image>().sprite;
        spMarioEx   =   cardMarioEx.GetComponent<Image>().sprite;
        spMary      =   cardMary.GetComponent<Image>().sprite;
        spMaryEx    =   cardMaryEx.GetComponent<Image>().sprite;
        spPeter     =   cardPeter.GetComponent<Image>().sprite;
        spPeterEx   =   cardPeterEx.GetComponent<Image>().sprite;
        spRick      =   cardRick.GetComponent<Image>().sprite;
        spRickEx    =   cardRickEx.GetComponent<Image>().sprite;
        spSandra    =   cardSandra.GetComponent<Image>().sprite;
        spSandraEx  =   cardSandraEx.GetComponent<Image>().sprite;
        spStefan    =   cardStefan.GetComponent<Image>().sprite;
        spStefanEx  =   cardStefanEx.GetComponent<Image>().sprite;
        spTilda     =   cardTilda.GetComponent<Image>().sprite;
        spTildaEx   =   cardTildaEx.GetComponent<Image>().sprite;
    }

    private void Start()
    {
        isNewRound = false;
        round = 1;
        communityWellbeingObject = CommunityWellbeing.CommunityWellbeingObject;
        situationObject = Situation.SituationObject;
        realityCheckObject = RealityCheck.RealityCheckObject;
        SetInitialActiveStatus();
    }

    private void CardAllotment()
    {
        cardOneIndex = (UnityEngine.Random.Range(0, 5) / 2) * 2;
        cardTwoIndex = (UnityEngine.Random.Range(6, 11) / 2) * 2;
        cardThreeIndex = (UnityEngine.Random.Range(12, 21) / 2) * 2;

        card1 = cards[cardOneIndex];
        card2 = cards[cardTwoIndex];
        card3 = cards[cardThreeIndex];

        if (cardTwoIndex == 6)
        {
            cardCharlieOngoing = true;
            cardMariaOngoing = false;
            cardStefanOngoing = false;
        }
        else if (cardTwoIndex == 8)
        {
            cardMariaOngoing = true;
            cardCharlieOngoing = false;
            cardStefanOngoing = false;
        }
        else if (cardTwoIndex == 10)
        {
            cardMariaOngoing = false;
            cardCharlieOngoing = false;
            cardStefanOngoing = true;
        }
    }
    private void AllotName() 
    {
        switch (cardOneIndex)
        {
            case 0:
                cardOneName = "Peter";
                break;
            case 2:
                cardOneName = "Rick";
                break;
            case 4:
                cardOneName = "Tilda";
                break;
        }

        switch (cardTwoIndex)
        {
            case 6:
                cardTwoName = "Charlie";
                break;
            case 8:
                cardTwoName = "Maria";
                break;
            case 10:
                cardTwoName = "Stefan";
                break;
        }

        switch (cardThreeIndex)
        {
            case 12:
                cardThreeName = "Andrew";
                break;
            case 14:
                cardThreeName = "Joey";
                break;
            case 16:
                cardThreeName = "Liz";
                break;
            case 18:
                cardThreeName = "Mario";
                break;
            case 20:
                cardThreeName = "Sandra";
                break;
        }
    }

    private void HeadingAndInstructionText(string heading, string instruction)
    {
        headingText.text = heading;
        instructionText.text = instruction;
    }
    private void SetInitialText()
    {
        HeadingAndInstructionText("MEET THE CHARACTERS",
            "These are main members of your team. Read carefully how they can help you, it will be important for your strategy.");

        rTimeText.text = "5";
        rNetworkText.text = "5";
        rMoneyText.text = "5";

        lTimeText.text = "5";
        lNetworkText.text = "5";
        lMoneyText.text = "5";

        ResetExchange();
        emResetExchange();
    }

    private void SetInitialActiveStatus()
    {
        cardsContainer.SetActive(true);
        card1.SetActive(true);
        card2.SetActive(true);
        card3.SetActive(true);

        readyPlayBtn.gameObject.SetActive(true);
        headingText.gameObject.SetActive(true);
        instructionText.gameObject.SetActive(true);

        situationCardContainer.SetActive(false);
        resourceContainer.SetActive(false);
        longTermEffectContainer.SetActive(false);
        communityInvolvment.SetActive(false);
        communityWellbeing.SetActive(false);
        resourceGainerContainer.SetActive(false);

        situationOneActionOneBtn.gameObject.SetActive(false);
        situationOneActionTwoBtn.gameObject.SetActive(false);
        situationOneActionThreeBtn.gameObject.SetActive(false);
        situationOneIgnoreBtn.gameObject.SetActive(false);
        situationTwoActionOneBtn.gameObject.SetActive(false);
        situationTwoActionTwoBtn.gameObject.SetActive(false);
        situationTwoActionThreeBtn.gameObject.SetActive(false);
        situationTwoIgnoreBtn.gameObject.SetActive(false);

        moveProtest.SetActive(false);
        movePetition.SetActive(false);
        moveDonation.SetActive(false);
        moveProtestBtn.gameObject.SetActive(false);
        movePetitionBtn.gameObject.SetActive(false);
        moveDontaionBtn.gameObject.SetActive(false);

        situationActionContainer.SetActive(false);
        situationObject.homelessSituationAct1.SetActive(false);
        situationObject.homelessSituationAct2.SetActive(false);
        situationObject.homelessSituationAct3.SetActive(false);
        situationObject.refugeeSituationAct1.SetActive(false);
        situationObject.refugeeSituationAct2.SetActive(false);
        situationObject.refugeeSituationAct3.SetActive(false);
        situationObject.languageSituationAct1.SetActive(false);
        situationObject.languageSituationAct2.SetActive(false);
        situationObject.languageSituationAct3.SetActive(false);
        situationObject.trashSituationAct1.SetActive(false);
        situationObject.trashSituationAct2.SetActive(false);
        situationObject.trashSituationAct3.SetActive(false);
        situationObject.fastFoodSituationAct1.SetActive(false);
        situationObject.fastFoodSituationAct2.SetActive(false);
        situationObject.fastFoodSituationAct3.SetActive(false);

        goToAnotherSituationAfterCompletingOneBtn.gameObject.SetActive(false);
        goBackToSituationBtn.gameObject.SetActive(false);
        cardBackground.SetActive(false);

        card1.GetComponent<Button>().interactable = false;
        card2.GetComponent<Button>().interactable = false;
        card3.GetComponent<Button>().interactable = false;
        cardBackground.GetComponent<Button>().interactable = false;

        popupContainer.SetActive(false);

        andrewMoneyOngoingButton.gameObject.SetActive(false);
        andrewTimeOngoingButton.gameObject.SetActive(false);
        andrewNetworkOngoingButton.gameObject.SetActive(false);
        specialAndrewBtn.gameObject.SetActive(false);
/*        ongoingCharlieBtn.gameObject.SetActive(false);
*/        specialCharlieBtn.gameObject.SetActive(false);
        ongoingJoeyBtn.gameObject.SetActive(false);
        specialJoeyBtn.gameObject.SetActive(false);
        ongoingLiz1Btn.gameObject.SetActive(false);
        ongoingLiz2Btn.gameObject.SetActive(false);
        specialLiz1Btn.gameObject.SetActive(false);
        specialLiz2Btn.gameObject.SetActive(false);
/*        ongoingMariaBtn.gameObject.SetActive(false);
*/        specialMariaBtn.gameObject.SetActive(false);
        ongoingMoneyMario1Btn.gameObject.SetActive(false);
        ongoingTimeMario2Btn.gameObject.SetActive(false);
        ongoingNetworkMario3Btn.gameObject.SetActive(false);
        specialMarioBtn.gameObject.SetActive(false);
        ongoingMaryBtn.gameObject.SetActive(false);
        specialMaryBtn.gameObject.SetActive(false);
        ongoingPeterBtn.gameObject.SetActive(false);
        specialPeterBtn.gameObject.SetActive(false);
        ongoingRickBtn.gameObject.SetActive(false);
        specialRickBtn.gameObject.SetActive(false);
        ongoingSandraBtn.gameObject.SetActive(false);
        specialSandraBtn.gameObject.SetActive(false);
/*        ongoingStefanBtn.gameObject.SetActive(false);
*/        specialStefanBtn.gameObject.SetActive(false);
        ongoingTildaBtn.gameObject.SetActive(false);
        specialTildaBtn.gameObject.SetActive(false);

        communityWellbeingReadyCard1Btn.gameObject.SetActive(false);
        communityWellbeingReadyCard2Btn.gameObject.SetActive(false);
        communityWellbeingReadyCard3Btn.gameObject.SetActive(false);

        communityInvolvementGoToNextRoundBtn.gameObject.SetActive(false);
        roundCounterText.gameObject.SetActive(false);

        exchangeMenuButton.gameObject.SetActive(false);
        exchangeMenuContainer.gameObject.SetActive(false);

        finalMessageText.gameObject.SetActive(false);
        finalScoreText.gameObject.SetActive(false);
    }

    public void ReadyPlayBtn()
    {
        cardAnimator.SetBool("CardPositionChange", true);

        resourceContainer.SetActive(true);
        exchangeMenuButton.gameObject.SetActive(true);
        longTermEffectContainer.SetActive(true);
        communityWellbeing.SetActive(true);
        communityInvolvment.SetActive(true);
        moveDonation.SetActive(true);
        movePetition.SetActive(true);
        moveProtest.SetActive(true);
        moveDontaionBtn.gameObject.SetActive(true);
        movePetitionBtn.gameObject.SetActive(true);
        moveProtestBtn.gameObject.SetActive(true);
        card1.GetComponent<Button>().interactable = true;
        card2.GetComponent<Button>().interactable = true;
        card3.GetComponent<Button>().interactable = true;
        cardBackground.GetComponent<Button>().interactable = true;
        roundCounterText.gameObject.SetActive(true);

        readyPlayBtn.gameObject.SetActive(false);
        roundCounterText.text = $"Round {round} of 5";
        HeadingAndInstructionText("CHOOSE A SITUATION",
            "This round, you will be facing two situations. Read them and decide, which one you want to do first.");

        finishGameBtn.gameObject.SetActive(false);
    }



    public void PayWithResources()
    {
        TextMoneyNetworkSet();

        short resourceMoneyText = Convert.ToInt16(rMoneyText.text);
        short resourceNetworkText = Convert.ToInt16(rNetworkText.text);
        short resourceTimeText = Convert.ToInt16(rTimeText.text);

        short money = Convert.ToInt16(moneyText);
        short network = Convert.ToInt16(networkText);
        short time = Convert.ToInt16(timeText);

        if (situationObject.homelessSituationAct1.activeSelf)
        {
            if (resourceMoneyText >= money && Convert.ToInt16(lMoneyText.text) >= 1 && cardTildaSpecial)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                cardTildaSpecial = false;
                cardRickSpecial = false;
                cardRickOngoing = false;
                cardPeterSpecial = false;
                cardPeterOngoing = false;
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) - 1);
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && Convert.ToInt16(lMoneyText.text) >= 1 && cardTildaOngoing)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                cardTildaOngoing = false;
                cardRickSpecial = false;
                cardRickOngoing = false;
                cardPeterSpecial = false;
                cardPeterOngoing = false;
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) - 1);
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && Convert.ToInt16(lMoneyText.text) >= 1)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                cardRickSpecial = false;
                cardRickOngoing = false;
                cardPeterSpecial = false;
                cardPeterOngoing = false;
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) - 1);
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else
            {
                NotEnoughResourcesPopup();
                return;
            }
        }
        if (situationObject.homelessSituationAct2.activeSelf)
        {
            if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardTildaSpecial)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardTildaSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardTildaOngoing)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardTildaOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardRickSpecial)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardRickSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardRickOngoing)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardRickOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardPeterSpecial)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardPeterSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardPeterOngoing)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardPeterOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else
            {
                NotEnoughResourcesPopup();
                return;
            }
        }
        if (situationObject.homelessSituationAct3.activeSelf)
        {
            if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardTildaSpecial)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardTildaSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardTildaOngoing)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardTildaOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardRickSpecial)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardRickSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardRickOngoing)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardRickOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardPeterSpecial)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardPeterSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardPeterOngoing)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardPeterOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else
            {
                NotEnoughResourcesPopup();
                return;
            }
        }
        if (situationObject.refugeeSituationAct1.activeSelf)
        {
            if (resourceMoneyText >= money && cardTildaSpecial)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                cardTildaSpecial = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceMoneyText >= money && cardTildaOngoing)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                cardTildaOngoing = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && cardRickSpecial)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                cardRickSpecial = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && cardRickOngoing)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                cardRickOngoing = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && cardPeterSpecial)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                cardPeterSpecial = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && cardPeterOngoing)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                cardPeterOngoing = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else
            {
                NotEnoughResourcesPopup();
                return;
            }
        }
        if (situationObject.refugeeSituationAct2.activeSelf)
        {
            if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardTildaSpecial)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardTildaSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) + 1);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardTildaOngoing)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardTildaOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) + 1);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardRickSpecial)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardRickSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) + 1);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardRickOngoing)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardRickOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) + 1);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardPeterSpecial)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardPeterSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) + 1);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardPeterOngoing)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardPeterOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) + 1);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                communityWellbeingObject.WellbeingIncrease();
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) + 1);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else
            {
                NotEnoughResourcesPopup();
                return;
            }
        }
        if (situationObject.refugeeSituationAct3.activeSelf)
        {
            if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardTildaSpecial)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardTildaSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardTildaOngoing)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardTildaOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardRickSpecial)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardRickSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardRickOngoing)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardRickOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardPeterSpecial)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardPeterSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time && cardPeterOngoing)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardPeterOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) + 1);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceMoneyText >= money && resourceNetworkText >= network && resourceTimeText >= time)
            {
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) + 1);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else
            {
                NotEnoughResourcesPopup();
                return;
            }
        }

        if (situationObject.fastFoodSituationAct1.activeSelf)
        {
            if (resourceTimeText >= time && cardTildaSpecial)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardTildaSpecial = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceTimeText >= time && cardTildaOngoing)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardTildaOngoing = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceTimeText >= time && cardRickSpecial)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardRickSpecial = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceTimeText >= time && cardRickOngoing)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardRickOngoing = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceTimeText >= time && cardPeterSpecial)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardPeterSpecial = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceTimeText >= time && cardPeterOngoing)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                cardPeterOngoing = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceTimeText >= time)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else
            {
                NotEnoughResourcesPopup();
                return;
            }
        }
        if (situationObject.fastFoodSituationAct2.activeSelf)
        {
            if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardTildaSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardTildaSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardTildaOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardTildaOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardRickSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardRickSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardRickOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardRickOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardPeterSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardPeterSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardPeterOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardPeterOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                communityWellbeingObject.WellbeingIncrease();
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else
            {
                NotEnoughResourcesPopup();
                return;
            }
        }
        if (situationObject.fastFoodSituationAct3.activeSelf)
        {
            if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && Convert.ToInt16(lMoneyText.text) >= 1 && cardTildaSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) - 1);
                cardTildaSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && Convert.ToInt16(lMoneyText.text) >= 1 && cardTildaOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) - 1);
                cardTildaOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && Convert.ToInt16(lMoneyText.text) >= 1 && cardRickSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) - 1);
                cardRickSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && Convert.ToInt16(lMoneyText.text) >= 1 && cardRickOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) - 1);
                cardRickOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && Convert.ToInt16(lMoneyText.text) >= 1 && cardPeterSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) - 1);
                cardPeterSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && Convert.ToInt16(lMoneyText.text) >= 1 && cardPeterOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) - 1);
                cardPeterOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && Convert.ToInt16(lMoneyText.text) >= 1)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) - 1);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else
            {
                NotEnoughResourcesPopup();
                return;
            }
        }

        if (situationObject.languageSituationAct1.activeSelf)
        {
            if (resourceNetworkText >= network && resourceTimeText >= time && cardTildaSpecial)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                cardTildaSpecial = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && cardTildaOngoing)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                cardTildaOngoing = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && cardRickSpecial)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                cardRickSpecial = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && cardRickOngoing)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                cardRickOngoing = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && cardPeterSpecial)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                cardPeterSpecial = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && cardPeterOngoing)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                cardPeterOngoing = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else
            {
                NotEnoughResourcesPopup();
                return;
            }
        }
        if (situationObject.languageSituationAct2.activeSelf)
        {
            if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardTildaSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardTildaSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardTildaOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardTildaOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardRickSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardRickSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardRickOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardRickOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardPeterSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardPeterSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardPeterOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardPeterOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                communityWellbeingObject.WellbeingIncrease();
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else
            {
                NotEnoughResourcesPopup();
                return;
            }
        }
        if (situationObject.languageSituationAct3.activeSelf)
        {
            if (resourceNetworkText >= network && resourceTimeText >= time && resourceMoneyText >= money &&  Convert.ToInt16(lMoneyText.text) >= 1 && cardTildaSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) - 1);
                cardTildaSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && resourceMoneyText >= money && Convert.ToInt16(lMoneyText.text) >= 1 && cardTildaOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) - 1);
                cardTildaOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && resourceMoneyText >= money && Convert.ToInt16(lMoneyText.text) >= 1 && cardRickSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) - 1);
                cardRickSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && resourceMoneyText >= money && Convert.ToInt16(lMoneyText.text) >= 1 && cardRickOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) - 1);
                cardRickOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && resourceMoneyText >= money && Convert.ToInt16(lMoneyText.text) >= 1 && cardPeterSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) - 1);
                cardPeterSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && resourceMoneyText >= money && Convert.ToInt16(lMoneyText.text) >= 1 && cardPeterOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) - 1);
                cardPeterOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && resourceMoneyText >= money && Convert.ToInt16(lMoneyText.text) >= 1)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) - 1);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else
            {
                NotEnoughResourcesPopup();
                return;
            }
        }

        if (situationObject.trashSituationAct1.activeSelf)
        {
            if (resourceNetworkText >= network && resourceTimeText >= time && cardTildaSpecial)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                cardTildaSpecial = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && cardTildaOngoing)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                cardTildaOngoing = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && cardRickSpecial)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                cardRickSpecial = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && cardRickOngoing)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                cardRickOngoing = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && cardPeterSpecial)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                cardPeterSpecial = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && cardPeterOngoing)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                cardPeterOngoing = false;
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time)
            {
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else
            {
                NotEnoughResourcesPopup();
                return;
            }
        }
        if (situationObject.trashSituationAct2.activeSelf)
        {
            if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardTildaSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardTildaSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardTildaOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardTildaOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardRickSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardRickSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardRickOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardRickOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardPeterSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardPeterSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1 && cardPeterOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardPeterOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && Convert.ToInt16(lTimeText.text) >= 1)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                communityWellbeingObject.WellbeingIncrease();
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else
            {
                NotEnoughResourcesPopup();
                return;
            }
        }
        if (situationObject.trashSituationAct3.activeSelf)
        {
            if (resourceNetworkText >= network && resourceTimeText >= time && resourceMoneyText >= money && Convert.ToInt16(lTimeText.text) >= 1 && cardTildaSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardTildaSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && resourceMoneyText >= money && Convert.ToInt16(lTimeText.text) >= 1 && cardTildaOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardTildaOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && resourceMoneyText >= money && Convert.ToInt16(lTimeText.text) >= 1 && cardRickSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardRickSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && resourceMoneyText >= money && Convert.ToInt16(lTimeText.text) >= 1 && cardRickOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardRickOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && resourceMoneyText >= money && Convert.ToInt16(lTimeText.text) >= 1 && cardPeterSpecial)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardPeterSpecial = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }

            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && resourceMoneyText >= money && Convert.ToInt16(lTimeText.text) >= 1 && cardPeterOngoing)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                cardPeterOngoing = false;
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else if (resourceNetworkText >= network && resourceTimeText >= time && resourceMoneyText >= money && Convert.ToInt16(lTimeText.text) >= 1)
            {
                rNetworkText.text = Convert.ToString(resourceNetworkText - network);
                rTimeText.text = Convert.ToString(resourceTimeText - time);
                rMoneyText.text = Convert.ToString(resourceMoneyText - money);
                communityWellbeingObject.WellbeingIncrease();
                communityWellbeingObject.WellbeingIncrease();
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) - 1);
                PayWithResourcesSupportive();
                if (cardMarioSpecial)
                {
                    communityWellbeingObject.WellbeingIncrease();
                    cardMarioSpecial = false;
                }
            }
            else
            {
                NotEnoughResourcesPopup();
                return;
            }
        }
    }

    private void PayWithResourcesSupportive()
    {
        payNowBtn.interactable = false;       
        goToAnotherSituationAfterCompletingOneBtn.interactable = true;
        goBackToSituationBtn.interactable = false;       
        /*situationObject.NextRoundSetup();*/
        Situation.round++;
        if (Situation.round % 2 != 0)
        {
            HeadingAndInstructionText("Congratulations",
            "You have completed the task from the situation. Now you can go toward other situation.");
            goToAnotherSituationAfterCompletingOneBtn.onClick.RemoveAllListeners();
            goToAnotherSituationAfterCompletingOneBtn.onClick.AddListener(situationObject.GoToAnotherSituationAfterCompletingOne);
        }
        else
        {
            HeadingAndInstructionText("Congratulations",
            "You have completed the round. Now you can go to the next round. But before, checkout Community Involvement First.");
            goToAnotherSituationAfterCompletingOneBtn.onClick.RemoveAllListeners();
            goToAnotherSituationAfterCompletingOneBtn.onClick.AddListener(NextRoundStart);
        }
    }

    public void ExchangeResources()
    {
        int sum = Convert.ToInt16(iTimeFieldFrom.text) + Convert.ToInt16(iNetworkFieldFrom.text) + Convert.ToInt16(iMoneyFieldFrom.text);
        if (cardJoeySpecial && sum >= 1)
        {
            if (EventSystem.current.currentSelectedGameObject == rConversionToTimeBtn.gameObject)
            {

                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(iTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(iNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(iMoneyFieldFrom.text));
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) + 1);
                ResetExchange();
            }
            else if (EventSystem.current.currentSelectedGameObject == rConversionToNetworkBtn.gameObject)
            {
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(iTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(iNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(iMoneyFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) + 1);
                ResetExchange();
            }
            else if (EventSystem.current.currentSelectedGameObject == rConversionToMoneyBtn.gameObject)
            {
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(iTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(iNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(iMoneyFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) + 1);
                ResetExchange();
            }
            cardJoeySpecial = false;
            return;
        }
        if (cardJoeyOngoing && sum >= 2)
        {
            if (EventSystem.current.currentSelectedGameObject == rConversionToTimeBtn.gameObject)
            {

                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(iTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(iNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(iMoneyFieldFrom.text));
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) + 1);
                ResetExchange();
            }
            else if (EventSystem.current.currentSelectedGameObject == rConversionToNetworkBtn.gameObject)
            {
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(iTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(iNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(iMoneyFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) + 1);
                ResetExchange();
            }
            else if (EventSystem.current.currentSelectedGameObject == rConversionToMoneyBtn.gameObject)
            {
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(iTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(iNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(iMoneyFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) + 1);
                ResetExchange();
            }
            cardJoeyOngoing = false;
            return;
        }
        if (sum >= 3)
        {
            if (EventSystem.current.currentSelectedGameObject == rConversionToTimeBtn.gameObject)
            {

                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(iTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(iNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(iMoneyFieldFrom.text));
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) + 1);
                ResetExchange();
            }
            else if (EventSystem.current.currentSelectedGameObject == rConversionToNetworkBtn.gameObject)
            {
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(iTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(iNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(iMoneyFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) + 1);
                ResetExchange();
            }
            else if (EventSystem.current.currentSelectedGameObject == rConversionToMoneyBtn.gameObject)
            {
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(iTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(iNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(iMoneyFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) + 1);
                ResetExchange();
            }
        }
        else
        {
            NotEnoughResourcesPopup();
        }
    }
    private void ResetExchange()
    {
        iTimeFieldFrom.text = "0";
        iNetworkFieldFrom.text = "0";
        iMoneyFieldFrom.text = "0";
    }

    public void ExchangeResourceMenuOpener()
    {
        exchangeMenuContainer.gameObject.SetActive(true);
        exchangeMenuContainer.GetComponent<Animator>().SetBool("exchangeMenuClose", false);
    }

    public void ExchangeResourceMenuCloser()
    {
        exchangeMenuContainer.GetComponent<Animator>().SetBool("exchangeMenuClose", true);
    }

    public void ExchangeResourceMenuCloserSetInactive()
    {
        exchangeMenuContainer.gameObject.SetActive(false);
    }

    public void EmExchangeResources()
    {
        int sum = Convert.ToInt16(emTimeFieldFrom.text) + Convert.ToInt16(emNetworkFieldFrom.text) + Convert.ToInt16(emMoneyFieldFrom.text);
        if (cardJoeySpecial && sum >= 1)
        {
            if (EventSystem.current.currentSelectedGameObject == emConversionToTimeBtn.gameObject)
            {

                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(emTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(emNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(emMoneyFieldFrom.text));
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) + 1);
                emResetExchange();
            }
            else if (EventSystem.current.currentSelectedGameObject == emConversionToNetworkBtn.gameObject)
            {
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(emTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(emNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(emMoneyFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) + 1);
                emResetExchange();
            }
            else if (EventSystem.current.currentSelectedGameObject == emConversionToMoneyBtn.gameObject)
            {
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(emTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(emNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(emMoneyFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) + 1);
                emResetExchange();
            }
            cardJoeySpecial = false;
            return;
        }
        if (cardJoeyOngoing && sum >= 2)
        {
            if (EventSystem.current.currentSelectedGameObject == emConversionToTimeBtn.gameObject)
            {

                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(emTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(emNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(emMoneyFieldFrom.text));
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) + 1);
                emResetExchange();
            }
            else if (EventSystem.current.currentSelectedGameObject == emConversionToNetworkBtn.gameObject)
            {
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(emTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(emNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(emMoneyFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) + 1);
                emResetExchange();
            }
            else if (EventSystem.current.currentSelectedGameObject == emConversionToMoneyBtn.gameObject)
            {
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(emTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(emNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(emMoneyFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) + 1);
                emResetExchange();
            }
            cardJoeyOngoing = false;
            return;
        }
        if (sum >= 3)
        {
            if (EventSystem.current.currentSelectedGameObject == emConversionToTimeBtn.gameObject)
            {

                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(emTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(emNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(emMoneyFieldFrom.text));
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) + 1);
                emResetExchange();
            }
            else if (EventSystem.current.currentSelectedGameObject == emConversionToNetworkBtn.gameObject)
            {
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(emTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(emNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(emMoneyFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) + 1);
                emResetExchange();
            }
            else if (EventSystem.current.currentSelectedGameObject == emConversionToMoneyBtn.gameObject)
            {
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(emTimeFieldFrom.text));
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(emNetworkFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(emMoneyFieldFrom.text));
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) + 1);
                emResetExchange();
            }
        }
        else
        {
            NotEnoughResourcesPopup();
        }
    }
    private void emResetExchange()
    {
        emTimeFieldFrom.text = "0";
        emNetworkFieldFrom.text = "0";
        emMoneyFieldFrom.text = "0";
    }

    public void CardOneOngoingAbility()
    {
        if (card1 == cardPeter || card1.GetComponent<Image>().sprite == spPeterEx)
        {
            cardPeterOngoing = true;
            ongoingPeterBtn.interactable = false;
        }
        else if (card1 == cardRick || card1.GetComponent<Image>().sprite == spRickEx)
        {
            cardRickOngoing = true;
            ongoingRickBtn.interactable = false;
        }
        else if (card1 == cardTilda || card1.GetComponent<Image>().sprite == spTildaEx)
        {
            cardTildaOngoing = true;
            ongoingTildaBtn.interactable = false;
        }
        TextMoneyNetworkSet();

    }


/*    public void CardTwoOngoingAbility()
    {
        if (card2 == cardCharlie || card2.GetComponent<Image>().sprite == spCharlieEx)
        {
            cardCharlieOngoing = true;
            ongoingCharlieBtn.interactable = false;
        }
        else if (card2 == cardMaria || card2.GetComponent<Image>().sprite == spMariaEx)
        {
            cardMariaOngoing = true;
            ongoingMariaBtn.interactable = false;
        }
        else if (card2 == cardStefan || card2.GetComponent<Image>().sprite == spStefanEx)
        {
            cardStefanOngoing = true;
            ongoingStefanBtn.interactable = false;
        }
        TextMoneyNetworkSet();
    }*/

    public void AndrewMoneyOngoingAbility()
    {
        cardTildaOngoing = true;
        andrewNetworkOngoingButton.interactable = false;
        andrewMoneyOngoingButton.interactable = false;
        andrewTimeOngoingButton.interactable = false;
        TextMoneyNetworkSet();
    }
    public void AndrewNetworkOngoingAbility()
    {
        cardRickOngoing = true;
        andrewNetworkOngoingButton.interactable = false;
        andrewMoneyOngoingButton.interactable = false;
        andrewTimeOngoingButton.interactable = false;
        TextMoneyNetworkSet();
    }
    public void AndrewTimeOngoingAbility()
    {
        cardPeterOngoing = true;
        andrewNetworkOngoingButton.interactable = false;
        andrewMoneyOngoingButton.interactable = false;
        andrewTimeOngoingButton.interactable = false;
        TextMoneyNetworkSet();
    }

    public void CardThreeOngoingAbility()
    {

        if (card3 == cardJoey || card3.GetComponent<Image>().sprite == spJoeyEx)
        {
            cardJoeyOngoing = true;
            ongoingJoeyBtn.interactable = false;
        }
        else if (card3 == cardMario || card3.GetComponent<Image>().sprite == spMarioEx)
        {
            cardMarioOngoing = true;
            /*CardMarioOngoingAbility();*/
            ongoingMoneyMario1Btn.interactable = false;
            ongoingTimeMario2Btn.interactable = false;
            ongoingNetworkMario3Btn.interactable = false;
        }
        else if (card3 == cardMary || card3.GetComponent<Image>().sprite == spMaryEx)
        {
            cardMaryOngoing = true;
            ongoingMaryBtn.interactable = false;
        }
        else if (card3 == cardSandra || card3.GetComponent<Image>().sprite == spSandraEx)
        {
            cardSandraOngoing = true;
            ongoingSandraBtn.interactable = false;
            cardAnimator.SetBool("CardClicked", false);
            cardAnimator.SetBool("CardAndBackgroundClicked", true);
            communityInvolvementAnimator.SetBool("CommunityInvolvementClickExit", false);
            communityInvolvementAnimator.SetBool("CommunityInvolvementClick", true);
        }
        TextMoneyNetworkSet();
    }


    public void CardOneSpecialAbility()
    {
        if (card1 == cardPeter && card1.GetComponent<Image>().sprite != spPeterEx)
        {
            cardPeterSpecial = true;
            specialPeterBtn.interactable = false;
            cardPeter.GetComponent<Image>().sprite = spPeterEx;
            card1.GetComponent<Image>().sprite = spPeterEx;
        }
        else if (card1 == cardRick && card1.GetComponent<Image>().sprite != spRickEx)
        {
            cardRickSpecial = true;
            specialRickBtn.interactable = false;
            cardRick.GetComponent<Image>().sprite = spRickEx;
            card1.GetComponent<Image>().sprite = spRickEx;
        }
        else if (card1 == cardTilda && card1.GetComponent<Image>().sprite != spTildaEx)
        {
            cardTildaSpecial = true;
            specialTildaBtn.interactable = false;
            cardTilda.GetComponent<Image>().sprite = spTildaEx;
            card1.GetComponent<Image>().sprite = spTildaEx;
        }
        else
        {
            CustomPopup("Ready the Card First");
        }
        TextMoneyNetworkSet();
    }
    public void CardTwoSpecialAbility()
    {
        if (card2 == cardCharlie && card2.GetComponent<Image>().sprite != spCharlieEx)
        {
            cardCharlieSpecial = true;
            specialCharlieBtn.interactable = false;
            CardCharlieSpecialAbility();
            cardCharlie.GetComponent<Image>().sprite = spCharlieEx;
            card2.GetComponent<Image>().sprite = spCharlieEx;
        }
        else if (card2 == cardMaria && card2.GetComponent<Image>().sprite != spMariaEx)
        {
            cardMariaSpecial = true;
            specialMariaBtn.interactable = false;
            CardMariaSpecialAbility();
            cardMaria.GetComponent<Image>().sprite = spMariaEx;
            card2.GetComponent<Image>().sprite = spMariaEx;
        }
        else if (card2 == cardStefan && card2.GetComponent<Image>().sprite != spStefanEx)
        {
            cardStefanSpecial = true;
            specialStefanBtn.interactable = false;
            CardStefanSpecialAbility();
            cardStefan.GetComponent<Image>().sprite = spStefanEx;
            card2.GetComponent<Image>().sprite = spStefanEx;
        }
        else
        {
            CustomPopup("Ready the Card First");
        }
        TextMoneyNetworkSet();

    }
    public void CardThreeSpecialAbility()
    {
        if (card3 == cardAndrew && card3.GetComponent<Image>().sprite != spAndrewEx)
        {
            cardAndrewSpecial = true;
            specialAndrewBtn.interactable = false;
            cardAndrew.GetComponent<Image>().sprite = spAndrewEx;
            card3.GetComponent<Image>().sprite = spAndrewEx;
        }
        else if (card3 == cardJoey && card3.GetComponent<Image>().sprite != spJoeyEx)
        {
            cardJoeySpecial = true;
            specialJoeyBtn.interactable = false;
            cardJoey.GetComponent<Image>().sprite = spJoeyEx;
            card3.GetComponent<Image>().sprite = spJoeyEx;

        }
        else if (card3 == cardLiz && card3.GetComponent<Image>().sprite != spLizEx)
        {
            cardLizSpecial = true;
            specialLiz1Btn.interactable = false;
            specialLiz2Btn.interactable = false;
            cardLiz.GetComponent<Image>().sprite = spLizEx;
            card3.GetComponent<Image>().sprite = spLizEx;

        }
        else if (card3 == cardMario && card3.GetComponent<Image>().sprite != spMarioEx)
        {
            cardMarioSpecial = true;
            specialMarioBtn.interactable = false;
            cardMario.GetComponent<Image>().sprite = spMarioEx;
            card3.GetComponent<Image>().sprite = spMarioEx;

        }
        else if (card3 == cardMary && card3.GetComponent<Image>().sprite != spMaryEx)
        {
            cardMarySpecial = true;
            specialMaryBtn.interactable = false;
            cardMary.GetComponent<Image>().sprite = spMaryEx;
            card3.GetComponent<Image>().sprite = spMaryEx;
        }
        else if (card3 == cardSandra && card3.GetComponent<Image>().sprite != spSandraEx)
        {
            cardSandraSpecial = true;
            specialSandraBtn.interactable = false;
            cardSandra.GetComponent<Image>().sprite = spSandraEx;
            card3.GetComponent<Image>().sprite = spSandraEx;
            cardAnimator.SetBool("CardClicked", false);
            cardAnimator.SetBool("CardAndBackgroundClicked", true);
            communityInvolvementAnimator.SetBool("CommunityInvolvementClickExit", false);
            communityInvolvementAnimator.SetBool("CommunityInvolvementClick", true);
        }
        else
        {
            CustomPopup("Ready the Card First");
        }
        TextMoneyNetworkSet();

    }


    public void CardCharlieSpecialAbility()
    {
        if (cardCharlieSpecial)
        {
            lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) + 1);
            cardAndrewSpecial = false;
        }
        else
        {
            CustomPopup("Ready the card first");
        }
    }
    public void CardMariaSpecialAbility()
    {
        if (cardMariaSpecial)
        {
            lNetworkText.text = Convert.ToString(Convert.ToInt16(lNetworkText.text) + 1);
            cardMariaSpecial = false;
        }
        else
        {
            CustomPopup("Ready the card first");
        }
    }

    public void CardStefanSpecialAbility()
    {
        if (cardStefanSpecial)
        {
            lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) + 1);
            cardStefanSpecial = false;
        }
        else
        {
            CustomPopup("Ready the card first");
        }
    }

    /*private void CardMarioOngoingAbility()
    {
        int random = UnityEngine.Random.Range(1, 3);
        switch (random)
        {
            case 1:
                rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) + 1);
                cardMarioOngoing = false;
                break;
            case 2:
                rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) + 1);
                cardMarioOngoing = false;
                break;
            case 3:
                rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) + 1);
                cardMarioOngoing = false;
                break;
            default:
                break;
        }
    }*/


    public void NotEnoughResourcesPopup()
    {
        popupText.text = "Not Enough Resources";
        popupContainer.SetActive(true);
        popupContainer.GetComponent<Animator>().SetBool("PopupClosed", false);
        popupContainer.GetComponent<Animator>().SetBool("PopupOpened", true);
    }

    public void CompleteRealityCheckFirstPopup()
    {
        popupText.text = "Please Complete Reality Check First";
        popupContainer.SetActive(true);
        popupContainer.GetComponent<Animator>().SetBool("PopupClosed", false);
        popupContainer.GetComponent<Animator>().SetBool("PopupOpened", true);
    }

    public void CustomPopup(string _popupText)
    {
        popupText.text = _popupText;
        popupContainer.SetActive(true);
        popupContainer.GetComponent<Animator>().SetBool("PopupClosed", false);
        popupContainer.GetComponent<Animator>().SetBool("PopupOpened", true);
    }

    public void OperationInvalidPopup()
    {
        popupText.text = "Please Complete Reality Check First";
        popupContainer.SetActive(true);
        popupContainer.GetComponent<Animator>().SetBool("PopupClosed", false);
        popupContainer.GetComponent<Animator>().SetBool("PopupOpened", true);
    }
    public void PopupBackDown()
    {
        popupContainer.GetComponent<Animator>().SetBool("PopupClosed", true);
        popupContainer.GetComponent<Animator>().SetBool("PopupOpened", false);
    }

    public void PopupInactive()
    {
        popupContainer.SetActive(false);
    }

    public void RealityCheckBurnoutSyndromCard1()
    {
        if (card1.GetComponent<Image>().sprite != cards[cardOneIndex + 1].GetComponent<Image>().sprite)
        {
            if (card1 == cardPeter && card1.GetComponent<Image>().sprite != spPeterEx)
            {
                cardPeterSpecial = false;
                specialPeterBtn.interactable = false;
                cardPeter.GetComponent<Image>().sprite = spPeterEx;
                card1.GetComponent<Image>().sprite = spPeterEx;
            }
            else if (card1 == cardRick && card1.GetComponent<Image>().sprite != spRickEx)
            {
                cardRickSpecial = false;
                specialRickBtn.interactable = false;
                cardRick.GetComponent<Image>().sprite = spRickEx;
                card1.GetComponent<Image>().sprite = spRickEx;
            }
            else if (card1 == cardTilda && card1.GetComponent<Image>().sprite != spTildaEx)
            {
                cardTildaSpecial = false;
                specialTildaBtn.interactable = false;
                cardTilda.GetComponent<Image>().sprite = spTildaEx;
                card1.GetComponent<Image>().sprite = spTildaEx;
            }
            RealityCheck.rcBurnoutSyndrome = false;
            realityCheckContainer.SetActive(false);
        }
        else
        {
            CustomPopup("Card 1 is already Exhausted. Choose Another");
            rcBurnoutCard1Btn.gameObject.SetActive(false);
        }
        if (!rcBurnoutCard1Btn.gameObject.activeSelf && !rcBurnoutCard2Btn.gameObject.activeSelf && !rcBurnoutCard3Btn.gameObject.activeSelf)
        {
            rcBurnoutResourceBtn.gameObject.SetActive(true);
        }
    }
    public void RealityCheckBurnoutSyndromCard2()
    {
        if (card2.GetComponent<Image>().sprite != cards[cardTwoIndex + 1].GetComponent<Image>().sprite)
        {
            if (card2 == cardCharlie && card2.GetComponent<Image>().sprite != spCharlieEx)
            {
                cardCharlieSpecial = false;
                specialCharlieBtn.interactable = false;
                cardCharlie.GetComponent<Image>().sprite = spCharlieEx;
                card2.GetComponent<Image>().sprite = spCharlieEx;
            }
            else if (card2 == cardMaria && card2.GetComponent<Image>().sprite != spMariaEx)
            {
                cardMariaSpecial = false;
                specialMariaBtn.interactable = false;
                cardMaria.GetComponent<Image>().sprite = spMariaEx;
                card2.GetComponent<Image>().sprite = spMariaEx;
            }
            else if (card2 == cardStefan && card2.GetComponent<Image>().sprite != spStefanEx)
            {
                cardStefanSpecial = false;
                specialStefanBtn.interactable = false;
                cardStefan.GetComponent<Image>().sprite = spStefanEx;
                card2.GetComponent<Image>().sprite = spStefanEx;
            }
            RealityCheck.rcBurnoutSyndrome = false;
            realityCheckContainer.SetActive(false);
        }
        else
        {
            CustomPopup("Card 2 is already Exhausted. Choose Another");
            rcBurnoutCard2Btn.gameObject.SetActive(false);
        }
        if (!rcBurnoutCard1Btn.gameObject.activeSelf && !rcBurnoutCard2Btn.gameObject.activeSelf && !rcBurnoutCard3Btn.gameObject.activeSelf)
        {
            rcBurnoutResourceBtn.gameObject.SetActive(true);
        }
    }

    public void RealityCheckBurnoutSyndromCard3()
    {
        if (card3.GetComponent<Image>().sprite != cards[cardThreeIndex + 1].GetComponent<Image>().sprite)
        {
            if (card3 == cardAndrew && card3.GetComponent<Image>().sprite != spAndrewEx)
            {
                cardAndrewSpecial = false;
                specialAndrewBtn.interactable = false;
                cardAndrew.GetComponent<Image>().sprite = spAndrewEx;
                card3.GetComponent<Image>().sprite = spAndrewEx;
            }
            else if (card3 == cardJoey && card3.GetComponent<Image>().sprite != spJoeyEx)
            {
                cardJoeySpecial = false;
                specialJoeyBtn.interactable = false;
                cardJoey.GetComponent<Image>().sprite = spJoeyEx;
                card3.GetComponent<Image>().sprite = spJoeyEx;

            }
            else if (card3 == cardLiz && card3.GetComponent<Image>().sprite != spLizEx)
            {
                cardLizSpecial = false;
                specialLiz1Btn.interactable = false;
                specialLiz2Btn.interactable = false;
                cardLiz.GetComponent<Image>().sprite = spLizEx;
                card3.GetComponent<Image>().sprite = spLizEx;
            }
            else if (card3 == cardMario && card3.GetComponent<Image>().sprite != spMarioEx)
            {
                cardMarioSpecial = false;
                specialMarioBtn.interactable = false;
                cardMario.GetComponent<Image>().sprite = spMarioEx;
                card3.GetComponent<Image>().sprite = spMarioEx;

            }
            else if (card3 == cardMary && card3.GetComponent<Image>().sprite != spMaryEx)
            {
                cardMarySpecial = false;
                specialMaryBtn.interactable = false;
                cardMary.GetComponent<Image>().sprite = spMaryEx;
                card3.GetComponent<Image>().sprite = spMaryEx;
            }
            else if (card3 == cardSandra && card3.GetComponent<Image>().sprite != spSandraEx)
            {
                cardSandraSpecial = false;
                specialSandraBtn.interactable = false;
                cardSandra.GetComponent<Image>().sprite = spSandraEx;
                card3.GetComponent<Image>().sprite = spSandraEx;
            }
            RealityCheck.rcBurnoutSyndrome = false;
            realityCheckContainer.SetActive(false);
        }
        else
        {
            CustomPopup("Card 3 is already Exhausted. Choose Another");
            rcBurnoutCard3Btn.gameObject.SetActive(false);
        }
        if (!rcBurnoutCard1Btn.gameObject.activeSelf && !rcBurnoutCard2Btn.gameObject.activeSelf && !rcBurnoutCard3Btn.gameObject.activeSelf)
        {
            rcBurnoutResourceBtn.gameObject.SetActive(true);
        }
    }
    public void RealityCheckBurnoutLoseResources()
    {
        resourceGainerContainer.GetComponent<Animator>().SetBool("GetResourceDown", false);
        rgHeadingText.text = "Select any Three resources to deplet";
        resourceGainerContainer.SetActive(true);
        rgGetNowBtn.onClick.RemoveAllListeners();
        rgGetNowBtn.onClick.AddListener(RealityCheckBurnoutLoseResourcesBtn);
        rgGetNowBtn.GetComponentInChildren<TextMeshProUGUI>().text = "Lose Resources";

    }

    public void RealityCheckBurnoutLoseResourcesBtn()
    {
        if (String.IsNullOrWhiteSpace(rgMoneyInput.text))
        {
            rgMoneyInput.text = "0";
        }

        if (String.IsNullOrWhiteSpace(rgNetworkInput.text))
        {
            rgNetworkInput.text = "0";
        }

        if (String.IsNullOrWhiteSpace(rgTimeInput.text))
        {
            rgTimeInput.text = "0";
        }

        int sum = Convert.ToInt16(rgMoneyInput.text) + Convert.ToInt16(rgNetworkInput.text) + Convert.ToInt16(rgTimeInput.text);

        if (sum == 3)
        {
            rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) - Convert.ToInt16(rgMoneyInput.text));
            rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) - Convert.ToInt16(rgNetworkInput.text));
            rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) - Convert.ToInt16(rgTimeInput.text));
            resourceGainerContainer.GetComponent<Animator>().SetBool("GetResourceDown", true);
            RealityCheck.rcBurnoutSyndrome = false;
            rcBurnoutResourceBtn.gameObject.SetActive(false);
            realityCheckContainer.SetActive(false);
        }
        else
        {
            CustomPopup("Sum of Resources should only be 3");
        }
    }

    public void RealityCheckTeamBuildingGetResources()
    {
        resourceGainerContainer.GetComponent<Animator>().SetBool("GetResourceDown", false);
        rgHeadingText.text = "Select any Three resources to Get";
        resourceGainerContainer.SetActive(true);
        rgGetNowBtn.onClick.RemoveAllListeners();
        rgGetNowBtn.onClick.AddListener(GetThreeResources);
        rgGetNowBtn.GetComponentInChildren<TextMeshProUGUI>().text = "Gain Resources";
        RealityCheck.rcTeamBuilding = false;
        realityCheckContainer.SetActive(false) ;
    }
    public void GetThreeResources()
    {
        if (String.IsNullOrWhiteSpace(rgMoneyInput.text))
        {
            rgMoneyInput.text = "0";
        }

        if (String.IsNullOrWhiteSpace(rgNetworkInput.text))
        {
            rgNetworkInput.text = "0";
        }

        if (String.IsNullOrWhiteSpace(rgTimeInput.text))
        {
            rgTimeInput.text = "0";
        }

        int sum = Convert.ToInt16(rgMoneyInput.text) + Convert.ToInt16(rgNetworkInput.text) + Convert.ToInt16(rgTimeInput.text);

        if (sum == 3)
        {
            rMoneyText.text = Convert.ToString( Convert.ToInt32(rMoneyText.text) + Convert.ToInt32(rgMoneyInput.text) );
            rNetworkText.text = Convert.ToString(Convert.ToInt32(rNetworkText.text) + Convert.ToInt32(rgNetworkInput.text));
            rTimeText.text = Convert.ToString(Convert.ToInt32(rTimeText.text) + Convert.ToInt32(rgTimeInput.text));
            resourceGainerContainer.GetComponent<Animator>().SetBool("GetResourceDown", true);
        }
        else
        {
            CustomPopup("Sum of Resources should only be 3");
        }
    }

    public void TeamBuildingReadyCard1()
    {
        if (card1.GetComponent<Image>().sprite == cards[cardOneIndex + 1].GetComponent<Image>().sprite)
        {
            if (card1 == cardPeter && card1.GetComponent<Image>().sprite == spPeterEx)
            {
                specialPeterBtn.interactable = true;
                cardPeter.GetComponent<Image>().sprite = spPeter;
                card1.GetComponent<Image>().sprite = spPeter;
            }
            else if (card1 == cardRick && card1.GetComponent<Image>().sprite == spRickEx)
            {
                specialRickBtn.interactable = true;
                cardRick.GetComponent<Image>().sprite = spRick;
                card1.GetComponent<Image>().sprite = spRick;
            }
            else if (card1 == cardTilda && card1.GetComponent<Image>().sprite == spTildaEx)
            {
                specialTildaBtn.interactable = true;
                cardTilda.GetComponent<Image>().sprite = spTilda;
                card1.GetComponent<Image>().sprite = spTilda;
            }
            RealityCheck.rcTeamBuilding = false;
            realityCheckContainer.SetActive(false);
        }
        else
        {
            CustomPopup("Card 1 is already ready. Choose Another");
            rcTeamBuildingCard1Btn.gameObject.SetActive(false);
        }
        if (!rcTeamBuildingCard1Btn.gameObject.activeSelf && !rcTeamBuildingCard2Btn.gameObject.activeSelf && !rcTeamBuildingCard3Btn.gameObject.activeSelf)
        {
            rcTeamBuildingResourceBtn.gameObject.SetActive(true);
        }
    }
    public void TeamBuildingReadyCard2()
    {
        if (card2.GetComponent<Image>().sprite == cards[cardTwoIndex + 1].GetComponent<Image>().sprite)
        {
            if (card2 == cardCharlie && card2.GetComponent<Image>().sprite == spCharlieEx)
            {
                specialCharlieBtn.interactable = true;
                cardCharlie.GetComponent<Image>().sprite = spCharlie;
                card2.GetComponent<Image>().sprite = spCharlie;
            }
            else if (card2 == cardMaria && card2.GetComponent<Image>().sprite == spMariaEx)
            {
                specialMariaBtn.interactable = true;
                cardMaria.GetComponent<Image>().sprite = spMaria;
                card2.GetComponent<Image>().sprite = spMaria;
            }
            else if (card2 == cardStefan && card2.GetComponent<Image>().sprite == spStefanEx)
            {
                specialStefanBtn.interactable = true;
                cardStefan.GetComponent<Image>().sprite = spStefan;
                card2.GetComponent<Image>().sprite = spStefan;
            }
            RealityCheck.rcTeamBuilding = false;
            realityCheckContainer.SetActive(false);
        }
        else
        {
            CustomPopup("Card 2 is already ready. Choose Another");
            rcTeamBuildingCard2Btn.gameObject.SetActive(false);
        }
        if (!rcTeamBuildingCard1Btn.gameObject.activeSelf && !rcTeamBuildingCard2Btn.gameObject.activeSelf && !rcTeamBuildingCard3Btn.gameObject.activeSelf)
        {
            rcTeamBuildingResourceBtn.gameObject.SetActive(true);
        }
    }

    public void TeamBuildingReadyCard3()
    {
        if (card3.GetComponent<Image>().sprite == cards[cardThreeIndex + 1].GetComponent<Image>().sprite)
        {
            if (card3 == cardAndrew && card3.GetComponent<Image>().sprite == spAndrewEx)
            {
                specialAndrewBtn.interactable = true;
                cardAndrew.GetComponent<Image>().sprite = spAndrew;
                card3.GetComponent<Image>().sprite = spAndrew;
            }
            else if (card3 == cardJoey && card3.GetComponent<Image>().sprite == spJoeyEx)
            {
                specialJoeyBtn.interactable = true;
                cardJoey.GetComponent<Image>().sprite = spJoey;
                card3.GetComponent<Image>().sprite = spJoey;
            }
            else if (card3 == cardLiz && card3.GetComponent<Image>().sprite == spLizEx)
            {
                specialLiz1Btn.interactable = true;
                specialLiz2Btn.interactable = true;
                cardLiz.GetComponent<Image>().sprite = spLiz;
                card3.GetComponent<Image>().sprite = spLiz;
            }
            else if (card3 == cardMario && card3.GetComponent<Image>().sprite == spMarioEx)
            {
                specialMarioBtn.interactable = true;
                cardMario.GetComponent<Image>().sprite = spMario;
                card3.GetComponent<Image>().sprite = spMario;
            }
            else if (card3 == cardMary && card3.GetComponent<Image>().sprite == spMaryEx)
            {
                specialMaryBtn.interactable = true;
                cardMary.GetComponent<Image>().sprite = spMary;
                card3.GetComponent<Image>().sprite = spMary;
            }
            else if (card3 == cardSandra && card3.GetComponent<Image>().sprite == spSandraEx)
            {
                specialSandraBtn.interactable = true;
                cardSandra.GetComponent<Image>().sprite = spSandra;
                card3.GetComponent<Image>().sprite = spSandra;
            }
            RealityCheck.rcTeamBuilding = false;
            realityCheckContainer.SetActive(false);
        }
        else
        {
            CustomPopup("Card 3 is already ready. Choose Another");
            rcTeamBuildingCard3Btn.gameObject.SetActive(false);
        }
        if (!rcTeamBuildingCard1Btn.gameObject.activeSelf && !rcTeamBuildingCard2Btn.gameObject.activeSelf && !rcTeamBuildingCard3Btn.gameObject.activeSelf)
        {
            rcTeamBuildingResourceBtn.gameObject.SetActive(true);
        }
    }

    public void CommunitWellbeingReadyCard1()
    {
        if (card1.GetComponent<Image>().sprite == cards[cardOneIndex + 1].GetComponent<Image>().sprite)
        {
            if (card1 == cardPeter && card1.GetComponent<Image>().sprite == spPeterEx)
            {
                specialPeterBtn.interactable = true;
                cardPeter.GetComponent<Image>().sprite = spPeter;
                card1.GetComponent<Image>().sprite = spPeter;
            }
            else if (card1 == cardRick && card1.GetComponent<Image>().sprite == spRickEx)
            {
                specialRickBtn.interactable = true;
                cardRick.GetComponent<Image>().sprite = spRick;
                card1.GetComponent<Image>().sprite = spRick;
            }
            else if (card1 == cardTilda && card1.GetComponent<Image>().sprite == spTildaEx)
            {
                specialTildaBtn.interactable = true;
                cardTilda.GetComponent<Image>().sprite = spTilda;
                card1.GetComponent<Image>().sprite = spTilda;
            }
            communityWellbeingReadyCard1Btn.gameObject.SetActive(false);
            communityWellbeingReadyCard2Btn.gameObject.SetActive(false);
            communityWellbeingReadyCard3Btn.gameObject.SetActive(false);
        }
        else
        {
            CustomPopup("Card 1 is already ready. Choose Another");
            rcTeamBuildingCard1Btn.gameObject.SetActive(false);
        }
    }
    public void CommunitWellbeingReadyCard2()
    {
        if (card2.GetComponent<Image>().sprite == cards[cardTwoIndex + 1].GetComponent<Image>().sprite)
        {
            if (card2 == cardCharlie && card2.GetComponent<Image>().sprite == spCharlieEx)
            {
                specialCharlieBtn.interactable = true;
                cardCharlie.GetComponent<Image>().sprite = spCharlie;
                card2.GetComponent<Image>().sprite = spCharlie;
            }
            else if (card2 == cardMaria && card2.GetComponent<Image>().sprite == spMariaEx)
            {
                specialMariaBtn.interactable = true;
                cardMaria.GetComponent<Image>().sprite = spMaria;
                card2.GetComponent<Image>().sprite = spMaria;
            }
            else if (card2 == cardStefan && card2.GetComponent<Image>().sprite == spStefanEx)
            {
                specialStefanBtn.interactable = true;
                cardStefan.GetComponent<Image>().sprite = spStefan;
                card2.GetComponent<Image>().sprite = spStefan;
            }
            communityWellbeingReadyCard1Btn.gameObject.SetActive(false);
            communityWellbeingReadyCard2Btn.gameObject.SetActive(false);
            communityWellbeingReadyCard3Btn.gameObject.SetActive(false);
        }
        else
        {
            CustomPopup("Card 2 is already ready. Choose Another");
            rcTeamBuildingCard2Btn.gameObject.SetActive(false);
        }
    }

    public void CommunitWellbeingReadyCard3()
    {
        if (card3.GetComponent<Image>().sprite == cards[cardThreeIndex + 1].GetComponent<Image>().sprite)
        {
            if (card3 == cardAndrew && card3.GetComponent<Image>().sprite == spAndrewEx)
            {
                specialAndrewBtn.interactable = true;
                cardAndrew.GetComponent<Image>().sprite = spAndrew;
                card3.GetComponent<Image>().sprite = spAndrew;
            }
            else if (card3 == cardJoey && card3.GetComponent<Image>().sprite == spJoeyEx)
            {
                specialJoeyBtn.interactable = true;
                cardJoey.GetComponent<Image>().sprite = spJoey;
                card3.GetComponent<Image>().sprite = spJoey;

            }
            else if (card3 == cardLiz && card3.GetComponent<Image>().sprite == spLizEx)
            {
                specialLiz1Btn.interactable = true;
                specialLiz2Btn.interactable = true;
                cardLiz.GetComponent<Image>().sprite = spLiz;
                card3.GetComponent<Image>().sprite = spLiz;
            }
            else if (card3 == cardMario && card3.GetComponent<Image>().sprite == spMarioEx)
            {
                specialMarioBtn.interactable = true;
                cardMario.GetComponent<Image>().sprite = spMario;
                card3.GetComponent<Image>().sprite = spMario;

            }
            else if (card3 == cardMary && card3.GetComponent<Image>().sprite == spMaryEx)
            {
                specialMaryBtn.interactable = true;
                cardMary.GetComponent<Image>().sprite = spMary;
                card3.GetComponent<Image>().sprite = spMary;
            }
            else if (card3 == cardSandra && card3.GetComponent<Image>().sprite == spSandraEx)
            {
                specialSandraBtn.interactable = true;
                cardSandra.GetComponent<Image>().sprite = spSandra;
                card3.GetComponent<Image>().sprite = spSandra;
            }
            communityWellbeingReadyCard1Btn.gameObject.SetActive(false);
            communityWellbeingReadyCard2Btn.gameObject.SetActive(false);
            communityWellbeingReadyCard3Btn.gameObject.SetActive(false);
        }
        else
        {
            CustomPopup("Card 3 is already ready. Choose Another");
            rcTeamBuildingCard3Btn.gameObject.SetActive(false);
        }
    }

    public void CommunityWellbeingReadyCharacter()
    {
        communityWellbeingReadyCard1Btn.GetComponentInChildren<TextMeshProUGUI>().text = $"Ready {cardOneName}";
        communityWellbeingReadyCard1Btn.gameObject.SetActive(true);
        communityWellbeingReadyCard2Btn.GetComponentInChildren<TextMeshProUGUI>().text = $"Ready {cardTwoName}";
        communityWellbeingReadyCard2Btn.gameObject.SetActive(true);
        communityWellbeingReadyCard3Btn.GetComponentInChildren<TextMeshProUGUI>().text = $"Ready {cardThreeName}";
        communityWellbeingReadyCard3Btn.gameObject.SetActive(true);
    }

    public void NextRoundStart()
    {
        round++;
        isNewRound= true;
        realityCheckContainer.SetActive(false);
        situationCardContainer.SetActive(false);

        situation1Container.SetActive(false);
        situationOneActionOneBtn.gameObject.SetActive(false);
        situationOneActionTwoBtn.gameObject.SetActive(false);
        situationOneActionThreeBtn.gameObject.SetActive(false);
        situationOneIgnoreBtn.gameObject.SetActive(false);
        situationOneBtn.gameObject.SetActive(false);

        situation2Container.SetActive(false);
        situationTwoActionOneBtn.gameObject.SetActive(false);
        situationTwoActionTwoBtn.gameObject.SetActive(false);
        situationTwoActionThreeBtn.gameObject.SetActive(false);
        situationTwoIgnoreBtn.gameObject.SetActive(false);
        situationTwoBtn.gameObject.SetActive(false);

        situationActionContainer.SetActive(false);
        goBackToSituationBtn.gameObject.SetActive(false);
        goToAnotherSituationAfterCompletingOneBtn.gameObject.SetActive(false);

        realityCheckObject.involvementGrowth.SetActive(false);
        realityCheckObject.economicCrisis.SetActive(false);
        realityCheckObject.caringCommunity.SetActive(false);
        realityCheckObject.unexpectedCosts.SetActive(false);
        realityCheckObject.hiredExpert.SetActive(false);
        realityCheckObject.burnoutSyndrome.SetActive(false);
        realityCheckObject.governmentObstacles.SetActive(false);
        realityCheckObject.localGrant.SetActive(false);
        realityCheckObject.timeManagementTraining.SetActive(false);
        realityCheckObject.volunteers.SetActive(false);
        realityCheckObject.extraHelp.SetActive(false);
        realityCheckObject.callAFriend.SetActive(false);
        realityCheckObject.networking.SetActive(false);
        realityCheckObject.injury.SetActive(false);
        realityCheckObject.extraHours.SetActive(false);
        realityCheckObject.teamBuilding.SetActive(false);
        realityCheckObject.enterprenuerSpirit.SetActive(false);
        realityCheckObject.donor.SetActive(false);

        situationObject.SituationActsInactive();
        if (round != 6)
        {
            HeadingAndInstructionText($"Lets go for round {round}",
            "But before that you should take a look at Community Involvment");
            communityInvolvementGoToNextRoundBtn.GetComponentInChildren<TextMeshProUGUI>().text = "Go To Next Round";
        }
        if (round == 6)
        {
            HeadingAndInstructionText($"Some Final Actions Remaining",
            "Make you use this opportunity to go up on community invovement as much as you can.");
            communityInvolvementGoToNextRoundBtn.GetComponentInChildren<TextMeshProUGUI>().text = "Check Final Scores";
        }

        communityInvolvment.GetComponent<Animator>().SetBool("CommunityInvolvementClick", true);
        communityInvolvment.GetComponent<Animator>().SetBool("CommunityInvolvementClickExit", false);
        communityInvolvementGoToNextRoundBtn.gameObject.SetActive(true);

        situationObject.ChooseSituationButtonRemoveProperty();

        situationAnimator.SetBool("SituationCard1Selected", false);
        situationAnimator.SetBool("SituationCard2Selected", false);

    }

    public void NextRoundInitialize()
    {
        if (round == 6)
        {
            situationCardContainer.SetActive(false);
            cardsContainer.SetActive(false);
            resourceContainer.SetActive(false);
            longTermEffectContainer.SetActive(false);
            communityInvolvment.SetActive(false);
            communityInvolvmentBackground.SetActive(false);
            communityWellbeing.SetActive(false);
            communityWellbeingCube.SetActive(false);
            realityCheckContainer.SetActive(false);
            situationActionContainer.SetActive(false);
            resourceGainerContainer.SetActive(false);
            finishGameBtn.gameObject.SetActive(true);
            exchangeMenuButton.gameObject.SetActive(false);           
            isNewRound = false;
            HeadingAndInstructionText("FINAL SCORE",
            "Congratulations! you have completed the game. Remember, Only you can defeat you.");
            finalScoreText.gameObject.SetActive(true);
            finalMessageText.gameObject.SetActive(true);
            int finalScore = CommunityWellbeing.wellbeingLevelCount + CommunityInvolvement.protestMoveCounter + CommunityInvolvement.donationMoveCounter + CommunityInvolvement.petitionMoveCounter;
            finalScoreText.text = $"YOU SCORED '{finalScore}'";
            if (finalScore < 10)
            {
                finalMessageText.text = "The community is very unhappy, you probably had very bad conditions";
            }
            else if (finalScore >= 10 && finalScore < 15)
            {
                finalMessageText.text = "The problems are persisting, but don't be upset, without you, it would have been worse.";
            }
            else if (finalScore >= 15 && finalScore < 20)
            {
                finalMessageText.text = "Great job! Your community is amazed by what you have done for them.";
            }
            else if (finalScore >= 20 && finalScore < 25)
            {
                finalMessageText.text = "Wonderful job! You met the high standard of your community and they are doing great!";
            }
            else if (finalScore > 25)
            {
                finalMessageText.text = "You are a master of youth participation! We wish you good luck in applying it in real life!";
            }
            return;
        }
        HeadingAndInstructionText("CHOOSE A SITUATION",
        "This round, you will be facing two situations. Read them and decide, which one you want to do first.");
        roundCounterText.text = $"Round {round} of Round 5";

        rMoneyText.text = lMoneyText.text;
        rNetworkText.text = lNetworkText.text;
        rTimeText.text = lTimeText.text;

        isNewRound = false;
        situationObject.ShuffleSituationCards();
        situationCardContainer.SetActive(true);
        situation1Container.SetActive(true);
        situation2Container.SetActive(true);
        situationOneBtn.gameObject.SetActive(true);
        situationTwoBtn.gameObject.SetActive(true);
        communityInvolvementGoToNextRoundBtn.gameObject.SetActive(false);
        communityInvolvment.GetComponent<Animator>().SetBool("CommunityInvolvementClick", false);
        communityInvolvment.GetComponent<Animator>().SetBool("CommunityInvolvementClickExit", true);
        andrewMoneyOngoingButton.interactable = true;
        andrewTimeOngoingButton.interactable = true;
        andrewNetworkOngoingButton.interactable = true;
/*        ongoingCharlieBtn.interactable = true;
*/        ongoingJoeyBtn.interactable = true;
        ongoingLiz1Btn.interactable = true;
        ongoingLiz2Btn.interactable = true;
/*        ongoingMariaBtn.interactable = true;
*/        ongoingMoneyMario1Btn.interactable = true;
        ongoingTimeMario2Btn.interactable = true;
        ongoingNetworkMario3Btn.interactable = true;
        ongoingMaryBtn.interactable = true;
        ongoingRickBtn.interactable = true;
        ongoingPeterBtn.interactable = true;
        ongoingSandraBtn.interactable = true;
/*        ongoingStefanBtn.interactable = true;
*/        ongoingTildaBtn.interactable = true;
    }

    public void LizReadyCard1()
    {
        if (card1.GetComponent<Image>().sprite == cards[cardOneIndex + 1].GetComponent<Image>().sprite)
        {
            if (card1 == cardPeter && card1.GetComponent<Image>().sprite == spPeterEx)
            {
                //cardPeterSpecial = true;
                specialPeterBtn.interactable = true;
                cardPeter.GetComponent<Image>().sprite = spPeter;
                card1.GetComponent<Image>().sprite = spPeter;               
            }
            else if (card1 == cardRick && card1.GetComponent<Image>().sprite == spRickEx)
            {
                //cardRickSpecial = true;
                specialRickBtn.interactable = true;
                cardRick.GetComponent<Image>().sprite = spRick;
                card1.GetComponent<Image>().sprite = spRick;
            }
            else if (card1 == cardTilda && card1.GetComponent<Image>().sprite == spTildaEx)
            {
                //cardTildaSpecial = true;
                specialTildaBtn.interactable = true;
                cardTilda.GetComponent<Image>().sprite = spTilda;
                card1.GetComponent<Image>().sprite = spTilda;
            }
            cardLiz.GetComponent<Image>().sprite = spLizEx;
            cardLizSpecial = false;
            specialLiz1Btn.interactable = false;
            specialLiz2Btn.interactable = false;
        }
        else
        {
            CustomPopup("Card 1 is already ready. Choose Another");
        }
    }

    public void LizReadyCard2()
    {
        if (card2.GetComponent<Image>().sprite == cards[cardTwoIndex + 1].GetComponent<Image>().sprite)
        {
            if (card2 == cardCharlie && card2.GetComponent<Image>().sprite == spCharlieEx)
            {
                //cardCharlieSpecial = true;
                specialCharlieBtn.interactable = true;
                cardCharlie.GetComponent<Image>().sprite = spCharlie;
                card2.GetComponent<Image>().sprite = spCharlie;
            }
            else if (card2 == cardMaria && card2.GetComponent<Image>().sprite == spMariaEx)
            {
                //cardMariaSpecial = true;
                specialMariaBtn.interactable = true;
                cardMaria.GetComponent<Image>().sprite = spMaria;
                card2.GetComponent<Image>().sprite = spMaria;
            }
            else if (card2 == cardStefan && card2.GetComponent<Image>().sprite == spStefanEx)
            {
                //cardStefanSpecial = true;
                specialStefanBtn.interactable = true;
                cardStefan.GetComponent<Image>().sprite = spStefan;
                card2.GetComponent<Image>().sprite = spStefan;
            }
            cardLiz.GetComponent<Image>().sprite = spLizEx;
            cardLizSpecial = false;
            specialLiz1Btn.interactable = false;
            specialLiz2Btn.interactable = false;
        }
        else
        {
            CustomPopup("Card 2 is already ready. Choose Another");
        }
    }

    public void LizCopyCard1()
    {
        if (card1 == cardPeter || card1 == cardPeterEx)
        {
            cardPeterOngoing = true;
            CustomPopup("You gained Peter's Ongoing Ability");
        }
        else if (card1 == cardRick || card1 == cardRickEx)
        {
            cardRickOngoing = true;
            CustomPopup("You gained Rick's Ongoing Ability");
        }
        else if (card1 == cardTilda || card1 == cardTildaEx)
        {
            cardTildaOngoing = true;
            CustomPopup("You gained Tilda's Ongoing Ability");
        }
        cardLizOngoing = false;
        ongoingLiz1Btn.interactable = false;
        ongoingLiz2Btn.interactable = false;
    }
    public void LizCopyCard2()
    {
        if (card2 == cardCharlie || card2 == cardCharlieEx)
        {
            cardLizCharlieOngoing = true;
            CustomPopup("You gained Charlie's Ongoing Ability");
        }
        else if (card2 == cardMaria || card2 == cardMariaEx)
        {
            cardLizMariaOngoing = true;
            CustomPopup("You gained Maria's Ongoing Ability");
        }
        else if (card2 == cardStefan || card2 == cardStefanEx)
        {
            cardLizStefanOngoing = true;
            CustomPopup("You gained Stefan's Ongoing Ability");
        }
        cardLizOngoing = false;
        ongoingLiz1Btn.interactable = false;
        ongoingLiz2Btn.interactable = false;
    }

    public void OngoingMarioMoneyGain()
    {
        cardMarioOngoing = false;
        /*CardMarioOngoingAbility();*/
        ongoingMoneyMario1Btn.interactable = false;
        ongoingTimeMario2Btn.interactable = false;
        ongoingNetworkMario3Btn.interactable = false;
        rMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) + 1);
    }

    public void OngoingMarioTimeGain()
    {
        cardMarioOngoing = false;
        /*CardMarioOngoingAbility();*/
        ongoingMoneyMario1Btn.interactable = false;
        ongoingTimeMario2Btn.interactable = false;
        ongoingNetworkMario3Btn.interactable = false;
        rTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) + 1);
    }

    public void OngoingMarioNetworkGain()
    {
        cardMarioOngoing = false;
        /*CardMarioOngoingAbility();*/
        ongoingMoneyMario1Btn.interactable = false;
        ongoingTimeMario2Btn.interactable = false;
        ongoingNetworkMario3Btn.interactable = false;
        rNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) + 1);
    }

    /*public void NextRoundStart()
    {
        round++;
        realityCheckContainer.SetActive(false);
        cardsContainer.SetActive(false);
        card1.SetActive(false);
        card2.SetActive(false);
        card3.SetActive(false);
        longTermEffectContainer.SetActive(false);
        resourceContainer.SetActive(false);
        situationCardContainer.SetActive(false);

        situation1Container.SetActive(false);
        situationOneActionOneBtn.gameObject.SetActive(false);
        situationOneActionTwoBtn.gameObject.SetActive(false);
        situationOneActionThreeBtn.gameObject.SetActive(false);
        situationOneIgnoreBtn.gameObject.SetActive(false);
        situationOneBtn.gameObject.SetActive(false);    

        situation2Container.SetActive(false);
        situationTwoActionOneBtn.gameObject.SetActive(false);
        situationTwoActionTwoBtn.gameObject.SetActive(false);
        situationTwoActionThreeBtn.gameObject.SetActive(false);
        situationTwoIgnoreBtn.gameObject.SetActive(false);
        situationTwoBtn.gameObject.SetActive(false);

        situationActionContainer.SetActive(false);
        communityWellbeing.SetActive(false);
        communityInvolvment.SetActive(false);
        goBackToSituationBtn.gameObject.SetActive(false);
        goToAnotherSituationAfterCompletingOneBtn.gameObject.SetActive(false);

        realityCheckObject.involvementGrowth.SetActive(false);
        realityCheckObject.economicCrisis.SetActive(false);
        realityCheckObject.caringCommunity.SetActive(false);
        realityCheckObject.unexpectedCosts.SetActive(false);
        realityCheckObject.hiredExpert.SetActive(false);
        realityCheckObject.burnoutSyndrome.SetActive(false);
        realityCheckObject.governmentObstacles.SetActive(false);
        realityCheckObject.localGrant.SetActive(false);
        realityCheckObject.timeManagementTraining.SetActive(false);
        realityCheckObject.volunteers.SetActive(false);
        realityCheckObject.extraHelp.SetActive(false);
        realityCheckObject.callAFriend.SetActive(false);
        realityCheckObject.networking.SetActive(false);
        realityCheckObject.injury.SetActive(false);
        realityCheckObject.extraHours.SetActive(false);
        realityCheckObject.teamBuilding.SetActive(false);
        realityCheckObject.enterprenuerSpirit.SetActive(false);
        realityCheckObject.donor.SetActive(false);

        situationObject.SituationActsInactive();

        HeadingAndInstructionText($"Lets go for round {round}", 
            "Here have the updated cards");
        CardAllotment();
        situationObject.ShuffleSituationCards();
        ongoingAndrewBtn.interactable = true;
        ongoingAndrewBtn.gameObject.SetActive(false);
        ongoingCharlieBtn.interactable = true;
        ongoingCharlieBtn.gameObject.SetActive(false);
        ongoingJoeyBtn.interactable = true;
        ongoingJoeyBtn.gameObject.SetActive(false);
        ongoingLizBtn.interactable = true; ;
        ongoingLizBtn.gameObject.SetActive(false);
        ongoingMariaBtn.interactable = true; ;
        ongoingMariaBtn.gameObject.SetActive(false);
        ongoingMarioBtn.interactable = true; ;
        ongoingMarioBtn.gameObject.SetActive(false);
        ongoingMaryBtn.interactable = true; ;
        ongoingMaryBtn.gameObject.SetActive(false);
        ongoingRickBtn.interactable = true; ;
        ongoingRickBtn.gameObject.SetActive(false);
        ongoingPeterBtn.interactable = true; ;
        ongoingPeterBtn.gameObject.SetActive(false);
        ongoingSandraBtn.interactable = true; ;
        ongoingSandraBtn.gameObject.SetActive(false);
        ongoingStefanBtn.interactable = true; ;
        ongoingStefanBtn.gameObject.SetActive(false);
        ongoingTildaBtn.interactable = true; ;
        ongoingTildaBtn.gameObject.SetActive(false);


        specialAndrewBtn.gameObject.SetActive(false);       
        specialCharlieBtn.gameObject.SetActive(false);        
        specialJoeyBtn.gameObject.SetActive(false);
        specialLizBtn.gameObject.SetActive(false);
        specialMariaBtn.gameObject.SetActive(false);
        specialMarioBtn.gameObject.SetActive(false);
        specialMaryBtn.gameObject.SetActive(false);
        specialPeterBtn.gameObject.SetActive(false);
        specialRickBtn.gameObject.SetActive(false);
        specialSandraBtn.gameObject.SetActive(false);
        specialStefanBtn.gameObject.SetActive(false);
        specialTildaBtn.gameObject.SetActive(false);

        situationObject.ChooseSituationButtonRemoveProperty();

        cardsContainer.SetActive(true);
        card1.SetActive(true);
        card2.SetActive(true);
        card3.SetActive(true);
        readyPlayBtn.gameObject.SetActive(true);

        *//*        situationAnimator.SetBool("SituationCard1Selected", false);
                situationAnimator.SetBool("SituationCard2Selected", false);*//*
        card1.GetComponent<Button>().interactable = false;
        card2.GetComponent<Button>().interactable = false;
        card3.GetComponent<Button>().interactable = false;

        lMoneyText.text = Convert.ToString(Convert.ToInt16(rMoneyText.text) + Convert.ToInt16(lMoneyText.text));
        lNetworkText.text = Convert.ToString(Convert.ToInt16(rNetworkText.text) + Convert.ToInt16(lNetworkText.text));
        lTimeText.text = Convert.ToString(Convert.ToInt16(rTimeText.text) + Convert.ToInt16(lTimeText.text));

        rMoneyText.text = "5";
        rNetworkText.text = "5";
        rTimeText.text = "5";

        cardsContainer.GetComponent<Animator>().SetBool("CardPositionChange", false);
        cardsContainer.GetComponent<Animator>().SetBool("CardAndBackgroundClicked", false);
        cardsContainer.GetComponent<Animator>().SetBool("CardClicked", false);
    }*/

    public void TextMoneyNetworkSet()
    {
        if (situationObject.homelessSituationAct1.activeSelf && cardTildaSpecial)
        {
            moneyText = "1";
            networkText = "0";
            timeText = "0";
            situationObject.homelessAct1MoneyText.text = moneyText;
            situationObject.homelessAct1NetworkText.text = networkText;
            situationObject.homelessAct1TimeText.text = timeText;
        }
        else if (situationObject.homelessSituationAct1.activeSelf && cardTildaOngoing)
        {
            moneyText = "3";
            networkText = "0";
            timeText = "0";
            situationObject.homelessAct1MoneyText.text = moneyText;
            situationObject.homelessAct1NetworkText.text = networkText;
            situationObject.homelessAct1TimeText.text = timeText;
        }
        else if (situationObject.homelessSituationAct1.activeSelf)
        {
            moneyText = "4";
            networkText = "0";
            timeText = "0";
            situationObject.homelessAct1MoneyText.text = moneyText;
            situationObject.homelessAct1NetworkText.text = networkText;
            situationObject.homelessAct1TimeText.text = timeText;
        }
        else if (situationObject.homelessSituationAct2.activeSelf && cardTildaSpecial)
        {
            moneyText = "1";
            networkText = "2";
            timeText = "2";
            situationObject.homelessAct2MoneyText.text = moneyText;
            situationObject.homelessAct2NetworkText.text = networkText;
            situationObject.homelessAct2TimeText.text = timeText;
        }
        else if (situationObject.homelessSituationAct2.activeSelf && cardTildaOngoing)
        {
            moneyText = "3";
            networkText = "2";
            timeText = "2";
            situationObject.homelessAct2MoneyText.text = moneyText;
            situationObject.homelessAct2NetworkText.text = networkText;
            situationObject.homelessAct2TimeText.text = timeText;
        }
        else if (situationObject.homelessSituationAct2.activeSelf && cardRickSpecial)
        {
            moneyText = "4";
            networkText = "0";
            timeText = "2";
            situationObject.homelessAct2MoneyText.text = moneyText;
            situationObject.homelessAct2NetworkText.text = networkText;
            situationObject.homelessAct2TimeText.text = timeText;
        }
        else if (situationObject.homelessSituationAct2.activeSelf && cardRickOngoing)
        {
            moneyText = "4";
            networkText = "1";
            timeText = "2";
            situationObject.homelessAct2MoneyText.text = moneyText;
            situationObject.homelessAct2NetworkText.text = networkText;
            situationObject.homelessAct2TimeText.text = timeText;
        }
        else if (situationObject.homelessSituationAct2.activeSelf && cardPeterSpecial)
        {
            moneyText = "4";
            networkText = "2";
            timeText = "0";
            situationObject.homelessAct2MoneyText.text = moneyText;
            situationObject.homelessAct2NetworkText.text = networkText;
            situationObject.homelessAct2TimeText.text = timeText;
        }
        else if (situationObject.homelessSituationAct2.activeSelf && cardPeterOngoing)
        {
            moneyText = "4";
            networkText = "2";
            timeText = "1";
            situationObject.homelessAct2MoneyText.text = moneyText;
            situationObject.homelessAct2NetworkText.text = networkText;
            situationObject.homelessAct2TimeText.text = timeText;
        }
        else if (situationObject.homelessSituationAct2.activeSelf)
        {
            moneyText = "4";
            networkText = "2";
            timeText = "2";
            situationObject.homelessAct2MoneyText.text = moneyText;
            situationObject.homelessAct2NetworkText.text = networkText;
            situationObject.homelessAct2TimeText.text = timeText;
        }
        else if (situationObject.homelessSituationAct3.activeSelf && cardTildaSpecial)
        {
            moneyText = "1";
            networkText = "6";
            timeText = "5";
            situationObject.homelessAct3MoneyText.text = moneyText;
            situationObject.homelessAct3NetworkText.text = networkText;
            situationObject.homelessAct3TimeText.text = timeText;
        }
        else if (situationObject.homelessSituationAct3.activeSelf && cardTildaOngoing)
        {
            moneyText = "3";
            networkText = "6";
            timeText = "5";
            situationObject.homelessAct3MoneyText.text = moneyText;
            situationObject.homelessAct3NetworkText.text = networkText;
            situationObject.homelessAct3TimeText.text = timeText;
        }
        else if (situationObject.homelessSituationAct3.activeSelf && cardRickSpecial)
        {
            moneyText = "4";
            networkText = "3";
            timeText = "5";
            situationObject.homelessAct3MoneyText.text = moneyText;
            situationObject.homelessAct3NetworkText.text = networkText;
            situationObject.homelessAct3TimeText.text = timeText;
        }
        else if (situationObject.homelessSituationAct3.activeSelf && cardRickOngoing)
        {
            moneyText = "4";
            networkText = "5";
            timeText = "5";
            situationObject.homelessAct3MoneyText.text = moneyText;
            situationObject.homelessAct3NetworkText.text = networkText;
            situationObject.homelessAct3TimeText.text = timeText;
        }
        else if (situationObject.homelessSituationAct3.activeSelf && cardPeterSpecial)
        {
            moneyText = "4";
            networkText = "6";
            timeText = "2";
            situationObject.homelessAct3MoneyText.text = moneyText;
            situationObject.homelessAct3NetworkText.text = networkText;
            situationObject.homelessAct3TimeText.text = timeText;
        }
        else if (situationObject.homelessSituationAct3.activeSelf && cardPeterOngoing)
        {
            moneyText = "4";
            networkText = "6";
            timeText = "4";
            situationObject.homelessAct3MoneyText.text = moneyText;
            situationObject.homelessAct3NetworkText.text = networkText;
            situationObject.homelessAct3TimeText.text = timeText;
        }
        else if (situationObject.homelessSituationAct3.activeSelf)
        {
            moneyText = "4";
            networkText = "6";
            timeText = "5";
            situationObject.homelessAct3MoneyText.text = moneyText;
            situationObject.homelessAct3NetworkText.text = networkText;
            situationObject.homelessAct3TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct1.activeSelf && cardTildaSpecial)
        {
            moneyText = "0";
            networkText = "0";
            timeText = "0";
            situationObject.refugeeAct1MoneyText.text = moneyText;
            situationObject.refugeeAct1NetworkText.text = networkText;
            situationObject.refugeeAct1TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct1.activeSelf && cardTildaOngoing)
        {
            moneyText = "2";
            networkText = "0";
            timeText = "0";
            situationObject.refugeeAct1MoneyText.text = moneyText;
            situationObject.refugeeAct1NetworkText.text = networkText;
            situationObject.refugeeAct1TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct1.activeSelf && cardRickSpecial)
        {
            moneyText = "3";
            networkText = "0";
            timeText = "0";
            situationObject.refugeeAct1MoneyText.text = moneyText;
            situationObject.refugeeAct1NetworkText.text = networkText;
            situationObject.refugeeAct1TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct1.activeSelf && cardRickOngoing)
        {
            moneyText = "3";
            networkText = "0";
            timeText = "0";
            situationObject.refugeeAct1MoneyText.text = moneyText;
            situationObject.refugeeAct1NetworkText.text = networkText;
            situationObject.refugeeAct1TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct1.activeSelf && cardPeterSpecial)
        {
            moneyText = "3";
            networkText = "0";
            timeText = "0";
            situationObject.refugeeAct1MoneyText.text = moneyText;
            situationObject.refugeeAct1NetworkText.text = networkText;
            situationObject.refugeeAct1TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct1.activeSelf && cardPeterOngoing)
        {
            moneyText = "3";
            networkText = "0";
            timeText = "0";
            situationObject.refugeeAct1MoneyText.text = moneyText;
            situationObject.refugeeAct1NetworkText.text = networkText;
            situationObject.refugeeAct1TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct1.activeSelf && cardPeterOngoing)
        {
            moneyText = "3";
            networkText = "0";
            timeText = "0";
            situationObject.refugeeAct1MoneyText.text = moneyText;
            situationObject.refugeeAct1NetworkText.text = networkText;
            situationObject.refugeeAct1TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct1.activeSelf)
        {
            moneyText = "3";
            networkText = "0";
            timeText = "0";
            situationObject.refugeeAct1MoneyText.text = moneyText;
            situationObject.refugeeAct1NetworkText.text = networkText;
            situationObject.refugeeAct1TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct2.activeSelf && cardTildaSpecial)
        {
            moneyText = "0";
            networkText = "6";
            timeText = "4";
            situationObject.refugeeAct2MoneyText.text = moneyText;
            situationObject.refugeeAct2NetworkText.text = networkText;
            situationObject.refugeeAct2TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct2.activeSelf && cardTildaOngoing)
        {
            moneyText = "0";
            networkText = "6";
            timeText = "4";
            situationObject.refugeeAct2MoneyText.text = moneyText;
            situationObject.refugeeAct2NetworkText.text = networkText;
            situationObject.refugeeAct2TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct2.activeSelf && cardRickSpecial)
        {
            moneyText = "0";
            networkText = "3";
            timeText = "4";
            situationObject.refugeeAct2MoneyText.text = moneyText;
            situationObject.refugeeAct2NetworkText.text = networkText;
            situationObject.refugeeAct2TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct2.activeSelf && cardRickOngoing)
        {
            moneyText = "0";
            networkText = "5";
            timeText = "4";
            situationObject.refugeeAct2MoneyText.text = moneyText;
            situationObject.refugeeAct2NetworkText.text = networkText;
            situationObject.refugeeAct2TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct2.activeSelf && cardPeterSpecial)
        {
            moneyText = "0";
            networkText = "6";
            timeText = "1";
            situationObject.refugeeAct2MoneyText.text = moneyText;
            situationObject.refugeeAct2NetworkText.text = networkText;
            situationObject.refugeeAct2TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct2.activeSelf && cardPeterOngoing)
        {
            moneyText = "0";
            networkText = "6";
            timeText = "3";
            situationObject.refugeeAct2MoneyText.text = moneyText;
            situationObject.refugeeAct2NetworkText.text = networkText;
            situationObject.refugeeAct2TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct2.activeSelf)
        {
            moneyText = "0";
            networkText = "6";
            timeText = "4";
            situationObject.refugeeAct2MoneyText.text = moneyText;
            situationObject.refugeeAct2NetworkText.text = networkText;
            situationObject.refugeeAct2TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct3.activeSelf && cardTildaSpecial)
        {
            moneyText = "3";
            networkText = "6";
            timeText = "6";
            situationObject.refugeeAct3MoneyText.text = moneyText;
            situationObject.refugeeAct3NetworkText.text = networkText;
            situationObject.refugeeAct3TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct3.activeSelf && cardTildaOngoing)
        {
            moneyText = "5";
            networkText = "6";
            timeText = "6";
            situationObject.refugeeAct3MoneyText.text = moneyText;
            situationObject.refugeeAct3NetworkText.text = networkText;
            situationObject.refugeeAct3TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct3.activeSelf && cardRickSpecial)
        {
            moneyText = "6";
            networkText = "3";
            timeText = "6";
            situationObject.refugeeAct3MoneyText.text = moneyText;
            situationObject.refugeeAct3NetworkText.text = networkText;
            situationObject.refugeeAct3TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct3.activeSelf && cardRickOngoing)
        {
            moneyText = "6";
            networkText = "5";
            timeText = "6";
            situationObject.refugeeAct3MoneyText.text = moneyText;
            situationObject.refugeeAct3NetworkText.text = networkText;
            situationObject.refugeeAct3TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct3.activeSelf && cardPeterSpecial)
        {
            moneyText = "6";
            networkText = "6";
            timeText = "3";
            situationObject.refugeeAct3MoneyText.text = moneyText;
            situationObject.refugeeAct3NetworkText.text = networkText;
            situationObject.refugeeAct3TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct3.activeSelf && cardPeterOngoing)
        {
            moneyText = "6";
            networkText = "6";
            timeText = "5";
            situationObject.refugeeAct3MoneyText.text = moneyText;
            situationObject.refugeeAct3NetworkText.text = networkText;
            situationObject.refugeeAct3TimeText.text = timeText;
        }
        else if (situationObject.refugeeSituationAct3.activeSelf)
        {
            moneyText = "6";
            networkText = "6";
            timeText = "6";
            situationObject.refugeeAct3MoneyText.text = moneyText;
            situationObject.refugeeAct3NetworkText.text = networkText;
            situationObject.refugeeAct3TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct1.activeSelf && cardTildaSpecial)
        {
            moneyText = "0";
            networkText = "0";
            timeText = "3";
            situationObject.fastFoodAct1MoneyText.text = moneyText;
            situationObject.fastFoodAct1NetworkText.text = networkText;
            situationObject.fastFoodAct1TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct1.activeSelf && cardTildaSpecial)
        {
            moneyText = "0";
            networkText = "0";
            timeText = "3";
            situationObject.fastFoodAct1MoneyText.text = moneyText;
            situationObject.fastFoodAct1NetworkText.text = networkText;
            situationObject.fastFoodAct1TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct1.activeSelf && cardTildaOngoing)
        {
            moneyText = "0";
            networkText = "0";
            timeText = "3";
            situationObject.fastFoodAct1MoneyText.text = moneyText;
            situationObject.fastFoodAct1NetworkText.text = networkText;
            situationObject.fastFoodAct1TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct1.activeSelf && cardRickSpecial)
        {
            moneyText = "0";
            networkText = "0";
            timeText = "3";
            situationObject.fastFoodAct1MoneyText.text = moneyText;
            situationObject.fastFoodAct1NetworkText.text = networkText;
            situationObject.fastFoodAct1TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct1.activeSelf && cardRickOngoing)
        {
            moneyText = "0";
            networkText = "0";
            timeText = "3";
            situationObject.fastFoodAct1MoneyText.text = moneyText;
            situationObject.fastFoodAct1NetworkText.text = networkText;
            situationObject.fastFoodAct1TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct1.activeSelf && cardPeterSpecial)
        {
            moneyText = "0";
            networkText = "0";
            timeText = "0";
            situationObject.fastFoodAct1MoneyText.text = moneyText;
            situationObject.fastFoodAct1NetworkText.text = networkText;
            situationObject.fastFoodAct1TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct1.activeSelf && cardPeterOngoing)
        {
            moneyText = "0";
            networkText = "0";
            timeText = "2";
            situationObject.fastFoodAct1MoneyText.text = moneyText;
            situationObject.fastFoodAct1NetworkText.text = networkText;
            situationObject.fastFoodAct1TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct1.activeSelf)
        {
            moneyText = "0";
            networkText = "0";
            timeText = "3";
            situationObject.fastFoodAct1MoneyText.text = moneyText;
            situationObject.fastFoodAct1NetworkText.text = networkText;
            situationObject.fastFoodAct1TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct2.activeSelf && cardTildaSpecial)
        {
            moneyText = "0";
            networkText = "2";
            timeText = "2";
            situationObject.fastFoodAct2MoneyText.text = moneyText;
            situationObject.fastFoodAct2NetworkText.text = networkText;
            situationObject.fastFoodAct2TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct2.activeSelf && cardTildaOngoing)
        {
            moneyText = "0";
            networkText = "2";
            timeText = "2";
            situationObject.fastFoodAct2MoneyText.text = moneyText;
            situationObject.fastFoodAct2NetworkText.text = networkText;
            situationObject.fastFoodAct2TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct2.activeSelf && cardRickSpecial)
        {
            moneyText = "0";
            networkText = "0";
            timeText = "2";
            situationObject.fastFoodAct2MoneyText.text = moneyText;
            situationObject.fastFoodAct2NetworkText.text = networkText;
            situationObject.fastFoodAct2TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct2.activeSelf && cardRickOngoing)
        {
            moneyText = "0";
            networkText = "1";
            timeText = "2";
            situationObject.fastFoodAct2MoneyText.text = moneyText;
            situationObject.fastFoodAct2NetworkText.text = networkText;
            situationObject.fastFoodAct2TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct2.activeSelf && cardPeterSpecial)
        {
            moneyText = "0";
            networkText = "2";
            timeText = "0";
            situationObject.fastFoodAct2MoneyText.text = moneyText;
            situationObject.fastFoodAct2NetworkText.text = networkText;
            situationObject.fastFoodAct2TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct2.activeSelf && cardPeterOngoing)
        {
            moneyText = "0";
            networkText = "2";
            timeText = "1";
            situationObject.fastFoodAct2MoneyText.text = moneyText;
            situationObject.fastFoodAct2NetworkText.text = networkText;
            situationObject.fastFoodAct2TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct2.activeSelf)
        {
            moneyText = "0";
            networkText = "2";
            timeText = "2";
            situationObject.fastFoodAct2MoneyText.text = moneyText;
            situationObject.fastFoodAct2NetworkText.text = networkText;
            situationObject.fastFoodAct2TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct3.activeSelf && cardTildaSpecial)
        {
            moneyText = "0";
            networkText = "4";
            timeText = "4";
            situationObject.fastFoodAct3MoneyText.text = moneyText;
            situationObject.fastFoodAct3NetworkText.text = networkText;
            situationObject.fastFoodAct3TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct3.activeSelf && cardTildaOngoing)
        {
            moneyText = "0";
            networkText = "4";
            timeText = "4";
            situationObject.fastFoodAct3MoneyText.text = moneyText;
            situationObject.fastFoodAct3NetworkText.text = networkText;
            situationObject.fastFoodAct3TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct3.activeSelf && cardRickSpecial)
        {
            moneyText = "0";
            networkText = "1";
            timeText = "4";
            situationObject.fastFoodAct3MoneyText.text = moneyText;
            situationObject.fastFoodAct3NetworkText.text = networkText;
            situationObject.fastFoodAct3TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct3.activeSelf && cardRickOngoing)
        {
            moneyText = "0";
            networkText = "3";
            timeText = "4";
            situationObject.fastFoodAct3MoneyText.text = moneyText;
            situationObject.fastFoodAct3NetworkText.text = networkText;
            situationObject.fastFoodAct3TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct3.activeSelf && cardPeterSpecial)
        {
            moneyText = "0";
            networkText = "4";
            timeText = "1";
            situationObject.fastFoodAct3MoneyText.text = moneyText;
            situationObject.fastFoodAct3NetworkText.text = networkText;
            situationObject.fastFoodAct3TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct3.activeSelf && cardPeterOngoing)
        {
            moneyText = "0";
            networkText = "4";
            timeText = "3";
            situationObject.fastFoodAct3MoneyText.text = moneyText;
            situationObject.fastFoodAct3NetworkText.text = networkText;
            situationObject.fastFoodAct3TimeText.text = timeText;
        }
        else if (situationObject.fastFoodSituationAct3.activeSelf)
        {
            moneyText = "0";
            networkText = "4";
            timeText = "4";
            situationObject.fastFoodAct3MoneyText.text = moneyText;
            situationObject.fastFoodAct3NetworkText.text = networkText;
            situationObject.fastFoodAct3TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct1.activeSelf && cardTildaSpecial)
        {
            moneyText = "0";
            networkText = "2";
            timeText = "2";
            situationObject.languageAct1MoneyText.text = moneyText;
            situationObject.languageAct1NetworkText.text = networkText;
            situationObject.languageAct1TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct1.activeSelf && cardTildaOngoing)
        {
            moneyText = "0";
            networkText = "2";
            timeText = "2";
            situationObject.languageAct1MoneyText.text = moneyText;
            situationObject.languageAct1NetworkText.text = networkText;
            situationObject.languageAct1TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct1.activeSelf && cardRickSpecial)
        {
            moneyText = "0";
            networkText = "0";
            timeText = "2";
            situationObject.languageAct1MoneyText.text = moneyText;
            situationObject.languageAct1NetworkText.text = networkText;
            situationObject.languageAct1TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct1.activeSelf && cardRickOngoing)
        {
            moneyText = "0";
            networkText = "1";
            timeText = "2";
            situationObject.languageAct1MoneyText.text = moneyText;
            situationObject.languageAct1NetworkText.text = networkText;
            situationObject.languageAct1TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct1.activeSelf && cardPeterSpecial)
        {
            moneyText = "0";
            networkText = "2";
            timeText = "0";
            situationObject.languageAct1MoneyText.text = moneyText;
            situationObject.languageAct1NetworkText.text = networkText;
            situationObject.languageAct1TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct1.activeSelf && cardPeterOngoing)
        {
            moneyText = "0";
            networkText = "2";
            timeText = "1";
            situationObject.languageAct1MoneyText.text = moneyText;
            situationObject.languageAct1NetworkText.text = networkText;
            situationObject.languageAct1TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct1.activeSelf)
        {
            moneyText = "0";
            networkText = "2";
            timeText = "2";
            situationObject.languageAct1MoneyText.text = moneyText;
            situationObject.languageAct1NetworkText.text = networkText;
            situationObject.languageAct1TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct2.activeSelf && cardTildaSpecial)
        {
            moneyText = "0";
            networkText = "3";
            timeText = "3";
            situationObject.languageAct2MoneyText.text = moneyText;
            situationObject.languageAct2NetworkText.text = networkText;
            situationObject.languageAct2TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct2.activeSelf && cardTildaOngoing)
        {
            moneyText = "0";
            networkText = "3";
            timeText = "3";
            situationObject.languageAct2MoneyText.text = moneyText;
            situationObject.languageAct2NetworkText.text = networkText;
            situationObject.languageAct2TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct2.activeSelf && cardRickSpecial)
        {
            moneyText = "0";
            networkText = "0";
            timeText = "3";
            situationObject.languageAct2MoneyText.text = moneyText;
            situationObject.languageAct2NetworkText.text = networkText;
            situationObject.languageAct2TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct2.activeSelf && cardRickOngoing)
        {
            moneyText = "0";
            networkText = "2";
            timeText = "3";
            situationObject.languageAct2MoneyText.text = moneyText;
            situationObject.languageAct2NetworkText.text = networkText;
            situationObject.languageAct2TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct2.activeSelf && cardPeterSpecial)
        {
            moneyText = "0";
            networkText = "3";
            timeText = "0";
            situationObject.languageAct2MoneyText.text = moneyText;
            situationObject.languageAct2NetworkText.text = networkText;
            situationObject.languageAct2TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct2.activeSelf && cardPeterOngoing)
        {
            moneyText = "0";
            networkText = "3";
            timeText = "2";
            situationObject.languageAct2MoneyText.text = moneyText;
            situationObject.languageAct2NetworkText.text = networkText;
            situationObject.languageAct2TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct2.activeSelf)
        {
            moneyText = "0";
            networkText = "3";
            timeText = "3";
            situationObject.languageAct2MoneyText.text = moneyText;
            situationObject.languageAct2NetworkText.text = networkText;
            situationObject.languageAct2TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct3.activeSelf && cardTildaSpecial)
        {
            moneyText = "0";
            networkText = "8";
            timeText = "2";
            situationObject.languageAct3MoneyText.text = moneyText;
            situationObject.languageAct3NetworkText.text = networkText;
            situationObject.languageAct3TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct3.activeSelf && cardTildaOngoing)
        {
            moneyText = "1";
            networkText = "8";
            timeText = "2";
            situationObject.languageAct3MoneyText.text = moneyText;
            situationObject.languageAct3NetworkText.text = networkText;
            situationObject.languageAct3TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct3.activeSelf && cardRickSpecial)
        {
            moneyText = "2";
            networkText = "5";
            timeText = "2";
            situationObject.languageAct3MoneyText.text = moneyText;
            situationObject.languageAct3NetworkText.text = networkText;
            situationObject.languageAct3TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct3.activeSelf && cardRickOngoing)
        {
            moneyText = "2";
            networkText = "7";
            timeText = "2";
            situationObject.languageAct3MoneyText.text = moneyText;
            situationObject.languageAct3NetworkText.text = networkText;
            situationObject.languageAct3TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct3.activeSelf && cardPeterSpecial)
        {
            moneyText = "2";
            networkText = "8";
            timeText = "0";
            situationObject.languageAct3MoneyText.text = moneyText;
            situationObject.languageAct3NetworkText.text = networkText;
            situationObject.languageAct3TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct3.activeSelf && cardPeterOngoing)
        {
            moneyText = "2";
            networkText = "8";
            timeText = "1";
            situationObject.languageAct3MoneyText.text = moneyText;
            situationObject.languageAct3NetworkText.text = networkText;
            situationObject.languageAct3TimeText.text = timeText;
        }
        else if (situationObject.languageSituationAct3.activeSelf)
        {
            moneyText = "2";
            networkText = "8";
            timeText = "2";
            situationObject.languageAct3MoneyText.text = moneyText;
            situationObject.languageAct3NetworkText.text = networkText;
            situationObject.languageAct3TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct1.activeSelf && cardTildaSpecial)
        {
            moneyText = "0";
            networkText = "1";
            timeText = "3";
            situationObject.trashAct1MoneyText.text = moneyText;
            situationObject.trashAct1NetworkText.text = networkText;
            situationObject.trashAct1TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct1.activeSelf && cardTildaOngoing)
        {
            moneyText = "0";
            networkText = "1";
            timeText = "3";
            situationObject.trashAct1MoneyText.text = moneyText;
            situationObject.trashAct1NetworkText.text = networkText;
            situationObject.trashAct1TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct1.activeSelf && cardRickSpecial)
        {
            moneyText = "0";
            networkText = "0";
            timeText = "3";
            situationObject.trashAct1MoneyText.text = moneyText;
            situationObject.trashAct1NetworkText.text = networkText;
            situationObject.trashAct1TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct1.activeSelf && cardRickOngoing)
        {
            moneyText = "0";
            networkText = "0";
            timeText = "3";
            situationObject.trashAct1MoneyText.text = moneyText;
            situationObject.trashAct1NetworkText.text = networkText;
            situationObject.trashAct1TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct1.activeSelf && cardPeterSpecial)
        {
            moneyText = "0";
            networkText = "1";
            timeText = "0";
            situationObject.trashAct1MoneyText.text = moneyText;
            situationObject.trashAct1NetworkText.text = networkText;
            situationObject.trashAct1TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct1.activeSelf && cardPeterOngoing)
        {
            moneyText = "0";
            networkText = "1";
            timeText = "2";
            situationObject.trashAct1MoneyText.text = moneyText;
            situationObject.trashAct1NetworkText.text = networkText;
            situationObject.trashAct1TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct1.activeSelf)
        {
            moneyText = "0";
            networkText = "1";
            timeText = "3";
            situationObject.trashAct1MoneyText.text = moneyText;
            situationObject.trashAct1NetworkText.text = networkText;
            situationObject.trashAct1TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct2.activeSelf && cardTildaSpecial)
        {
            moneyText = "0";
            networkText = "3";
            timeText = "2";
            situationObject.trashAct2MoneyText.text = moneyText;
            situationObject.trashAct2NetworkText.text = networkText;
            situationObject.trashAct2TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct2.activeSelf && cardTildaOngoing)
        {
            moneyText = "0";
            networkText = "3";
            timeText = "2";
            situationObject.trashAct2MoneyText.text = moneyText;
            situationObject.trashAct2NetworkText.text = networkText;
            situationObject.trashAct2TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct2.activeSelf && cardRickSpecial)
        {
            moneyText = "0";
            networkText = "0";
            timeText = "2";
            situationObject.trashAct2MoneyText.text = moneyText;
            situationObject.trashAct2NetworkText.text = networkText;
            situationObject.trashAct2TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct2.activeSelf && cardRickOngoing)
        {
            moneyText = "0";
            networkText = "2";
            timeText = "2";
            situationObject.trashAct2MoneyText.text = moneyText;
            situationObject.trashAct2NetworkText.text = networkText;
            situationObject.trashAct2TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct2.activeSelf && cardPeterSpecial)
        {
            moneyText = "0";
            networkText = "3";
            timeText = "0";
            situationObject.trashAct2MoneyText.text = moneyText;
            situationObject.trashAct2NetworkText.text = networkText;
            situationObject.trashAct2TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct2.activeSelf && cardPeterOngoing)
        {
            moneyText = "0";
            networkText = "3";
            timeText = "1";
            situationObject.trashAct2MoneyText.text = moneyText;
            situationObject.trashAct2NetworkText.text = networkText;
            situationObject.trashAct2TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct2.activeSelf)
        {
            moneyText = "0";
            networkText = "3";
            timeText = "2";
            situationObject.trashAct2MoneyText.text = moneyText;
            situationObject.trashAct2NetworkText.text = networkText;
            situationObject.trashAct2TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct3.activeSelf && cardTildaSpecial)
        {
            moneyText = "1";
            networkText = "6";
            timeText = "5";
            situationObject.trashAct3MoneyText.text = moneyText;
            situationObject.trashAct3NetworkText.text = networkText;
            situationObject.trashAct3TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct3.activeSelf && cardTildaOngoing)
        {
            moneyText = "3";
            networkText = "6";
            timeText = "5";
            situationObject.trashAct3MoneyText.text = moneyText;
            situationObject.trashAct3NetworkText.text = networkText;
            situationObject.trashAct3TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct3.activeSelf && cardRickSpecial)
        {
            moneyText = "4";
            networkText = "3";
            timeText = "5";
            situationObject.trashAct3MoneyText.text = moneyText;
            situationObject.trashAct3NetworkText.text = networkText;
            situationObject.trashAct3TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct3.activeSelf && cardRickOngoing)
        {
            moneyText = "4";
            networkText = "5";
            timeText = "5";
            situationObject.trashAct3MoneyText.text = moneyText;
            situationObject.trashAct3NetworkText.text = networkText;
            situationObject.trashAct3TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct3.activeSelf && cardPeterSpecial)
        {
            moneyText = "4";
            networkText = "6";
            timeText = "2";
            situationObject.trashAct3MoneyText.text = moneyText;
            situationObject.trashAct3NetworkText.text = networkText;
            situationObject.trashAct3TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct3.activeSelf && cardPeterOngoing)
        {
            moneyText = "4";
            networkText = "6";
            timeText = "4";
            situationObject.trashAct3MoneyText.text = moneyText;
            situationObject.trashAct3NetworkText.text = networkText;
            situationObject.trashAct3TimeText.text = timeText;
        }
        else if (situationObject.trashSituationAct3.activeSelf)
        {
            moneyText = "4";
            networkText = "6";
            timeText = "5";
            situationObject.trashAct3MoneyText.text = moneyText;
            situationObject.trashAct3NetworkText.text = networkText;
            situationObject.trashAct3TimeText.text = timeText;
        }
    }
}
