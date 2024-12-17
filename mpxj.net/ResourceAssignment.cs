using System;
using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ResourceAssignment : AbstractFieldContainer, IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.ResourceAssignment>
    {
        public new net.sf.mpxj.ResourceAssignment JavaObject => (net.sf.mpxj.ResourceAssignment)base.JavaObject;

        internal ResourceAssignment(ProxyManager proxyManager, net.sf.mpxj.ResourceAssignment javaObject) : base(proxyManager, javaObject) { }

        public ResourceAssignmentWorkgroupFields AddWorkgroupAssignment() => _proxyManager.ProxyObject(JavaObject.addWorkgroupAssignment());

        public int? UniqueID
        {
            get => JavaObject.getUniqueID().ConvertType();
            set => JavaObject.setUniqueID(value.ConvertType());
        }

        public double? Units
        {
            get => JavaObject.getUnits().ConvertType();
            set => JavaObject.setUnits(value.ConvertType());
        }

        public double? RemainingUnits
        {
            get => JavaObject.getRemainingUnits().ConvertType();
            set => JavaObject.setRemainingUnits(value.ConvertType());
        }

        public Duration Work
        {
            get => _proxyManager.ProxyObject(JavaObject.getWork());
            set => JavaObject.setWork(value?.JavaObject);
        }

        public DateTime? BaselineStart
        {
            get => JavaObject.getBaselineStart().ConvertType();
            set => JavaObject.setBaselineStart(value.ConvertType());
        }

        public DateTime? ActualStart
        {
            get => JavaObject.getActualStart().ConvertType();
            set => JavaObject.setActualStart(value.ConvertType());
        }

        public DateTime? BaselineFinish
        {
            get => JavaObject.getBaselineFinish().ConvertType();
            set => JavaObject.setBaselineFinish(value.ConvertType());
        }

        public DateTime? ActualFinish
        {
            get => JavaObject.getActualFinish().ConvertType();
            set => JavaObject.setActualFinish(value.ConvertType());
        }

        public Duration BaselineWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getBaselineWork());
            set => JavaObject.setBaselineWork(value?.JavaObject);
        }

        public Duration ActualWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualWork());
            set => JavaObject.setActualWork(value?.JavaObject);
        }

        public Duration OvertimeWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getOvertimeWork());
            set => JavaObject.setOvertimeWork(value?.JavaObject);
        }

        public double? Cost
        {
            get => JavaObject.getCost().ConvertType();
            set => JavaObject.setCost(value.ConvertType());
        }

        public double? BaselineCost
        {
            get => JavaObject.getBaselineCost().ConvertType();
            set => JavaObject.setBaselineCost(value.ConvertType());
        }

        public double? ActualCost
        {
            get => JavaObject.getActualCost().ConvertType();
            set => JavaObject.setActualCost(value.ConvertType());
        }

        public DateTime? Start
        {
            get => JavaObject.getStart().ConvertType();
            set => JavaObject.setStart(value.ConvertType());
        }

        public DateTime? Finish
        {
            get => JavaObject.getFinish().ConvertType();
            set => JavaObject.setFinish(value.ConvertType());
        }

        public Duration Delay
        {
            get => _proxyManager.ProxyObject(JavaObject.getDelay());
            set => JavaObject.setDelay(value?.JavaObject);
        }

        public int? ResourceUniqueID
        {
            get => JavaObject.getResourceUniqueID().ConvertType();
            set => JavaObject.setResourceUniqueID(value.ConvertType());
        }

        public ResourceAssignmentWorkgroupFields WorkgroupAssignment => _proxyManager.ProxyObject(JavaObject.getWorkgroupAssignment());

        public Task Task => _proxyManager.ProxyObject(JavaObject.getTask());

        public Resource Resource => _proxyManager.ProxyObject(JavaObject.getResource());

        public WorkContour WorkContour
        {
            get => _proxyManager.ProxyObject(JavaObject.getWorkContour());
            set => JavaObject.setWorkContour(_proxyManager.UnProxyObject(value));
        }

        public void Remove() => JavaObject.remove();

        public Duration RemainingWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getRemainingWork());
            set => JavaObject.setRemainingWork(value?.JavaObject);
        }

        public Duration LevelingDelay
        {
            get => _proxyManager.ProxyObject(JavaObject.getLevelingDelay());
            set => JavaObject.setLevelingDelay(value?.JavaObject);
        }

        public int? RateIndex
        {
            get => JavaObject.getRateIndex().ConvertType();
            set => JavaObject.setRateIndex(value.ConvertType());
        }

        public int? RoleUniqueID
        {
            get => JavaObject.getRoleUniqueID().ConvertType();
            set => JavaObject.setRoleUniqueID(value.ConvertType());
        }

        public Resource Role
        {
            get => _proxyManager.ProxyObject(JavaObject.getRole());
            set => JavaObject.setRole(value?.JavaObject);
        }

        public Rate OverrideRate
        {
            get => _proxyManager.ProxyObject(JavaObject.getOverrideRate());
            set => JavaObject.setOverrideRate(value?.JavaObject);
        }

        public RateSource? RateSource
        {
            get => JavaObject.getRateSource().ConvertType();
            set => JavaObject.setRateSource(value.ConvertType());
        }

        public IList<TimephasedWork> TimephasedPlannedWork => _proxyManager.ProxyList<net.sf.mpxj.TimephasedWork, TimephasedWork>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getTimephasedPlannedWork());

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

        public ProjectCalendar EffectiveCalendar => _proxyManager.ProxyObject(JavaObject.getEffectiveCalendar());

        public TimeUnit? VariableRateUnits
        {
            get => JavaObject.getVariableRateUnits().ConvertType();
            set => JavaObject.setVariableRateUnits(value.ConvertType());
        }

        public int? TaskUniqueID
        {
            get => JavaObject.getTaskUniqueID().ConvertType();
            set => JavaObject.setTaskUniqueID(value.ConvertType());
        }

        public double? BudgetCost
        {
            get => JavaObject.getBudgetCost().ConvertType();
            set => JavaObject.setBudgetCost(value.ConvertType());
        }

        public Duration BudgetWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getBudgetWork());
            set => JavaObject.setBudgetWork(value?.JavaObject);
        }

        public double? BaselineBudgetCost
        {
            get => JavaObject.getBaselineBudgetCost().ConvertType();
            set => JavaObject.setBaselineBudgetCost(value.ConvertType());
        }

        public Duration BaselineBudgetWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getBaselineBudgetWork());
            set => JavaObject.setBaselineBudgetWork(value?.JavaObject);
        }

        public void SetBaselineCost(int baselineNumber, double? value) => JavaObject.setBaselineCost(baselineNumber, value.ConvertType());

        public void SetBaselineWork(int baselineNumber, Duration value) => JavaObject.setBaselineWork(baselineNumber, value.JavaObject);

        public Duration GetBaselineWork(int baselineNumber) => _proxyManager.ProxyObject(JavaObject.getBaselineWork(baselineNumber));

        public double? GetBaselineCost(int baselineNumber) => JavaObject.getBaselineCost(baselineNumber).ConvertType();

        public void SetBaselineStart(int baselineNumber, DateTime value) => JavaObject.setBaselineStart(baselineNumber, value.ConvertType());

        public DateTime? GetBaselineStart(int baselineNumber) => JavaObject.getBaselineStart(baselineNumber).ConvertType();

        public void SetBaselineFinish(int baselineNumber, DateTime value) => JavaObject.setBaselineFinish(baselineNumber, value.ConvertType());

        public DateTime? GetBaselineFinish(int baselineNumber) => JavaObject.getBaselineFinish(baselineNumber).ConvertType();

        public void SetBaselineBudgetCost(int baselineNumber, double? value) => JavaObject.setBaselineBudgetCost(baselineNumber, value.ConvertType());

        public void SetBaselineBudgetWork(int baselineNumber, Duration value) => JavaObject.setBaselineBudgetWork(baselineNumber, value.JavaObject);

        public Duration GetBaselineBudgetWork(int baselineNumber) => _proxyManager.ProxyObject(JavaObject.getBaselineBudgetWork(baselineNumber));

        public double? GetBaselineBudgetCost(int baselineNumber) => JavaObject.getBaselineBudgetCost(baselineNumber).ConvertType();

        public void SetText(int index, string value) => JavaObject.setText(index, value);

        public string GetText(int index) => JavaObject.getText(index);

        public void SetStart(int index, DateTime value) => JavaObject.setStart(index, value.ConvertType());

        public DateTime? GetStart(int index) => JavaObject.getStart(index).ConvertType();

        public void SetFinish(int index, DateTime value) => JavaObject.setFinish(index, value.ConvertType());

        public DateTime? GetFinish(int index) => JavaObject.getFinish(index).ConvertType();

        public void SetDate(int index, DateTime value) => JavaObject.setDate(index, value.ConvertType());

        public DateTime? GetDate(int index) => JavaObject.getDate(index).ConvertType();

        public void SetNumber(int index, double? value) => JavaObject.setNumber(index, value.ConvertType());

        public double? GetNumber(int index) => JavaObject.getNumber(index).ConvertType();

        public void SetDuration(int index, Duration value) => JavaObject.setDuration(index, value.JavaObject);

        public Duration GetDuration(int index) => _proxyManager.ProxyObject(JavaObject.getDuration(index));

        public void SetCost(int index, double? value) => JavaObject.setCost(index, value.ConvertType());

        public double? GetCost(int index) => JavaObject.getCost(index).ConvertType();

        public void SetFlag(int index, bool value) => JavaObject.setFlag(index, value);

        public bool GetFlag(int index) => JavaObject.getFlag(index);

        public void SetEnterpriseCost(int index, double? value) => JavaObject.setEnterpriseCost(index, value.ConvertType());

        public double? GetEnterpriseCost(int index) => JavaObject.getEnterpriseCost(index).ConvertType();

        public void SetEnterpriseDate(int index, DateTime value) => JavaObject.setEnterpriseDate(index, value.ConvertType());

        public DateTime? GetEnterpriseDate(int index) => JavaObject.getEnterpriseDate(index).ConvertType();

        public void SetEnterpriseDuration(int index, Duration value) => JavaObject.setEnterpriseDuration(index, value.JavaObject);

        public Duration GetEnterpriseDuration(int index) => _proxyManager.ProxyObject(JavaObject.getEnterpriseDuration(index));

        public void SetEnterpriseFlag(int index, bool value) => JavaObject.setEnterpriseFlag(index, value);

        public bool GetEnterpriseFlag(int index) => JavaObject.getEnterpriseFlag(index);

        public void SetEnterpriseNumber(int index, double? value) => JavaObject.setEnterpriseNumber(index, value.ConvertType());

        public double? GetEnterpriseNumber(int index) => JavaObject.getEnterpriseNumber(index).ConvertType();

        public void SetEnterpriseText(int index, string value) => JavaObject.setEnterpriseText(index, value);

        public string GetEnterpriseText(int index) => JavaObject.getEnterpriseText(index);

        public Duration RegularWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getRegularWork());
            set => JavaObject.setRegularWork(value?.JavaObject);
        }

        public Duration ActualOvertimeWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getActualOvertimeWork());
            set => JavaObject.setActualOvertimeWork(value?.JavaObject);
        }

        public Duration RemainingOvertimeWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getRemainingOvertimeWork());
            set => JavaObject.setRemainingOvertimeWork(value?.JavaObject);
        }

        public double? OvertimeCost
        {
            get => JavaObject.getOvertimeCost().ConvertType();
            set => JavaObject.setOvertimeCost(value.ConvertType());
        }

        public double? RemainingCost
        {
            get => JavaObject.getRemainingCost().ConvertType();
            set => JavaObject.setRemainingCost(value.ConvertType());
        }

        public double? ActualOvertimeCost
        {
            get => JavaObject.getActualOvertimeCost().ConvertType();
            set => JavaObject.setActualOvertimeCost(value.ConvertType());
        }

        public double? RemainingOvertimeCost
        {
            get => JavaObject.getRemainingOvertimeCost().ConvertType();
            set => JavaObject.setRemainingOvertimeCost(value.ConvertType());
        }

        public double? BCWP
        {
            get => JavaObject.getBCWP().ConvertType();
            set => JavaObject.setBCWP(value.ConvertType());
        }

        public double? BCWS
        {
            get => JavaObject.getBCWS().ConvertType();
            set => JavaObject.setBCWS(value.ConvertType());
        }

        public double? ACWP
        {
            get => JavaObject.getACWP().ConvertType();
            set => JavaObject.setACWP(value.ConvertType());
        }

        public double? SV
        {
            get => JavaObject.getSV().ConvertType();
            set => JavaObject.setSV(value.ConvertType());
        }

        public double? CV
        {
            get => JavaObject.getCV().ConvertType();
            set => JavaObject.setCV(value.ConvertType());
        }

        public double? CostVariance
        {
            get => JavaObject.getCostVariance().ConvertType();
            set => JavaObject.setCostVariance(value.ConvertType());
        }

        public double? PercentageWorkComplete
        {
            get => JavaObject.getPercentageWorkComplete().ConvertType();
            set => JavaObject.setPercentageWorkComplete(value.ConvertType());
        }

        public string Notes
        {
            get => JavaObject.getNotes();
            set => JavaObject.setNotes(value);
        }

        public Notes NotesObject
        {
            get => _proxyManager.ProxyObject(JavaObject.getNotesObject());
            set => JavaObject.setNotesObject(value?.JavaObject);
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
            set => JavaObject.setWorkVariance(value?.JavaObject);
        }

        public Duration StartVariance
        {
            get => _proxyManager.ProxyObject(JavaObject.getStartVariance());
            set => JavaObject.setStartVariance(value?.JavaObject);
        }

        public Duration FinishVariance
        {
            get => _proxyManager.ProxyObject(JavaObject.getFinishVariance());
            set => JavaObject.setFinishVariance(value?.JavaObject);
        }

        public DateTime? CreateDate
        {
            get => JavaObject.getCreateDate().ConvertType();
            set => JavaObject.setCreateDate(value.ConvertType());
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

        public double? VAC
        {
            get => JavaObject.getVAC().ConvertType();
            set => JavaObject.setVAC(value.ConvertType());
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

        public DateTime? Stop
        {
            get => JavaObject.getStop().ConvertType();
            set => JavaObject.setStop(value.ConvertType());
        }

        public DateTime? Resume
        {
            get => JavaObject.getResume().ConvertType();
            set => JavaObject.setResume(value.ConvertType());
        }

        public Duration PlannedWork
        {
            get => _proxyManager.ProxyObject(JavaObject.getPlannedWork());
            set => JavaObject.setPlannedWork(value?.JavaObject);
        }

        public double? PlannedCost
        {
            get => JavaObject.getPlannedCost().ConvertType();
            set => JavaObject.setPlannedCost(value.ConvertType());
        }

        public DateTime? PlannedStart
        {
            get => JavaObject.getPlannedStart().ConvertType();
            set => JavaObject.setPlannedStart(value.ConvertType());
        }

        public DateTime? PlannedFinish
        {
            get => JavaObject.getPlannedFinish().ConvertType();
            set => JavaObject.setPlannedFinish(value.ConvertType());
        }

        public bool CalculateCostsFromUnits
        {
            get => JavaObject.getCalculateCostsFromUnits();
            set => JavaObject.setCalculateCostsFromUnits(value);
        }

        public int? CostAccountUniqueID
        {
            get => JavaObject.getCostAccountUniqueID().ConvertType();
            set => JavaObject.setCostAccountUniqueID(value.ConvertType());
        }

        public CostAccount CostAccount
        {
            get => _proxyManager.ProxyObject(JavaObject.getCostAccount());
            set => JavaObject.setCostAccount(value?.JavaObject);
        }

        public DateTime? RemainingEarlyStart
        {
            get => JavaObject.getRemainingEarlyStart().ConvertType();
            set => JavaObject.setRemainingEarlyStart(value.ConvertType());
        }

        public DateTime? RemainingEarlyFinish
        {
            get => JavaObject.getRemainingEarlyFinish().ConvertType();
            set => JavaObject.setRemainingEarlyFinish(value.ConvertType());
        }

        public DateTime? RemainingLateStart
        {
            get => JavaObject.getRemainingLateStart().ConvertType();
            set => JavaObject.setRemainingLateStart(value.ConvertType());
        }

        public DateTime? RemainingLateFinish
        {
            get => JavaObject.getRemainingLateFinish().ConvertType();
            set => JavaObject.setRemainingLateFinish(value.ConvertType());
        }

        public IDictionary<ResourceAssignmentCode, ResourceAssignmentCodeValue> ResourceAssignmentCodeValues => _proxyManager.ProxyDictionary<net.sf.mpxj.ResourceAssignmentCode, net.sf.mpxj.ResourceAssignmentCodeValue, ResourceAssignmentCode, ResourceAssignmentCodeValue>(k => _proxyManager.ProxyObject(k), k => k.JavaObject, v => _proxyManager.ProxyObject(v), v => v.JavaObject, JavaObject.getResourceAssignmentCodeValues());
        
        public Rate GetEffectiveRate(DateTime date) => _proxyManager.ProxyObject(JavaObject.getEffectiveRate(date.ConvertType()));

        public object GetFieldByAlias(string alias) => _proxyManager.GenericProxyObject(JavaObject.getFieldByAlias(alias));

        public void SetFieldByAlias(string alias, object value) => JavaObject.setFieldByAlias(alias, value.GenericJavaObject());

        public override string ToString() => JavaObject.toString();
    }
}
