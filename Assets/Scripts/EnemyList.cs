using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyList : MonoBehaviour
{
    public static string[] tagsRange = { "Enemy", "EnemyFast", "EnemyTank" };
    public static List<string> tags = new List<string>(tagsRange);

    public static List<string> ReturnEnemyList()
    {
        return tags;
    }
}
