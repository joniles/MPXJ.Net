﻿namespace MPXJ.Net
{
    public class AstaBaselineStrategy : IBaselineStrategy
    {
        public static readonly AstaBaselineStrategy Instance = new AstaBaselineStrategy();

        private AstaBaselineStrategy() { }

        public org.mpxj.BaselineStrategy JavaObject => org.mpxj.asta.AstaBaselineStrategy.INSTANCE;

        public void ClearBaseline(ProjectFile project, int index)
        {
            JavaObject.clearBaseline(project.JavaObject, index);
        }

        public void PopulateBaseline(ProjectFile project, ProjectFile baseline, int index)
        {
            JavaObject.populateBaseline(project.JavaObject, baseline.JavaObject, index);
        }
    }
}
