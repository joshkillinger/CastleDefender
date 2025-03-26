namespace CastleDefender.System
{
    public enum SystemLayers
    {
        PreFrameDataUpdate,
        FrameDataUpdate,
        PostFrameDataUpdate,
        CalculateInitiative,
        ResolveAbility,
        ApplyHealthMod,
        DespawnEntities,
        MoveEntities,
        FaceEntities,
        SpawnEntities,
        Instantiate,
        Cleanup,
    }
}