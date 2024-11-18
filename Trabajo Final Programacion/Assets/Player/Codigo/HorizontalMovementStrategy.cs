using Assets.Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Player.Codigo
{
    public class HorizontalMovementStrategy : IMovementStrategy
    {
        public void Move(Transform transform, Jugador jugador, float direccion)
        {
            transform.Translate(direccion * jugador.Velocidad.X * Time.deltaTime, 0, 0);   
        }
    }
}
