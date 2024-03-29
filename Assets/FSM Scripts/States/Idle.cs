using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : BaseState
{

    public Idle(MovementSM stateMachine) : base("Idle", stateMachine) { }

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
