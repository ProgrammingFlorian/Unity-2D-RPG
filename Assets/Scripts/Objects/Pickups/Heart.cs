public class Heart : Pickupable
{
    public int healAmount = 2;

    protected override void OnPickup() {
        Context.GetPlayer().Heal(healAmount);
    }
}
