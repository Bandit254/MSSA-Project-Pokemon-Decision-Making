using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSSA_CAD_Project_Lugias_Lair.Models;

namespace MSSA_CAD_Project_Lugias_Lair.Models.ViewModels
{
    public class TeamBaseAnalysisViewModel
    {
        public TeamBase TeamBase { get; set; }
        public int[] TeamStatAverages { get; set; }
        public double[] TeamTypeAnalysis { get; set; }
    }
}
