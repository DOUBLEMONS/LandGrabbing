using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Item : MonoBehaviour
{
    [SerializeField] private GameObject yutPrefab;

    private Player1_Move player1Logic;

    private void Awake()
    {
        player1Logic = GetComponent<Player1_Move>();
    }

    void Update()
    {
        UseItemYut();
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
}
