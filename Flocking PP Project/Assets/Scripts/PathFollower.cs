﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : Kinematic
{
    PathFollow myMoveType;
    LookWhereGoing myRotateType;
    public GameObject[] targets; 

    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new PathFollow();
        myMoveType.character = this;
        myMoveType.targetPath = targets;

        myRotateType = new LookWhereGoing();
        myRotateType.character = this;
        myRotateType.target = myTarget;
    }

    // Update is called once per frame
    void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = myRotateType.getSteering().angular;
        base.Update();
    }
}
