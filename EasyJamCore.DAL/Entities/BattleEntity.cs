﻿namespace EasyJamCore.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Battle")]
    public class BattleEntity : IEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string BattleName { get; set; }

        public Common.Enums.Type Type { get; set; }

        public DateTime ScheduledTime { get; set; }

        public DateTime StartTime { get; set; }

        [Required]
        public string Location { get; set; }

        public BattlePreliminaryEntity BattlePreliminary { get; set; }

        public virtual IEnumerable<BattleParticipantEntity> BattleEntry { get; set; }

        public virtual IEnumerable<JudgeEntity> Judge { get; set; }

        public virtual IEnumerable<DjEntity> Dj { get; set; }

        public virtual IEnumerable<SpeakerEntity> Speaker { get; set; }

        public virtual IEnumerable<BattleRoundEntity> BattleRound { get; set; }
    }
}
