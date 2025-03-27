using System.Numerics;

public class PositionReachedBehaviourSwapper : BehaviourSwapperBase
{
    public override void ResetBehaviourSwaper()
    {
        return;
    }

    public override bool SwapBehaviour(EntityDataSchema entityData, BehaviourSwapDataSchema behaviourData)
    {
        return UnityEngine.Vector3.Distance(entityData.transform.position, entityData.target.position) < behaviourData.distance;
    }
}
