public class MeleeEnemy : ChasingEnemy {
    protected override void UpdateAnim() {
        base.UpdateAnim();
        anim.SetBool(Constants.ANIM_OGRE_attacking, currentState == EnemyState.attack);
    }
}
