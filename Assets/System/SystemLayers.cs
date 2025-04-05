namespace CastleDefender.System
{
    public enum SystemLayers
    {
        PreFrameDataUpdate,
        FrameDataUpdate,
        PostFrameDataUpdate,
        Targeting,
        ResolveAbility,
        ResolveAttack,
        ApplyHealthMod,
        DespawnEntities,
        MoveEntities,
        SpawnEntities,
        Instantiate,
        Render,
        Cleanup,
    }
}