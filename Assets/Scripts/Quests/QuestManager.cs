using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    [Header("Quest Offer Window")]
    public GameObject questOfferWindow;
    public Text questOfferName;
    public Text questOfferDescription;

    [Header("Quests Window")]
    public GameObject questWindow;
    public GameObject questPrefab;

    public List<Quest> completedQuests = new List<Quest>();
    public List<Quest> activeQuests = new List<Quest>();

    private Quest questOffered;
    private UIManager uiManager;

    private void Start() {
        uiManager = Context.GetUiManager();
        Context.controls.GUI.QuestWindow.performed += _ => {
            ToggleWindow();
        };
    }

    public void OfferQuest(Quest quest) {
        questOffered = quest;
        questOfferName.text = quest.questName;
        questOfferDescription.text = quest.description;
        questOfferWindow.SetActive(true);
        uiManager.questOfferIsActive = true;
    }

    public void AcceptOfferedQuest() {
        activeQuests.Add(questOffered);
        HideQuestOffer();
    }

    public void DenyOfferedQuest() {
        HideQuestOffer();
    }

    private void HideQuestOffer() {
        questOffered = null;
        questOfferWindow.SetActive(false);
        uiManager.questOfferIsActive = false;
    }

    public bool ToggleWindow() {
        if (!uiManager.questWindowIsActive) {
            Show();
        } else {
            Hide();
        }
        return uiManager.questWindowIsActive;
    }

    public void Show() {
        if (uiManager.CanOpenWindow()) {
            questWindow.SetActive(true);
            uiManager.questWindowIsActive = true;
        }
    }

    public void Hide() {
        questWindow.SetActive(false);
        uiManager.questWindowIsActive = false;
    }

}
