﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyJamCore.DAL.Entities
{
    public class BattlePreliminaryEntity : IEntity
    {
        [Key]
        public int ID { get; set; }
        public DateTime ScheduledTime { get; set; }
        public DateTime StartTime { get; set; }
        public virtual IEnumerable<BattleRoundEntity> BattleRound { get; set; }
        public virtual IEnumerable<BattleParticipantEntity> Participants { get; set; }

    }
}