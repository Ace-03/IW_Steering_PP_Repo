using UnityEngine;
public class ObstacleAvoider : Kinematic
{
    ObstacleAvoidance myMoveType;

    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new ObstacleAvoidance();
        myMoveType.character = this;
        myMoveType.target = myTarget;
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate = myMoveType.getSteering();
        steeringUpdate.linear.y = 0f;
        base.Update();
    }
}
