using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seeker : Kinematic
{
    Seek myMoveType;
    LookWhereGoing mySeekRotateType;
    LookWhereGoing myFleeRotateType;

    public bool flee = false;

    //public GameObject target;

    [SerializeField]
    private Toggle toggle;

    // Start is called before the first frame update
    

    void Start()
    {
        myMoveType = new Seek();
        myMoveType.character = this;
        myMoveType.target = myTarget;
        myMoveType.flee = flee;

        mySeekRotateType = new LookWhereGoing();
        mySeekRotateType.character = this;
        mySeekRotateType.target = myTarget;

        
        myFleeRotateType = new LookWhereGoing();
        myFleeRotateType.character = this;
        myFleeRotateType.target = myTarget;
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = flee ? myFleeRotateType.getSteering().angular : mySeekRotateType.getSteering().angular;
        base.Update();
    }

    public void ChangeBehaviour()
    {
        flee = !flee;
        myMoveType.flee = flee;
    }
}
