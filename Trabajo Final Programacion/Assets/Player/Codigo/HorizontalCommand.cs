using Assets.Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Player.Codigo
{
    public class HorizontalCommand : ICommand
    {
        private readonly float _input;
        private Transform _transform;
        private Jugador _jugador;
        private IMovementStrategy _moveStrategy;

        public HorizontalCommand(float input, Transform transform)
        {
            _input = input;
            _transform = transform;
            _jugador = new Jugador(new System.Numerics.Vector3(7,0,0));
            _moveStrategy = new HorizontalMovementStrategy();
        }
        public void execute()
        {
            _moveStrategy.Move(_transform, _jugador, _input);
        }
    }
}
