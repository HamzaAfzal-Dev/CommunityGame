using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelHandler : MonoBehaviour
{
    Situation situationObject;
    Level1 level1Object;

    private void Start()
    {
        situationObject = Situation.SituationObject;
        level1Object = Level1.Level1Object;
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(1);
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    public void PopupInactive()
    {
        Level1 level1Object = Level1.Level1Object;
        level1Object.PopupInactive();
    }

    public void EnableCommunityInvolvementBackground()
    {
        CommunityInvolvement communityInvolvementObject = CommunityInvolvement.CommunityInvolvementObject;
        if (!Level1.isNewRound)
        {
            communityInvolvementObject.communityInvolvementBackground.SetActive(true);
        }     
    }
    public void DisableCommunityInvolvementBackground()
    {
        CommunityInvolvement communityInvolvementObject = CommunityInvolvement.CommunityInvolvementObject;
        communityInvolvementObject.communityInvolvementBackground.SetActive(false);
    }

    public void SituationAddListeners()
    {
        situationObject.ChooseSituationButtonAddProperty();
    }

    public void OnGettingResourcesSetInactive()
    {
       level1Object.resourceGainerContainer.SetActive(false);
    }


    public void ExchangeResourceMenuCloserSetInactive()
    {
        level1Object.exchangeMenuContainer.gameObject.SetActive(false);
    }
}
