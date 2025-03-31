namespace CastleDefender.System
{
    public enum SystemLayers
    {
        PreFrameDataUpdate,
        FrameDataUpdate,
        PostFrameDataUpdate,
        Targeting,
        AiLogic,
        ResolveAbility,
        ApplyHealthMod,
        DespawnEntities,
        MoveEntities,
        SpawnEntities,
        Instantiate,
        Cleanup,
    }
}