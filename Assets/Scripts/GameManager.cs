using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{
    static GameManager _instance;
    public static GameManager instance { get { return _instance; } }
    public  GameObject enemy;
    NavMeshAgent agent = null;
    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        agent = GetComponent<NavMeshAgent>();

    }

    /*public void SpwanEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(100, 190), 0, Random.Range(190, 110)), Quaternion.identity);
    }*/
    public void SetDestForEnemy()
    {
        agent.SetDestination(enemy.transform.position);

    }

}
