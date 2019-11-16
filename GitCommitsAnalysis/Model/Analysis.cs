﻿using System;
using System.Collections.Generic;

namespace GitCommitsAnalysis.Model
{
    public class Analysis
    {
        public DateTime CreatedDate { get; } = DateTime.UtcNow;
        public DateTime FirstCommitDate { get; set; } = DateTime.MaxValue;
        public DateTime LatestCommitDate { get; set; } = DateTime.MinValue;
        public long AnalysisTime { get; set; }
        public long LinesOfCodeAnalysed { get; set; } = 0;
        public Dictionary<DateTime, int> CommitsEachDay { get; } = new Dictionary<DateTime, int>();
        public Dictionary<DateTime, int> LinesOfCodeAddedEachDay { get; } = new Dictionary<DateTime, int>();
        public Dictionary<DateTime, int> LinesOfCodeDeletedEachDay { get; } = new Dictionary<DateTime, int>();
        public Dictionary<string, FileStat> FileCommits { get; } = new Dictionary<string, FileStat>();
        public Dictionary<string, FolderStat> FolderCommits { get; } = new Dictionary<string, FolderStat>();
        public Dictionary<string, FileStat> UserfileCommits { get; } = new Dictionary<string, FileStat>();
        public Dictionary<string, int> FileTypes { get; } = new Dictionary<string, int>();
    }
}
