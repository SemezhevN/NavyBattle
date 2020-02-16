﻿using NavyBattle.Dal.Contexts;
using NavyBattleModels.Interfaces;

namespace NavyBattle.Dal.Repositories
{
    /// <summary>
    /// Repository to work with game objects in db
    /// </summary>
    internal class UserRepository : BaseRepository<IUser>        
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">db context</param>
        public UserRepository(NavyBattleContext context) : base(context)
        {
        }

        #endregion
    }
}
