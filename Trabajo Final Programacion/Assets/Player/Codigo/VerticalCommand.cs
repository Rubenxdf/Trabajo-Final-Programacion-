using Assets.Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Player.Codigo
{
    public class VerticalCommand : ICommand
    {
        private readonly float _input;
        private Transform _transform;
        private Jugador _jugador;
        private IMovementStrategy _movementStrategy;

        public VerticalCommand(float input, Transform transform)
        {
            _input = input;
            _transform = transform;
            _jugador = new Jugador(new System.Numerics.Vector3(0, 0, 7));
            _movementStrategy = new VerticalMovementStrategy();
        }
        public void execute()
        {
            _movementStrategy.Move(_transform, _jugador, _input);
        }
    }
}
