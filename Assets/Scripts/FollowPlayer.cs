using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,7,-9);
    
    //Atualizar o método após a finalização das funções
    void LateUpdate()
    {
        //Deslocar a câmera atrás do player adicionando a posição do player
        //posição da camera = posição do player + deslocamento (camera)
        transform.position = player.transform.position + offset;

    }
}
