using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CommunityWellbeing : MonoBehaviour
{
    private static CommunityWellbeing communityWellbeingObject;

    public static CommunityWellbeing CommunityWellbeingObject 
    { 
        get      
        { 
            return communityWellbeingObject; 
        }
    }

    // Start is called before the first frame update
    [Header("Community Wellbeing GameObjects")]
    [SerializeField] GameObject communityWellbeingCube;

    [Header("Long-Term Effect Resources")]
    [SerializeField] TextMeshProUGUI lTimeText;
    [SerializeField] TextMeshProUGUI lNetworkText;
    [SerializeField] TextMeshProUGUI lMoneyText;


    static public int wellbeingLevelCount = 5;
    Level1 level1Object;

    private void Awake()
    {
        if (communityWellbeingObject != null && communityWellbeingObject != this)
        {
            Destroy(this);
        }
        else
        {
            communityWellbeingObject = this;
        }
    }
    private void Start()
    {
        wellbeingLevelCount = 5;
        level1Object = Level1.Level1Object;
    }
    public void WellbeingIncrease()
    {
        wellbeingLevelCount++;
        switch (wellbeingLevelCount)
        {
            case 0:
                gameObject.AddComponent<LevelHandler>().GameOver();
                break;
            case 1:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -740.4f);
                break;
            case 2:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -709.5f);
                break;
            case 3:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -680.1f);
                break;
            case 4:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -654.63f);
                break;
            case 5:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -625.4f);
                break;
            case 6:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -595);
                break;
            case 7:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -566.85f);
                break;
            case 8:
                level1Object.CommunityWellbeingReadyCharacter();
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -537.1f);
                break;
            case 9:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -509);
                break;
            case 10:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -481);
                lTimeText.text = Convert.ToString(Convert.ToInt16(lTimeText.text) + 1);
                break;
            case 11:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -450.7f);
                break;
            case 12:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -422f);
                lNetworkText.text = Convert.ToString(Convert.ToInt16(lNetworkText.text) + 1);
                break;
            case 13:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -393f);
                break;
            case 14:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -363.2f);
                lMoneyText.text = Convert.ToString(Convert.ToInt16(lMoneyText.text) + 1);
                break;
            case 15:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -334.4f);
                break;
            case 16:
                level1Object.CommunityWellbeingReadyCharacter();
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -305.4f);
                break;
            case 17:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -276.1f);
                break;
            case 18:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -246.2f);
                break;
            case 19:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -218f);
                break;
            case 20:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -189f);
                break;
            case 21:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -160.6f);
                break;
            case 22:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -131.2f);
                break;
            case 23:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -102.3f);
                break;
            case 24:
                communityWellbeingCube.GetComponent<RectTransform>().anchoredPosition = new Vector2(-94.3f, -73.5f);
                break;
            default:
                break;
        }
    }
}
