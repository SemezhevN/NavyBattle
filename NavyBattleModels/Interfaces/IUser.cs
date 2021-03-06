﻿using NavyBattleModels.Enums;
using NavyBattleModels.Models;
using System;
using System.Collections.Generic;


namespace NavyBattleModels.Interfaces
{
    /// <summary>
    /// Interface for the user
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// User id
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Battlefields which are attcached to the games
        /// </summary>
        IEnumerable<GameBattleField> GameBattleFields { get; set; }

        /// <summary>
        /// Battlefields that was created by this user
        /// </summary>
        IEnumerable<BaseBattleField> BattleFields { get; set; }

        /// <summary>
        /// Battlefields that was created by this user
        /// </summary>
        IEnumerable<Game> Games { get; set; }
    }
}
