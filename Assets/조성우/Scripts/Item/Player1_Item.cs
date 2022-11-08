using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Item : MonoBehaviour
{
    [SerializeField] private GameObject yutPrefab;
    [SerializeField] private GameObject jaegiPrefab;

    private Player1_Move player1Logic;

    private void Awake()
    {
        player1Logic = GetComponent<Player1_Move>();
    }

    void Update()
    {
        UseItemYut();
        UseItemJaegi();
    }

    private void UseItemYut()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(yutPrefab, transform.position, Quaternion.Euler(new Vector3(0, 0, player1Logic.playerLotation + 9)));
            Instantiate(yutPrefab, transform.position, Quaternion.Euler(new Vector3(0, 0, player1Logic.playerLotation + 30)));
            Instantiate(yutPrefab, transform.position, Quaternion.Euler(new Vector3(0, 0, player1Logic.playerLotation + -9)));
            Instantiate(yutPrefab, transform.position, Quaternion.Euler(new Vector3(0, 0, player1Logic.playerLotation + -30)));
        }
    }

    private void UseItemJaegi()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            GameObject jaegi = Instantiate(jaegiPrefab, transform.position, Quaternion.identity);
            jaegi.GetComponent<Jaegi>().randomDir = new Vector2(Random.Range(-360, 360), Random.Range(-360, 360));
        }
    }    
}
