using System;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class ResourceAssignment : AbstractFieldContainer, IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.ResourceAssignment>
    {
        public new net.sf.mpxj.ResourceAssignment JavaObject { get => (net.sf.mpxj.ResourceAssignment)base.JavaObject; }

        internal ResourceAssignment(ProxyManager proxyManager, net.sf.mpxj.ResourceAssignment javaObject) : base(proxyManager, javaObject) { }

        public ResourceAssignmentWorkgroupFields AddWorkgroupAssignment()
        {
            return _proxyManager.ProxyObject(JavaObject.addWorkgroupAssignment());
        }

        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
            set => JavaObject.setUniqueID(value);
        }

        public java.lang.Number Units
        {
            get => JavaObject.getUnits();
            set => JavaObject.setUnits(value);
        }

        public net.sf.mpxj.Duration Work
        {
            get => JavaObject.getWork();
            set => JavaObject.setWork(value);
        }

        public java.time.LocalDateTime BaselineStart
        {
            get => JavaObject.getBaselineStart();
            set => JavaObject.setBaselineStart(value);
        }

        public java.time.LocalDateTime ActualStart
        {
            get => JavaObject.getActualStart();
            set => JavaObject.setActualStart(value);
        }

        public java.time.LocalDateTime BaselineFinish
        {
            get => JavaObject.getBaselineFinish();
            set => JavaObject.setBaselineFinish(value);
        }

        public java.time.LocalDateTime ActualFinish
        {
            get => JavaObject.getActualFinish();
            set => JavaObject.setActualFinish(value);
        }

        public net.sf.mpxj.Duration BaselineWork
        {
            get => JavaObject.getBaselineWork();
            set => JavaObject.setBaselineWork(value);
        }

        public net.sf.mpxj.Duration ActualWork
        {
            get => JavaObject.getActualWork();
            set => JavaObject.setActualWork(value);
        }

        public net.sf.mpxj.Duration OvertimeWork
        {
            get => JavaObject.getOvertimeWork();
            set => JavaObject.setOvertimeWork(value);
        }

        public java.lang.Number Cost
        {
            get => JavaObject.getCost();
            set => JavaObject.setCost(value);
        }

        public java.lang.Number BaselineCost
        {
            get => JavaObject.getBaselineCost();
            set => JavaObject.setBaselineCost(value);
        }

        public java.lang.Number ActualCost
        {
            get => JavaObject.getActualCost();
            set => JavaObject.setActualCost(value);
        }

        public java.time.LocalDateTime Start
        {
            get => JavaObject.getStart();
            set => JavaObject.setStart(value);
        }

        public java.time.LocalDateTime Finish
        {
            get => JavaObject.getFinish();
            set => JavaObject.setFinish(value);
        }

        public net.sf.mpxj.Duration Delay
        {
            get => JavaObject.getDelay();
            set => JavaObject.setDelay(value);
        }

        public java.lang.Integer ResourceUniqueID
        {
            get => JavaObject.getResourceUniqueID();
            set => JavaObject.setResourceUniqueID(value);
        }

        public ResourceAssignmentWorkgroupFields WorkgroupAssignment
        {
            get => _proxyManager.ProxyObject(JavaObject.getWorkgroupAssignment());
        }

        public Task Task
        {
            get => _proxyManager.ProxyObject(JavaObject.getTask());
        }

        public Resource Resource
        {
            get => _proxyManager.ProxyObject(JavaObject.getResource());
        }

        public WorkContour WorkContour
        {
            get => _proxyManager.ProxyObject(JavaObject.getWorkContour());
            set => JavaObject.setWorkContour(value.JavaObject);
        }

        public void Remove()
        {
            JavaObject.remove();
        }

        public net.sf.mpxj.Duration RemainingWork
        {
            get => JavaObject.getRemainingWork();
            set => JavaObject.setRemainingWork(value);
        }

        public net.sf.mpxj.Duration LevelingDelay
        {
            get => JavaObject.getLevelingDelay();
            set => JavaObject.setLevelingDelay(value);
        }

        public java.lang.Integer RateIndex
        {
            get => JavaObject.getRateIndex();
            set => JavaObject.setRateIndex(value);
        }

        public java.lang.Integer RoleUniqueID
        {
            get => JavaObject.getRoleUniqueID();
            set => JavaObject.setRoleUniqueID(value);
        }

        public Resource Role
        {
            get => _proxyManager.ProxyObject(JavaObject.getRole());
            set => JavaObject.setRole(value.JavaObject);
        }

        public net.sf.mpxj.Rate OverrideRate
        {
            get => JavaObject.getOverrideRate();
            set => JavaObject.setOverrideRate(value);
        }

        public net.sf.mpxj.RateSource RateSource
        {
            get => JavaObject.getRateSource();
            set => JavaObject.setRateSource(value);
        }

        public java.util.List TimephasedActualWork
        {
            get => JavaObject.getTimephasedActualWork();
        }

        public java.util.List TimephasedWork
        {
            get => JavaObject.getTimephasedWork();
        }

        public java.util.List TimephasedOvertimeWork
        {
            get => JavaObject.getTimephasedOvertimeWork();
        }

        public java.util.List TimephasedActualOvertimeWork
        {
            get => JavaObject.getTimephasedActualOvertimeWork();
        }

        public java.util.List TimephasedCost
        {
            get => JavaObject.getTimephasedCost();
        }

        public java.util.List TimephasedActualCost
        {
            get => JavaObject.getTimephasedActualCost();
        }

        public bool HasTimephasedData
        {
            get => JavaObject.getHasTimephasedData();
        }

        public void SetTimephasedBaselineWork(int index, net.sf.mpxj.TimephasedWorkContainer data)
        {
            JavaObject.setTimephasedBaselineWork(index, data);
        }

        public void SetTimephasedBaselineCost(int index, net.sf.mpxj.TimephasedCostContainer data)
        {
            JavaObject.setTimephasedBaselineCost(index, data);
        }

        public java.util.List GetTimephasedBaselineWork(int index)
        {
            return JavaObject.getTimephasedBaselineWork(index);
        }

        public java.util.List GetTimephasedBaselineCost(int index)
        {
            return JavaObject.getTimephasedBaselineCost(index);
        }

        public ProjectCalendar Calendar
        {
            get => _proxyManager.ProxyObject(JavaObject.getCalendar());
        }

        public TimeUnit? VariableRateUnits
        {
            get => JavaObject.getVariableRateUnits().ConvertType();
            set => JavaObject.setVariableRateUnits(value.ConvertType());
        }

        public java.lang.Integer TaskUniqueID
        {
            get => JavaObject.getTaskUniqueID();
            set => JavaObject.setTaskUniqueID(value);
        }

        public java.lang.Number BudgetCost
        {
            get => JavaObject.getBudgetCost();
            set => JavaObject.setBudgetCost(value);
        }

        public net.sf.mpxj.Duration BudgetWork
        {
            get => JavaObject.getBudgetWork();
            set => JavaObject.setBudgetWork(value);
        }

        public java.lang.Number BaselineBudgetCost
        {
            get => JavaObject.getBaselineBudgetCost();
            set => JavaObject.setBaselineBudgetCost(value);
        }

        public net.sf.mpxj.Duration BaselineBudgetWork
        {
            get => JavaObject.getBaselineBudgetWork();
            set => JavaObject.setBaselineBudgetWork(value);
        }

        public void SetBaselineCost(int baselineNumber, java.lang.Number value)
        {
            JavaObject.setBaselineCost(baselineNumber, value);
        }

        public void SetBaselineWork(int baselineNumber, net.sf.mpxj.Duration value)
        {
            JavaObject.setBaselineWork(baselineNumber, value);
        }

        public net.sf.mpxj.Duration GetBaselineWork(int baselineNumber)
        {
            return JavaObject.getBaselineWork(baselineNumber);
        }

        public java.lang.Number GetBaselineCost(int baselineNumber)
        {
            return JavaObject.getBaselineCost(baselineNumber);
        }

        public void SetBaselineStart(int baselineNumber, java.time.LocalDateTime value)
        {
            JavaObject.setBaselineStart(baselineNumber, value);
        }

        public java.time.LocalDateTime GetBaselineStart(int baselineNumber)
        {
            return JavaObject.getBaselineStart(baselineNumber);
        }

        public void SetBaselineFinish(int baselineNumber, java.time.LocalDateTime value)
        {
            JavaObject.setBaselineFinish(baselineNumber, value);
        }

        public java.time.LocalDateTime GetBaselineFinish(int baselineNumber)
        {
            return JavaObject.getBaselineFinish(baselineNumber);
        }

        public void SetBaselineBudgetCost(int baselineNumber, java.lang.Number value)
        {
            JavaObject.setBaselineBudgetCost(baselineNumber, value);
        }

        public void SetBaselineBudgetWork(int baselineNumber, net.sf.mpxj.Duration value)
        {
            JavaObject.setBaselineBudgetWork(baselineNumber, value);
        }

        public net.sf.mpxj.Duration GetBaselineBudgetWork(int baselineNumber)
        {
            return JavaObject.getBaselineBudgetWork(baselineNumber);
        }

        public java.lang.Number GetBaselineBudgetCost(int baselineNumber)
        {
            return JavaObject.getBaselineBudgetCost(baselineNumber);
        }

        public void SetText(int index, string value)
        {
            JavaObject.setText(index, value);
        }

        public string GetText(int index)
        {
            return JavaObject.getText(index);
        }

        public void SetStart(int index, java.time.LocalDateTime value)
        {
            JavaObject.setStart(index, value);
        }

        public java.time.LocalDateTime GetStart(int index)
        {
            return JavaObject.getStart(index);
        }

        public void SetFinish(int index, java.time.LocalDateTime value)
        {
            JavaObject.setFinish(index, value);
        }

        public java.time.LocalDateTime GetFinish(int index)
        {
            return JavaObject.getFinish(index);
        }

        public void SetDate(int index, java.time.LocalDateTime value)
        {
            JavaObject.setDate(index, value);
        }

        public java.time.LocalDateTime GetDate(int index)
        {
            return JavaObject.getDate(index);
        }

        public void SetNumber(int index, java.lang.Number value)
        {
            JavaObject.setNumber(index, value);
        }

        public java.lang.Number GetNumber(int index)
        {
            return JavaObject.getNumber(index);
        }

        public void SetDuration(int index, net.sf.mpxj.Duration value)
        {
            JavaObject.setDuration(index, value);
        }

        public net.sf.mpxj.Duration GetDuration(int index)
        {
            return JavaObject.getDuration(index);
        }

        public void SetCost(int index, java.lang.Number value)
        {
            JavaObject.setCost(index, value);
        }

        public java.lang.Number GetCost(int index)
        {
            return JavaObject.getCost(index);
        }

        public void SetFlag(int index, bool value)
        {
            JavaObject.setFlag(index, value);
        }

        public bool GetFlag(int index)
        {
            return JavaObject.getFlag(index);
        }

        public void SetEnterpriseCost(int index, java.lang.Number value)
        {
            JavaObject.setEnterpriseCost(index, value);
        }

        public java.lang.Number GetEnterpriseCost(int index)
        {
            return JavaObject.getEnterpriseCost(index);
        }

        public void SetEnterpriseDate(int index, java.time.LocalDateTime value)
        {
            JavaObject.setEnterpriseDate(index, value);
        }

        public java.time.LocalDateTime GetEnterpriseDate(int index)
        {
            return JavaObject.getEnterpriseDate(index);
        }

        public void SetEnterpriseDuration(int index, net.sf.mpxj.Duration value)
        {
            JavaObject.setEnterpriseDuration(index, value);
        }

        public net.sf.mpxj.Duration GetEnterpriseDuration(int index)
        {
            return JavaObject.getEnterpriseDuration(index);
        }

        public void SetEnterpriseFlag(int index, bool value)
        {
            JavaObject.setEnterpriseFlag(index, value);
        }

        public bool GetEnterpriseFlag(int index)
        {
            return JavaObject.getEnterpriseFlag(index);
        }

        public void SetEnterpriseNumber(int index, java.lang.Number value)
        {
            JavaObject.setEnterpriseNumber(index, value);
        }

        public java.lang.Number GetEnterpriseNumber(int index)
        {
            return JavaObject.getEnterpriseNumber(index);
        }

        public void SetEnterpriseText(int index, string value)
        {
            JavaObject.setEnterpriseText(index, value);
        }

        public string GetEnterpriseText(int index)
        {
            return JavaObject.getEnterpriseText(index);
        }

        public net.sf.mpxj.Duration RegularWork
        {
            get => JavaObject.getRegularWork();
            set => JavaObject.setRegularWork(value);
        }

        public net.sf.mpxj.Duration ActualOvertimeWork
        {
            get => JavaObject.getActualOvertimeWork();
            set => JavaObject.setActualOvertimeWork(value);
        }

        public net.sf.mpxj.Duration RemainingOvertimeWork
        {
            get => JavaObject.getRemainingOvertimeWork();
            set => JavaObject.setRemainingOvertimeWork(value);
        }

        public java.lang.Number OvertimeCost
        {
            get => JavaObject.getOvertimeCost();
            set => JavaObject.setOvertimeCost(value);
        }

        public java.lang.Number RemainingCost
        {
            get => JavaObject.getRemainingCost();
            set => JavaObject.setRemainingCost(value);
        }

        public java.lang.Number ActualOvertimeCost
        {
            get => JavaObject.getActualOvertimeCost();
            set => JavaObject.setActualOvertimeCost(value);
        }

        public java.lang.Number RemainingOvertimeCost
        {
            get => JavaObject.getRemainingOvertimeCost();
            set => JavaObject.setRemainingOvertimeCost(value);
        }

        public java.lang.Number BCWP
        {
            get => JavaObject.getBCWP();
            set => JavaObject.setBCWP(value);
        }

        public java.lang.Number BCWS
        {
            get => JavaObject.getBCWS();
            set => JavaObject.setBCWS(value);
        }

        public java.lang.Number ACWP
        {
            get => JavaObject.getACWP();
            set => JavaObject.setACWP(value);
        }

        public java.lang.Number SV
        {
            get => JavaObject.getSV();
            set => JavaObject.setSV(value);
        }

        public java.lang.Number CV
        {
            get => JavaObject.getCV();
            set => JavaObject.setCV(value);
        }

        public java.lang.Number CostVariance
        {
            get => JavaObject.getCostVariance();
            set => JavaObject.setCostVariance(value);
        }

        public java.lang.Number PercentageWorkComplete
        {
            get => JavaObject.getPercentageWorkComplete();
            set => JavaObject.setPercentageWorkComplete(value);
        }

        public string Notes
        {
            get => JavaObject.getNotes();
            set => JavaObject.setNotes(value);
        }

        public Notes NotesObject
        {
            get => _proxyManager.ProxyObject(JavaObject.getNotesObject());
            set => JavaObject.setNotesObject(value.JavaObject);
        }

        public bool Confirmed
        {
            get => JavaObject.getConfirmed();
            set => JavaObject.setConfirmed(value);
        }

        public bool UpdateNeeded
        {
            get => JavaObject.getUpdateNeeded();
            set => JavaObject.setUpdateNeeded(value);
        }

        public bool LinkedFields
        {
            get => JavaObject.getLinkedFields();
            set => JavaObject.setLinkedFields(value);
        }

        public string Hyperlink
        {
            get => JavaObject.getHyperlink();
            set => JavaObject.setHyperlink(value);
        }

        public string HyperlinkAddress
        {
            get => JavaObject.getHyperlinkAddress();
            set => JavaObject.setHyperlinkAddress(value);
        }

        public string HyperlinkSubAddress
        {
            get => JavaObject.getHyperlinkSubAddress();
            set => JavaObject.setHyperlinkSubAddress(value);
        }

        public net.sf.mpxj.Duration WorkVariance
        {
            get => JavaObject.getWorkVariance();
            set => JavaObject.setWorkVariance(value);
        }

        public net.sf.mpxj.Duration StartVariance
        {
            get => JavaObject.getStartVariance();
            set => JavaObject.setStartVariance(value);
        }

        public net.sf.mpxj.Duration FinishVariance
        {
            get => JavaObject.getFinishVariance();
            set => JavaObject.setFinishVariance(value);
        }

        public java.time.LocalDateTime CreateDate
        {
            get => JavaObject.getCreateDate();
            set => JavaObject.setCreateDate(value);
        }

        public Guid? GUID
        {
            get => JavaObject.getGUID().ConvertType();
            set => JavaObject.setGUID(value.ConvertType());
        }

        public bool ResponsePending
        {
            get => JavaObject.getResponsePending();
            set => JavaObject.setResponsePending(value);
        }

        public bool TeamStatusPending
        {
            get => JavaObject.getTeamStatusPending();
            set => JavaObject.setTeamStatusPending(value);
        }

        public java.lang.Number VAC
        {
            get => JavaObject.getVAC();
            set => JavaObject.setVAC(value);
        }

        public int CostRateTableIndex
        {
            get => JavaObject.getCostRateTableIndex();
            set => JavaObject.setCostRateTableIndex(value);
        }

        public CostRateTable CostRateTable
        {
            get => _proxyManager.ProxyObject(JavaObject.getCostRateTable());
        }

        public string HyperlinkScreenTip
        {
            get => JavaObject.getHyperlinkScreenTip();
            set => JavaObject.setHyperlinkScreenTip(value);
        }

        public net.sf.mpxj.ResourceRequestType ResourceRequestType
        {
            get => JavaObject.getResourceRequestType();
            set => JavaObject.setResourceRequestType(value);
        }

        public java.time.LocalDateTime Stop
        {
            get => JavaObject.getStop();
            set => JavaObject.setStop(value);
        }

        public java.time.LocalDateTime Resume
        {
            get => JavaObject.getResume();
            set => JavaObject.setResume(value);
        }

        public net.sf.mpxj.Duration PlannedWork
        {
            get => JavaObject.getPlannedWork();
            set => JavaObject.setPlannedWork(value);
        }

        public java.lang.Number PlannedCost
        {
            get => JavaObject.getPlannedCost();
            set => JavaObject.setPlannedCost(value);
        }

        public java.time.LocalDateTime PlannedStart
        {
            get => JavaObject.getPlannedStart();
            set => JavaObject.setPlannedStart(value);
        }

        public java.time.LocalDateTime PlannedFinish
        {
            get => JavaObject.getPlannedFinish();
            set => JavaObject.setPlannedFinish(value);
        }

        public bool CalculateCostsFromUnits
        {
            get => JavaObject.getCalculateCostsFromUnits();
            set => JavaObject.setCalculateCostsFromUnits(value);
        }

        public java.lang.Integer CostAccountUniqueID
        {
            get => JavaObject.getCostAccountUniqueID();
            set => JavaObject.setCostAccountUniqueID(value);
        }

        public CostAccount CostAccount
        {
            get => _proxyManager.ProxyObject(JavaObject.getCostAccount());
            set => JavaObject.setCostAccount(value.JavaObject);
        }

        public net.sf.mpxj.Rate GetEffectiveRate(java.time.LocalDateTime date)
        {
            return JavaObject.getEffectiveRate(date);
        }

        public object GetFieldByAlias(string alias)
        {
            // TODO: proxy
            return JavaObject.getFieldByAlias(alias);
        }

        public void SetFieldByAlias(string alias, object value)
        {
            // TODO: proxy
            JavaObject.setFieldByAlias(alias, value);
        }

        public override string ToString()
        {
            return JavaObject.toString();
        }
    }
}

