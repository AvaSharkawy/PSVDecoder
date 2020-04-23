﻿using System.Collections.Generic;

namespace Decoder.Models
{
    public class Clip
    {
        public string ClipName { get; set; }
        public string ClipTitle { get; set; }
        public int ClipId { get; set; }
        public int ClipIndex { get; set; }
        public List<ClipTranscript> Subtitle { get; set; }

        public Clip()
        {
            Subtitle = new List<ClipTranscript>();
        }
    }
}