namespace CastleDefender.System
{
    public enum SystemLayers
    {
        PreFrameDataUpdate,
        FrameDataUpdate,
        PostFrameDataUpdate,
        ResolveAbility,
        ApplyHealthMod,
        DespawnEntities,
        MoveEntities,
        SpawnEntities,
        Instantiate,
        Cleanup,
    }
}