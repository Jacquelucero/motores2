using UnityEngine;

public class EnemyRoomTrigger : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enemyMovement[] enemies = FindObjectsOfType<enemyMovement>();

            foreach (enemyMovement enemy in enemies)
            {
                float dist = Vector2.Distance(enemy.transform.position, other.transform.position);

                // Solo afecta a enemigos cercanos al jugador (dentro de esta habitación)
                if (dist < 10f)
                {
                    enemy.StopChasingAndReturn();
                }
            }
        }
    }
}
