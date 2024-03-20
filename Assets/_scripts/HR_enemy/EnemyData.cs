using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemyData", menuName = "Enemy Data")]
public class EnemyData : ScriptableObject
{
    public string enemyName;
    public int health;
    public int damage;
    public GameObject prefab; // Reference to the enemy's prefab for instantiation

    // You can add more properties here as needed
}

