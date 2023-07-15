using System;
using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class ResourceAssignment : AbstractFieldContainer, IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.ResourceAssignment>
    {
        public new net.sf.mpxj.ResourceAssignment JavaObject => (net.sf.mpxj.ResourceAssignment)base.JavaObject;

        internal ResourceAssignment(ProxyManager proxyManager, net.sf.mpxj.ResourceAssignment javaObject) : base(proxyManager, javaObject) { }

        public ResourceAssignmentWorkgroupFields AddWorkgroupAssignment() => _proxyManager.ProxyObject(JavaObject.addWorkgroupAssignment());

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

        public Duration Work
        {
            get => _proxyManager.ProxyObject(JavaObject.getWork());
            set => JavaObject.setWork(value.JavaObject);
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

        public Duration BaselineWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getBaselineWork());
            set => JavaObject.setBaselineWork(value.JavaObject);
        }

        public Duration ActualWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualWork());
            set => JavaObject.setActualWork(value.JavaObject);
        }

        public Duration OvertimeWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getOvertimeWork());
            set => JavaObject.setOvertimeWork(value.JavaObject);
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

        public Duration Delay
        {
            get => _proxyManager.ProxyObject(JavaObject.getDelay());
            set => JavaObject.setDelay(value.JavaObject);
        }

        public java.lang.Integer ResourceUniqueID
        {
            get => JavaObject.getResourceUniqueID();
            set => JavaObject.setResourceUniqueID(value);
        }

        public ResourceAssignmentWorkgroupFields WorkgroupAssignment => _proxyManager.ProxyObject(JavaObject.getWorkgroupAssignment());

        public Task Task => _proxyManager.ProxyObject(JavaObject.getTask());

        public Resource Resource => _proxyManager.ProxyObject(JavaObject.getResource());

        public WorkContour WorkContour
        {
            get => _proxyManager.ProxyObject(JavaObject.getWorkContour());
            set => JavaObject.setWorkContour(value.JavaObject);
        }

        public void Remove() => JavaObject.remove();

        public Duration RemainingWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getRemainingWork());
            set => JavaObject.setRemainingWork(value.JavaObject);
        }

        public Duration LevelingDelay
        {
            get => _proxyManager.ProxyObject(JavaObject.getLevelingDelay());
            set => JavaObject.setLevelingDelay(value.JavaObject);
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

        public Rate OverrideRate
        {
            get => _proxyManager.ProxyObject(JavaObject.getOverrideRate());
            set => JavaObject.setOverrideRate(value.JavaObject);
        }

        public RateSource? RateSource
        {
            get => JavaObject.getRateSource().ConvertType();
            set => JavaObject.setRateSource(value.ConvertType());
        }

        public IList<TimephasedWork> TimephasedActualWork => _proxyManager.ProxyList<net.sf.mpxj.TimephasedWork, TimephasedWork>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getTimephasedActualWork());

        public IList<TimephasedWork> TimephasedWork => _proxyManager.ProxyList<net.sf.mpxj.TimephasedWork, TimephasedWork>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getTimephasedWork());

        public IList<TimephasedWork> TimephasedOvertimeWork => _proxyManager.ProxyList<net.sf.mpxj.TimephasedWork, TimephasedWork>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getTimephasedOvertimeWork());

        public IList<TimephasedWork> TimephasedActualOvertimeWork => _proxyManager.ProxyList<net.sf.mpxj.TimephasedWork, TimephasedWork>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getTimephasedActualOvertimeWork());

        public IList<TimephasedCost> TimephasedCost => _proxyManager.ProxyList<net.sf.mpxj.TimephasedCost, TimephasedCost>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getTimephasedCost());

        public IList<TimephasedCost> TimephasedActualCost => _proxyManager.ProxyList<net.sf.mpxj.TimephasedCost, TimephasedCost>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getTimephasedActualCost());

        public bool HasTimephasedData => JavaObject.getHasTimephasedData();

        // TODO: implement as required
        //public void SetTimephasedBaselineWork(int index, net.sf.mpxj.TimephasedWorkContainer data) => JavaObject.setTimephasedBaselineWork(index, data);

        // TODO: implement as required
        //public void SetTimephasedBaselineCost(int index, net.sf.mpxj.TimephasedCostContainer data) => JavaObject.setTimephasedBaselineCost(index, data);

        public IList<TimephasedWork> GetTimephasedBaselineWork(int index) => _proxyManager.ProxyList<net.sf.mpxj.TimephasedWork, TimephasedWork>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getTimephasedBaselineWork(index));

        public IList<TimephasedCost> GetTimephasedBaselineCost(int index) => _proxyManager.ProxyList<net.sf.mpxj.TimephasedCost, TimephasedCost>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getTimephasedBaselineCost(index));

        public ProjectCalendar Calendar => _proxyManager.ProxyObject(JavaObject.getCalendar());

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

        public Duration BudgetWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getBudgetWork());
            set => JavaObject.setBudgetWork(value.JavaObject);
        }

        public java.lang.Number BaselineBudgetCost
        {
            get => JavaObject.getBaselineBudgetCost();
            set => JavaObject.setBaselineBudgetCost(value);
        }

        public Duration BaselineBudgetWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getBaselineBudgetWork());
            set => JavaObject.setBaselineBudgetWork(value.JavaObject);
        }

        public void SetBaselineCost(int baselineNumber, java.lang.Number value) => JavaObject.setBaselineCost(baselineNumber, value);

        public void SetBaselineWork(int baselineNumber, Duration value) => JavaObject.setBaselineWork(baselineNumber, value.JavaObject);

        public Duration GetBaselineWork(int baselineNumber) => _proxyManager.ProxyObject(JavaObject.getBaselineWork(baselineNumber));

        public java.lang.Number GetBaselineCost(int baselineNumber) => JavaObject.getBaselineCost(baselineNumber);

        public void SetBaselineStart(int baselineNumber, java.time.LocalDateTime value) => JavaObject.setBaselineStart(baselineNumber, value);

        public java.time.LocalDateTime GetBaselineStart(int baselineNumber) => JavaObject.getBaselineStart(baselineNumber);

        public void SetBaselineFinish(int baselineNumber, java.time.LocalDateTime value) => JavaObject.setBaselineFinish(baselineNumber, value);

        public java.time.LocalDateTime GetBaselineFinish(int baselineNumber) => JavaObject.getBaselineFinish(baselineNumber);

        public void SetBaselineBudgetCost(int baselineNumber, java.lang.Number value) => JavaObject.setBaselineBudgetCost(baselineNumber, value);

        public void SetBaselineBudgetWork(int baselineNumber, Duration value) => JavaObject.setBaselineBudgetWork(baselineNumber, value.JavaObject);

        public Duration GetBaselineBudgetWork(int baselineNumber) => _proxyManager.ProxyObject(JavaObject.getBaselineBudgetWork(baselineNumber));

        public java.lang.Number GetBaselineBudgetCost(int baselineNumber) => JavaObject.getBaselineBudgetCost(baselineNumber);

        public void SetText(int index, string value) => JavaObject.setText(index, value);

        public string GetText(int index) => JavaObject.getText(index);

        public void SetStart(int index, java.time.LocalDateTime value) => JavaObject.setStart(index, value);

        public java.time.LocalDateTime GetStart(int index) => JavaObject.getStart(index);

        public void SetFinish(int index, java.time.LocalDateTime value) => JavaObject.setFinish(index, value);

        public java.time.LocalDateTime GetFinish(int index) => JavaObject.getFinish(index);

        public void SetDate(int index, java.time.LocalDateTime value) => JavaObject.setDate(index, value);

        public java.time.LocalDateTime GetDate(int index) => JavaObject.getDate(index);

        public void SetNumber(int index, java.lang.Number value) => JavaObject.setNumber(index, value);

        public java.lang.Number GetNumber(int index) => JavaObject.getNumber(index);

        public void SetDuration(int index, Duration value) => JavaObject.setDuration(index, value.JavaObject);

        public Duration GetDuration(int index) => _proxyManager.ProxyObject(JavaObject.getDuration(index));

        public void SetCost(int index, java.lang.Number value) => JavaObject.setCost(index, value);

        public java.lang.Number GetCost(int index) => JavaObject.getCost(index);

        public void SetFlag(int index, bool value) => JavaObject.setFlag(index, value);

        public bool GetFlag(int index) => JavaObject.getFlag(index);

        public void SetEnterpriseCost(int index, java.lang.Number value) => JavaObject.setEnterpriseCost(index, value);

        public java.lang.Number GetEnterpriseCost(int index) => JavaObject.getEnterpriseCost(index);

        public void SetEnterpriseDate(int index, java.time.LocalDateTime value) => JavaObject.setEnterpriseDate(index, value);

        public java.time.LocalDateTime GetEnterpriseDate(int index) => JavaObject.getEnterpriseDate(index);

        public void SetEnterpriseDuration(int index, Duration value) => JavaObject.setEnterpriseDuration(index, value.JavaObject);

        public Duration GetEnterpriseDuration(int index) => _proxyManager.ProxyObject(JavaObject.getEnterpriseDuration(index));

        public void SetEnterpriseFlag(int index, bool value) => JavaObject.setEnterpriseFlag(index, value);

        public bool GetEnterpriseFlag(int index) => JavaObject.getEnterpriseFlag(index);

        public void SetEnterpriseNumber(int index, java.lang.Number value) => JavaObject.setEnterpriseNumber(index, value);

        public java.lang.Number GetEnterpriseNumber(int index) => JavaObject.getEnterpriseNumber(index);

        public void SetEnterpriseText(int index, string value) => JavaObject.setEnterpriseText(index, value);

        public string GetEnterpriseText(int index) => JavaObject.getEnterpriseText(index);

        public Duration RegularWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getRegularWork());
            set => JavaObject.setRegularWork(value.JavaObject);
        }

        public Duration ActualOvertimeWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualOvertimeWork());
            set => JavaObject.setActualOvertimeWork(value.JavaObject);
        }

        public Duration RemainingOvertimeWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getRemainingOvertimeWork());
            set => JavaObject.setRemainingOvertimeWork(value.JavaObject);
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

        public Duration WorkVariance
        {
            get => _proxyManager.ProxyObject(JavaObject.getWorkVariance());
            set => JavaObject.setWorkVariance(value.JavaObject);
        }

        public Duration StartVariance
        {
            get => _proxyManager.ProxyObject(JavaObject.getStartVariance());
            set => JavaObject.setStartVariance(value.JavaObject);
        }

        public Duration FinishVariance
        {
            get => _proxyManager.ProxyObject(JavaObject.getFinishVariance());
            set => JavaObject.setFinishVariance(value.JavaObject);
        }

        public java.time.LocalDateTime CreateDate
        {
            get => JavaObject.getCreateDate();
            set => JavaObject.setCreateDate(value);
        }

        public Guid? GUID
        {
            get => JavaObject.getGUID().FromJava();
            set => JavaObject.setGUID(value.ToJava());
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

        public CostRateTable CostRateTable => _proxyManager.ProxyObject(JavaObject.getCostRateTable());

        public string HyperlinkScreenTip
        {
            get => JavaObject.getHyperlinkScreenTip();
            set => JavaObject.setHyperlinkScreenTip(value);
        }

        public ResourceRequestType? ResourceRequestType
        {
            get => JavaObject.getResourceRequestType().ConvertType();
            set => JavaObject.setResourceRequestType(value.ConvertType());
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

        public Duration PlannedWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getPlannedWork());
            set => JavaObject.setPlannedWork(value.JavaObject);
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

        public Rate GetEffectiveRate(java.time.LocalDateTime date) => _proxyManager.ProxyObject(JavaObject.getEffectiveRate(date));

        public object GetFieldByAlias(string alias) => _proxyManager.GenericProxyObject(JavaObject.getFieldByAlias(alias));

        // TODO: proxy
        public void SetFieldByAlias(string alias, object value) => JavaObject.setFieldByAlias(alias, value);

        public override string ToString() => JavaObject.toString();
    }
}
