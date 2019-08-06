using System;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {
    public GameObject window;
    public GameObject windowSingle;
    public Text dialogueTextSingle;
    public GameObject windowAnswers;
    public Text dialogueTextAnswers;
    public Text[] answers;
    public Image[] answersBackground;
    public GameObject continueButton;
    public Sprite answerSelected;
    public Sprite answerUnselected;

    private int currentChoice = 0;

    private Dialogues currentDialogue;
    public delegate void OnTrigger(string trigger);
    private event OnTrigger onTrigger;

    private void Start() {
        Context.controls.Dialogue.Continue.performed += _ => {
            Continue();
        };
        Context.controls.Dialogue.ChooseAnswer.performed += _ => {
            ChooseAnswer(currentChoice);
        };
        Context.controls.Dialogue.AnswerUp.performed += _ => {
            currentChoice--;
            if (currentChoice < 0) {
                currentChoice = answers.Length - 1;
            }
            UpdateAnswers();
        };
        Context.controls.Dialogue.AnswerDown.performed += _ => {
            currentChoice++;
            if (currentChoice >= answers.Length) {
                currentChoice = 0;
            }
            UpdateAnswers();
        };
    }

    public void StartDialogue(Dialogues dialogue, string tree, OnTrigger onTrigger = null) {
        currentDialogue = dialogue;
        this.onTrigger = onTrigger;
        currentDialogue.SetTree(tree);
        window.SetActive(true);
        Context.GetUiManager().ShowDialogue();
        DisplayDialogue();
    }

    public void StopDialogue() {
        if (currentDialogue != null) {
            window.SetActive(false);
            currentDialogue = null;
            Context.GetUiManager().StopDialogue();
        }
    }

    public void Continue() {
        if (currentDialogue != null && currentDialogue.GetChoices().Length == 0) {
            currentDialogue.Next();
            DisplayDialogue();
        }
    }

    public void SelectAnswer(int index) {
        currentChoice = Mathf.Clamp(index, 0, answers.Length - 1);
        UpdateAnswers();
    }

    public void ChooseAnswer(int index) {
        Debug.Log(index);
        if (currentDialogue != null) {
            if (currentDialogue.GetChoices().Length > 0) {
                if (index < currentDialogue.GetChoices().Length) {
                    currentDialogue.NextChoice(currentDialogue.GetChoices()[index]);
                } else {
                    Debug.LogWarning("Dialogue options index out of bounds");
                    currentDialogue.NextChoice(currentDialogue.GetChoices()[0]);
                }
                DisplayDialogue();
            } else {
                Debug.LogWarning("Dialogue window wasn't a choice");
                Continue();
            }
        }
    }

    private void DisplayDialogue() {
        if (currentDialogue == null)
            return;

        if (currentDialogue.HasTrigger()) {
            onTrigger?.Invoke(currentDialogue.GetTrigger());
        }

        if (currentDialogue.GetChoices().Length > 0) {
            dialogueTextAnswers.text = currentDialogue.GetCurrentDialogue();
            windowSingle.SetActive(false);
            windowAnswers.SetActive(true);
            if (continueButton != null) {
                continueButton.SetActive(false);
            }
            if (currentDialogue.GetChoices().Length >= answers.Length) {
                Debug.LogWarning("More choices than answer texts");
            }
           for (int i = 0; i < answers.Length; i++) {
                if (i < currentDialogue.GetChoices().Length) {
                    answers[i].transform.parent.gameObject.SetActive(true);
                    answers[i].text = currentDialogue.GetChoices()[i];
                } else {
                    answers[i].transform.parent.gameObject.SetActive(false);
                }
            }
            currentChoice = 0;
            UpdateAnswers();
        } else {
            dialogueTextSingle.text = currentDialogue.GetCurrentDialogue();
            windowSingle.SetActive(true);
            windowAnswers.SetActive(false);
            if (continueButton != null) {
                continueButton.SetActive(true);
            }
        }

        if (currentDialogue.End()) {
            onTrigger?.Invoke("end");
            currentDialogue.Next();
            if (currentDialogue.HasTrigger()) {
                onTrigger?.Invoke(currentDialogue.GetTrigger());
            }
            StopDialogue();
        }
    }

    public void UpdateAnswers() {
        if (currentDialogue != null) {
            for (int i = 0; i < answers.Length; i++) {
                answersBackground[i].sprite = currentChoice == i ? answerSelected : answerUnselected;
            }
        }
    }

}
