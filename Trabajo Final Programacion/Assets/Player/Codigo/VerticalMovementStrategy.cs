using Assets.Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Player.Codigo
{
    public class VerticalMovementStrategy : IMovementStrategy
    {
        public void Move(Transform transform, Jugador jugador, float direccion)
        {
            transform.Translate(0,0,direccion * jugador.Velocidad.Z * Time.deltaTime); 
        }
    }
}
