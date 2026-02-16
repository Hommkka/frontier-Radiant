// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-License-Identifier: AGPL-3.0-or-later

using Robust.Shared.Physics.Components;

namespace Content.Shared._EinsteinEngines.Contests;

public sealed partial class ContestsSystem : EntitySystem
{
    private const float AverageMass = 71f;

    /// <summary>
    ///     Outputs the ratio of mass between a performer and the average human mass
    /// </summary>
    public float MassContest(EntityUid performerUid, bool bypassClamp = false, float rangeFactor = 1f, float otherMass = AverageMass)
    {
        if (!TryComp<PhysicsComponent>(performerUid, out var performerPhysics)
            || performerPhysics.Mass == 0)
            return 1f;

        return performerPhysics.Mass / otherMass;
    }

    /// <summary>
    ///     Outputs the ratio of mass between a performer and a target
    /// </summary>
    public float MassContest(EntityUid performerUid, EntityUid targetUid, bool bypassClamp = false, float rangeFactor = 1f)
    {
        if (!TryComp<PhysicsComponent>(performerUid, out var performerPhysics)
            || !TryComp<PhysicsComponent>(targetUid, out var targetPhysics)
            || performerPhysics.Mass == 0
            || targetPhysics.InvMass == 0)
            return 1f;

        return performerPhysics.Mass * targetPhysics.InvMass;
    }
}
