using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Situation : MonoBehaviour
{
    private static Situation situationObject;

    public static Situation SituationObject
    {
        get
        {
            return situationObject;
        }
    }

    [SerializeField] GameObject situationCardContainer;
    [SerializeField] GameObject situationActionContainer;
    [SerializeField] GameObject realityCheckContainer;

    [Header("Situation Cards")]
    [SerializeField] GameObject homelessSituationCard;
    [SerializeField] GameObject refugeeSituationCard;
    [SerializeField] GameObject fastFoodSituationCard;
    [SerializeField] GameObject languageSituationCard;
    [SerializeField] GameObject trashSituationCard;

    [Header("Situation Acts")]
    public GameObject homelessSituationAct1;
    public GameObject homelessSituationAct2;
    public GameObject homelessSituationAct3;
    public GameObject refugeeSituationAct1;
    public GameObject refugeeSituationAct2;
    public GameObject refugeeSituationAct3;
    public GameObject fastFoodSituationAct1;
    public GameObject fastFoodSituationAct2;
    public GameObject fastFoodSituationAct3;
    public GameObject languageSituationAct1;
    public GameObject languageSituationAct2;
    public GameObject languageSituationAct3;
    public GameObject trashSituationAct1;
    public GameObject trashSituationAct2;
    public GameObject trashSituationAct3;

    [Header("Texts")]
    [SerializeField] TextMeshProUGUI headingText;
    [SerializeField] TextMeshProUGUI instructionText;
    public TextMeshProUGUI homelessAct1MoneyText;
    public TextMeshProUGUI homelessAct1NetworkText;
    public TextMeshProUGUI homelessAct1TimeText;
    public TextMeshProUGUI homelessAct2MoneyText;
    public TextMeshProUGUI homelessAct2NetworkText;
    public TextMeshProUGUI homelessAct2TimeText;
    public TextMeshProUGUI homelessAct3MoneyText;
    public TextMeshProUGUI homelessAct3NetworkText;
    public TextMeshProUGUI homelessAct3TimeText;
    public TextMeshProUGUI refugeeAct1MoneyText;
    public TextMeshProUGUI refugeeAct1NetworkText;
    public TextMeshProUGUI refugeeAct1TimeText;
    public TextMeshProUGUI refugeeAct2MoneyText;
    public TextMeshProUGUI refugeeAct2NetworkText;
    public TextMeshProUGUI refugeeAct2TimeText;
    public TextMeshProUGUI refugeeAct3MoneyText;
    public TextMeshProUGUI refugeeAct3NetworkText;
    public TextMeshProUGUI refugeeAct3TimeText;
    public TextMeshProUGUI fastFoodAct1MoneyText;
    public TextMeshProUGUI fastFoodAct1NetworkText;
    public TextMeshProUGUI fastFoodAct1TimeText;
    public TextMeshProUGUI fastFoodAct2MoneyText;
    public TextMeshProUGUI fastFoodAct2NetworkText;
    public TextMeshProUGUI fastFoodAct2TimeText;
    public TextMeshProUGUI fastFoodAct3MoneyText;
    public TextMeshProUGUI fastFoodAct3NetworkText;
    public TextMeshProUGUI fastFoodAct3TimeText;
    public TextMeshProUGUI languageAct1MoneyText;
    public TextMeshProUGUI languageAct1NetworkText;
    public TextMeshProUGUI languageAct1TimeText;
    public TextMeshProUGUI languageAct2MoneyText;
    public TextMeshProUGUI languageAct2NetworkText;
    public TextMeshProUGUI languageAct2TimeText;
    public TextMeshProUGUI languageAct3MoneyText;
    public TextMeshProUGUI languageAct3NetworkText;
    public TextMeshProUGUI languageAct3TimeText;
    public TextMeshProUGUI trashAct1MoneyText;
    public TextMeshProUGUI trashAct1NetworkText;
    public TextMeshProUGUI trashAct1TimeText;
    public TextMeshProUGUI trashAct2MoneyText;
    public TextMeshProUGUI trashAct2NetworkText;
    public TextMeshProUGUI trashAct2TimeText;
    public TextMeshProUGUI trashAct3MoneyText;
    public TextMeshProUGUI trashAct3NetworkText;
    public TextMeshProUGUI trashAct3TimeText;
    [SerializeField] TextMeshProUGUI goToAnotherSituationAfterCompletingOneBtnText;


    [Header("Situations Placeholder")]
    [SerializeField] GameObject situation1Container;
    [SerializeField] GameObject situation2Container;

    [Header("Situation Buttons")]
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
    [SerializeField] Button goToAnotherSituationAfterCompletingOneBtn;
    [SerializeField] Button goBackToSituationBtn;
    [SerializeField] Button payNowBtn;

    [Header("Card Animation")]
    [SerializeField] Animator cardAnimator;
    [SerializeField] Animator situationAnimator;


    [Header("Your Resources")]
    [SerializeField] TextMeshProUGUI rTimeText;
    [SerializeField] TextMeshProUGUI rNetworkText;
    [SerializeField] TextMeshProUGUI rMoneyText;

    [Header("Long-Term Effect Resources")]
    [SerializeField] TextMeshProUGUI lTimeText;
    [SerializeField] TextMeshProUGUI lNetworkText;
    [SerializeField] TextMeshProUGUI lMoneyText;

    static public int situationSolvedCount = 1;
    static public bool roundCompleted = false;
    static public int round = 0;
    static int situationCardCount = 0;

    List<GameObject> situationCards;
    RealityCheck realityCheckObject;
    CommunityWellbeing communityWellbeingObject;
    Level1 level1Object;

    private void Awake()
    {
        if (situationObject != null && situationObject != this)
        {
            Destroy(this);
        }
        else
        {
            situationObject = this;
        }
        situationCards = new List<GameObject>() { homelessSituationCard, refugeeSituationCard, fastFoodSituationCard, languageSituationCard, trashSituationCard };
        ShuffleSituationCards();
    }

    private void Start()
    {
        situationSolvedCount = 1;
        roundCompleted = false;
        round = 0;
        communityWellbeingObject = CommunityWellbeing.CommunityWellbeingObject;
        realityCheckObject = RealityCheck.RealityCheckObject;
        level1Object = Level1.Level1Object;
    }

    public void NextRoundSetup()
    {
        if (round % 2 != 0)
        {
            ChooseSituationButtonAddProperty();
            situationOneIgnoreBtn.onClick.RemoveAllListeners();
            goToAnotherSituationAfterCompletingOneBtn.onClick.RemoveAllListeners();
            situationOneIgnoreBtn.onClick.AddListener(IgnoreSituation);
            goToAnotherSituationAfterCompletingOneBtn.onClick.AddListener(GoToAnotherSituationAfterCompletingOne);
        }
        else
        {
            ChooseSituationButtonAddProperty();
            situationOneIgnoreBtn.onClick.RemoveAllListeners();
            goToAnotherSituationAfterCompletingOneBtn.onClick.RemoveAllListeners();
            situationOneIgnoreBtn.onClick.AddListener(level1Object.NextRoundStart);
            goToAnotherSituationAfterCompletingOneBtn.onClick.AddListener(level1Object.NextRoundStart);
        }
    }

    public void ShuffleSituationCards()
    {
        //Completely random logic
        /*situation1Container.GetComponent<Image>().sprite = situationCards[UnityEngine.Random.Range(0, situationCards.Count)].GetComponent<Image>().sprite;
        for (int i = 0; i < situationCards.Count; i++)
        {
            situation2Container.GetComponent<Image>().sprite = situationCards[UnityEngine.Random.Range(0, situationCards.Count)].GetComponent<Image>().sprite;
            if (situation1Container.GetComponent<Image>().sprite != situation2Container.GetComponent<Image>().sprite)
            {
                return;
            }
        }*/

        // new logic
        situation1Container.GetComponent<Image>().sprite = situationCards[situationCardCount].GetComponent<Image>().sprite;
        situationCardCount++;

        if (situationCardCount == situationCards.Count)
        {
            situationCardCount = 0;
        }
        situation2Container.GetComponent<Image>().sprite = situationCards[situationCardCount].GetComponent<Image>().sprite;
        situationCardCount++;

        if (situationCardCount == situationCards.Count)
        {
            situationCardCount = 0;
        }
    }

    private void HeadingAndInstructionText(string heading, string instruction)
    {
        headingText.text = heading;
        instructionText.text = instruction;
    }
    public void IgnoreSituation()
    {
        if (Level1.cardAndrewSpecial == false)
        {
            CommunityWellbeing.wellbeingLevelCount -= 2;
            communityWellbeingObject.WellbeingIncrease();
        }
        round++;
        Level1.cardAndrewSpecial = false;
        if (round % 2 != 0)
        {
            GoToOtherSituation();
        }
        else
        {
            level1Object.NextRoundStart();
        }
    }

    private void GoToOtherSituation()
    {
        HeadingAndInstructionText("ACT ON SITUATION",
            "Choose one action on situation");

        situationCardContainer.SetActive(true);
        realityCheckContainer.SetActive(true);

        realityCheckObject.ShuffleRealityCheck();
        if (situation1Container.activeSelf)
        {
            situation1Container.SetActive(false);
            situation2Container.SetActive(true);
            situationAnimator.SetBool("SituationCard1Selected", false);
            situationAnimator.SetBool("SituationCard2Selected", true);
            situationTwoActionOneBtn.gameObject.SetActive(true);
            situationTwoActionTwoBtn.gameObject.SetActive(true);
            situationTwoActionThreeBtn.gameObject.SetActive(true);
            situationTwoIgnoreBtn.gameObject.SetActive(true);
            ChooseSituationButtonAddProperty();
        }
        else if (situation2Container.activeSelf)
        {
            situation2Container.SetActive(false);
            situation1Container.SetActive(true);
            situationAnimator.SetBool("SituationCard2Selected", false);
            situationAnimator.SetBool("SituationCard1Selected", true);
            situationOneActionOneBtn.gameObject.SetActive(true);
            situationOneActionTwoBtn.gameObject.SetActive(true);
            situationOneActionThreeBtn.gameObject.SetActive(true);
            situationOneIgnoreBtn.gameObject.SetActive(true);
            ChooseSituationButtonAddProperty();
        }
    }

    public void FaceSituationOne()
    {
        HeadingAndInstructionText("ACT ON SITUATION",
            "Choose one action on situation");

        situation2Container.SetActive(false);
        situationTwoBtn.gameObject.SetActive(false);

        situationAnimator.SetBool("SituationCard1Selected", true);

        situationOneActionOneBtn.interactable = true;
        situationOneActionTwoBtn.interactable = true;
        situationOneActionThreeBtn.interactable = true;
        situationOneIgnoreBtn.interactable = true;

        situationOneActionOneBtn.gameObject.SetActive(true);
        situationOneActionTwoBtn.gameObject.SetActive(true);
        situationOneActionThreeBtn.gameObject.SetActive(true);
        situationOneIgnoreBtn.gameObject.SetActive(true);
        

        situationOneBtn.gameObject.SetActive(false);

        realityCheckContainer.SetActive(true);
        
        realityCheckObject.ShuffleRealityCheck();
        ChooseSituationButtonAddProperty();
    }
    public void FaceSituationTwo()
    {
        HeadingAndInstructionText("ACT ON SITUATION",
            "Choose one action on situation");

        situation1Container.SetActive(false);
        situationOneBtn.gameObject.SetActive(false);

        situationAnimator.SetBool("SituationCard2Selected", true);

        situationTwoActionOneBtn.interactable = true;
        situationTwoActionTwoBtn.interactable = true;
        situationTwoActionThreeBtn.interactable = true;
        situationTwoIgnoreBtn.interactable = true;

        situationTwoActionOneBtn.gameObject.SetActive(true);
        situationTwoActionTwoBtn.gameObject.SetActive(true);
        situationTwoActionThreeBtn.gameObject.SetActive(true);
        situationTwoIgnoreBtn.gameObject.SetActive(true);
        situationTwoBtn.gameObject.SetActive(false);

        realityCheckContainer.SetActive(true);
        
        realityCheckObject.ShuffleRealityCheck();
        ChooseSituationButtonAddProperty();
    }

    public void GoBackToSituation()
    {
        HeadingAndInstructionText("ACT ON SITUATION",
            "Choose one action on situation");

        situationCardContainer.SetActive(true);

        goBackToSituationBtn.gameObject.SetActive(false);
        goToAnotherSituationAfterCompletingOneBtn.gameObject.SetActive(false);
        situationActionContainer.SetActive(false);

        if (situation1Container.activeSelf)
        {
            situationAnimator.SetBool("SituationCard1Selected", true);
            situationOneActionOneBtn.interactable = true;
            situationOneActionTwoBtn.interactable = true;
            situationOneActionThreeBtn.interactable = true;
            situationOneIgnoreBtn.interactable = true;
        }

        if (situation2Container.activeSelf)
        {
            situationAnimator.SetBool("SituationCard2Selected", true);
            situationTwoActionOneBtn.interactable = true;
            situationTwoActionTwoBtn.interactable = true;
            situationTwoActionThreeBtn.interactable = true;
            situationTwoIgnoreBtn.interactable = true;
        }

        SituationActsInactive();
    }

    public void SituationActsInactive()
    {
        homelessSituationAct1.SetActive(false);
        homelessSituationAct2.SetActive(false);
        homelessSituationAct3.SetActive(false);
        refugeeSituationAct1.SetActive(false);
        refugeeSituationAct2.SetActive(false);
        refugeeSituationAct3.SetActive(false);
        fastFoodSituationAct1.SetActive(false);
        fastFoodSituationAct2.SetActive(false);
        fastFoodSituationAct3.SetActive(false);
        languageSituationAct1.SetActive(false);
        languageSituationAct2.SetActive(false);
        languageSituationAct3.SetActive(false);
        trashSituationAct1.SetActive(false);
        trashSituationAct2.SetActive(false);
        trashSituationAct3.SetActive(false);
    }

    public void ChooseSituationButtonAddProperty()
    {
        ChooseSituationButtonRemoveProperty();
        if (situation1Container.GetComponent<Image>().sprite == homelessSituationCard.GetComponent<Image>().sprite)
        {
            situationOneActionOneBtn.onClick.AddListener(ChooseHomelessAct1);
            situationOneActionTwoBtn.onClick.AddListener(ChooseHomelessAct2);
            situationOneActionThreeBtn.onClick.AddListener(ChooseHomelessAct3);
        }
        else if (situation1Container.GetComponent<Image>().sprite == refugeeSituationCard.GetComponent<Image>().sprite)
        {
            situationOneActionOneBtn.onClick.AddListener(ChooseRefugeeAct1);
            situationOneActionTwoBtn.onClick.AddListener(ChooseRefugeeAct2);
            situationOneActionThreeBtn.onClick.AddListener(ChooseRefugeeAct3);
        }
        else if (situation1Container.GetComponent<Image>().sprite == fastFoodSituationCard.GetComponent<Image>().sprite)
        {
            situationOneActionOneBtn.onClick.AddListener(ChooseFastFoodAct1);
            situationOneActionTwoBtn.onClick.AddListener(ChooseFastFoodAct2);
            situationOneActionThreeBtn.onClick.AddListener(ChooseFastFoodAct3);
        }
        else if (situation1Container.GetComponent<Image>().sprite == languageSituationCard.GetComponent<Image>().sprite)
        {
            situationOneActionOneBtn.onClick.AddListener(ChooseLangaugeAct1);
            situationOneActionTwoBtn.onClick.AddListener(ChooseLangaugeAct2);
            situationOneActionThreeBtn.onClick.AddListener(ChooseLangaugeAct3);

        }
        else if (situation1Container.GetComponent<Image>().sprite == trashSituationCard.GetComponent<Image>().sprite)
        {
            situationOneActionOneBtn.onClick.AddListener(ChooseTrashAct1);
            situationOneActionTwoBtn.onClick.AddListener(ChooseTrashAct2);
            situationOneActionThreeBtn.onClick.AddListener(ChooseTrashAct3);
        }

        if (situation2Container.GetComponent<Image>().sprite == homelessSituationCard.GetComponent<Image>().sprite)
        {
            situationTwoActionOneBtn.onClick.AddListener(ChooseHomelessAct1);
            situationTwoActionTwoBtn.onClick.AddListener(ChooseHomelessAct2);
            situationTwoActionThreeBtn.onClick.AddListener(ChooseHomelessAct3);

        }
        else if (situation2Container.GetComponent<Image>().sprite == refugeeSituationCard.GetComponent<Image>().sprite)
        {
            situationTwoActionOneBtn.onClick.AddListener(ChooseRefugeeAct1);
            situationTwoActionTwoBtn.onClick.AddListener(ChooseRefugeeAct2);
            situationTwoActionThreeBtn.onClick.AddListener(ChooseRefugeeAct3);
        }
        else if (situation2Container.GetComponent<Image>().sprite == fastFoodSituationCard.GetComponent<Image>().sprite)
        {
            situationTwoActionOneBtn.onClick.AddListener(ChooseFastFoodAct1);
            situationTwoActionTwoBtn.onClick.AddListener(ChooseFastFoodAct2);
            situationTwoActionThreeBtn.onClick.AddListener(ChooseFastFoodAct3);
        }
        else if (situation2Container.GetComponent<Image>().sprite == languageSituationCard.GetComponent<Image>().sprite)
        {
            situationTwoActionOneBtn.onClick.AddListener(ChooseLangaugeAct1);
            situationTwoActionTwoBtn.onClick.AddListener(ChooseLangaugeAct2);
            situationTwoActionThreeBtn.onClick.AddListener(ChooseLangaugeAct3);

        }
        else if (situation2Container.GetComponent<Image>().sprite == trashSituationCard.GetComponent<Image>().sprite)
        {
            situationTwoActionOneBtn.onClick.AddListener(ChooseTrashAct1);
            situationTwoActionTwoBtn.onClick.AddListener(ChooseTrashAct2);
            situationTwoActionThreeBtn.onClick.AddListener(ChooseTrashAct3);
        }

    }

    public void ChooseSituationButtonRemoveProperty()
    {      
        situationOneActionOneBtn.onClick.RemoveAllListeners();
        situationOneActionTwoBtn.onClick.RemoveAllListeners(); 
        situationOneActionThreeBtn.onClick.RemoveAllListeners(); 

        situationTwoActionOneBtn.onClick.RemoveAllListeners();
        situationTwoActionTwoBtn.onClick.RemoveAllListeners();
        situationTwoActionThreeBtn.onClick.RemoveAllListeners();
    }

    private bool RealityCheckWhileChoosingAct()
    {
        if (RealityCheck.rcUnexpectedCosts)
        {
            realityCheckObject.RealityCheckUnexpectedCost();
            return false;
        }
        else if (RealityCheck.rcExtraHours)
        {
            realityCheckObject.RealityCheckExtraHours();
            return false;
        }
        else if (RealityCheck.rcGovernmentObstacles)
        {
            realityCheckObject.RealityCheckGovernmentObstacles();
            return false;
        }
        else if (RealityCheck.rcHiredExpert)
        {
            realityCheckObject.RealityCheckHiredExpert();
            return false;
        }
        else if (RealityCheck.rcInjury)
        {
            realityCheckObject.RealityCheckInjury();
            return false;
        }      
        else if (RealityCheck.rcCaringCommunity)
        {
            communityWellbeingObject.WellbeingIncrease();
            RealityCheck.rcCaringCommunity = false;
            return false;
        }
        else if (RealityCheck.rcBurnoutSyndrome || RealityCheck.rcCallAFriend || RealityCheck.rcCaringCommunity || RealityCheck.rcDonor || RealityCheck.rcEconomicCrisis ||
            RealityCheck.rcEnterprenuerSpirit || RealityCheck.rcExtraHelp || RealityCheck.rcExtraHours || RealityCheck.rcGovernmentObstacles || RealityCheck.rcHiredExpert ||
            RealityCheck.rcInjury || RealityCheck.rcInvolvementGrowth || RealityCheck.rcLocalGrant || RealityCheck.rcNetworking || RealityCheck.rcTeamBuilding ||
            RealityCheck.rcTimeManagementTraining || RealityCheck.rcUnexpectedCosts || RealityCheck.rcVolunteers)
        {
            level1Object.CompleteRealityCheckFirstPopup();
            return true;
        }
        return false;
    }

    public void ChooseHomelessAct1()
    {
        if (RealityCheckWhileChoosingAct())
        {
            return;
        }       
        homelessSituationAct1.SetActive(true);
        ChoosingActSupportive();
    }
    public void ChooseHomelessAct2()
    {
        if (RealityCheckWhileChoosingAct())
        {
            return;
        }
        homelessSituationAct2.SetActive(true);
        ChoosingActSupportive();
    }

    public void ChooseHomelessAct3()
    {
        if (RealityCheckWhileChoosingAct())
        {
            return;
        }
        homelessSituationAct3.SetActive(true);
        ChoosingActSupportive();
    }

    public void ChooseRefugeeAct1()
    {
        if (RealityCheckWhileChoosingAct())
        {
            return;
        }
        refugeeSituationAct1.SetActive(true);
        ChoosingActSupportive();
    }
    public void ChooseRefugeeAct2()
    {
        if (RealityCheckWhileChoosingAct())
        {
            return;
        }
        refugeeSituationAct2.SetActive(true);
        ChoosingActSupportive();
    }
    public void ChooseRefugeeAct3()
    {
        if (RealityCheckWhileChoosingAct())
        {
            return;
        }
        refugeeSituationAct3.SetActive(true);
        ChoosingActSupportive();
    }

    public void ChooseFastFoodAct1()
    {
        if (RealityCheckWhileChoosingAct())
        {
            return;
        }
        fastFoodSituationAct1.SetActive(true);
        ChoosingActSupportive();
    }
    public void ChooseFastFoodAct2()
    {
        if (RealityCheckWhileChoosingAct())
        {
            return;
        }
        fastFoodSituationAct2.SetActive(true);
        ChoosingActSupportive();
    }
    public void ChooseFastFoodAct3()
    {
        if (RealityCheckWhileChoosingAct())
        {
            return;
        }
        fastFoodSituationAct3.SetActive(true);
        ChoosingActSupportive();
    }
    public void ChooseLangaugeAct1()
    {
        if (RealityCheckWhileChoosingAct())
        {
            return;
        }
        languageSituationAct1.SetActive(true);
        ChoosingActSupportive();
    }
    public void ChooseLangaugeAct2()
    {
        if (RealityCheckWhileChoosingAct())
        {
            return;
        }
        languageSituationAct2.SetActive(true);
        ChoosingActSupportive();
    }
    public void ChooseLangaugeAct3()
    {
        if (RealityCheckWhileChoosingAct())
        {
            return;
        }
        languageSituationAct3.SetActive(true);
        ChoosingActSupportive();
    }

    public void ChooseTrashAct1()
    {
        if (RealityCheckWhileChoosingAct())
        {
            return;
        }
        trashSituationAct1.SetActive(true);
        ChoosingActSupportive();
    }
    public void ChooseTrashAct2()
    {
        if (RealityCheckWhileChoosingAct())
        {
            return;
        }
        trashSituationAct2.SetActive(true);
        ChoosingActSupportive();
    }
    public void ChooseTrashAct3()
    {
        if (RealityCheckWhileChoosingAct())
        {
            return;
        }
        trashSituationAct3.SetActive(true);
        ChoosingActSupportive();
    }

    private void ChoosingActSupportive()
    {
        HeadingAndInstructionText("Pay for Action",
            "Please choose how you want to pay for action.");
        situationCardContainer.SetActive(false);
        realityCheckContainer.SetActive(false);
        goToAnotherSituationAfterCompletingOneBtn.gameObject.SetActive(true);
        goToAnotherSituationAfterCompletingOneBtn.interactable = false;
        payNowBtn.interactable = true;
        situationActionContainer.SetActive(true);
        if (round % 2 != 0)
        {
            goToAnotherSituationAfterCompletingOneBtnText.text = "Check Community Involvement";
        }
        else
        {
            goToAnotherSituationAfterCompletingOneBtnText.text = "Solve other Sitution";
        }
        goBackToSituationBtn.gameObject.SetActive(true);
        goBackToSituationBtn.interactable = true;
        level1Object.TextMoneyNetworkSet();
    }

    public void GoToAnotherSituationAfterCompletingOne()
    {
        HeadingAndInstructionText("ACT ON SITUATION",
            "Choose one action on situation");

        situationActionContainer.SetActive(false);
        goToAnotherSituationAfterCompletingOneBtn.gameObject.SetActive(false);
        goBackToSituationBtn.gameObject.SetActive(false);


        SituationActsInactive();

        situationCardContainer.SetActive(true);
        

        realityCheckContainer.SetActive(true);

        realityCheckObject.ShuffleRealityCheck();

        if (situation1Container.activeSelf)
        {
            situation1Container.SetActive(false);
            situation2Container.SetActive(true);

            situationAnimator.SetBool("SituationCard1Selected", false);
            situationAnimator.SetBool("SituationCard2Selected", true);

            situationTwoActionOneBtn.interactable = true;
            situationTwoActionTwoBtn.interactable = true;
            situationTwoActionThreeBtn.interactable = true;
            situationTwoIgnoreBtn.interactable = true;

            situationTwoActionOneBtn.gameObject.SetActive(true);
            situationTwoActionTwoBtn.gameObject.SetActive(true);
            situationTwoActionThreeBtn.gameObject.SetActive(true);
            situationTwoIgnoreBtn.gameObject.SetActive(true);

            ChooseSituationButtonAddProperty();
        }
        else if (situation2Container.activeSelf)
        {
            situation2Container.SetActive(false);
            situation1Container.SetActive(true);

            situationAnimator.SetBool("SituationCard2Selected", false);
            situationAnimator.SetBool("SituationCard1Selected", true);

            situationOneActionOneBtn.interactable = true;
            situationOneActionTwoBtn.interactable = true;
            situationOneActionThreeBtn.interactable = true;
            situationOneIgnoreBtn.interactable = true;

            situationOneActionOneBtn.gameObject.SetActive(true);
            situationOneActionTwoBtn.gameObject.SetActive(true);
            situationOneActionThreeBtn.gameObject.SetActive(true);
            situationOneIgnoreBtn.gameObject.SetActive(true);

            ChooseSituationButtonAddProperty();
        }
    }


}
