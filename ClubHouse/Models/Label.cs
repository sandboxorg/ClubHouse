﻿using ClubHouse.Serialization;
using System;

namespace ClubHouse.Models
{
    public class Label : ClubHouseModel<int>
    {
        [HideFromUpdate, HideFromCreate]
        public DateTime CreatedAt { get; set; }
        [HideFromUpdate, HideFromCreate]
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }

    }

    public class LabelWithCounts : Label
    {
        [HideFromUpdate, HideFromCreate]
        public int NumStoriesInProgress { get; set; }
        [HideFromUpdate, HideFromCreate]
        public int NumStoriesTotal { get; set; }
        [HideFromUpdate, HideFromCreate]
        public int NumStoriesCompleted { get; set; }
    }

}
