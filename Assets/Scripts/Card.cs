using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] GameObject cardBackground;

    Level1 level1Object;

    private void Start()
    {
        level1Object = Level1.Level1Object;
    }
    //animation functions
    public void SetSituationsActiveAfterInitialPlayClick()
    {
        level1Object.situationCardContainer.SetActive(true);
        level1Object.situation1Container.SetActive(true);
        level1Object.situation2Container.SetActive(true);
        level1Object.situationOneBtn.gameObject.SetActive(true);
        level1Object.situationTwoBtn.gameObject.SetActive(true);
    }

    public void EnableCardBackground()
    {
        cardBackground.SetActive(true);
    }
    public void DisableCardBackground()
    {
        cardBackground.SetActive(false);
    }

    // button click functions

    public void OnCardClick()
    {
        GetComponent<Animator>().SetBool("CardPositionChange", false);
        GetComponent<Animator>().SetBool("CardAndBackgroundClicked", false);
        GetComponent<Animator>().SetBool("CardClicked", true);
        level1Object.andrewMoneyOngoingButton.gameObject.SetActive(true);
        level1Object.andrewTimeOngoingButton.gameObject.SetActive(true);
        level1Object.andrewNetworkOngoingButton.gameObject.SetActive(true);
        level1Object.specialAndrewBtn.gameObject.SetActive(true);
/*        level1Object.ongoingCharlieBtn.gameObject.SetActive(true);
*/        level1Object.specialCharlieBtn.gameObject.SetActive(true);
        level1Object.ongoingJoeyBtn.gameObject.SetActive(true);
        level1Object.specialJoeyBtn.gameObject.SetActive(true);
        level1Object.ongoingLiz1Btn.gameObject.SetActive(true);
        level1Object.ongoingLiz2Btn.gameObject.SetActive(true);
        level1Object.specialLiz1Btn.gameObject.SetActive(true);
        level1Object.specialLiz2Btn.gameObject.SetActive(true);
/*        level1Object.ongoingMariaBtn.gameObject.SetActive(true);
*/        level1Object.specialMariaBtn.gameObject.SetActive(true);
        level1Object.ongoingMoneyMario1Btn.gameObject.SetActive(true);
        level1Object.ongoingTimeMario2Btn.gameObject.SetActive(true);
        level1Object.ongoingNetworkMario3Btn.gameObject.SetActive(true);
        level1Object.specialMarioBtn.gameObject.SetActive(true);
        level1Object.ongoingMaryBtn.gameObject.SetActive(true);
        level1Object.specialMaryBtn.gameObject.SetActive(true);
        level1Object.ongoingPeterBtn.gameObject.SetActive(true);
        level1Object.specialPeterBtn.gameObject.SetActive(true);
        level1Object.ongoingRickBtn.gameObject.SetActive(true);
        level1Object.specialRickBtn.gameObject.SetActive(true);
        level1Object.ongoingSandraBtn.gameObject.SetActive(true);
        level1Object.specialSandraBtn.gameObject.SetActive(true);
/*        level1Object.ongoingStefanBtn.gameObject.SetActive(true);
*/        level1Object.specialStefanBtn.gameObject.SetActive(true);
        level1Object.ongoingTildaBtn.gameObject.SetActive(true);
        level1Object.specialTildaBtn.gameObject.SetActive(true);
    }
    public void OnCardExitClick()
    {
        GetComponent<Animator>().SetBool("CardPositionChange", false);
        GetComponent<Animator>().SetBool("CardClicked", false);
        GetComponent<Animator>().SetBool("CardAndBackgroundClicked", true);
        level1Object.andrewMoneyOngoingButton.gameObject.SetActive(false);
        level1Object.andrewTimeOngoingButton.gameObject.SetActive(false);
        level1Object.andrewNetworkOngoingButton.gameObject.SetActive(false);
        level1Object.specialAndrewBtn.gameObject.SetActive(false);
/*        level1Object.ongoingCharlieBtn.gameObject.SetActive(false);
*/        level1Object.specialCharlieBtn.gameObject.SetActive(false);
        level1Object.ongoingJoeyBtn.gameObject.SetActive(false);
        level1Object.specialJoeyBtn.gameObject.SetActive(false);
        level1Object.ongoingLiz1Btn.gameObject.SetActive(false);
        level1Object.ongoingLiz2Btn.gameObject.SetActive(false);
        level1Object.specialLiz1Btn.gameObject.SetActive(false);
        level1Object.specialLiz2Btn.gameObject.SetActive(false);
/*        level1Object.ongoingMariaBtn.gameObject.SetActive(false);
*/        level1Object.specialMariaBtn.gameObject.SetActive(false);
        level1Object.ongoingMoneyMario1Btn.gameObject.SetActive(false);
        level1Object.ongoingTimeMario2Btn.gameObject.SetActive(false);
        level1Object.ongoingNetworkMario3Btn.gameObject.SetActive(false);
        level1Object.specialMarioBtn.gameObject.SetActive(false);
        level1Object.ongoingMaryBtn.gameObject.SetActive(false);
        level1Object.specialMaryBtn.gameObject.SetActive(false);
        level1Object.ongoingPeterBtn.gameObject.SetActive(false);
        level1Object.specialPeterBtn.gameObject.SetActive(false);
        level1Object.ongoingRickBtn.gameObject.SetActive(false);
        level1Object.specialRickBtn.gameObject.SetActive(false);
        level1Object.ongoingSandraBtn.gameObject.SetActive(false);
        level1Object.specialSandraBtn.gameObject.SetActive(false);
/*        level1Object.ongoingStefanBtn.gameObject.SetActive(false);
*/        level1Object.specialStefanBtn.gameObject.SetActive(false);
        level1Object.ongoingTildaBtn.gameObject.SetActive(false);
        level1Object.specialTildaBtn.gameObject.SetActive(false);

    }
}
