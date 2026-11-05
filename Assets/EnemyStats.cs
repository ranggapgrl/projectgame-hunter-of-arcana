using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemyStats", menuName = "HunterOfArcana/Enemy Stats")]
public class EnemyStats : ScriptableObject 
{
    public string enemyName;
    public float hp;
    public float damage;
    public float speed;
    public float cooldown;
    public float armor;
    public int cost;
}