using Assets.Player.Codigo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private List<ICommand> commands;
    private Animator anim; // Añadimos la referencia al Animator
    public GameObject canvasDerrota;
    private void Start()
    {
        commands = new List<ICommand>();
        anim = GetComponent<Animator>(); // Obtenemos el Animator en Start
    }

    void Update()
    {
        commands.Clear();

        // Lectura del input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Actualizar los parámetros de animación
        anim.SetFloat("VelX", horizontalInput);
        anim.SetFloat("VelY", verticalInput);

        // Comandos de movimiento
        commands.Add(new HorizontalCommand(horizontalInput, transform));
        commands.Add(new VerticalCommand(verticalInput, transform));

        // Ejecutar los comandos
        foreach (var command in commands)
        {
            command.execute();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            // Activa el CanvasDerrota
            canvasDerrota.SetActive(true);
            Destroy(gameObject);

        }
    }
}
