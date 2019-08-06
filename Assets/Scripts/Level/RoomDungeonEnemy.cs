using UnityEngine;

public class RoomDungeonEnemy : Room
{
    public Door[] doors;
    public Enemy[] enemies;

    private int enemiesAlive;

    private void Start() {
        foreach (Enemy e in enemies) {
            e.SetDungeonRoom(this);
        }
    }

    private bool CheckEnemies() {
        foreach (Enemy enemy in enemies) {
            if (enemy.gameObject.activeSelf) {
                return false;
            }
        }
        return true;
    }

    private void OpenDoors() {
        foreach (Door door in doors) {
            door.Open();
        }
    }

    private void CloseDoors() {
        foreach (Door door in doors) {
            door.Close();
        }
    }

    protected override void OnPlayerEnter() {
        base.OnPlayerEnter();
        CloseDoors();
        enemiesAlive = enemies.Length;
    }

    protected override void ActivateComponents(bool active) {
        base.ActivateComponents(active);
        foreach (Enemy e in enemies) {
            e.gameObject.SetActive(true);
        }
    }

    public void EnemyDeath() {
        enemiesAlive--;
        if (enemiesAlive <= 0) {
            OpenDoors();
        }
    }

}
