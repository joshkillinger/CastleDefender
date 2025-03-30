namespace CastleDefender.System
{
    public enum SystemLayers
    {
        PreFrameDataUpdate,
        FrameDataUpdate,
        PostFrameDataUpdate,
        Targeting,
        ResolveAbility,
        ApplyHealthMod,
        DespawnEntities,
        MoveEntities,
        SpawnEntities,
        Instantiate,
        Cleanup,
    }
}