public class Goal
{
    public string description;
    public bool completed;
    public int currentAmount;
    public int requiredAmount;

    private Quest quest;

    public void SetQuest(Quest quest) {
        this.quest = quest;
    }

    public virtual void Init() {

    }

    public void Evaluate() {
        if (currentAmount >= requiredAmount) {
            Complete();
        }
    }

    public void Complete() {
        completed = true;
        if (quest != null) {
            quest.CheckGoals();
        }
    }

}
