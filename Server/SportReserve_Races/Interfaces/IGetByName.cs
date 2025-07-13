﻿using SportReserve_Shared.Models.Workout;

namespace SportReserve_Races.Interfaces
{
    public interface IGetByName
    {
        Task<GetRaceDto> GetByName(string name);
    }
}
