using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Player.Models
{
    public class Jugador
    {
        private Vector3 posicion;
        private Vector3 velocidad;

        public Jugador(Vector3 velocidad)
        {
            this.Velocidad = velocidad;
        }

        public Vector3
            Velocidad { get => velocidad; set => velocidad = value; }
    }
}
