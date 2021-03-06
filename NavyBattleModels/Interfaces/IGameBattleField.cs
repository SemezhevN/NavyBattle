﻿using NavyBattleModels.Models;
using System;
using System.Collections.Generic;


namespace NavyBattleModels.Interfaces
{
    /// <summary>
    /// Interface for the game battlefield
    /// </summary>
    public interface IGameBattleField
    {
        /// <summary>
        /// Game battlefield id
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Battlefield on which the game will take place
        /// </summary>
        BaseBattleField BattleField { get; set; }

        /// <summary>
        /// Id of the battlefield
        /// </summary>
        int? BattleFieldId { get; set; }

        /// <summary>
        /// Game which this battlefield is added to
        /// </summary>
        Game Game { get; set; }

        /// <summary>
        /// Id of the game which this battlefield is added to
        /// </summary>
        int? GameId { get; set; }

        /// <summary>
        /// Player owner of this battlefield
        /// </summary>
        User Owner { get; set; }

        /// <summary>
        /// Id of the player owner of this battlefield
        /// </summary>
        int? OwnerId { get; set; }

        /// <summary>
        /// BattleShips in the game
        /// </summary>
        IEnumerable<GameBattleShip> GameBattleShips { get; set; }

        /// <summary>
        /// Shots that were made during the game                                                                                                                                                                                                                                                                                                                     
        /// </summary>
        IEnumerable<Shot> Shots { get; set; }

        /// <summary>
        /// Flag to indicate that battlefield is ready to play
        /// </summary>
        bool IsWaiting { get; set; }
        
    }
}
