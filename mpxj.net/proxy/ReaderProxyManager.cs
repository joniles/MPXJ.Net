﻿using System;

namespace MPXJ.Net.Proxy
{
    internal class ReaderProxyManager : AbstractProxyManager
    {
        internal AstaFileReader ProxyObject(net.sf.mpxj.asta.AstaFileReader value)
        {
            return ProxyObject(value, v => new AstaFileReader(v));
        }

        internal ConceptDrawProjectReader ProxyObject(net.sf.mpxj.conceptdraw.ConceptDrawProjectReader value)
        {
            return ProxyObject(value, v => new ConceptDrawProjectReader(v));
        }

        internal FastTrackReader ProxyObject(net.sf.mpxj.fasttrack.FastTrackReader value)
        {
            return ProxyObject(value, v => new FastTrackReader(v));
        }

        internal GanttDesignerReader ProxyObject(net.sf.mpxj.ganttdesigner.GanttDesignerReader value)
        {
            return ProxyObject(value, v => new GanttDesignerReader(v));
        }

        internal GanttProjectReader ProxyObject(net.sf.mpxj.ganttproject.GanttProjectReader value)
        {
            return ProxyObject(value, v => new GanttProjectReader(v));
        }

        internal MerlinReader ProxyObject(net.sf.mpxj.merlin.MerlinReader value)
        {
            return ProxyObject(value, v => new MerlinReader(v));
        }

        internal MPDFileReader ProxyObject(net.sf.mpxj.mpd.MPDFileReader value)
        {
            return ProxyObject(value, v => new MPDFileReader(v));
        }

        internal MPPReader ProxyObject(net.sf.mpxj.mpp.MPPReader value)
        {
            return ProxyObject(value, v => new MPPReader(v));
        }

        internal MPXReader ProxyObject(net.sf.mpxj.mpx.MPXReader value)
        {
            return ProxyObject(value, v => new MPXReader(v));
        }

        internal MSPDIReader ProxyObject(net.sf.mpxj.mspdi.MSPDIReader value)
        {
            return ProxyObject(value, v => new MSPDIReader(v));
        }

        internal OpenPlanReader ProxyObject(net.sf.mpxj.openplan.OpenPlanReader value)
        {
            return ProxyObject(value, v => new OpenPlanReader(v));
        }

        internal P3DatabaseReader ProxyObject(net.sf.mpxj.primavera.p3.P3DatabaseReader value)
        {
            return ProxyObject(value, v => new P3DatabaseReader(v));
        }

        internal P3PRXFileReader ProxyObject(net.sf.mpxj.primavera.p3.P3PRXFileReader value)
        {
            return ProxyObject(value, v => new P3PRXFileReader(v));
        }

        internal PhoenixReader ProxyObject(net.sf.mpxj.phoenix.PhoenixReader value)
        {
            return ProxyObject(value, v => new PhoenixReader(v));
        }

        internal PlannerReader ProxyObject(net.sf.mpxj.planner.PlannerReader value)
        {
            return ProxyObject(value, v => new PlannerReader(v));
        }

        internal PrimaveraDatabaseFileReader ProxyObject(net.sf.mpxj.primavera.PrimaveraDatabaseFileReader value)
        {
            return ProxyObject(value, v => new PrimaveraDatabaseFileReader(v));
        }

        internal PrimaveraPMFileReader ProxyObject(net.sf.mpxj.primavera.PrimaveraPMFileReader value)
        {
            return ProxyObject(value, v => new PrimaveraPMFileReader(v));
        }

        internal PrimaveraXERFileReader ProxyObject(net.sf.mpxj.primavera.PrimaveraXERFileReader value)
        {
            return ProxyObject(value, v => new PrimaveraXERFileReader(v));
        }

        internal ProjectCommanderReader ProxyObject(net.sf.mpxj.projectcommander.ProjectCommanderReader value)
        {
            return ProxyObject(value, v => new ProjectCommanderReader(v));
        }

        internal ProjectLibreReader ProxyObject(net.sf.mpxj.projectlibre.ProjectLibreReader value)
        {
            return ProxyObject(value, v => new ProjectLibreReader(v));
        }

        internal SageReader ProxyObject(net.sf.mpxj.sage.SageReader value)
        {
            return ProxyObject(value, v => new SageReader(v));
        }

        internal SDEFReader ProxyObject(net.sf.mpxj.sdef.SDEFReader value)
        {
            return ProxyObject(value, v => new SDEFReader(v));
        }

        internal SureTrakDatabaseReader ProxyObject(net.sf.mpxj.primavera.suretrak.SureTrakDatabaseReader value)
        {
            return ProxyObject(value, v => new SureTrakDatabaseReader(v));
        }

        internal SureTrakSTXFileReader ProxyObject(net.sf.mpxj.primavera.suretrak.SureTrakSTXFileReader value)
        {
            return ProxyObject(value, v => new SureTrakSTXFileReader(v));
        }

        internal SynchroReader ProxyObject(net.sf.mpxj.synchro.SynchroReader value)
        {
            return ProxyObject(value, v => new SynchroReader(v));
        }

        internal TurboProjectReader ProxyObject(net.sf.mpxj.turboproject.TurboProjectReader value)
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
                case "net.sf.mpxj.asta.AstaFileReader":
                    return ProxyObject((net.sf.mpxj.asta.AstaFileReader)o);

                case "net.sf.mpxj.conceptdraw.ConceptDrawProjectReader":
                    return ProxyObject((net.sf.mpxj.conceptdraw.ConceptDrawProjectReader)o);

                case "net.sf.mpxj.ganttdesigner.GanttDesignerReader":
                    return ProxyObject((net.sf.mpxj.ganttdesigner.GanttDesignerReader)o);

                case "net.sf.mpxj.ganttproject.GanttProjectReader":
                    return ProxyObject((net.sf.mpxj.ganttproject.GanttProjectReader)o);

                case "net.sf.mpxj.merlin.MerlinReader":
                    return ProxyObject((net.sf.mpxj.merlin.MerlinReader)o);

                case "net.sf.mpxj.mpd.MPDFileReader":
                    return ProxyObject((net.sf.mpxj.mpd.MPDFileReader)o);

                case "net.sf.mpxj.mpp.MPPReader":
                    return ProxyObject((net.sf.mpxj.mpp.MPPReader)o);

                case "net.sf.mpxj.mpx.MPXReader":
                    return ProxyObject((net.sf.mpxj.mpx.MPXReader)o);

                case "net.sf.mpxj.mspdi.MSPDIReader":
                    return ProxyObject((net.sf.mpxj.mspdi.MSPDIReader)o);

                case "net.sf.mpxj.openplan.OpenPlanReader":
                    return ProxyObject((net.sf.mpxj.openplan.OpenPlanReader)o);

                case "net.sf.mpxj.primavera.p3.P3DatabaseReader":
                    return ProxyObject((net.sf.mpxj.primavera.p3.P3DatabaseReader)o);

                case "net.sf.mpxj.primavera.p3.P3PRXFileReader":
                    return ProxyObject((net.sf.mpxj.primavera.p3.P3PRXFileReader)o);

                case "net.sf.mpxj.phoenix.PhoenixReader":
                    return ProxyObject((net.sf.mpxj.phoenix.PhoenixReader)o);

                case "net.sf.mpxj.planner.PlannerReader":
                    return ProxyObject((net.sf.mpxj.planner.PlannerReader)o);

                case "net.sf.mpxj.primavera.PrimaveraDatabaseFileReader":
                    return ProxyObject((net.sf.mpxj.primavera.PrimaveraDatabaseFileReader)o);

                case "net.sf.mpxj.primavera.PrimaveraPMFileReader":
                    return ProxyObject((net.sf.mpxj.primavera.PrimaveraPMFileReader)o);

                case "net.sf.mpxj.primavera.PrimaveraXERFileReader":
                    return ProxyObject((net.sf.mpxj.primavera.PrimaveraXERFileReader)o);

                case "net.sf.mpxj.projectcommander.ProjectCommanderReader":
                    return ProxyObject((net.sf.mpxj.projectcommander.ProjectCommanderReader)o);

                case "net.sf.mpxj.projectlibre.ProjectLibreReader":
                    return ProxyObject((net.sf.mpxj.projectlibre.ProjectLibreReader)o);

                case "net.sf.mpxj.sage.SageReader":
                    return ProxyObject((net.sf.mpxj.sage.SageReader)o);

                case "net.sf.mpxj.sdef.SDEFReader":
                    return ProxyObject((net.sf.mpxj.sdef.SDEFReader)o);

                case "net.sf.mpxj.primavera.suretrak.SureTrakDatabaseReader":
                    return ProxyObject((net.sf.mpxj.primavera.suretrak.SureTrakDatabaseReader)o);

                case "net.sf.mpxj.primavera.suretrak.SureTrakSTXFileReader":
                    return ProxyObject((net.sf.mpxj.primavera.suretrak.SureTrakSTXFileReader)o);

                case "net.sf.mpxj.synchro.SynchroReader":
                    return ProxyObject((net.sf.mpxj.synchro.SynchroReader)o);

                case "net.sf.mpxj.turboproject.TurboProjectReader":
                    return ProxyObject((net.sf.mpxj.turboproject.TurboProjectReader)o);

            }

            throw new NotSupportedException();
        }
    }
}
