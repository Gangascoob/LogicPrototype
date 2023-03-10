using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : BaseState
{
    public Moving(MovementSM stateMachine) : base("Moving", stateMachine) { }

    public override void Enter()
    {
        base.Enter();
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
    }
}
