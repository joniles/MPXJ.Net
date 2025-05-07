using System;

namespace MPXJ.Net.Proxy
{
    internal class ReaderProxyManager : AbstractProxyManager
    {
        internal AstaFileReader ProxyObject(org.mpxj.asta.AstaFileReader value)
        {
            return ProxyObject(value, v => new AstaFileReader(v));
        }

        internal ConceptDrawProjectReader ProxyObject(org.mpxj.conceptdraw.ConceptDrawProjectReader value)
        {
            return ProxyObject(value, v => new ConceptDrawProjectReader(v));
        }

        internal FastTrackReader ProxyObject(org.mpxj.fasttrack.FastTrackReader value)
        {
            return ProxyObject(value, v => new FastTrackReader(v));
        }

        internal GanttDesignerReader ProxyObject(org.mpxj.ganttdesigner.GanttDesignerReader value)
        {
            return ProxyObject(value, v => new GanttDesignerReader(v));
        }

        internal GanttProjectReader ProxyObject(org.mpxj.ganttproject.GanttProjectReader value)
        {
            return ProxyObject(value, v => new GanttProjectReader(v));
        }

        internal MerlinReader ProxyObject(org.mpxj.merlin.MerlinReader value)
        {
            return ProxyObject(value, v => new MerlinReader(v));
        }

        internal MPDFileReader ProxyObject(org.mpxj.mpd.MPDFileReader value)
        {
            return ProxyObject(value, v => new MPDFileReader(v));
        }

        internal MPPReader ProxyObject(org.mpxj.mpp.MPPReader value)
        {
            return ProxyObject(value, v => new MPPReader(v));
        }

        internal MPXReader ProxyObject(org.mpxj.mpx.MPXReader value)
        {
            return ProxyObject(value, v => new MPXReader(v));
        }

        internal MSPDIReader ProxyObject(org.mpxj.mspdi.MSPDIReader value)
        {
            return ProxyObject(value, v => new MSPDIReader(v));
        }

        internal OpenPlanReader ProxyObject(org.mpxj.openplan.OpenPlanReader value)
        {
            return ProxyObject(value, v => new OpenPlanReader(v));
        }

        internal P3DatabaseReader ProxyObject(org.mpxj.primavera.p3.P3DatabaseReader value)
        {
            return ProxyObject(value, v => new P3DatabaseReader(v));
        }

        internal P3PRXFileReader ProxyObject(org.mpxj.primavera.p3.P3PRXFileReader value)
        {
            return ProxyObject(value, v => new P3PRXFileReader(v));
        }

        internal PhoenixReader ProxyObject(org.mpxj.phoenix.PhoenixReader value)
        {
            return ProxyObject(value, v => new PhoenixReader(v));
        }

        internal PlannerReader ProxyObject(org.mpxj.planner.PlannerReader value)
        {
            return ProxyObject(value, v => new PlannerReader(v));
        }

        internal PrimaveraDatabaseFileReader ProxyObject(org.mpxj.primavera.PrimaveraDatabaseFileReader value)
        {
            return ProxyObject(value, v => new PrimaveraDatabaseFileReader(v));
        }

        internal PrimaveraPMFileReader ProxyObject(org.mpxj.primavera.PrimaveraPMFileReader value)
        {
            return ProxyObject(value, v => new PrimaveraPMFileReader(v));
        }

        internal PrimaveraXERFileReader ProxyObject(org.mpxj.primavera.PrimaveraXERFileReader value)
        {
            return ProxyObject(value, v => new PrimaveraXERFileReader(v));
        }

        internal ProjectCommanderReader ProxyObject(org.mpxj.projectcommander.ProjectCommanderReader value)
        {
            return ProxyObject(value, v => new ProjectCommanderReader(v));
        }

        internal ProjectLibreReader ProxyObject(org.mpxj.projectlibre.ProjectLibreReader value)
        {
            return ProxyObject(value, v => new ProjectLibreReader(v));
        }

        internal SageReader ProxyObject(org.mpxj.sage.SageReader value)
        {
            return ProxyObject(value, v => new SageReader(v));
        }

        internal SDEFReader ProxyObject(org.mpxj.sdef.SDEFReader value)
        {
            return ProxyObject(value, v => new SDEFReader(v));
        }

        internal SureTrakDatabaseReader ProxyObject(org.mpxj.primavera.suretrak.SureTrakDatabaseReader value)
        {
            return ProxyObject(value, v => new SureTrakDatabaseReader(v));
        }

        internal SureTrakSTXFileReader ProxyObject(org.mpxj.primavera.suretrak.SureTrakSTXFileReader value)
        {
            return ProxyObject(value, v => new SureTrakSTXFileReader(v));
        }

        internal SynchroReader ProxyObject(org.mpxj.synchro.SynchroReader value)
        {
            return ProxyObject(value, v => new SynchroReader(v));
        }

        internal TurboProjectReader ProxyObject(org.mpxj.turboproject.TurboProjectReader value)
        {
            return ProxyObject(value, v => new TurboProjectReader(v));
        }

        internal object GenericProxyObject(object o)
        {
            if (o == null)
            {
                return null;
            }

            var key = o.GetType().FullName;
            switch (key)
            {
                case "org.mpxj.asta.AstaFileReader":
                    return ProxyObject((org.mpxj.asta.AstaFileReader)o);

                case "org.mpxj.conceptdraw.ConceptDrawProjectReader":
                    return ProxyObject((org.mpxj.conceptdraw.ConceptDrawProjectReader)o);

                case "org.mpxj.ganttdesigner.GanttDesignerReader":
                    return ProxyObject((org.mpxj.ganttdesigner.GanttDesignerReader)o);

                case "org.mpxj.ganttproject.GanttProjectReader":
                    return ProxyObject((org.mpxj.ganttproject.GanttProjectReader)o);

                case "org.mpxj.merlin.MerlinReader":
                    return ProxyObject((org.mpxj.merlin.MerlinReader)o);

                case "org.mpxj.mpd.MPDFileReader":
                    return ProxyObject((org.mpxj.mpd.MPDFileReader)o);

                case "org.mpxj.mpp.MPPReader":
                    return ProxyObject((org.mpxj.mpp.MPPReader)o);

                case "org.mpxj.mpx.MPXReader":
                    return ProxyObject((org.mpxj.mpx.MPXReader)o);

                case "org.mpxj.mspdi.MSPDIReader":
                    return ProxyObject((org.mpxj.mspdi.MSPDIReader)o);

                case "org.mpxj.openplan.OpenPlanReader":
                    return ProxyObject((org.mpxj.openplan.OpenPlanReader)o);

                case "org.mpxj.primavera.p3.P3DatabaseReader":
                    return ProxyObject((org.mpxj.primavera.p3.P3DatabaseReader)o);

                case "org.mpxj.primavera.p3.P3PRXFileReader":
                    return ProxyObject((org.mpxj.primavera.p3.P3PRXFileReader)o);

                case "org.mpxj.phoenix.PhoenixReader":
                    return ProxyObject((org.mpxj.phoenix.PhoenixReader)o);

                case "org.mpxj.planner.PlannerReader":
                    return ProxyObject((org.mpxj.planner.PlannerReader)o);

                case "org.mpxj.primavera.PrimaveraDatabaseFileReader":
                    return ProxyObject((org.mpxj.primavera.PrimaveraDatabaseFileReader)o);

                case "org.mpxj.primavera.PrimaveraPMFileReader":
                    return ProxyObject((org.mpxj.primavera.PrimaveraPMFileReader)o);

                case "org.mpxj.primavera.PrimaveraXERFileReader":
                    return ProxyObject((org.mpxj.primavera.PrimaveraXERFileReader)o);

                case "org.mpxj.projectcommander.ProjectCommanderReader":
                    return ProxyObject((org.mpxj.projectcommander.ProjectCommanderReader)o);

                case "org.mpxj.projectlibre.ProjectLibreReader":
                    return ProxyObject((org.mpxj.projectlibre.ProjectLibreReader)o);

                case "org.mpxj.sage.SageReader":
                    return ProxyObject((org.mpxj.sage.SageReader)o);

                case "org.mpxj.sdef.SDEFReader":
                    return ProxyObject((org.mpxj.sdef.SDEFReader)o);

                case "org.mpxj.primavera.suretrak.SureTrakDatabaseReader":
                    return ProxyObject((org.mpxj.primavera.suretrak.SureTrakDatabaseReader)o);

                case "org.mpxj.primavera.suretrak.SureTrakSTXFileReader":
                    return ProxyObject((org.mpxj.primavera.suretrak.SureTrakSTXFileReader)o);

                case "org.mpxj.synchro.SynchroReader":
                    return ProxyObject((org.mpxj.synchro.SynchroReader)o);

                case "org.mpxj.turboproject.TurboProjectReader":
                    return ProxyObject((org.mpxj.turboproject.TurboProjectReader)o);

            }

            throw new NotSupportedException();
        }
    }
}
