using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float speed;
   public float turnSpeed = 25.0f;
   public float horizontalInput;
   public float forwardInput;

    // Update is called once per frame
    void Update()
    {
        ControllVeihcle();
    }

    //Função para o controle do veiculo
    private void ControllVeihcle()
    {
        //gerenciadores de entrada do teclado
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //condição para boostspeed
        speed = Input.GetKey(KeyCode.LeftShift) ? 40 : 20;

        if (forwardInput > 0)
        {
            // Mandar força no objeto = Acelerar
            //direção * tempo * velocidade * angulo
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        }
        else if (forwardInput < 0)
        {
            // Mandar força no objeto = Ré
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Rotate(Vector3.down, turnSpeed * horizontalInput * Time.deltaTime);
        }


    }
}
