using System;
using UnityEngine;

public class Quest : MonoBehaviour {

    public int requiredLevel;
    public Goal[] goals;
    public string questName;
    public string description;
    public int experienceReward;
    public event Action onComplete;
    public bool completed { get; private set; } = false;

    private void Start() {
        onComplete += () => {
            GiveReward();
        };
    }

    public void CheckGoals() {
        foreach (Goal goal in goals) {
            if (!goal.completed) {
                return;
            }
        }
        completed = true;
        onComplete();
    }

    public void GiveReward() {
        Context.GetPlayerStats().AddExperience(experienceReward);
    }
}
