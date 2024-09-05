using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RealityCheck : MonoBehaviour
{
    private static RealityCheck realityCheckObject;

    public static RealityCheck RealityCheckObject
    {
        get
        {
            return realityCheckObject;
        }
    }

    [Header("Reality Checks")]
    public GameObject involvementGrowth;
    public GameObject economicCrisis;
    public GameObject caringCommunity;
    public GameObject unexpectedCosts;
    public GameObject hiredExpert;
    public GameObject burnoutSyndrome;
    public GameObject governmentObstacles;
    public GameObject localGrant;
    public GameObject timeManagementTraining;
    public GameObject volunteers;
    public GameObject extraHelp;
    public GameObject callAFriend;
    public GameObject networking;
    public GameObject injury;
    public GameObject extraHours;
    public GameObject teamBuilding;
    public GameObject enterprenuerSpirit;
    public GameObject donor;

    public static bool rcInvolvementGrowth = false;
    public static bool rcEconomicCrisis = false;
    public static bool rcCaringCommunity = false;
    public static bool rcUnexpectedCosts = false;
    public static bool rcHiredExpert = false;
    public static bool rcBurnoutSyndrome = false;
    public static bool rcGovernmentObstacles = false;
    public static bool rcLocalGrant = false;
    public static bool rcTimeManagementTraining = false;
    public static bool rcVolunteers = false;
    public static bool rcExtraHelp = false;
    public static bool rcCallAFriend = false;
    public static bool rcNetworking = false;
    public static bool rcInjury = false;
    public static bool rcExtraHours = false;
    public static bool rcTeamBuilding = false;
    public static bool rcEnterprenuerSpirit = false;
    public static bool rcDonor = false;
    public static int realityCheckCardNumber = 0;

    public GameObject currentRealityCheckCard;
    public List<GameObject> realityCheckCards;

    Level1 level1Object;
    CommunityInvolvement communityInvolvementObject;

    private void Awake()
    {
        if (realityCheckObject != null && realityCheckObject != this)
        {
            Destroy(this);
        }
        else
        {
            realityCheckObject = this;
        }
        realityCheckCards = new List<GameObject>() { involvementGrowth /*, economicCrisis*/ , caringCommunity , unexpectedCosts , hiredExpert , burnoutSyndrome ,
                                                     governmentObstacles, localGrant, timeManagementTraining, volunteers /*, extraHelp*/ , callAFriend , networking , injury,
                                                     extraHours, teamBuilding, enterprenuerSpirit, donor };
    }

    private void Start()
    {
        level1Object = Level1.Level1Object;
        communityInvolvementObject = CommunityInvolvement.CommunityInvolvementObject;
    }
    private void InitialStatesSet()
    {        
        involvementGrowth.SetActive(false);
        economicCrisis.SetActive(false);
        caringCommunity.SetActive(false);
        unexpectedCosts.SetActive(false);
        hiredExpert.SetActive(false);
        burnoutSyndrome.SetActive(false);
        governmentObstacles.SetActive(false);
        localGrant.SetActive(false);
        timeManagementTraining.SetActive(false);
        volunteers.SetActive(false);
        extraHelp.SetActive(false);
        callAFriend.SetActive(false);
        networking.SetActive(false);
        injury.SetActive(false);
        extraHours.SetActive(false);
        teamBuilding.SetActive(false);
        enterprenuerSpirit.SetActive(false);
        donor.SetActive(false);

        rcInvolvementGrowth = false;
        rcEconomicCrisis = false;
        rcCaringCommunity = false;
        rcUnexpectedCosts = false;
        rcHiredExpert = false;
        rcBurnoutSyndrome = false;
        rcGovernmentObstacles = false;
        rcLocalGrant = false;
        rcTimeManagementTraining = false;
        rcVolunteers = false;
        rcExtraHelp = false;
        rcCallAFriend = false;
        rcNetworking = false;
        rcInjury = false;
        rcExtraHours = false;
        rcTeamBuilding = false;
        rcEnterprenuerSpirit = false;
        rcDonor = false;
    }

    public void ShuffleRealityCheck()
    {
        int tempNumber = UnityEngine.Random.Range(0, 16);
        InitialStatesSet();

        while (tempNumber == realityCheckCardNumber)
        {
            tempNumber = UnityEngine.Random.Range(0, 16);
        }

        realityCheckCardNumber = tempNumber;
        currentRealityCheckCard = realityCheckCards[realityCheckCardNumber];
        RealityCheckManager();
    }
    public void RealityCheckManager()
    {
        if (currentRealityCheckCard == involvementGrowth)
        {
            InitialStatesSet();
            involvementGrowth.SetActive(true);
            rcInvolvementGrowth = true;
            Debug.Log("involvementGrowth");
        }
        else if (currentRealityCheckCard == economicCrisis)
        {
            InitialStatesSet();
            economicCrisis.SetActive(true);
            rcEconomicCrisis= true;
            Debug.Log("economicCrisis");
        }
        else if (currentRealityCheckCard == caringCommunity)
        {
            InitialStatesSet();
            caringCommunity.SetActive(true);
            rcCaringCommunity= true;
            Debug.Log("caringCommunity");
        }
        else if (currentRealityCheckCard == unexpectedCosts)
        {
            InitialStatesSet();
            unexpectedCosts.SetActive(true);
            rcUnexpectedCosts= true;
            Debug.Log("unexpectedCosts");
        }
        else if (currentRealityCheckCard == hiredExpert)
        {
            InitialStatesSet();
            hiredExpert.SetActive(true);
            rcHiredExpert = true;
            Debug.Log("hiredExpert");
        }
        else if (currentRealityCheckCard == burnoutSyndrome)
        {
            InitialStatesSet();
            burnoutSyndrome.SetActive(true);
            rcBurnoutSyndrome= true;
            level1Object.rcBurnoutCard1Btn.GetComponentInChildren<TextMeshProUGUI>().text = $"Burnout {Level1.cardOneName}";
            level1Object.rcBurnoutCard1Btn.gameObject.SetActive(true);
            level1Object.rcBurnoutCard2Btn.GetComponentInChildren<TextMeshProUGUI>().text = $"Burnout {Level1.cardTwoName}";
            level1Object.rcBurnoutCard2Btn.gameObject.SetActive(true);
            level1Object.rcBurnoutCard3Btn.GetComponentInChildren<TextMeshProUGUI>().text = $"Burnout {Level1.cardThreeName}";
            level1Object.rcBurnoutCard3Btn.gameObject.SetActive(true);
            level1Object.rcBurnoutResourceBtn.gameObject.SetActive(false);
            Debug.Log("burnoutSyndrome");
        }
        else if (currentRealityCheckCard == governmentObstacles)
        {
            InitialStatesSet();
            governmentObstacles.SetActive(true);
            rcGovernmentObstacles= true;
            Debug.Log("governmentObstacles");
        }
        else if (currentRealityCheckCard == localGrant)
        {
            InitialStatesSet();
            localGrant.SetActive(true);
            rcLocalGrant= true;
            Debug.Log("localGrant");
        }
        else if (currentRealityCheckCard == timeManagementTraining)
        {
            InitialStatesSet();
            timeManagementTraining.SetActive(true);
            rcTimeManagementTraining= true;
            Debug.Log("timeManagementTraining");
        }
        else if (currentRealityCheckCard == volunteers)
        {
            InitialStatesSet();
            volunteers.SetActive(true);
            rcVolunteers= true;
            Debug.Log("volunteers");
        }
        else if (currentRealityCheckCard == extraHelp)
        {
            InitialStatesSet();
            extraHelp.SetActive(true);
            rcExtraHelp= true;
            Debug.Log("extraHelp");
        }
        else if (currentRealityCheckCard == callAFriend)
        {
            InitialStatesSet();
            callAFriend.SetActive(true);
            rcCallAFriend= true;
            Debug.Log("callAFriend");
        }
        else if (currentRealityCheckCard == networking)
        {
            InitialStatesSet();
            networking.SetActive(true);
            rcNetworking= true;
            Debug.Log("networking");
        }
        else if (currentRealityCheckCard == extraHours)
        {
            InitialStatesSet();
            extraHours.SetActive(true);
            rcExtraHours= true;
            Debug.Log("extraHours");
        }
        else if (currentRealityCheckCard == teamBuilding)
        {
            InitialStatesSet();
            teamBuilding.SetActive(true);
            rcTeamBuilding= true;
            level1Object.rcTeamBuildingCard1Btn.GetComponentInChildren<TextMeshProUGUI>().text = $"Ready {Level1.cardOneName}";
            level1Object.rcTeamBuildingCard1Btn.gameObject.SetActive(true);
            level1Object.rcTeamBuildingCard2Btn.GetComponentInChildren<TextMeshProUGUI>().text = $"Ready {Level1.cardTwoName}";
            level1Object.rcTeamBuildingCard2Btn.gameObject.SetActive(true);
            level1Object.rcTeamBuildingCard3Btn.GetComponentInChildren<TextMeshProUGUI>().text = $"Ready {Level1.cardThreeName}";
            level1Object.rcTeamBuildingCard3Btn.gameObject.SetActive(true);
            level1Object.rcTeamBuildingResourceBtn.gameObject.SetActive(false);
            Debug.Log("teamBuilding");
        }
        else if (currentRealityCheckCard == enterprenuerSpirit)
        {
            InitialStatesSet();
            enterprenuerSpirit.SetActive(true);
            rcEnterprenuerSpirit= true;
            Debug.Log("enterprenuerSpirit");
        }
        else if (currentRealityCheckCard == donor)
        {
            InitialStatesSet();
            donor.SetActive(true);
            rcDonor= true;
            Debug.Log("donor");
        }
    }

    public void RealityCheckInvolvementGrowth()
    {
        rcInvolvementGrowth = false;
    }

    public void RealityCheckUnexpectedCost()
    {
        if (rcUnexpectedCosts)
        {
            if (Convert.ToInt16(level1Object.rMoneyText.text) >= 1)
            {
                level1Object.rMoneyText.text = Convert.ToString(Convert.ToInt16(level1Object.rMoneyText.text) - 1);
                rcUnexpectedCosts = false;
                level1Object.realityCheckContainer.SetActive(false);
            }         
        }              
    }

    public void RealityCheckCallAFriend()
    {
        if (rcCallAFriend && Convert.ToInt16(level1Object.rNetworkText.text) >= 1)
        {
            rcCallAFriend = false;
            level1Object.rNetworkText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 1);
            level1Object.realityCheckContainer.SetActive(false);
        }
        else
        {
            level1Object.OperationInvalidPopup();
        }
    }

    public void GainTime()
    {
        level1Object.rTimeText.text = Convert.ToString(Convert.ToInt16(level1Object.rTimeText.text) + 1);
        level1Object.realityCheckContainer.SetActive(false);
        rcDonor = false;
        rcTimeManagementTraining= false;
    }
    public void GainNetwork()
    {
        level1Object.rNetworkText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) + 1);
        level1Object.realityCheckContainer.SetActive(false);
        rcDonor = false;
    }
    public void GainMoney()
    {
        level1Object.rMoneyText.text = Convert.ToString(Convert.ToInt16(level1Object.rMoneyText.text) + 1);
        level1Object.realityCheckContainer.SetActive(false);
        rcEnterprenuerSpirit = false;
        rcDonor = false;
    }

    public void RealityCheckEconomicCrisis()
    {
        rcEconomicCrisis = false;
    }

    public void MoveProtestDown()
    {
        if (CommunityInvolvement.protestMoveCounter == 0)
        {
            if (Convert.ToInt16(level1Object.rMoneyText.text) >= 1 || Convert.ToInt16(level1Object.rNetworkText.text) >= 1 || Convert.ToInt16(level1Object.rTimeText.text) >= 1)
            {
                if (Convert.ToInt16(level1Object.rMoneyText.text) >= 1 && Convert.ToInt16(level1Object.rNetworkText.text) >= 2)
                {
                    level1Object.rMoneyText.text = Convert.ToString(Convert.ToInt16(level1Object.rMoneyText.text) - 1);
                    level1Object.rNetworkText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 2);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;
                }
                else if (Convert.ToInt16(level1Object.rMoneyText.text) >= 1 && Convert.ToInt16(level1Object.rTimeText.text) >= 2)
                {
                    level1Object.rMoneyText.text = Convert.ToString(Convert.ToInt16(level1Object.rMoneyText.text) - 1);
                    level1Object.rTimeText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 2);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;
                }
                else if (Convert.ToInt16(level1Object.rNetworkText.text) >= 2 && Convert.ToInt16(level1Object.rTimeText.text) >= 1)
                {
                    level1Object.rNetworkText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 2);
                    level1Object.rTimeText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 1);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;
                }
                else if (Convert.ToInt16(level1Object.rMoneyText.text) >= 3)
                {
                    level1Object.rMoneyText.text = Convert.ToString(Convert.ToInt16(level1Object.rMoneyText.text) - 3);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;
                }
                else if (Convert.ToInt16(level1Object.rNetworkText.text) >= 3)
                {
                    level1Object.rNetworkText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 3);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;

                }
                else if (Convert.ToInt16(level1Object.rTimeText.text) >= 3)
                {
                    level1Object.rTimeText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 3);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;
                }
            }           
        }
        else
        {
            CommunityInvolvement.protestMoveCounter -= 2;
            communityInvolvementObject.MoveProtest();
            rcEconomicCrisis = false;
            return;
        }

        level1Object.NotEnoughResourcesPopup();
    }

    public void MovePetitionDown()
    {
        if (CommunityInvolvement.petitionMoveCounter == 0)
        {
            if (Convert.ToInt16(level1Object.rMoneyText.text) >= 1 || Convert.ToInt16(level1Object.rNetworkText.text) >= 1 || Convert.ToInt16(level1Object.rTimeText.text) >= 1)
            {
                if (Convert.ToInt16(level1Object.rMoneyText.text) >= 1 && Convert.ToInt16(level1Object.rNetworkText.text) >= 2)
                {
                    level1Object.rMoneyText.text = Convert.ToString(Convert.ToInt16(level1Object.rMoneyText.text) - 1);
                    level1Object.rNetworkText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 2);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;
                }
                else if (Convert.ToInt16(level1Object.rMoneyText.text) >= 1 && Convert.ToInt16(level1Object.rTimeText.text) >= 2)
                {
                    level1Object.rMoneyText.text = Convert.ToString(Convert.ToInt16(level1Object.rMoneyText.text) - 1);
                    level1Object.rTimeText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 2);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;
                }
                else if (Convert.ToInt16(level1Object.rNetworkText.text) >= 2 && Convert.ToInt16(level1Object.rTimeText.text) >= 1)
                {
                    level1Object.rNetworkText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 2);
                    level1Object.rTimeText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 1);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;
                }
                else if (Convert.ToInt16(level1Object.rMoneyText.text) >= 3)
                {
                    level1Object.rMoneyText.text = Convert.ToString(Convert.ToInt16(level1Object.rMoneyText.text) - 3);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;
                }
                else if (Convert.ToInt16(level1Object.rNetworkText.text) >= 3)
                {
                    level1Object.rNetworkText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 3);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;

                }
                else if (Convert.ToInt16(level1Object.rTimeText.text) >= 3)
                {
                    level1Object.rTimeText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 3);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;
                }
            }           
        }
        else
        {
            CommunityInvolvement.petitionMoveCounter -= 2;
            communityInvolvementObject.MovePetition();
            rcEconomicCrisis = false;
            return;
        }

        level1Object.NotEnoughResourcesPopup();
    }

    public void MoveDonationDown()
    {
        if (CommunityInvolvement.donationMoveCounter == 0)
        {
            if (Convert.ToInt16(level1Object.rMoneyText.text) >= 1 || Convert.ToInt16(level1Object.rNetworkText.text) >= 1 || Convert.ToInt16(level1Object.rTimeText.text) >= 1)
            {
                if (Convert.ToInt16(level1Object.rMoneyText.text) >= 1 && Convert.ToInt16(level1Object.rNetworkText.text) >= 2)
                {
                    level1Object.rMoneyText.text = Convert.ToString(Convert.ToInt16(level1Object.rMoneyText.text) - 1);
                    level1Object.rNetworkText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 2);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;
                }
                else if (Convert.ToInt16(level1Object.rMoneyText.text) >= 1 && Convert.ToInt16(level1Object.rTimeText.text) >= 2)
                {
                    level1Object.rMoneyText.text = Convert.ToString(Convert.ToInt16(level1Object.rMoneyText.text) - 1);
                    level1Object.rTimeText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 2);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;
                }
                else if (Convert.ToInt16(level1Object.rNetworkText.text) >= 2 && Convert.ToInt16(level1Object.rTimeText.text) >= 1)
                {
                    level1Object.rNetworkText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 2);
                    level1Object.rTimeText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 1);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;
                }
                else if (Convert.ToInt16(level1Object.rMoneyText.text) >= 3)
                {
                    level1Object.rMoneyText.text = Convert.ToString(Convert.ToInt16(level1Object.rMoneyText.text) - 3);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;
                }
                else if (Convert.ToInt16(level1Object.rNetworkText.text) >= 3)
                {
                    level1Object.rNetworkText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 3);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;

                }
                else if (Convert.ToInt16(level1Object.rTimeText.text) >= 3)
                {
                    level1Object.rTimeText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 3);
                    rcEconomicCrisis = false;
                    level1Object.realityCheckContainer.SetActive(false);
                    return;
                }
            }
        }
        else
        {
            CommunityInvolvement.donationMoveCounter -= 2;
            communityInvolvementObject.MoveDonation();
            rcEconomicCrisis = false;
            return;
        }

        level1Object.NotEnoughResourcesPopup();
    }

    public void RealityCheckExtraHelp()
    {
        rcExtraHelp = false;
        level1Object.realityCheckContainer.SetActive(false);
    }

    public void RealityCheckExtraHours()
    {
        if (rcExtraHours)
        {
            if (Convert.ToInt16(level1Object.rTimeText.text) >= 1)
            {
                level1Object.rTimeText.text = Convert.ToString(Convert.ToInt16(level1Object.rTimeText.text) - 1);
                rcExtraHours = false;
                level1Object.realityCheckContainer.SetActive(false); 
            }
            else
            {
                level1Object.NotEnoughResourcesPopup();
            }
        }      
    }

    public void RealityCheckGovernmentObstacles()
    {
        if (rcGovernmentObstacles)
        {
            if (Convert.ToInt16(level1Object.rNetworkText.text) >= 2)
            {
                level1Object.rNetworkText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) - 2);
                rcGovernmentObstacles = false;
                level1Object.realityCheckContainer.SetActive(false);
            }
            else
            {
                level1Object.NotEnoughResourcesPopup();
            }
        }
    }

    public void RealityCheckInjury()
    {
        if (rcInjury)
        {
            if (Convert.ToInt16(level1Object.rTimeText.text) >= 2)
            {
                level1Object.rTimeText.text = Convert.ToString(Convert.ToInt16(level1Object.rTimeText.text) - 2);
                rcInjury = false;
                level1Object.realityCheckContainer.SetActive(false);
            }
            else
            {
                level1Object.NotEnoughResourcesPopup();
            }
        }
    }

    public void RealityCheckHiredExpert()
    {
        if (rcHiredExpert)
        {
            if (Convert.ToInt16(level1Object.rMoneyText.text) >= 2)
            {
                level1Object.rMoneyText.text = Convert.ToString(Convert.ToInt16(level1Object.rMoneyText.text) - 2);
                rcHiredExpert = false;
                level1Object.realityCheckContainer.SetActive(false);
            }
            else
            {
                level1Object.NotEnoughResourcesPopup();
            }
        }
    }

    public void GainMoney2()
    {   
        level1Object.rMoneyText.text = Convert.ToString(Convert.ToInt16(level1Object.rMoneyText.text) + 2);
        level1Object.realityCheckContainer.SetActive(false);
        rcLocalGrant = false;
    }

    public void MoveDonationUp()
    {
        communityInvolvementObject.MoveDonationUpWithoutMoney();
        rcLocalGrant = false;
        level1Object.realityCheckContainer.SetActive(false);
    }

    public void GainNetwork2()
    {
        level1Object.rNetworkText.text = Convert.ToString(Convert.ToInt16(level1Object.rNetworkText.text) + 2);
        level1Object.realityCheckContainer.SetActive(false);
        rcNetworking = false;
    }

    public void GainLongTermNetwork()
    {
        level1Object.lNetworkText.text = Convert.ToString(Convert.ToInt16(level1Object.lNetworkText.text) + 1);
        level1Object.realityCheckContainer.SetActive(false);
        rcNetworking = false;
    }

    public void GainTime2()
    {
        level1Object.rTimeText.text = Convert.ToString(Convert.ToInt16(level1Object.rTimeText.text) + 2);
        level1Object.realityCheckContainer.SetActive(false);
        rcVolunteers = false;
    }

    public void MoveProtestUp()
    {
        communityInvolvementObject.MoveProtestUpWithoutMoney();
        rcVolunteers = false;
        level1Object.realityCheckContainer.SetActive(false);
    }
}
